using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vit vit = new VitCo();
            vit.Id = 1;
            vit.Name = "test";
            vit.DiChuyen.DiChuyen();
            vit.DiChuyen=new KieuThienNga();
            vit.DiChuyen.DiChuyen();
            vit.InThongTin();
            Console.ReadLine();
            

        }
    }
}
