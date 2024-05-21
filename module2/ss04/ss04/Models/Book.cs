using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ss04.Models
{
    [Table("books")]
    public class Book
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("sale_price")]
        public double SalePrice { get; set; }
        [Column("intro")]
        public string Intro { get; set;}
        [Column("content")]
        public string Content { get; set;}
        [Column("image")]
        public string Image { get; set;}
        [Column("quantity")]
        public int Quantity {  get; set; }
        [Column("author_id")]
        public int IdAuthor { get; set; }
        [ForeignKey("IdAuthor")]
        public Author Author { get; set;}

        [Column("category_id")]
        public int IdCategory {  get; set; }
        [ForeignKey("IdCategory")]
        public Category Category { get; set; }
        public bool IsDeleted { get; set; } = false;


    }
}
