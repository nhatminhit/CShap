using System;

namespace CANBACHAI
{
    class TG
    {
        public double e;
        public double ham (int x)
        {
            double result = 1.0;
            
            while (Math.Abs((result * result - x)) / x >= e)
            {
                result = (x/ result - result) / 2 + result;
                
            }
            

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            TG Temp = new TG();
            Console.WriteLine("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập e: ");
            Temp.e = double.Parse(Console.ReadLine());
            double r = Temp.ham(a);
            Console.WriteLine("Kết quả là:{0}", r);
        }
    }
}
