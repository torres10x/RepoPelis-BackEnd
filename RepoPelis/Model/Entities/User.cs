using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RepoPelis.Model.Entities
{

    [Table("Users")]
    public class User    {
        
        
            [Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(50)]
            public string UserName { get; set; }

            [Required]
            [EmailAddress]
            [MaxLength(100)]
            public string Email { get; set; }

            public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        

    }
}
