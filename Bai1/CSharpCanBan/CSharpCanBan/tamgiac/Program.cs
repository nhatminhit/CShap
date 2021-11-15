using System;

namespace tamgiac
{
    class TAMGIAC
    {
        public float a;
        public float b;
        public float c;
        public float CVI(float x, float y, float z)
        {
            float t;
            t = x + y + z;
            return t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float r = 0;
            double s = 0;
            TAMGIAC TG1 = new TAMGIAC();
            Console.WriteLine("nhap vao canh a");
            TG1.a = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao canh b");
            TG1.b = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao canh c");
            TG1.c = float.Parse(Console.ReadLine());

            r = TG1.CVI(TG1.a, TG1.b, TG1.c);
            float tg = r / 2;
            s = Math.Sqrt(tg * (tg - TG1.a) * (tg - TG1.b) * (tg - TG1.c));
            if(TG1.a >= TG1.b + TG1.c || TG1.b >= TG1.a + TG1.c || TG1.c >= TG1.a + TG1.b)
            {
                Console.WriteLine("khong phai tam giac");
            }
            else
            {
                Console.WriteLine("Chu vi cua tam giac la:{0}", r);
                Console.Write("Dien tich cua tam giac la:{0}", s);
            }
            Console.ReadLine();
        }
    }
}
