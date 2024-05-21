using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var brands = new List<Brand>() {
                        new Brand{ID = 1, Name = "Công ty AAA"},
                        new Brand{ID = 2, Name = "Công ty BBB"},
                        new Brand{ID = 4, Name = "Công ty CCC"},
                   };

            var products = new List<Product>()
                {
                    new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                    new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                    new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                    new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                    new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                    new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                    new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
                };


            // Lấy sản phẩm có giá bằng 400 
            var query= from p in products where p.Price == 400 select p;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            var kq= products.Select(
                (p) =>
                {
                    return p.Name;
                }
                );
            foreach(var item in kq)
            {
                Console.WriteLine(item);
            }

            var result=products.Where(
                (p) =>
                {
                    return p.Name.Contains("tr");
                }
            );
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();

        }
    }
}
