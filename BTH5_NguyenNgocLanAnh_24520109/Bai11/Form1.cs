using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        public List<Tuple<string, Point, Point, Pen, Brush>> shapes
            = new List<Tuple<string, Point, Point, Pen, Brush>>();

        Point? startPoint = null;
        Point? currentPoint = null;

        public Form1()
        {
            InitializeComponent();
            rbLine.Checked = true;
            tbWidth.Text = 1.ToString(); // Khởi tạo width = 1
            rbSolidBrush.Checked = true;
        }

        private Rectangle GetRect(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y));
        }

        private string GetSelectedShape()
        {
            if (rbLine.Checked) return "Line";
            if (rbRectangle.Checked) return "Rectangle";
            return "Ellipse";
        }

        private Brush GetSelectedBrush()
        {
            if (rbSolidBrush.Checked)
                return new SolidBrush(Color.Green);

            if (rbHatchBrush.Checked)
                return new System.Drawing.Drawing2D.HatchBrush(
                        System.Drawing.Drawing2D.HatchStyle.Horizontal,
                        Color.Blue, Color.Green);

            if (rbTextureBrush.Checked)
            {
                Bitmap bmp = Properties.Resources.texture;
                return new TextureBrush(bmp);
            }

            if (rbLinearGradientBrush.Checked)
                return new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Rectangle(0, 0, panel1.Width, panel1.Height),
                    Color.Red, Color.Green,
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical);

            return new SolidBrush(Color.Green);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && startPoint != null)
            {
                currentPoint = e.Location;
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (startPoint == null) return;

            Point p1 = startPoint.Value;
            Point p2 = e.Location;

            string shape = GetSelectedShape();
            int width = int.Parse(tbWidth.Text);

            Pen pen = new Pen(btnColor.BackColor, width);
            Brush brush = GetSelectedBrush();

            shapes.Add(new Tuple<string, Point, Point, Pen, Brush>(
                shape, p1, p2, pen, brush));

            startPoint = null;
            currentPoint = null;
            panel1.Invalidate();
        }

        private void DrawShape(Graphics g, Tuple<string, Point, Point, Pen, Brush> item)
        {
            string shape = item.Item1;
            Point p1 = item.Item2;
            Point p2 = item.Item3;
            Pen pen = item.Item4;
            Brush brush = item.Item5;

            Rectangle r = GetRect(p1, p2);

            if (shape == "Line")
            {
                g.DrawLine(pen, p1, p2);
            }
            else if (shape == "Rectangle")
            {
                g.FillRectangle(brush, r);
                g.DrawRectangle(pen, r);
            }
            else if (shape == "Ellipse")
            {
                g.FillEllipse(brush, r);
                g.DrawEllipse(pen, r);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var s in shapes)
                DrawShape(g, s);

            // Vẽ preview hình đang kéo
            if (startPoint != null && currentPoint != null)
            {
                Rectangle r = GetRect(startPoint.Value, currentPoint.Value);

                Pen preview = new Pen(Color.Blue, 1)
                { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

                string shape = GetSelectedShape();

                if (shape == "Line")
                    g.DrawLine(preview, startPoint.Value, currentPoint.Value);
                else
                    g.DrawRectangle(preview, r);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                btnColor.BackColor = dlg.Color;
        }
    }
}
