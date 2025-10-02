using System;

public class Program
{
    public static void Nhap(out int[] arr, out int n)
    {
        Console.WriteLine("Nhap so luong phan tu cua mang");
        n = int.Parse(Console.ReadLine());
        arr = new int[n];
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = r.Next(0, 100);
        }
    }

    public static void Xuat(ref int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static int Tong_Le(int[] arr)
    {
        int result = 0;
        foreach (var item in arr)
        {
            if (item % 2 != 0)
                result += item;
        }
        return result;
    }

    public static bool Check_SNT(int x)
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

    public static int Dem_SNT(int[] arr)
    {
        int count = 0;
        foreach (var item in arr)
        {
            if (Check_SNT(item))
                count++;
        }
        return count;
    }

    public static bool Check_SCP(int x)
    {
        if (x < 0) return false;
        else
        {
            int _sqrt = (int)Math.Sqrt(x);
            if (_sqrt * _sqrt == x)
                return true;
        }
        return false;
    }

    public static int SCP_min(int[] arr)
    {
        int? min = null;
        foreach (var item in arr)
        {
            if (Check_SCP(item))
                if (min == null || item < min)
                    min = item;
        }
        return min ?? -1;
    }

    public static void Main()
    {
        int[] arr;
        int n;
        Nhap(out arr, out n);

        //MENU:
        int choice;
        do
        {
            Console.WriteLine("================= MENU ================");
            Console.WriteLine("1. In mang");
            Console.WriteLine("2. Tinh tong cac so le trong mang");
            Console.WriteLine("3. Dem so luong so nguyen to trong mang");
            Console.WriteLine("4. Tim so chinh phuong nho nhat trong mang");
            Console.WriteLine("0. Exit");
            Console.Write("Chon chuc nang: ");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case (0):
                    Console.WriteLine("===========THANKYOU!===========");
                    return;
                case (1):
                    Console.WriteLine("Mang vua nhap la: ");
                    Xuat(ref arr); break;
                case (2):
                    int sum_le = Tong_Le(arr);
                    if (sum_le != 0)
                        Console.WriteLine("Tong cac so le trong mang la: " + sum_le);
                    else
                        Console.WriteLine("Khong co so le trong mang");
                    break;
                case (3):
                    int count_SNT = Dem_SNT(arr);
                    if (count_SNT != 0)
                        Console.WriteLine("So luong so nguyen to trong mang: " + count_SNT);
                    else
                        Console.WriteLine("Khong co so nguyen to trong mang");
                    break;
                case (4):
                    int SCP = SCP_min(arr);
                    if (SCP != -1)
                        Console.WriteLine("So chinh phuong nho nhat trong mang: " + SCP);
                    else
                        Console.WriteLine("Khong co so chinh phuong trong mang");
                    break;
                default:
                    Console.WriteLine("Chuc nang khong hop le! Vui long chon lai");
                    continue;
            }
        } while (choice != 0);
    }
}