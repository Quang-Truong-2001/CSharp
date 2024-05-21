using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string name="hh";
            int age = 10;
            try
            {
                checkEmpty(name,age);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(AgeException e)
            {
                Console.WriteLine(e.Message);
                e.Detail();

            }
            
            Console.ReadLine();
        }
        private static void checkEmpty(string name, int age)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new CustomException();
            }
            if (age<18||age>100)
            {
                throw new AgeException(age);

            }
            else
            {
                Console.WriteLine("Chinh xac");
            }
        }
    }
}
