using System.Collections.Generic;
using System.Web.Http;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Repository;

namespace ProjectManhattan.Controllers.AppController
{
    public class GalleryController : ApiController
    {
        private readonly IMoviePhotoRepository _moviePhotoRepository = new MoviePhotoRepository();
        //// GET: api/Gallery
        //public IEnumerable<MoviePhotoDTO> Get()
        //{
        //    return _moviePhotoRepository.GetAllEntities();
        //}

        ///// <summary>
        ///// Gets the Movie Photo with Artist Information
        ///// </summary>
        ///// <param name="moviePhotoId"></param>
        ///// <returns></returns>
        //public MoviePhotoDTO GetGallery(int id)
        //{
        //    return _moviePhotoRepository.GetMoviePhoto(id);
        //}

        /// <summary>
        /// Gets the Movie Photo's with the Movie Id
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public List<MoviePhotoDTO> GetGalleries(int movieId)
        {
            return _moviePhotoRepository.GetMoviePhotos(movieId);
        } 
        
        
    }
}
