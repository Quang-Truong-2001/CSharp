using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "ab cd";
            char[] chars = a.ToCharArray();
            string result = "";

            foreach (char c in chars)
            {
                result += c;
                Console.WriteLine(c);
            }
            Console.WriteLine(result);


            string[] strings = result.Split(' ');
            foreach (string s in strings) {
                Console.WriteLine(s);
            }



            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            sb.Append("em");
            string d=sb.ToString();


            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
