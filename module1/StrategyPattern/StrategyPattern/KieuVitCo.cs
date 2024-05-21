using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class KieuVitCo : IDiChuyen
    {
        public void DiChuyen()
        {
            Console.WriteLine("Vit co chay");
        }
    }
}
