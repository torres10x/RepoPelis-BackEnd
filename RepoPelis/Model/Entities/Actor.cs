using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RepoPelis.Model.Entities
{
    [Table("Actors")]
    public class Actor
    {
            [Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(100)]
            public string FullName { get; set; }

            [Url]
            public string PictureUrl { get; set; }

            public ICollection<MovieActor> MovieActors { get; set; } = new List<MovieActor>();

        
    }
 }
