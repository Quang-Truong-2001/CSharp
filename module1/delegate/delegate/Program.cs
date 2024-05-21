using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    internal class Program
    {
        public delegate void ShowInfor(string message);
        static void Main(string[] args)
        {
            ShowInfor infor=null;
            infor += ShowBlue;
            infor += ShowGreen;
            infor?.Invoke("hello");


            Action<string> delegateVoid = null;
            delegateVoid += ShowHello;
            delegateVoid += ShowGoodbyte;
            delegateVoid?.Invoke("hello");

            Func<int, int, int> tinhToan;
            tinhToan = null;
            tinhToan += Tong;
            tinhToan += Hieu;
            Console.WriteLine(tinhToan?.Invoke(4, 5));;




            Console.ReadKey();

        }
        public static void ShowBlue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ShowGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ShowHello(string message)
        {
            Console.WriteLine(message);
        }
        public static void ShowGoodbyte(string message)
        {
            Console.WriteLine("Goodbyte");
        }
        public static int Tong(int a, int b)
        {
            return a + b;
        }
        public static int Hieu(int a, int b)
        {
            return a -  b;
        }

    }
}
