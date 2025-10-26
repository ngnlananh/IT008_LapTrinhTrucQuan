using System.Formats.Tar;
using System.IO;
using System.Runtime.Intrinsics.Arm;

namespace BTH2_NguyenNgocLanAnh_24520109
{
    class Bai02
    {
        public static void Run()
        {
            //Bật Unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            //Nhập đường dẫn thư mục
            string strFile;
            bool flag = true; //Đặt cờ báo hiệu lần nhập đầu tiên
            do
            {
                if (flag == false)
                    Console.WriteLine("Vui long nhap lai duong dan!");
                Console.Write("Nhap duong dan thu muc: ");
                strFile = Console.ReadLine();
                flag = false;
                if (!Directory.Exists(strFile))
                    Console.WriteLine("Khong tim thay thu muc hoac duong dan khong hop le");
            } while (!Directory.Exists(strFile));

            string[] str = Directory.GetFiles(strFile);
            if (Directory.Exists(strFile))
            {
                Console.WriteLine();
                DriveInfo drive = new DriveInfo(Path.GetPathRoot(strFile)!);
                string label = string.IsNullOrEmpty(drive.VolumeLabel) ? "NO LABEL" : drive.VolumeLabel;
                Console.WriteLine();
                Console.WriteLine($" Volume in drive {drive.Name.TrimEnd('\\')} is {drive.VolumeLabel}");
                Console.WriteLine($" Volume Serial Number is {drive.VolumeLabel.GetHashCode():X8}");
                Console.WriteLine();
                Console.WriteLine($" Directory of {Path.GetFullPath(strFile)}");
                Console.WriteLine();

                string[] dirs = Directory.GetDirectories(strFile);
                string[] files = Directory.GetFiles(strFile);

                long totalFileBytes = 0;
                int fileCount = 0;
                int dirCount = 0;

                // In thư mục con
                foreach (var dir in dirs)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    Console.WriteLine($"{di.LastWriteTime:dd/MM/yyyy  hh:mm tt}    <DIR>\t{di.Name}");
                    dirCount++;
                }

                // In file
                foreach (var f in files)
                {
                    FileInfo fi = new FileInfo(f);
                    Console.WriteLine($"{fi.LastWriteTime:dd/MM/yyyy  hh:mm tt}\t{fi.Length,15:N0} {fi.Name}");
                    totalFileBytes += fi.Length;
                    fileCount++;
                }
                
                //In tổng số file và tổng số Bytes trong thư mục 
                Console.WriteLine($"\t{fileCount,3} File(s)\t{totalFileBytes,15:N0} bytes");

                //In số thư mục con và ổ đĩa còn trống bao nhiêu byte
                long freeSpace = drive.AvailableFreeSpace;
                Console.WriteLine($"\t{dirCount,3} Dir(s)  {freeSpace,15:N0} bytes free");
            }
            else
                Console.WriteLine("Khong co tap tin nao trong thu muc!");
        }
    }
}