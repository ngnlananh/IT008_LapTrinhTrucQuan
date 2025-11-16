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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbChildEvents.Font = new Font("Cambria", 10);
            this.Load += Form2_Load;
            this.Activated += Form2_Activated;
            this.Deactivate += Form2_Deactivated;
            this.FormClosing += Form2_FormClosing;
            this.FormClosed += Form2_FormClosed;
            this.Resize += Form2_Resize;
            this.GotFocus += Form2_GotFocus;
            this.Click += Form2_Click;
        }
        private void Log(string evt)
        {
            lbChildEvents.Items.Add($"{DateTime.Now:HH:mm:ss} - {evt}");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Log("Form2 Load");
        }
        private void Form2_Activated(object sender, EventArgs e)
        {
            Log("Form2 Activated");
        }
        private void Form2_Deactivated(object sender, EventArgs e)
        {
            Log("Form2 Deactivated");
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("Form2 FormClosing");
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log("Form2 FormClosed");
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            Log("Form2 Resize");
        }
        private void Form2_GotFocus(object sender, EventArgs e)
        {
            Log("Form2 GotFocus");
        }
        private void Form2_Click(object sender, EventArgs e)
        {
            Log("Form2 Click");
        }
    }
}
