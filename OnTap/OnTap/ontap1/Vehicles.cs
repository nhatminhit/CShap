using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap1
{
    class Vehicles 
    {
        private string hsx { get; set; }
        private string color { get; set; }
        public Vehicles()
        {
            hsx = "DEFAULT_HSX";
            color = "DEFAULT_COLOR";
        }
        public Vehicles(string hsx)
        {
            this.hsx = hsx;
            color = "DEFAULT_COLOR";
        }
        public Vehicles(string hsx, string color)
        {
            this.hsx = hsx;
            this.color = color;
        }
        public virtual void Input()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập hãng sản xuất: ");
            hsx = Console.ReadLine();
            Console.Write("Nhập màu sắc: ");
            color = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return $"Hãng Sản Xuất: {hsx}" +
                $"\nMàu Sắc: {color}";
        }
    }
}
