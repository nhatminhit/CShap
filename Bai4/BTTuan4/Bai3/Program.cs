using System;
using System.Text;
namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Student student = new Student("SV01", "Minh", 10);

            Console.WriteLine(student);
        }
    }
}
