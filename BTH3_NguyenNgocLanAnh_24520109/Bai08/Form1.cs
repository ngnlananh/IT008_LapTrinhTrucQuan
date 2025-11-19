using System;
using System.Windows.Forms;

namespace Bai08
{
    public partial class fBai08 : Form
    {
        private double SumTien = 0;
        public fBai08()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("STT", 50);
            listView1.Columns.Add("Mã tài khoản",100);
            listView1.Columns.Add("Tên khách hàng", 150);
            listView1.Columns.Add("Địa chỉ", 250);
            listView1.Columns.Add("Số tiền", 250);
            listView1.FullRowSelect = true;
            txtbTongTien.Text = SumTien.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtbSTK.Text.Length == 0 || txtbTenKH.Text.Length == 0 
                || txtbDiaChiKH.Text.Length == 0 || txtbSoTien.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (!double.TryParse(txtbSoTien.Text, out double money) || money < 0)
            {
                MessageBox.Show("Số tiền phải là số thực dương, Vui lòng nhập lại!");
                return;
            }
            if (!int.TryParse(txtbSTK.Text, out int stk) || stk < 0)
            {
                MessageBox.Show("Số tài khoản phải là số nguyên dương, Vui lòng nhập lại!");
                return;
            }
            var foundItem = listView1.FindItemWithText(txtbSTK.Text);
            int index = foundItem?.Index ?? -1;
            if (index == -1) //chưa tồn tại STK -> thêm mới
            {
                ListViewItem item = new ListViewItem((listView1.Items.Count + 1).ToString());
                item.SubItems.Add(txtbSTK.Text);
                item.SubItems.Add(txtbTenKH.Text);
                item.SubItems.Add(txtbDiaChiKH.Text);
                item.SubItems.Add(money.ToString("N2"));
                listView1.Items.Add(item);
                SumTien += money;
                txtbTongTien.Text = SumTien.ToString();

                txtbSTK.Clear();
                txtbTenKH.Clear();
                txtbDiaChiKH.Clear();
                txtbSoTien.Clear();
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else //đã tồn tại STK -> cập nhật dữ liệu
            {
                listView1.Items[index].SubItems[2].Text = txtbTenKH.Text;
                listView1.Items[index].SubItems[3].Text = txtbDiaChiKH.Text;
                double oldMoney = double.Parse(listView1.Items[index].SubItems[4].Text);
                double newMoney = double.Parse(txtbSoTien.Text);
                listView1.Items[index].SubItems[4].Text = newMoney.ToString();
                SumTien = SumTien - oldMoney + newMoney;
                txtbTongTien.Text = SumTien.ToString();
                MessageBox.Show("Cập nhật dữ liệu thành công!");
                txtbSTK.Clear();
                txtbTenKH.Clear();
                txtbDiaChiKH.Clear();
                txtbSoTien.Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int stk = int.Parse(txtbSTK.Text);
            var foundItem = listView1.FindItemWithText(stk.ToString(), true, 0);
            int index = foundItem?.Index ?? -1;
            if (foundItem != null)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này?", "Xác nhận xoá",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Tính lại tổng tiền
                    double money = double.Parse(listView1.Items[foundItem.Index].SubItems[4].Text);
                    SumTien -= money;
                    txtbTongTien.Text = SumTien.ToString();
                    listView1.Items.RemoveAt(foundItem.Index);
                    //Cập nhật lại STT
                    for (int j = 0; j < listView1.Items.Count; j++)
                    {
                        listView1.Items[j].SubItems[0].Text = (j + 1).ToString();
                    }
                    MessageBox.Show("Xóa tài khoản thành công!");
                    return;
                }
                else
                    return;
            }
            else
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                txtbSTK.Text = item.SubItems[1].Text;
                txtbTenKH.Text = item.SubItems[2].Text;
                txtbDiaChiKH.Text = item.SubItems[3].Text;
                txtbSoTien.Text = item.SubItems[4].Text;
            }
        }
    }
}
