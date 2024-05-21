using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MAIN
    {
        static void Main(string[] args)
        {
            string path = "data.dat";
            using var stream=new FileStream(path: path,mode: FileMode.OpenOrCreate);



            Console.ReadLine();

        }
    }
}
