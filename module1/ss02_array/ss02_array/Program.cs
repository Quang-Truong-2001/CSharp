using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss02_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*string[] arr = { "a","b","c"};
            int[] arr2 = new int[5];
            int[] arr3 = new int[] {4,5,6,7,8,1};
            
            int min = arr3.Min();
            int max = arr3.Max();
            Console.WriteLine("So chiều "+arr3.Rank);
            Console.WriteLine("Tổng "+arr3.Sum());
            Array.Sort(arr3);
            foreach(int i in arr3)
            {
                Console.WriteLine(i);
            }
            */


            // Mang 2 chieu
            int[,] towDemensionalArrays = new int[2, 3] { { 1, 2, 3 }, { 3, 4, 5 } };

            int hang = towDemensionalArrays.Length;
            int cot = 3;
            for(int i = 0; i < hang; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    Console.WriteLine(towDemensionalArrays[i,j]);
                }
            }

            Console.ReadLine();
        }
    }
}
