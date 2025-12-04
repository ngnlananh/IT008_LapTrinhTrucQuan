using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        string currentFile = "";   // để biết file đang mở
        bool isNewFile = true;     // kiểm tra văn bản mới
        bool isSaved = true;      // kiểm tra văn bản đã lưu
        public Form1()
        {
            InitializeComponent();
            this.MainMenuStrip = menuStrip1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load font
            foreach (FontFamily f in FontFamily.Families)
                cboFont.Items.Add(f.Name);

            // Load size
            int[] size = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach(int s in size)
                cboSize.Items.Add(s.ToString());

            // giá trị mặc định là Font Tahoma, Size 14
            int idxFont = cboFont.Items.IndexOf("Tahoma");
            if (idxFont >= 0) cboFont.SelectedIndex = idxFont;

            int idxSize = cboSize.Items.IndexOf("14");
            if (idxSize >= 0) cboSize.SelectedIndex = idxSize;
            ApplyFont();
        }

        // ========================== Hàm dùng chung ========================
        private void ApplyFont()
        {
            try
            {
                string fontName = cboFont.SelectedItem?.ToString() ?? "Tahoma";
                float fontSize = float.TryParse(cboSize.SelectedItem?.ToString(), out float s) ? s : 14;

                if (rtbMain.SelectionFont != null)
                {
                    rtbMain.SelectionFont = new Font(
                        fontName,
                        fontSize,
                        rtbMain.SelectionFont.Style
                    );
                }
                else
                {
                    rtbMain.Font = new Font(fontName, fontSize);
                }
            }
            catch { }
        }



        private void ToggleStyle(FontStyle style)
        {
            if (rtbMain.SelectionFont == null) return;

            // Loại bỏ style cũ, thay bằng style mới 
            FontStyle newStyle = rtbMain.SelectionFont.Style.HasFlag(style)
                ? rtbMain.SelectionFont.Style & ~style
                : rtbMain.SelectionFont.Style | style;

            rtbMain.SelectionFont = new Font(
                rtbMain.SelectionFont.FontFamily,
                rtbMain.SelectionFont.Size,
                newStyle
            );
        }
        private bool AskSaveBeforeAction() // Hàm hỏi người dùng muốn lưu file trước không
        {
            if (!isSaved)
            {
                var result = MessageBox.Show("Bạn có muốn lưu trước khi tiếp tục?",
                                             "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }
        private void SaveFile()
        {
            if (string.IsNullOrEmpty(currentFile) || isNewFile)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "RTF File|*.rtf";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    currentFile = savefile.FileName;
                    rtbMain.SaveFile(savefile.FileName, RichTextBoxStreamType.RichText);
                    isNewFile = false;
                    isSaved = true;
                    MessageBox.Show("Lưu văn bản thành công!");
                }
            }
            else
            {
                rtbMain.SaveFile(currentFile, RichTextBoxStreamType.RichText);
                isSaved = true;
                MessageBox.Show("Lưu văn bản thành công!");
            }
        }
        private void CreateNewFile()
        {
            rtbMain.Clear();
            currentFile = "";
            isSaved = true;
            isNewFile = true;

            int idxFont = cboFont.Items.IndexOf("Tahoma");
            if (idxFont >= 0) cboFont.SelectedIndex = idxFont;

            int idxSize = cboSize.Items.IndexOf("14");
            if (idxSize >= 0) cboSize.SelectedIndex = idxSize;

            ApplyFont();
        }

        // ============================ Sự kiện của menuStrip ==========================

        private void CreateNewFileMenustrip_Click(object sender, EventArgs e)
        {
            if (AskSaveBeforeAction())
                CreateNewFile();
        }

        private void OpenFileMenustrip_Click(object sender, EventArgs e)
        {
            if (AskSaveBeforeAction())
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "TXT File (*.txt)|*.txt| RTF File (*.rtf)|*.rtf";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    currentFile = openfile.FileName;
                    if (Path.GetExtension(currentFile).ToLower() == ".rtf")
                        rtbMain.LoadFile(currentFile, RichTextBoxStreamType.RichText);
                    else
                        rtbMain.LoadFile(currentFile, RichTextBoxStreamType.PlainText);
                    isNewFile = false;
                    isSaved = true;
                }
            }
        }
        private void OpenFontDialogToolstrip_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowApply = true; // cho phép chọn style
            if (font.ShowDialog() == DialogResult.OK)
            {
                if (rtbMain.SelectionLength > 0)
                    rtbMain.SelectionFont = new Font(font.Font.FontFamily, font.Font.Size, font.Font.Style);
                else
                    rtbMain.Font = new Font(font.Font.FontFamily, font.Font.Size, font.Font.Style);

                // cập nhật combobox
                cboFont.SelectedIndex = cboFont.Items.IndexOf(font.Font.Name);
                cboSize.SelectedIndex = cboSize.Items.IndexOf(font.Font.Size.ToString());
            }
        }

        private void SaveMenustrip_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void ExitMenustrip_Click(object sender, EventArgs e)
        {
            if (AskSaveBeforeAction())
                this.Close();
        }

        // ============================ Sự kiện của toolStrip ==========================
        private void btnNewFile_Click(object sender, EventArgs e)
        {
            if (AskSaveBeforeAction())
                CreateNewFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        // ============================ Sự kiện của richTextBox ==========================
        private void rtbMain_TextChanged(object sender, EventArgs e)
        {
            if (rtbMain.SelectionFont == null)
            {
                rtbMain.SelectionFont = rtbMain.Font;
            }

            // logic lưu trạng thái
            if (string.IsNullOrWhiteSpace(rtbMain.Text))
            {
                isSaved = true;
                isNewFile = true;
                currentFile = "";
            }
            else
            {
                isSaved = false;
            }
        }
    }
}
