using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSUNG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HocSinh> list = new List<HocSinh>();
            Console.WriteLine("Nhap thong tin cua 10 sinh vien: ");
            for (int i = 0; i < 10; i++)
            {
                HocSinh a = new HocSinh();
                a.nhap();
                list.Add(a);
            };
            foreach (HocSinh hs in list)
            {
                hs.XuatHocSinhin();
            }
            // sap xep theo ho ten
            var newList = list.OrderBy(x => x.hoTen);
            foreach (HocSinh hs in newList)
            {
                hs.XuatHocSinhout();
            }


        }

        class HocSinh
        {
            int maHS;
            public string hoTen;
            string ngaySinh;
            string gender;

            public void nhap()
            {
                Console.WriteLine("Nhap ma hoc sinh: ");
                maHS = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ho ten sinh: ");
                hoTen = Console.ReadLine();
                Console.WriteLine("Nhap ngay sinh: ");
                ngaySinh = Console.ReadLine();
                Console.WriteLine("Nhap gioi tinh: ");
                gender = Console.ReadLine();
            }
            public void XuatHocSinhin()
            {
                Console.WriteLine("In hoc sinh");
                Console.WriteLine("Ho ten: {0} Ma SV: {1} Ngay sinh:{2} Gioi Tinh: {3} ", hoTen, maHS, ngaySinh, gender);
            }
            public void XuatHocSinhout()
            {
                Console.WriteLine("Sap xep hoc sinh");
                Console.WriteLine("Ho ten: {0} Ma SV: {1} Ngay sinh:{2} Gioi Tinh: {3} ", hoTen, maHS, ngaySinh, gender);
            }
        }
    }
}
