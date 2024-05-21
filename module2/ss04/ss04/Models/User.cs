using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ss04.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
   
    }
}
