using System.Drawing;
using System.Windows.Forms;

namespace Bai09
{
    public partial class fBai09 : Form
    {
        public fBai09()
        {
            InitializeComponent();
            grbTTSv.Text = "Thông Tin Sinh Viên";
            label1.Text = "Mã Sinh Viên";
            label1.Font = new Font("Cambria", 10);
            label2.Text = "Họ Tên";
            label2.Font = new Font("Cambria", 10);
            label3.Text = "Chuyên Ngành";
            label3.Font = new Font("Cambria", 10);
            label4.Text = "Giới tính";
            label4.Font = new Font("Cambria", 10);
            label5.Text = "Chọn Các Môn Học Tham Gia";
            label5.Font = new Font("Cambria", 10);
            ckbNam.Font = new Font("Cambria", 10);
            ckbNam.Text = "Nam";
            ckbNu.Font = new Font("Cambria", 10);
            ckbNu.Text = "Nữ";
            cmbChuyenNganh.Items.Add("Kỹ Thuật Phần Mềm");
            cmbChuyenNganh.Items.Add("Khoa Học Máy Tính");
            cmbChuyenNganh.Items.Add("Kỹ Thuật Máy Tính");
            cmbChuyenNganh.Items.Add("Trí Tuệ Nhân Tạo");
            cmbChuyenNganh.Items.Add("Hệ Thống Thông Tin");
            cmbChuyenNganh.Items.Add("An Toàn Thông Tin");
            lbListMon.Items.Add("Cơ Sở Dữ Liệu");
            lbListMon.Items.Add("Cơ Sở DL NC");
            lbListMon.Items.Add("PTTK Hệ Thống Thông Tin");
            btnLuu.Text = "Lưu Thông Tin";
            btnThem.Text = ">";
            btnBo.Text = "<";
            btnXoaChon.Text = "Xóa Chọn";


            dataGridView1.Columns.Add("MSSV", "MSSV");
            dataGridView1.Columns.Add("HoTen", "Họ tên");
            dataGridView1.Columns.Add("ChuyenNganh", "Chuyên Ngành");
            dataGridView1.Columns.Add("GioiTinh", "Giới Tính");
            dataGridView1.Columns.Add("SoMon", "Số Môn");
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[3].Width = 80;
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            if (lbListMon.SelectedItem != null)
            {
                lbListChon.Items.Add(lbListMon.SelectedItem);
                lbListMon.Items.Remove(lbListMon.SelectedItem);
            }
            else
                MessageBox.Show("Vui lòng chọn môn học để thêm");
        }

        private void btnBo_Click(object sender, System.EventArgs e)
        {
            if (lbListChon.SelectedItems != null)
            {
                lbListMon.Items.Add(lbListChon.SelectedItem);
                lbListChon.Items.Remove(lbListChon.SelectedItem);
            }
            else
                MessageBox.Show("Vui lòng chọn môn học để xóa");
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            //Kiểm thử input
            if (txtbMSSV.Text == "" || txtbHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập MSSV và Họ Tên!");
                return;
            }
            if (!int.TryParse(txtbMSSV.Text, out int mssv))
            {
                MessageBox.Show("Mã Số Sinh Viên phải là dãy số nguyên. Vui lòng nhập lại!", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (ckbNam.Checked && ckbNu.Checked)
            {
                MessageBox.Show("Chỉ được chọn giới tính là Nam hoặc Nữ. Vui lòng chọn lại!", "Warning", MessageBoxButtons.OK);
                return;
            }
            else if (!ckbNam.Checked && !ckbNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Warning", MessageBoxButtons.OK);
                return;
            }
                //Nhập dữ liệu sau khi kiểm thử
                string gt = ckbNam.Checked ? "Nam" : "Nữ";
            dataGridView1.Rows.Add(
                txtbMSSV.Text,
                txtbHoTen.Text,
                cmbChuyenNganh.Text,
                gt,
                lbListChon.Items.Count
            );
            //trả lại trạng thái ban đầu cho các item sau khi nhập
            txtbHoTen.Clear();
            txtbMSSV.Clear();
            cmbChuyenNganh.Items.Clear();
            ckbNam.Checked = false;
            ckbNu.Checked = false;
            foreach (var item in lbListChon.Items)
                lbListMon.Items.Add(item);
            lbListChon.Items.Clear();
            MessageBox.Show("Lưu thông tin thành công!");
        }

        private void btnXoaChon_Click(object sender, System.EventArgs e)
        {
            txtbMSSV.Clear();
            txtbHoTen.Clear();
            cmbChuyenNganh.SelectedIndex = -1;
            ckbNam.Checked = false;
            ckbNu.Checked = false;

            // đưa môn đã chọn về lại danh sách ban đầu
            foreach (var item in lbListChon.Items)
                lbListMon.Items.Add(item);

            lbListChon.Items.Clear();
        }
    }
}
