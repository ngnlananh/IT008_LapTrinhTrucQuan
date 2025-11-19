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
        protected override void OnPaint(PaintEventArgs e)
        {
            //Random ngẫu nhiên 2 số x và y
            Random rd = new Random();
            int x = rd.Next(0, 500);
            int y = rd.Next(0, 300);
            //Tạo Font và Brush để vẽ
            Font f = new Font("Consolas", 25, FontStyle.Bold);
            Brush br = new SolidBrush(Color.DarkRed);
            e.Graphics.DrawString("Paint Event", f, br, x, y);
        }
    }
}
