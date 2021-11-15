using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace De4_Minh_026_C2_C2
{
    class Program
    {
        public static List<NhanVien> ds = new List<NhanVien>();
        public static bool FindID(string id)
        {
            bool test = false;
            foreach (var nv in ds)
            {
                if (nv.HoTen == id)
                {
                    test = true;
                }
            }
            return test;
        }
        public static void nhap()
        {
            int choose;
            Console.WriteLine("1. Nhan Vien");
            Console.WriteLine("2. Nhan Vien Ban Hang");
            do
            {
                Console.Write("Chon: ");
                choose = int.Parse(Console.ReadLine());
            } while (choose > 2 && choose < 1);
            if (choose == 1)
            {

                Console.Write("Nhap ho ten");
                string HoTen = Console.ReadLine();
                Console.Write("Nhap ngay tuyen dung: ");
                DateTime NgayTuyen = DateTime.Parse(Console.ReadLine());
                if (FindID(HoTen) == false)
                {
                    NhanVien a = new NhanVien(HoTen, NgayTuyen);
                    ds.Add(a);
                }
                else
                    Console.WriteLine("Khong duoc trung ten ");
            }
            else
            {
                Console.Write("Nhap ho ten");
                string HoTen = Console.ReadLine();
                Console.Write("Nhap ngay tuyen dung: ");
                DateTime NgayTuyen = DateTime.Parse(Console.ReadLine());
                Console.Write("Nhap SL ban: ");
                int SLB = int.Parse(Console.ReadLine());
                if (FindID(HoTen) == false)
                {
                    NhanVienBanHang b = new NhanVienBanHang(HoTen, NgayTuyen,SLB );
                    ds.Add(b);
                }
                else
                    Console.WriteLine("Khong duoc trung ten ");
            }

        }
        public static void xuat()
        {
            Console.WriteLine("Ho Ten\tNgay Tuyen\tSL Ban\tTien Hoa Hong");
            foreach (var item in ds)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int chon;
            do
            {
                Console.WriteLine("============================================================");
                Console.WriteLine("============================Menu============================");
                Console.WriteLine("============================================================");
                Console.WriteLine("=1. Nhập Thông Tin                                         =");
                Console.WriteLine("=2. Hiển Thị Danh Sách                                     =");
                Console.WriteLine("=3. Sắp Xếp                                                =");
                Console.WriteLine("=4. Kết Thúc                                               =");
                Console.WriteLine("============================================================");
                do
                {
                    Console.Write("Nhap lua chon: ");
                    chon = int.Parse(Console.ReadLine());
                } while (chon > 4 && chon < 1);
                switch (chon)
                {
                    case 1:
                        {
                            nhap();
                            break;
                        }
                    case 2:
                        {
                            xuat();
                            break;
                        }
                    case 3:
                        break;
                    case 4:
                        break;
                }
            } while (true);
        }
    }
}

