using System.ComponentModel.DataAnnotations;

namespace RepoPelis.Model.DTOs.Genre
{
    public class GenreUpdateDto
        
    {
        [Required] 
        public int  Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
