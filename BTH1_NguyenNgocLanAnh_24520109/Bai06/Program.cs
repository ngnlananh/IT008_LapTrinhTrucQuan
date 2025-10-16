using System;

class Program
{
    public static int NhapSoNguyen(string message)
    {
        int temp;
        bool flag = false;
        string s;
        do
        {
            if (flag)
                Console.WriteLine("Vui long nhap so nguyen duong !!!");
            Console.Write(message);
            s = Console.ReadLine();
            flag = true;

        } while (!int.TryParse(s, out temp) || temp <= 0);
        return temp;
    }



    static void Main()
    {
        //Nhập n và m
        int n = NhapSoNguyen("Nhap n (n>0): ");
        int m = NhapSoNguyen("Nhap m (m>0): ");

        //Tạo ma trận ngẫu nhiên
        int[][] arr = new int[n][];
        TaoMaTran_NgauNhien(ref arr, n, m);

        int choice;
        do
        {
            //In menu 
            Console.WriteLine();
            Console.WriteLine("================= MENU ================");
            Console.WriteLine("1. Xuat ma tran");
            Console.WriteLine("2. Tim phan tu lon nhat / nho nhat");
            Console.WriteLine("3. Tim dong co tong lon nhat");
            Console.WriteLine("4. Tinh tong cac so khong phai la so nguyen to");
            Console.WriteLine("5. Xoa dong thu k trong ma tran");
            Console.WriteLine("6. Xoa cot chua phan tu lon nhat trong ma tran");
            Console.WriteLine("0. Exit");
            Console.Write("Chon chuc nang: ");

            //Đọc lựa chọn
            choice = int.Parse(Console.ReadLine());

            //Xử lý lựa chọn
            switch (choice)
            {
                case 0:
                    Console.WriteLine("===========THANKYOU!===========");
                    return;
                case 1:
                    XuatMaTran(arr);
                    break;
                case 2:
                    Console.WriteLine("Phan tu lon nhat: " + Max_Element(arr));
                    Console.WriteLine("Phan tu nho nhat: " + Min_Element(arr));
                    break;
                case 3:
                    Console.WriteLine("Dong co tong lon nhat la dong thu: " + (DongCoTongLonNhat(arr) + 1));
                    break;
                case 4:
                    Console.WriteLine("Tong cac so khong phai la so nguyen to: " + NumOfNonPrime(arr));
                    break;
                case 5:
                    Console.Write("Nhap k (0 <= k < " + n + "): ");
                    int k = int.Parse(Console.ReadLine());
                    Erase_Row(ref arr, k);
                    break;
                case 6:
                    Erase_Column_Max_element(ref arr);
                    break;
                default:
                    Console.WriteLine("Chuc nang khong hop le! Vui long chon lai");
                    continue;
            }
        } while (choice != 0);
    }

    //Tạo ma trận ngẫu nhiên
    static void TaoMaTran_NgauNhien(ref int[][] arr, int n, int m)
    {
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                arr[i][j] = rand.Next(0, 100);
            }
        }
    }
    //Xuất ma trận
    static void XuatMaTran(int[][] arr)
    {
        Console.Write("Ma tran:");
        if (arr.Length == 0)
        {
            Console.Write("Rong");
        }
        else
        {
            Console.WriteLine();
            foreach (var row in arr)
            {
                foreach (var item in row)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
        }
    }
    //Tìm phần tử lớn nhất
    static int Max_Element(int[][] arr)
    {
        int max = int.MinValue;
        foreach (var row in arr)
        {
            foreach (var item in row)
            {
                if (item > max)
                    max = item;
            }
        }
        return max;
    }
    //Tìm phần tử nhỏ nhất
    static int Min_Element(int[][] arr)
    {
        int min = int.MaxValue;
        foreach (var row in arr)
        {
            foreach (var item in row)
            {
                if (item < min)
                    min = item;
            }
        }
        return min;
    }
    //Tìm dòng có tổng lớn nhất
    static int DongCoTongLonNhat(int[][] arr)
    {
        int maxSum = int.MinValue;
        int rowIndex = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < arr[i].Length; j++)
            {
                sum += arr[i][j];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                rowIndex = i;
            }
        }
        return rowIndex;
    }
    //Kiểm tra số nguyên tố
    static bool Check_SNT(int x)
    {
        if (x <= 1) return false;
        if (x == 2) return true;
        if (x % 2 == 0) return false;
        else
        {
            for (int i = 3; i <= Math.Sqrt(x); i += 2)
            {
                if (x % i == 0)
                    return false;
            }
        }
        return true;
    }
    //Tổng các số không phải số nguyên tố
    static int NumOfNonPrime(int[][] arr)
    {
        int sum = 0;
        foreach (var row in arr)
        {
            foreach (var item in row)
            {
                if (!Check_SNT(item))
                    sum += item;
            }
        }
        return sum;
    }
    //Xóa dòng thứ k
    static void Erase_Row(ref int[][] arr, int k)
    {
        if (k < 0 || k >= arr.Length)
        {
            Console.WriteLine("Dong khong hop le.");
            return;
        }
        for (int i = k; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        Array.Resize(ref arr, arr.Length - 1);
    }
    //Xóa cột chứa phần tử lớn nhất
    static void Erase_Column_Max_element(ref int[][] arr)
    {
        int maxElement = int.MinValue;
        int maxCol = -1;
        // Tìm cột chứa phần tử lớn nhất
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] > maxElement)
                {
                    maxElement = arr[i][j];
                    maxCol = j;
                }
            }
        }
        if (maxCol == -1)
        {
            Console.WriteLine("Khong tim thay phan tu lon nhat!");
            return;
        }
        // Xóa cột maxCol
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = maxCol; j < arr[i].Length - 1; j++)
                arr[i][j] = arr[i][j + 1];

            Array.Resize(ref arr[i], arr[i].Length - 1);
        }
    }

}