using RepoPelis.Model.DTOs.Movie;

namespace RepoPelis.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieCatalogResponseDto>> GetMoviesCatalogWithMetadata();
        Task<MovieResponseDto> GetMovieWithMetadata(int movieId);
    }
}
