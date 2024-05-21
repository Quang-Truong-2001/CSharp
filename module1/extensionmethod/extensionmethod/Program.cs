using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using extensionmethod;
namespace extensionmethod
{
    public static class Abc
    {
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            s.Print(ConsoleColor.Red);
            Console.WriteLine(5.BinhPhuong());
            bool iss = 6.CoChiaHetCho2Khong();
            if ( iss )
            {
                Console.WriteLine("Có");
            }  
            else
            {
                Console.WriteLine("Không");
            }
            Console.ReadLine();


        }
    }
}
