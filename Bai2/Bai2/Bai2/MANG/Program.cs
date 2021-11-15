using System;

namespace MANG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập số lượng phần tử mảng: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n>0)
            {
                int[] number = new int[n];
                for(int i=0;i<n;i++)
                {
                    Console.WriteLine("Nhập phần tử thứ: "+ (i+1));
                    number[i] = Convert.ToInt32(Console.ReadLine());
                }
                int max = number[0];
                int min = number[0];
                for (int i = 1; i < n; i++)
                {
                    if (max < number[i])
                    {
                        max = number[i];
                    }
                    if (min > number[i])
                    {
                        min = number[i];
                    }
                }
                Console.WriteLine("Gia trị lớn nhất trong mảng: " + max);
                Console.WriteLine("Gia tri nhỏ nhất trong mảng: " + min);
            }
            else
            {
                Console.WriteLine("Nhập số nguyên n>0");
            }    
        }
    }
}
