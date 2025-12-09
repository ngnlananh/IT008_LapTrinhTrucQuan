using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.ItemHeight = 30;
            listBox1.DrawMode = DrawMode.OwnerDrawFixed; // Cho phép vẽ tùy chỉnh
            LoadFontFamilies();
        }
        private void LoadFontFamilies()
        {
            listBox1.Items.Clear();
            foreach(FontFamily f in FontFamily.Families)
            {
                listBox1.Items.Add(f.Name);
            }
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0 && e.Index <= listBox1.Items.Count)
            {
                // Lấy tên font
                string fontName = listBox1.Items[e.Index].ToString();

                // Tạo brush và FontStyle mặc định
                Brush brush = SystemBrushes.ControlText;
                FontStyle style = FontStyle.Regular;

                // Thiết lập khi chọn item
                e.DrawBackground();
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }

                // Apply font cho item
                try
                {
                    Font itemFont = new Font(fontName, 14, style);
                    e.Graphics.DrawString(fontName, itemFont, brush, e.Bounds.Location);
                }
                catch(Exception)
                {
                    // Nếu lỗi -> hiển thị lỗi font với font mặc định của Item
                    e.Graphics.DrawString("(Lỗi font)", e.Font, brush, e.Bounds.Location);
                }
                
                // Vẽ hình chữ nhật Focus khi được chọn
                e.DrawFocusRectangle();
            }
        }
    }
}
