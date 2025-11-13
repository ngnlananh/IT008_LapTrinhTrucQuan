using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class fBai04 : Form
    {
        public fBai04()
        {
            InitializeComponent();
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.FullOpen = true; // mở bảng chọn màu
                cd.Color = this.BackColor;

                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = cd.Color; // đổi màu nền form
                }
            }
        }
    }
}
