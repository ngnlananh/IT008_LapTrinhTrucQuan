using System;

class Program
{
    static void Main()
    {
        //Nhập n và m
        Console.Write("Nhap n (n > 0):");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap m (m > 0):");
        int m = int.Parse(Console.ReadLine());

        //Tạo ma trận ngẫu nhiên
        int[][] arr = new int[n][];
        TaoMaTran_NgauNhien(ref arr, n, m);

        int choice;
        do
        {
            //In menu 
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
        Console.WriteLine("Ma tran:");
        foreach (var row in arr)
        {
            foreach (var item in row)
                Console.Write(item + " ");
            Console.WriteLine();
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
    //Đếm số lượng số không phải số nguyên tố
    static int NumOfNonPrime(int[][] arr)
    {
        int count = 0;
        foreach (var row in arr)
        {
            foreach (var item in row)
            {
                if (!Check_SNT(item))
                    count++;
            }
        }
        return count;
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
        int maxElement = Max_Element(arr);
        int colIndex = Array.IndexOf(arr[0], maxElement);
        if (colIndex == -1)
        {
            Console.WriteLine("Cot khong hop le.");
            return;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = colIndex; j < arr[i].Length - 1; j++)
            {
                arr[i][j] = arr[i][j + 1];
            }
            Array.Resize(ref arr[i], arr[i].Length - 1);
        }
    }
}