using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepoPelis.Model.Entities
{
    [Table("Genres")]

    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();

    }
}
