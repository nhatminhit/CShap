using System;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap vao kich thuoc cua mang: ");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"a[{i}] = ");
                    a[i] = int.Parse(Console.ReadLine());
                }
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (a[i] % 2 != 0) sum += a[i];
                }
                Console.WriteLine($"Tong so le cua mang la {sum}");
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ky tu vua nhap vao khong phai la so nguyen, chuong trinh dung tai day, tam biet va hen gap lai!!!");
                Console.ResetColor();
                return;
            }
        }
    }
}

