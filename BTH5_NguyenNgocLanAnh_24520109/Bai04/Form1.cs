using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load size
            float[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in sizes)
                cmbSize.Items.Add(s.ToString());
            cmbSize.SelectedIndex = 0;

            // Load font mặc định
            foreach (var f in FontFamily.Families)
                cmbFont.Items.Add(f.Name);
            cmbFont.SelectedIndex = 0;

            cmbFont.SelectedIndexChanged += cmbFont_SelectedIndexChanged;
            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;
        }
        private void ApplyFont()
        {
            if (cmbFont.SelectedItem == null)
                return;
            string fontName = cmbFont.SelectedItem.ToString();

            float size;
            if (!float.TryParse(cmbSize.Text, out size) || size <= 0)
            {
                // Chỉ hiện lỗi nếu có text nhưng không phải là số
                if (!string.IsNullOrEmpty(cmbSize.Text))
                {
                    MessageBox.Show("Size không hợp lệ!", "Lỗi");
                }
                return;
            }

            FontStyle style = FontStyle.Regular; // mặc định là regular

            if (ckbBold.Checked)
                style |= FontStyle.Bold;
            if (ckbItalic.Checked)
                style |= FontStyle.Italic;
            if (ckbUnderline.Checked)
                style |= FontStyle.Underline;

            // Áp dụng font và color
            richTextBox1.Font = new Font(fontName, size, style);
            richTextBox1.ForeColor = btnColor.BackColor;

            // Áp dụng alignment
            if (rbLeft.Checked)
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            else if (rbCenter.Checked)
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            else if (rbRight.Checked)
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dl = new ColorDialog();
            if (dl.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = dl.Color;
                ApplyFont();
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void Style_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void Alignment_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void cmbSize_TextChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }
    }
}
