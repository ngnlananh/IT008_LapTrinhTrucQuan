using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        private Point? startPoint = null;
        // Lưu list các thông tin của line: startPoint, endPoint, Style
        public List<Tuple<Point, Point, Style>> _lines = new List<Tuple<Point, Point, Style>>(); 
        public class Style
        {
            public DashStyle _dashStyle { get; set; }
            public DashCap _dashCap { get; set; }
            public LineJoin _lineJoin { get; set; }
            public LineCap _startCap { get; set; }
            public LineCap _endCap { get; set; }
            public float _width { get; set; }
        }
        public Form1()
        {
            InitializeComponent();

            // Gán dữ liệu cho ComboBox
            cbDashStyle.DataSource = Enum.GetNames(typeof(DashStyle));
            cbLineJoin.DataSource = Enum.GetNames(typeof(LineJoin));
            cbDashCap.DataSource = Enum.GetNames(typeof(DashCap));
            cbStartCap.DataSource = Enum.GetNames(typeof(LineCap));
            cbEndCap.DataSource = Enum.GetNames(typeof(LineCap));

            // Khởi tạo cho comboBox 
            cbDashStyle.SelectedItem = "Solid";
            numWidth.Value = 4;
            cbLineJoin.SelectedItem = "Round";
            cbDashCap.SelectedItem = "Flat";
            cbStartCap.SelectedItem = "Flat";
            cbEndCap.SelectedItem = "ArrowAnchor";
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (startPoint != null)
            {
                // Tạo line mới với style hiện tại
                Point endPoint = e.Location;
                Style _style = new Style();
                _style._dashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), cbDashStyle.SelectedItem.ToString());
                _style._dashCap = (DashCap)Enum.Parse(typeof(DashCap), cbDashCap.SelectedItem.ToString());
                _style._endCap = (LineCap)Enum.Parse(typeof(LineCap), cbEndCap.SelectedItem.ToString());
                _style._startCap = (LineCap)Enum.Parse(typeof(LineCap), cbStartCap.SelectedItem.ToString());
                _style._lineJoin = (LineJoin)Enum.Parse(typeof(LineJoin), cbLineJoin.SelectedItem.ToString());
                _style._width = (float)numWidth.Value;
                Tuple<Point, Point, Style> newLine = new Tuple<Point, Point, Style>(startPoint.Value, endPoint, _style);

                // Thêm line mới vào list 
                _lines.Add(newLine);

                // Khởi tạo lại startPoint
                startPoint = null; 
                
                // Gọi hàm vẽ
                drawPanel.Invalidate();
            }
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            foreach(var line in _lines)
            {
                Style style = line.Item3; // lấy đối tượng Style
                using (Pen pen = new Pen(Color.DarkRed, style._width))
                {
                    pen.DashStyle = style._dashStyle;
                    pen.LineJoin = style._lineJoin;
                    pen.DashCap = style._dashCap;
                    pen.StartCap = style._startCap;
                    pen.EndCap = style._endCap;

                    g.DrawLine(pen, line.Item1, line.Item2);
                }
            }
        }
    }
}