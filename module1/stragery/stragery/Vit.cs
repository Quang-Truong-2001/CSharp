using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stragery
{
    internal abstract class Vit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IDiChuyen DiChuyen { get; set; }
        public void GetInfor()
        {
            Console.WriteLine($"Vi tri nguoi choi {Id} ten nguoi choi {Name}");
        }
    }
}
