using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethod
{
    public static class MyExtension
    {
        public static int BinhPhuong(this int a)
        {
            return a*a;
        }

        public static bool CoChiaHetCho2Khong(this int a)
        {
            if(a%2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
