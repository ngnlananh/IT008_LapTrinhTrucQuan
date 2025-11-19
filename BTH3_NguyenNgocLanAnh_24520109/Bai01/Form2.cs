using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form2 : Form
    {
        private readonly Action<string> logAction;
        public Form2()
        {
            InitializeComponent();
        }

        //Hàm khởi tạo Form2 có tham số
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
            this.Disposed += (s, e) => Log("[Form2] Disposed");
            this.KeyPreview = true;
            this.KeyDown += (s, e) => Log("[Form2] KeyDown");
            this.Paint += (s, e) => Log("[Form2] Paint");
        }
        private void Log(string evt)
        {
            logAction?.Invoke(evt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log("Button Clicked!");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Log("Button MouseHover!");
        }

        private void Form2_DoubleClick(object sender, EventArgs e)
        {
            Log("Button DoubleClick!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Log($"[TextBox] TextChanged: {textBox1.Text}");
        }
    }
}
