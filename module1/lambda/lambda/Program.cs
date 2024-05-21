using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = () => { Console.WriteLine("hello"); };
            action?.Invoke();


            Func<int,int> func=x=> x*2;
            var a=func?.Invoke(2);
            Console.WriteLine(a);

            //int[] mang = { 3, 4, 5, 6, 7, 8, 9, 10 };
            //var kq = mang.Select(x => Math.Sqrt(x));
            //foreach(var x in kq) { Console.WriteLine(x); }
            Console.ReadLine();
        }
    }
}
