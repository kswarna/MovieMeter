using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Model;

namespace ProjectManhattan.Repository
{
    public class MoviePhotoRepository : GenericRepository<MoviePhoto, MoviePhotoDTO>, IMoviePhotoRepository
    {
        public MoviePhotoDTO GetMoviePhoto(int id)
        {
            using (var dbContext = new ProjectManhattanEntities())
            {
                MoviePhoto moviePhoto = dbContext.MoviePhotoes
                    .Where(m => m.MoviePhotoId == id)
                    .Include(m => m.Movie)
                    .Include(m => m.MoviePhotoArtists)
                    .Include(m => m.MoviePhotoArtists.Select(mpa => mpa.Artist))
                    .FirstOrDefault();
                if (moviePhoto != null)
                {
                    var moviePhotoDTO = Mapper.Map<MoviePhotoDTO>(moviePhoto);
                    return moviePhotoDTO;
                }
                return null;
            }
        }

        public List<MoviePhotoDTO> GetMoviePhotos(int movieId)
        {
            List<MoviePhotoDTO> moviePhotoDtos;

            using (var dbContext = new ProjectManhattanEntities())
            {
                var moviePhotos = dbContext.MoviePhotoes
                    .Where(m => m.MovieId == movieId)
                    .Include(m => m.Movie)
                    .Include(m => m.MoviePhotoArtists)
                    .Include(m => m.MoviePhotoArtists.Select(mpa => mpa.Artist)).ToList();

                moviePhotoDtos = moviePhotos.Select(Mapper.Map<MoviePhotoDTO>).ToList();
            }

            return moviePhotoDtos;
        }

        public List<MoviePhotoDTO> GetMoviePhotos()
        {
            List<MoviePhotoDTO> moviePhotoDtos;

            using (var dbContext = new ProjectManhattanEntities())
            {
                var moviePhotos = dbContext.MoviePhotoes
                    .Take(100)
                    .Include(m => m.Movie)
                    .Include(m => m.MoviePhotoArtists)
                    .Include(m => m.MoviePhotoArtists.Select(mpa => mpa.Artist)).ToList();

                moviePhotoDtos = moviePhotos.Select(Mapper.Map<MoviePhotoDTO>).ToList();
            }

            return moviePhotoDtos;
        }
    }
}