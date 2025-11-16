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
        private readonly Action<string> logAction;
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

        public Form2(Action<string> logAction)
        {
            InitializeComponent();
            this.logAction = logAction;

            this.Load += (s, e) => Log("[Form2] Load");
            this.Activated += (s, e) => Log("[Form2] Activated");
            this.Deactivate += (s, e) => Log("[Form2] Deactivated");
            this.FormClosing += (s, e) => Log("[Form2] FormClosing");
            this.FormClosed += (s, e) => Log("[Form2] FormClosed");
            this.Resize += (s, e) => Log("[Form2] Resize");
            this.GotFocus += (s, e) => Log("[Form2] GotFocus");
            this.Click += (s, e) => Log("[Form2] Click");
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Log("[Form2] OnHandleCreated");
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            Log("[Form2] OnHandleDestroyed");
            base.OnHandleDestroyed(e);
        }

        private void Log(string evt)
        {
            logAction?.Invoke(evt);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Log("[Form2] Load");
        }
        private void Form2_Activated(object sender, EventArgs e)
        {
            Log("[Form2] Activated");
        }
        private void Form2_Deactivated(object sender, EventArgs e)
        {
            Log("[Form2] Deactivated");
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("[Form2] FormClosing");
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log("[Form2] FormClosed");
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            Log("[Form2] Resize");
        }
        private void Form2_GotFocus(object sender, EventArgs e)
        {
            Log("[Form2] GotFocus");
        }
        private void Form2_Click(object sender, EventArgs e)
        {
            Log("[Form2] Click");
        }
    }
}
