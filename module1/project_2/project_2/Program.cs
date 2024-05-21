using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chiều dài");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng");
            int b= int.Parse(Console.ReadLine());
            Console.WriteLine("Dien tich la "+(a*b));
            Console.ReadLine();
        }
    }
}
