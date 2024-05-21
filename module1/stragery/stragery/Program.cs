using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stragery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vit vit = new ThienNga();
            vit.Id= 1;
            vit.Name= "test";
            vit.DiChuyen.Chuyen();
            vit.GetInfor();
            vit.DiChuyen = new KieuVitCo();
            vit.GetInfor();
            vit.DiChuyen.Chuyen();
            Console.ReadLine();
        }
    }
}
