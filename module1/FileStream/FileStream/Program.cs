using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "data.dat";
            using 
            using var stream=new FileStream(path: filepath, FileMode.OpenOrCreate);
            //Product product = new Product();
            //product.Id = 1;
            //product.Name = "Test";
            //product.Price = 100;
       
           
        }
    }

    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public void Save(Stream stream)
        {
            var bytes_id=BitConverter.GetBytes(Id);
            stream.Write(bytes_id, 0, 4);

            var bytes_price=BitConverter.GetBytes(Price);
            stream.Write(bytes_price, 0, 8);

            var bytes_name=Encoding.UTF8.GetBytes(Name);
            var bytes_leng = BitConverter.GetBytes(bytes_name.Length);
            stream.Write(bytes_leng, 0, 4);
            stream.Write(bytes_name, 0, bytes_name.Length);


        }
        void Restore()
        {

        }
    }
}
