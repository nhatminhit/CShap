using System;
using System.Collections.Generic;
namespace Bai1_ThucHanh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Nguoi> arr = new List<Nguoi>();
            string luachon = "";
            Console.Write("Nhap vao 1 de nhap thong tin nguoi, nhap 2 de nhap thong tin sinh vien, nhap ky tu khac de ket thuc chuong trinh: ");
            luachon = Console.ReadLine();
            while (luachon == "1" || luachon == "2")
            {
                if (luachon == "1")
                {
                    Console.Write("Ho ten: ");
                    string HoTen = Console.ReadLine();
                    Console.Write("Gioi tinh: ");
                    string GioiTinh = Console.ReadLine();
                    Console.Write("Nam sinh: ");
                    int NamSinh = int.Parse(Console.ReadLine());
                    Console.Write("Dia Chi: ");
                    string DC = Console.ReadLine();
                    Nguoi a = new Nguoi(HoTen, GioiTinh, NamSinh, DC);
                    arr.Add(a);

                }
                else
                {
                    Console.Write("Ho ten: ");
                    string HoTen = Console.ReadLine();
                    Console.Write("Gioi tinh: ");
                    string GioiTinh = Console.ReadLine();
                    Console.Write("Nam sinh: ");
                    int NamSinh = int.Parse(Console.ReadLine());
                    Console.Write("Dia Chi: ");
                    string DC = Console.ReadLine();
                    Console.Write("Diem Thuong Xuyen: ");
                    double TX = double.Parse(Console.ReadLine());
                    Console.Write("Diem Thi: ");
                    double DT = double.Parse(Console.ReadLine());
                    SINHVIEN y = new SINHVIEN(HoTen, GioiTinh, NamSinh, DC, TX, DT);
                    arr.Add(y);
                }
                Console.Write("Nhap vao 1 de nhap thong tin nguoi, nhap 2 de nhap thong tin sinh vien, nhap ky tu khac de hien thi danh sach: ");
                luachon = Console.ReadLine();
            }
            foreach (Nguoi item in arr)
            {
                item.Output();
                Console.WriteLine();
            }
        }
    }
}

