using System;
using System.Collections.Generic;
namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<float> DanhSach = new List<float>();
                int i = 0;
                while (i < 5)
                {
                    Console.Write($"\tPhan tu {i + 1} = ");
                    DanhSach.Add(float.Parse(Console.ReadLine()));
                    i++;
                }
                DanhSach.Sort();
                Console.Write($"Hien thi danh sach sau khi sap xep: ");
                hienThi(DanhSach);
                var searchAll = DanhSach.FindAll((e) =>
                {
                    return e < 0;
                });
                if (searchAll.Count == 0) Console.WriteLine("Danh sach khong co so am");
                else
                {
                    for (i = 0; i < searchAll.Count; i++)
                    {
                        DanhSach.Remove(searchAll[i]);
                    }
                    Console.Write($"Hien thi danh sach sau khi xoa so am: ");
                    hienThi(DanhSach);
                }
                Console.Write("Nhap vao so x: ");
                float x = float.Parse(Console.ReadLine());
                DanhSach.Add(x);
                //Nếu muốn x sắp xếp theo thứ tự từ nhỏ đến lớn thì chạy lệnh bên dưới
                //DanhSach.Sort();
                Console.Write($"Hien thi danh sach sau khi them so {x}: ");
                hienThi(DanhSach);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ky tu vua nhap vao khong phai la so nguyen, chuong trinh dung tai day, tam biet va hen gap lai!!!");
                Console.ResetColor();
                return;
            }
        }
        static void hienThi(List<float> a)
        {
            foreach (var i in a)
            {
                Console.Write($"\t{i}");
            }
            Console.WriteLine();
        }
    }
}
