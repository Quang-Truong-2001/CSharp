using ss04.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ss04.Dto
{
    public class BookDto
    {
  
        public int Id { get; set; }
        [Required(ErrorMessage = "Phải có tên bài viết")]
        //[StringLength(160, MinimumLength = 5, ErrorMessage = "{0} dài {1} đến {2}")]
        public string Name { get; set; }
        [Required]

        public double Price { get; set; }


        public double SalePrice { get; set; }
        //[RegularExpression(@"^[a-z0-9-]*$", ErrorMessage = "Chỉ dùng các ký tự [a-z0-9-]")]
        public string Intro { get; set; }

        public string Content { get; set; }
  
        public string Image { get; set; }

        public int Quantity { get; set; }

        public int IdAuthor { get; set; }

        public int IdCategory { get; set; }
        
     
    }
}
