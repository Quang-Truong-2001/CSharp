using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ss02.Models
{
    [Table("PostCategory")]
    public class PostCategory
    {
        [Key]
        public int Id { get; set; }

        public int PostID { set; get; }

        public int CategoryID { set; get; }


        [ForeignKey("Id")]
        public Post Post { set; get; }

        [ForeignKey("Id")]
        public Category Category { set; get; }
    }
}
