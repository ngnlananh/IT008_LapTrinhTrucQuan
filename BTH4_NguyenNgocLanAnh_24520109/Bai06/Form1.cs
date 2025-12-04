using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Thêm ToolTip cho các điều khiển
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtSource, "Chọn thư mục chứa tập tin cần sao chép");
            toolTip.SetToolTip(txtDestination, "Chọn thư mục đích để lưu tập tin");
            toolTip.SetToolTip(btnCopy, "Bấm để bắt đầu sao chép tập tin");
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn thư mục đích
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Chọn thư mục đích";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestination.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn thư mục nguồn
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Chọn thư mục nguồn";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = dialog.SelectedPath;
                }
            }
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            // Lấy đường dẫn từ TextBox
            string sourcePath = txtSource.Text;
            string destinationPath = txtDestination.Text;

            if (!Directory.Exists(sourcePath) || !Directory.Exists(destinationPath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ.");
                return;
            }

            // Lấy danh sách tập tin trong thư mục nguồn
            string[] files = Directory.GetFiles(sourcePath);
            int totalFiles = files.Length;
            progressBar.Maximum = totalFiles;
            progressBar.Value = 0;

            // Sao chép từng tập tin
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(destinationPath, fileName);

                lblStatus.Text = $"Đang sao chép: {fileName}";
                await Task.Run(() => File.Copy(file, destFile, true));

                progressBar.Value += 1;
                Application.DoEvents(); // Cập nhật giao diện
            }

            lblStatus.Text = "Hoàn tất sao chép!";
            MessageBox.Show("Sao chép hoàn tất.");
        }
    }
}
