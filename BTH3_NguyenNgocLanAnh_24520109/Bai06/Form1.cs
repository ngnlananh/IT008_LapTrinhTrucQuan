using System;
using System.Windows.Forms;

namespace Bai06
{
    public partial class fBai06 : Form
    {
        double result = 0; //lưu kết quả phép tính
        string operation = ""; //lưu phép toán hiện tại
        bool isOperationPressed = false; //đánh dấu nhấn vào nút phép tính
        double memory = 0; // biến lưu bộ nhớ
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
            if (!string.IsNullOrEmpty(operation))
            {
                //tính phép toán phía trước
                btnEqual_Click(sender, e);
            }
            operation = b.Text;
            result = double.Parse(textBox1.Text);
            isOperationPressed = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Xóa toàn bộ phép toán đang thực hiện
            textBox1.Text = "0";
            result = 0;
            operation = "";
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; //chỉ xóa số đang nhập
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
                    {
                        textBox1.Text = (result / second).ToString();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Error");
                        textBox1.Text = "0";
                        return;
                    }
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
        private void btnMS_Click(object sender, EventArgs e)
        {
            //Lưu giá trị hiện tại vào bộ nhớ
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                memory = value;
            }
        }
        private void btnMR_Click(object sender, EventArgs e)
        {
            //Hiển thị giá trị trong bộ nhớ vào textbox
            textBox1.Text = memory.ToString();
        }
        private void btnMC_Click(object sender, EventArgs e)
        {
            //Xóa bộ nhớ
            memory = 0;
        }
        private void btnMplus_Click(object sender, EventArgs e)
        {
            //Cộng giá trị hiện tại vào bộ nhớ
            double value;
            if (double.TryParse(textBox1.Text, out value))
            {
                memory += value;
            }
        }

    }
}
