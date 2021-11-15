using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap1
{
    class Car:Vehicles
    {
        private string biensoxe { get; set; }
        private string dongxe { get; set; }
        private string phienban { get; set; }
        private double gia { get; set; }
        public double salary
        {
            get
            {
                if (phienban == "Standard")
                {
                    return gia + 0.0;
                }
                else if (phienban == "Premium")
                {
                    return gia + 2000.0;
                }
                else if (phienban == "Deluxe") 
                {
                    return gia + 5000.0;
                }
                else 
                {
                    return gia + 10000.0;
                }
            }
        }

        public Car() :base()
        {
            biensoxe = "DEFAULT_BIENSOXE";
            dongxe = "DEFAULT_DONGXE";
            phienban = "DEFAULT_PHIENBAN";
            gia = 0;
        }
        public Car(string hsx, string color, string biensoxe, string dongxe,string phienban, double gia) : base(hsx,color)
        {
            this.biensoxe = biensoxe;
            this.dongxe = dongxe;
            this.phienban = phienban;
            this.gia = gia;
        }
        public override void Input()
        {
            base.Input();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập biển số xe: ");
            biensoxe = Console.ReadLine();
            Console.Write("Nhập dòng xe: ");
            dongxe = Console.ReadLine();
            Console.Write("Nhập phiên bản: ");
            phienban = Console.ReadLine();
            Console.Write("Nhập giá: ");
            gia = double.Parse(Console.ReadLine());
        }
        
    }
}
