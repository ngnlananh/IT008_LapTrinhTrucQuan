using System.Drawing;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += (s, e) => this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string selectedShape = comboBox1.SelectedItem.ToString();
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(80, 80, 200, 200);
            Brush fillBrush = Brushes.Green;
            Pen borderPen = Pens.Black;

            // Vẽ theo hình được chọn
            switch (selectedShape)
            {
                case "Circle":
                    g.DrawEllipse(borderPen, rect);
                    break;
                case "Filled Circle":
                    g.FillEllipse(fillBrush, rect);
                    break;
                case "Square":
                    g.DrawRectangle(borderPen, rect);
                    break;
                case "Filled Square":
                    g.FillRectangle(fillBrush, rect);
                    break;
                case "Ellipse":
                    g.DrawEllipse(borderPen, 100, 130, 180, 100);
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(fillBrush, 100, 130, 180, 100);
                    break;
                case "Pie":
                    g.DrawPie(borderPen, rect, 30, 120);
                    break;
                case "Filled Pie":
                    g.FillPie(fillBrush, rect, 30, 120);
                    break;
            }
        }
    }
}
