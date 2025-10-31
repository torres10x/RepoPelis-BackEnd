using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepoPelis.Model.Entities
{
    [Table("Movies")]

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Url]
        public string PictureUrl { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; } 

        public ICollection<MovieGenre> MovieGenres { get; set; } 

        public ICollection<Rating> Ratings { get; set; } 

    }
}
