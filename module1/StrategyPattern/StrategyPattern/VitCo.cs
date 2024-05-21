using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class VitCo : Vit
    {
        public VitCo()
        {
            DiChuyen = new KieuVitCo();
        }
    }
}
