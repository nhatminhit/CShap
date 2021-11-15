using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace btap
{
    class Program
    {
        public static List<KhachHang> ds = new List<KhachHang>();
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
            Console.WriteLine("1. Khach Hang");
            Console.WriteLine("2. Khach Hang than thiet");
            do
            {
                Console.Write("Chon: ");
                choose = int.Parse(Console.ReadLine());
            } while (choose > 2 && choose < 1);
            if (choose == 1)
            {

                Console.Write("Nhap ho ten");
                string hoten = Console.ReadLine();
                Console.Write("Nhap gioi tinh (bool): ");
                bool gioitinh = Convert.ToBoolean(Console.ReadLine());
                Console.Write("Nhap SL mua: ");
                int sl = int.Parse(Console.ReadLine());
                Console.Write("Nhap don gia: ");
                double dongia = double.Parse(Console.ReadLine());
                if (FindID(hoten) == false)
                {
                    KhachHang a = new KhachHang(hoten, gioitinh, sl, dongia);
                    ds.Add(a);
                }
                else
                    Console.WriteLine("Khong duoc trung ten khach hang");
            }
            else
            {
                Console.Write("Nhap ho ten");
                string hoten = Console.ReadLine();
                Console.Write("Nhap gioi tinh (bool): ");
                bool gioitinh = Convert.ToBoolean(Console.ReadLine());
                Console.Write("Nhap SL mua: ");
                int sl = int.Parse(Console.ReadLine());
                Console.Write("Nhap don gia: ");
                double dongia = double.Parse(Console.ReadLine());
                if (FindID(hoten) == false)
                {
                    KhachHangThanThiet b = new KhachHangThanThiet(hoten, gioitinh, sl, dongia);
                    ds.Add(b);
                }
                else
                    Console.WriteLine("Khong duoc trung ten khach hang");
            }

        }
        public static void xuat()
        {
            Console.WriteLine("Ho Ten\tGioi Tinh\tSL Mua\tDon Gia\tTong Tien\t Qua Tang");
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
                        {
                            var li = ds.OrderBy(P => P.SLMua);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;
                        }
                    case 4:
                        break;
                }
            } while (true);
        }
    }
}


