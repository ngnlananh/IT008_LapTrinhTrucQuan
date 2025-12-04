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
                string query = @"SELECT TENKHOA FROM KHOA";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    cboKhoa.Items.Add(reader["TENKHOA"].ToString());
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
            if (!int.TryParse(txtMaSV.Text, out int maSV))
            {
                MessageBox.Show("Mã số sinh viên phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra điểm TB có hợp lệ không
            if (!double.TryParse(txtDiemTB.Text, out double diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm trung bình phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert vao CSDL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO SINHVIEN (MSSV, TEN, KHOA, DIEMTB) "
                                + "VALUES (@MSSV, @TEN, @KHOA, @DIEMTB)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MSSV", maSV);
                command.Parameters.AddWithValue("@TEN", txtTenSV.Text);
                command.Parameters.AddWithValue("@KHOA", cboKhoa.SelectedItem.ToString());
                command.Parameters.AddWithValue("@DIEMTB", diem);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Tạo đối tượng SinhVienMoi để trả về frmMain
            SinhVienMoi = new SinhVien
            {
                MSSV = maSV,
                Ten = txtTenSV.Text,
                Khoa = cboKhoa.Text, // hiển thị tên khoa
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
