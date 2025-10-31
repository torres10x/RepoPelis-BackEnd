using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RepoPelis.Model.Entities
{
    [Table("Ratings")]

    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Range(1, 10)]
        public int Score { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}