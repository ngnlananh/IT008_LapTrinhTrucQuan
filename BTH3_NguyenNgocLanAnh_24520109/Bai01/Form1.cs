using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Bai01
{
    public partial class fBai01 : Form
    {
        private ListBox log;
        private Button btnOpenChild;
        public fBai01()
        {
            InitializeComponent();
            Text = "Form1 - Parent";
            Size = new Size(800, 500);

            log = new ListBox
            {
                Font = new Font("Cambria", 10),
                Height = this.ClientSize.Height - 100,
                Width = this.ClientSize.Width - 20,
                Location = new Point(10, 50)
            };

            btnOpenChild = new Button
            {
                Location = new Point(100,10),
                Text = "Open ChildForm",
                Font = new Font("Cambria", 10),
                Width = 200
            };
            btnOpenChild.Click += BtnOpenChild_Click;

            Controls.Add(log);
            Controls.Add(btnOpenChild);
        }
        private void Log(string eventName)
        {
            log.Items.Add($"{DateTime.Now:HH:mm:ss} - {eventName}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log("[Form1] Load");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Log("[Form1] Activated");
        }

        private void Form1_Deactivated(object sender, EventArgs e)
        {
            Log("[Form1] Deactivated");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("[Form1] FormClosing");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log("[Form1] FormClosed");
        }

        private void Form1_GotFocus(object sender, EventArgs e)
        {
            Log("[Form1] GotFocus");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Log("[Form1] Click");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Log("[Form1] Resize");
        }

        private void BtnOpenChild_Click(object sender, EventArgs e)
        {
            // truyền hàm Log cho Form2
            Form2 f = new Form2(Log);
            f.Show();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Log("[Form1] Shown");
        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            Log("[Form1] Disposed");
        }
    }
}
