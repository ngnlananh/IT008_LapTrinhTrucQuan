namespace Bai05
{
    public class Khoa
    {
        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public override string ToString()
        {
            return TenKhoa; // để hiển thị trong ComboBox
        }
    }
}
