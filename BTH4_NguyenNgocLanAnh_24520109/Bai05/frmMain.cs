using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Bai05
{
    public partial class frmMain : Form
    {
        // Kết nối CSDL QuanLySinhVien
        string connectionString = @"Server=localhost; Database=QuanLySinhVien;Integrated Security=True;";
        public frmMain()
        {
            InitializeComponent();
            this.MainMenuStrip = menuStrip1;
            LoadDatagrid();
            LoadDataFromDatabase();
        }
        private void LoadDatagrid()
        {
            // Thêm cột STT
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            sttColumn.Name = "STT";
            dgvStudent.Columns.Add(sttColumn);

            // Thêm cột MSSV
            DataGridViewTextBoxColumn mssvColumn = new DataGridViewTextBoxColumn();
            mssvColumn.HeaderText = "MSSV";
            mssvColumn.DataPropertyName = "MSSV"; // phải khớp với tên cột trong DataTable
            dgvStudent.Columns.Add(mssvColumn);

            // Thêm cột TEN
            DataGridViewTextBoxColumn tenColumn = new DataGridViewTextBoxColumn();
            tenColumn.HeaderText = "Tên sinh viên";
            tenColumn.DataPropertyName = "TEN";
            dgvStudent.Columns.Add(tenColumn);

            // Thêm cột TENKHOA
            DataGridViewTextBoxColumn khoaColumn = new DataGridViewTextBoxColumn();
            khoaColumn.HeaderText = "Tên khoa";
            khoaColumn.DataPropertyName = "TENKHOA";
            dgvStudent.Columns.Add(khoaColumn);

            // Thêm cột DIEMTB
            DataGridViewTextBoxColumn diemColumn = new DataGridViewTextBoxColumn();
            diemColumn.HeaderText = "Điểm TB";
            diemColumn.DataPropertyName = "DIEMTB";
            dgvStudent.Columns.Add(diemColumn);

            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SV.MSSV, SV.TEN, K.TENKHOA, SV.DIEMTB " +
                    "FROM SINHVIEN SV " +
                    "INNER JOIN KHOA K ON K.MAKHOA = SV.KHOA";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvStudent.DataSource = dt;

                // Đánh số thứ tự cho từng dòng
                for (int i = 0; i < dgvStudent.Rows.Count; i++)
                {
                    dgvStudent.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }

        // Sự kiện thêm mới từ menu hoặc toolstrip
        private void AddStudent_Click(object sender, System.EventArgs e)
        {
            frmNhapSinhVien nhap = new frmNhapSinhVien();
            if (nhap.ShowDialog() == DialogResult.OK)
            {
                var svmoi = nhap.SinhVienMoi;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO SINHVIEN (MSSV, TEN, KHOA, DIEMTB) " +
                                   "VALUES (@MSSV, @TEN, @KHOA, @DIEMTB)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MSSV", svmoi.MSSV);
                    command.Parameters.AddWithValue("@TEN", svmoi.Ten);
                    command.Parameters.AddWithValue("@KHOA", svmoi.Khoa);
                    command.Parameters.AddWithValue("@DIEMTB", svmoi.DiemTB);
                    command.ExecuteNonQuery();
                }
                LoadDataFromDatabase();
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SV.MSSV, SV.TEN, K.TENKHOA,SV.DIEMTB " +
                        "FROM SINHVIEN SV" +
                        "INNER JOIN KHOA K ON K.MAKHOA = SV.KHOA" +
                        "WHERE SV.TEN LIKE @keyword";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvStudent.DataSource = dt;
                    // Đánh số thứ tự
                    for (int i = 0; i < dgvStudent.Rows.Count; i++)
                    {
                        dgvStudent.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
        }
    }
}
