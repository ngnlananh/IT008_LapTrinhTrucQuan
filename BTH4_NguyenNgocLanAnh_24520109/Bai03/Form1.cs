using System;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form1
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog(); // Tạo hộp thoại mở file
            // Bộ lọc để chỉ hiển thị các định dạng file media
            dialog.Filter = "AVI File | *.avi | MPEG File | *.mpeg | WAV File | *.wav |"
                + "MIDI File | *.midi | MP4 File| *.mp4 | MP3 File| *.mp3";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                media1.URL = dialog.FileName; // Thiết lập đường dẫn file cho điều khiển media1
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now; // Lấy thời gian hiện tại
            // Cập nhật lblTimer với định dạng ngày và giờ
            lblTimer.Text = "Hôm nay là ngày " + now.ToString("dd/mm/yyyy")
                + " Bây giờ là " + now.ToString("hh:mm:ss tt");
        }
    }
}
