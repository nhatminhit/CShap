using System;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap vao so n su dung vong while: ");
                int n = 0;
                while (n < 1 || n > 100)
                {
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"in ra so n: {n}");
                Console.WriteLine("Nhap vao so n su dung vong do: ");
                n = 0;
                do
                {
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                } while (n < 1 || n > 100);
                Console.WriteLine($"in ra so n: {n}");
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

