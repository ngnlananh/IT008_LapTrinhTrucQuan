using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class fBai06 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPressed = false;
        public fBai06()
        {
            InitializeComponent();
        }
        private void number_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || isOperationPressed)
                textBox1.Clear();

            isOperationPressed = false;
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            result = double.Parse(textBox1.Text);
            isOperationPressed = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.";
            result = 0;
            operation = "";
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; // chỉ xóa nội dung đang nhập
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double second = double.Parse(textBox1.Text);
            switch (operation)
            {
                case "+": textBox1.Text = (result + second).ToString(); break;
                case "-": textBox1.Text = (result - second).ToString(); break;
                case "*": textBox1.Text = (result * second).ToString(); break;
                case "/":
                    if (second != 0)
                        textBox1.Text = (result / second).ToString();
                    else
                        textBox1.Text = "Error";
                    break;
            }
            result = double.Parse(textBox1.Text);
            operation = "";
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sqrt(value).ToString();
        }
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);
            if (value != 0)
                textBox1.Text = (1 / value).ToString();
            else
                textBox1.Text = "Error";
        }
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);
            textBox1.Text = (-value).ToString();
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            double value = double.Parse(textBox1.Text);
            textBox1.Text = (value / 100).ToString();
        }
    }
}
