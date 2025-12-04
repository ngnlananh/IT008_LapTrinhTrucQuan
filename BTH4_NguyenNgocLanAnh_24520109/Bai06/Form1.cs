using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        private ToolTip toolTip = new ToolTip();
        public Form1()
        {
            InitializeComponent();
            // Thêm ToolTip cho các điều khiển
            toolTip.SetToolTip(btnBrowseSource, "Chọn thư mục chứa tập tin cần sao chép");
            toolTip.SetToolTip(btnBrowseDestination, "Chọn thư mục đích để lưu tập tin");
            toolTip.SetToolTip(btnCopy, "Bấm để bắt đầu sao chép tập tin");
            lblStatus.Text = "Đang sao chép:";
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
            string sourcePath = txtSource.Text;
            string destinationPath = txtDestination.Text;

            if (!Directory.Exists(sourcePath) || !Directory.Exists(destinationPath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ.");
                return;
            }

            string[] files = Directory.GetFiles(sourcePath);
            progressBar.Maximum = files.Length;
            progressBar.Value = 0;

            await Task.Run(() =>
            {
                foreach (var file in files)
                {
                    try
                    {
                        string fileName = Path.GetFileName(file);
                        string dest = Path.Combine(destinationPath, fileName);

                        // Cập nhật status và tiến trình trên progressBar
                        this.Invoke(new Action(() =>
                        {
                            lblStatus.Text = $"Đang sao chép: {fileName}";
                            progressBar.Value += 1;
                        }));

                        File.Copy(file, dest, true);
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action(() =>
                        {
                            lblStatus.Text = $"Lỗi sao chép: {ex.Message}";
                        }));
                    }
                }
            });

            lblStatus.Text = "Hoàn tất sao chép!";
            MessageBox.Show("Sao chép hoàn tất.");
        }
    }
}