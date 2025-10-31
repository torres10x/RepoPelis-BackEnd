using System.ComponentModel.DataAnnotations;

namespace RepoPelis.Model.DTOs.Genre
{
    public class GenreCreateDto
    {
       [Required]
        public string Name { get; set; }
    
    }
}
