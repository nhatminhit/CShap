using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap vao so phan tu cua day: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"\ta[{i + 1}] = ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Tach day con gom cac so chan: ");
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.Write($"\t{arr[i]}");
                    }
                }
                Console.Write("\nTach day con gom cac so le: ");
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        Console.Write($"\t{arr[i]}");
                    }
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
