using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            IList<string> list = new List<string>();
            list.Add("hello1");
            list.Add("hello2");
            list.Add("hello3");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            IDictionary<int, string> dictionary = new Dictionary<int, string>();

            Console.ReadLine();
        }
    }
}
