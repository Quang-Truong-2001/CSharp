﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class ThienNga : Vit
    {
        public ThienNga()
        {
            DiChuyen = new KieuThienNga();
        }
    }
}
