using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class fBai01 : Form
    {
        public fBai01()
        {
            InitializeComponent();
            lbEvents.Font = new Font("Cambria", 10);
            this.Load += Form1_Load;
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivated;
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += Form1_FormClosed;
            this.Resize += Form1_Resize;
            this.GotFocus += Form1_GotFocus;
            this.Click += Form1_Click;
        }
        private void Log(string eventName)
        {
            lbEvents.Items.Add($"{DateTime.Now:HH:mm:ss} - {eventName}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log("Load");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Log("Activated");
        }

        private void Form1_Deactivated(object sender, EventArgs e)
        {
            Log("Deactivated");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("FormClosing");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log("FormClosed");
        }

        private void Form1_GotFocus(object sender, EventArgs e)
        {
            Log("GotFocus");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Log("Click");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Log("Resize");
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
