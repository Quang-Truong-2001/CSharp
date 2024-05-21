using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal abstract class Vit
    {
        public Vit()
        {
            Console.WriteLine("Vịt chạy");
        }

        public int Id {  get; set; }
        public string Name { get; set; }
        public IDiChuyen DiChuyen { get; set; }

        public void InThongTin()
        {
            Console.WriteLine($"Ten nguoi choi {Name} so {Id}");
        }
    }
}
