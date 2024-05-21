using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ss04.Models
{
    [Table("authors")]
    public class Author
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        //Collect Navigation
        //public virtual List<Book> Books { get; set; }

    }
}
