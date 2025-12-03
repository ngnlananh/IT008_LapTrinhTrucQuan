using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Bai05
{
    public partial class frmMain : Form
    {
        private List<SinhVien> danhsachSV = new List<SinhVien>();
        public frmMain()
        {
            InitializeComponent();
            this.MainMenuStrip = menuStrip1;
            dgvStudent.AutoGenerateColumns = false;
        }
        // Hiển thị danh sách lên DataGridView
        private void HienThiDanhSach(List<SinhVien> ds)
        {
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = ds;
            // Đánh số thứ tự cho từng dòng
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                dgvStudent.Rows[i].Cells[0].Value = i + 1;
            }
        }

        // Sự kiện thêm mới từ menu hoặc toolstrip
        private void AddStudent_Click(object sender, System.EventArgs e)
        {
            frmNhapSinhVien nhap = new frmNhapSinhVien();
            if (nhap.ShowDialog() == DialogResult.OK)
            {
                // Lấy đối tượng SinhVienMoi từ form nhập liệu
                danhsachSV.Add(nhap.SinhVienMoi);

                // Hiển thị lại danh sách
                HienThiDanhSach(danhsachSV);
            }
        }
        // Thoát chương trình
        private void Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        // Tìm kiếm theo tên
        private void txbFindStudent_TextChanged(object sender, System.EventArgs e)
        {
            string keyword = txbFindStudent.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu rỗng thì hiển thị lại toàn bộ danh sách
                HienThiDanhSach(danhsachSV);
            }
            else
            {
                // Nếu có từ khóa thì lọc theo tên
                var ketQua = danhsachSV
                    .Where(sv => sv.Ten.ToLower().Contains(keyword))
                    .ToList();
                HienThiDanhSach(ketQua);
            }
        }
    }
}
