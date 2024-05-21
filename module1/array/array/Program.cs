using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3, 4 }, { 1, 2, 3, 7 } };
            int hang = 2;
            int cot = 4;
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
            Console.WriteLine(array[1, 3]);
            Console.ReadLine();
        }
    }
}
