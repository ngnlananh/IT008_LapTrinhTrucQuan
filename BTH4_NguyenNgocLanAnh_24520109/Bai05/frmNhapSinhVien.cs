using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Bai05
{
    public partial class frmNhapSinhVien : Form
    {
        // Kết nối CSDL QuanLySinhVien
        string connectionString = @"Server=localhost; Database=QuanLySinhVien;Integrated Security=True;";
        public SinhVien SinhVienMoi { get; set; }
        public frmNhapSinhVien()
        {
            InitializeComponent();
            LoadDataKhoa();
        }
        private void LoadDataKhoa()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT MAKHOA, TENKHOA FROM KHOA";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Khoa khoa = new Khoa
                    {
                        MaKhoa = reader.GetInt32(0),
                        TenKhoa = reader.GetString(1)
                    };
                    cboKhoa.Items.Add(khoa);
                }
            }
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
            if (!int.TryParse(txtMaSV.Text, out int maSV) || maSV <= 0)
            {
                MessageBox.Show("Mã số sinh viên phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra điểm TB có hợp lệ không
            if (!double.TryParse(txtDiemTB.Text, out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm trung bình phải là số thuộc [0;10]!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert vao CSDL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Kiểm tra MSSV đã tồn tại chưa
                string checkQuery = "SELECT COUNT(*) FROM SINHVIEN WHERE MSSV = @MSSV";
                SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                checkCmd.Parameters.AddWithValue("@MSSV", maSV);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO SINHVIEN (MSSV, TEN, KHOA, DIEMTB) "
                                + "VALUES (@MSSV, @TEN, @KHOA, @DIEMTB)";
                SqlCommand command = new SqlCommand(query, connection);
                Khoa selectedKhoa = cboKhoa.SelectedItem as Khoa;
                if (selectedKhoa == null)
                {
                    MessageBox.Show("Vui lòng chọn khoa hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                command.Parameters.AddWithValue("@MSSV", maSV);
                command.Parameters.AddWithValue("@TEN", txtTenSV.Text);
                command.Parameters.AddWithValue("@KHOA", selectedKhoa.MaKhoa);
                command.Parameters.AddWithValue("@DIEMTB", diem);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Tạo đối tượng SinhVienMoi để trả về frmMain
                    SinhVienMoi = new SinhVien
                    {
                        MSSV = maSV,
                        Ten = txtTenSV.Text,
                        Khoa = selectedKhoa.MaKhoa, // hiển thị tên khoa
                        DiemTB = diem
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
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
