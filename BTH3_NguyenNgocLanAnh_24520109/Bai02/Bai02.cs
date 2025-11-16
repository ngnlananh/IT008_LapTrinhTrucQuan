using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    public partial class fBai02 : Form
    {
        public fBai02()
        {
            InitializeComponent();
            btnPaint.Text = "Paint Event";
        }
        private void btnPaint_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void fBai02_Paint(object sender, PaintEventArgs e)
        {
            Random rd = new Random();
            int x = rd.Next(0, 200);
            int y = rd.Next(0, 200);
            Font f = new Font("Consolas", 25, FontStyle.Bold);
            Brush br = new SolidBrush(Color.DarkRed);
            e.Graphics.DrawString("Paint Event", f, br, x, y);
        }
    }
}
