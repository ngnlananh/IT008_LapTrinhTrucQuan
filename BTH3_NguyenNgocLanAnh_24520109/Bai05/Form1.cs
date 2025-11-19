using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai05
{
    public partial class fBai05 : Form
    {
        public fBai05()
        {
            InitializeComponent();
            label1.Text = "Number 1:";
            label1.Font = new Font("Book Antiqua", 10, FontStyle.Bold);
            label2.Text = "Number 2:";
            label2.Font = new Font("Book Antiqua", 10, FontStyle.Bold);
            label3.Text = "Answer:";
            label3.Font = new Font("Book Antiqua", 10, FontStyle.Bold);
            button1.Text = "+";
            button1.Size = new Size(40, 30);
            button1.Location = new Point(50, 120);
            button2.Text = "-";
            button2.Size = new Size(40, 30);
            button2.Location = new Point(100, 120);
            button3.Text = "x";
            button3.Size = new Size(40, 30);
            button3.Location = new Point(150, 120);
            button4.Text = "/";
            button4.Size = new Size(40, 30);
            button4.Location = new Point(200, 120);
        }

        private bool check() // kiểm thử input
        {
            if (!double.TryParse(textBox1.Text.Trim(), out double num1) || !double.TryParse(textBox2.Text.Trim(), out double num2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hoặc số thực!", "Warning");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e) //phep cong
        {
            if (check())
            {
                double ans = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
                textBox3.Text = ans.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) //phep tru
        {
            if (check())
            {
                double ans = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
                textBox3.Text = ans.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e) //phep nhan
        {
            if (check())
            {
                double ans = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
                textBox3.Text = ans.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e) //phep chia
        {
            if (check())
            {
                if (double.Parse(textBox2.Text) == 0)
                {
                    MessageBox.Show("Không thể chia cho 0! Vui lòng thử lại!", "Warning", MessageBoxButtons.OK);
                    return;
                }
                double ans = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
                textBox3.Text = ans.ToString();
            }
        }
    }
}
