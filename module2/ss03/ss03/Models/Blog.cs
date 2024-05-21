using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ss03.Models
{
    public class Blog
    {
        [Key]
        public int Id {  get; set; }
        public string Tittle { get; set; }
        public string Decription { get; set; }
        public int IdCategory {  get; set; }
        [ForeignKey("IdCategory")]
        public virtual Category Category { get; set; }

    }
}
