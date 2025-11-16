using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai03
{
    public partial class fBai03 : Form
    {
        public fBai03()
        {
            InitializeComponent();
            btnChangeColor.Text = "Change Color";
            btnChangeColor.Size = new Size(200, 50);
            btnChangeColor.Location = new Point((this.ClientSize.Width - btnChangeColor.Width) / 2,
                                              (this.ClientSize.Height - btnChangeColor.Height) / 2);
            btnChangeColor.Font = new Font("Courier New", 15, FontStyle.Bold);
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Color randomColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            this.BackColor = randomColor;
        }
    }
}
