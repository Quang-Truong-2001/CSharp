using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class KieuThienNga : IDiChuyen
    {

        public void DiChuyen()
        {
            Console.WriteLine("Thien Nga bay");
        }
    }
}
