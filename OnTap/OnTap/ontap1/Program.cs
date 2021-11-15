using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace ontap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            List<Vehicles> vehicleList = new List<Vehicles>();

            int choose = 5;

            while (true)
            {
                try
                {
                    Console.WriteLine("============================================================");
                    Console.WriteLine("=====================QUẢN LÝ VẬN TẢI========================");
                    Console.WriteLine("============================================================");
                    Console.WriteLine("=1. Thêm Ô Tô                                              =");
                    Console.WriteLine("=2. Hiển Thị Danh Sách                                     =");
                    Console.WriteLine("=3. Sắp Xếp Theo Giá                                       =");
                    Console.WriteLine("=4. Kết Thúc                                               =");
                    Console.WriteLine("============================================================");
                    Console.Write("Mời bạn nhập lựa chọn: ");
                    choose = int.Parse(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(ThemCar(ref vehicleList));
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine(HienThiDanhSach(vehicleList));
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(SapXepTheoPrice(vehicleList));
                            break;
                        case 4:
                            Console.Clear();
                            int choose2 = 2;
                            Console.WriteLine("Bạn Muốn Thoát Chương Trình?");
                            Console.WriteLine("1. Có");
                            Console.WriteLine("2. Không");
                            choose2 = int.Parse(Console.ReadLine());

                            if (choose2 == 1)
                            {
                                break;
                            }
                            else if (choose2 == 2)
                            {
                                choose = 5;
                            }
                            else
                            {
                                throw new Exception("Lựa chọn không hợp lệ!!!");
                            }
                            break;
                        default:
                            break;
                    }

                    if (choose == 4)
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bạn phải nhập theo định dạng số!!!");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    continue;
                }
            }
        }
        //1. Thêm Car
        private static string ThemCar(ref List<Vehicles> vehicleList)
        {
            Console.WriteLine("Nhập thông tin car: ");
            Vehicles car = new Vehicles();
            car.Input();

            int choose1 = 2;
            Console.WriteLine("Bạn muốn thêm sinh viên này không?");
            Console.WriteLine("1. Có");
            Console.WriteLine("2. Không");
            choose1 = int.Parse(Console.ReadLine());

            if (choose1 == 1)
            {
                vehicleList.Add(car);
                return "Thêm mới thành công".ToUpper();
            }
            else if (choose1 == 2)
            {
                return "Thêm mới không thành công".ToUpper();
            }
            else
            {
                throw new Exception("Lựa chọn không hợp lệ!!!");
            }
        }
        //2.Hien Thi Danh Sach
        public static string HienThiDanhSach(List<Vehicles> vehicleList)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (vehicleList.Count == 0)
            {
                return "Danh sách này trống".ToUpper();
            }

            int i = 1;

            foreach (var item in vehicleList)
            {
                Console.WriteLine($"Thông tin xe thứ {i++}: ");
                item.Output();
            }

            return "Đã hiển thị tất cả xe".ToUpper();
        }
        //3.Sắp xếp theo giá
        public static string SapXepTheoPrice(List<Vehicles> vehicleList)
        {
            if (vehicleList.Count == 0)
            {
                return "Danh sách này trống".ToUpper();
            }

            var query = vehicleList.Sort(new SortVehiclesBygia());

            Console.WriteLine("Danh sách sau khi sắp xếp: ");

            int i = 1;

            foreach (var item in query)
            {
                Console.WriteLine($"Thông tin xe thứ {i++}: ");
                item.Output();
            }

            return "Sắp xếp thành công".ToUpper();
        }
    }
}
