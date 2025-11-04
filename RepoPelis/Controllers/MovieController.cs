using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepoPelis.Interfaces;

namespace RepoPelis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("catalog")]
        public async Task<IActionResult> GetMovieCatalog()
        {
            var result = await _movieService.GetMoviesCatalogWithMetadata();

            return Ok(result);
                
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieData(int id)
        {
            var result = await _movieService.GetMovieWithMetadata(id);

            if (result == null)
            {
                return NotFound();
                  }
            return Ok(result);

        }

    }
}
