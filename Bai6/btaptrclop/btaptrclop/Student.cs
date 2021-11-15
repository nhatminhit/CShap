using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btaptrclop
{
    class Student : Person
    {
        public byte maths { get; set; }
        public byte physics { get; set; }

        public Student() : base()
        {
            maths = physics = 0;
        }

        public Student(string name, string address, byte maths, byte physics) : base(name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }

        public override void Input()
        {
            base.Input();
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập Điểm Toán: ");
            maths = byte.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Lý: ");
            physics = byte.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Điểm Toán: {maths}" +
                $"\nĐiểm Lý: {physics}" +
                $"\nTổng Điểm: {Total()}");
        }

        public byte Total()
        {
            return (byte)(maths + physics);
        }
    }
}
