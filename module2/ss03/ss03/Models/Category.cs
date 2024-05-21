using System.ComponentModel.DataAnnotations;

namespace ss03.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Blog> Blogs { get; set;}
    }
}
