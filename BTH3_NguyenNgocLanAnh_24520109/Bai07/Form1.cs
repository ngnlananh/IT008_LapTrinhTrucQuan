using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class fBai07 : Form
    {
        const int cost = 100000;
        List<Button> selectedSeats = new List<Button>(); //List các ghế đang chọn 
        int sum = 0;
        public fBai07()
        {
            InitializeComponent();
        }
        private void btnGhe_Click (object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Blue) //Ghế đã bán
                MessageBox.Show("Ghế đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (btn.BackColor == Color.White) //Ghế chưa chọn
            {
                btn.BackColor = Color.Yellow; //Chuyển sang màu ghế đang chọn
                selectedSeats.Add(btn); //Thêm ghế vào danh sách ghế đang chọn
            }
            else if (btn.BackColor == Color.Yellow) //Ghế đang chọn -> hủy chọn ghế
            {
                btn.BackColor = Color.White; //Chuyển sang màu ghế chưa chọn
                selectedSeats.Remove(btn); //Xóa ghế khỏi danh sách ghế đang chọn
            }
            textBox1.Text = ((selectedSeats.Count * cost)).ToString();
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Chưa có ghế nào được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int totalCost = selectedSeats.Count * cost; //Tính tổng tiền
            string seats = string.Join(", ", selectedSeats.Select(b => b.Text)); //Lấy danh sách ghế đã chọn
            DialogResult result = MessageBox.Show($"Bạn đã chọn ghế: {seats}\nTổng tiền: {totalCost} VND\nXác nhận đặt chỗ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Button btn in selectedSeats)
                {
                    btn.BackColor = Color.Blue; //Chuyển sang màu ghế đã bán
                }
                selectedSeats.Clear(); //Xóa danh sách ghế đang chọn
                MessageBox.Show("Đặt chỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button btn in selectedSeats)
            {
                btn.BackColor = Color.White; //Chuyển sang màu ghế chưa chọn
            }
        }
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
