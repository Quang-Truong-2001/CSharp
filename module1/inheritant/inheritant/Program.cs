using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace inheritant
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Animal
    {
        public virtual void Sound()
        {

        }
    }
    public class Dog:Animal
    {
        public override void Sound()
        {

        }
    }
    public class Cat : Dog
    {
        public override void Sound()
        {

        }
    }
}
