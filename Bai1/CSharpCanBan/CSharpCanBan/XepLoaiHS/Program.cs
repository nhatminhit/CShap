using System;
using System.Text;
namespace XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string hoten;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập họ tên sinh viên: ");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhập điểm: ");
            double diem = double.Parse(Console.ReadLine());
            Console.WriteLine("Họ tên sinh viên là: {0}", hoten.ToUpper());
            if(diem<5)
            {
                Console.WriteLine("Điểm: {0}, học lực: yếu", diem);
            }
            else if (diem >= 5 && diem < 6.5)
            {
                Console.WriteLine("Điểm: {0}, học lực: trung bình", diem);
            }
            else if (diem >= 6.5 && diem < 8)
            {
                Console.WriteLine("Điểm: {0}, học lực: khá", diem);
            }
            else
            {
                Console.WriteLine("Điểm: {0}, học lực: giỏi", diem);
            }
        }
    }
}
