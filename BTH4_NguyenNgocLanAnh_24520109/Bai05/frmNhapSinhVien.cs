using System;
using System.Linq;
using System.Windows.Forms;

namespace Bai05
{
    public partial class frmNhapSinhVien : Form
    {
        public SinhVien SinhVienMoi { get; private set; }
        public frmNhapSinhVien()
        {
            InitializeComponent();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtTenSV.Text) ||
                cboKhoa.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // dừng lại, không thêm
            }
            // Kiểm tra MSSV là số nguyên
            if (!int.TryParse(txtMaSV.Text, out int maSV))
            {
                MessageBox.Show("Mã số sinh viên phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra điểm TB có hợp lệ không
            if (!double.TryParse(txtDiemTB.Text, out double diem))
            {
                MessageBox.Show("Điểm trung bình phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra điểm TB trong khoảng 0–10
            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm trung bình phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu hợp lệ --> tạo đối tượng SinhVien
            SinhVienMoi = new SinhVien
            {
                MaSV = int.Parse(txtMaSV.Text),
                Ten = txtTenSV.Text,
                Khoa = cboKhoa.SelectedItem.ToString(),
                DiemTB = diem
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
