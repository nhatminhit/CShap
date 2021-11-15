using System;

namespace TONGCHUOI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int tong1 = 0;
            double tong2 = 0;
            for(int i=1;i<=n;i++)
            {
                tong1 += i;
            }
            for(int i=1;i<=n;i++)
            {
                tong2 += 1.0/i;
            }
            Console.WriteLine("S=1+2+3+...+n : {0}", tong1);
            Console.WriteLine("S=1+1/2+1/3+...+1/n : {0}", tong2);
        }
    }
}
