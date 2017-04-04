using System.Collections.Generic;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Model;

namespace ProjectManhattan.Repository
{
    public interface IMoviePhotoRepository : IRepository<MoviePhoto, MoviePhotoDTO>
    {
        MoviePhotoDTO GetMoviePhoto(int id);

        List<MoviePhotoDTO> GetMoviePhotos(int movieId);

        List<MoviePhotoDTO> GetMoviePhotos();
    }

    public interface IMovieTrailerRepository : IRepository<MovieTrailer, MovieTrailerDTO>
    {
        MovieTrailerDTO GetMovieTrailer(int id);

        List<MovieTrailerDTO> GetMovieTrailers(int movieId);

        List<MovieTrailerDTO> GetMovieTrailers();
    }
}