using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Model;

namespace ProjectManhattan.Repository
{
    public static class MapperConfig
    {
        public static void InitializeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ArtistType, ArtistTypeDTO>();
                cfg.CreateMap<ArtistTypeDTO, ArtistType>();

                cfg.CreateMap<Artist, ArtistDTO>();
                cfg.CreateMap<ArtistDTO, Artist>();
                cfg.CreateMap<Movie, MovieDTO>();
                cfg.CreateMap<MovieDTO, Movie>();
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User,UserDTO>();
                cfg.CreateMap<CriticMovieRating, CriticRatingDTO>()
                    .ForMember(dest => dest.SiteName, opt => opt.MapFrom(src => src.Critic.SiteName))
                    .ForMember(dest => dest.WebUrl, opt => opt.MapFrom(src => src.Critic.WebUrl));
                cfg.CreateMap<UserMovieRatingtDTO, UserMovieRating>();
                cfg.CreateMap<UserMovieRating, UserMovieRatingtDTO>();
                cfg.CreateMap<Distributor, DistributorDTO>();
                cfg.CreateMap<DistributorDTO, Distributor>();

                cfg.CreateMap<Movie, MovieDetailDTO>()
                    .ForMember(dst => dst.Movie, opt => opt.MapFrom(src => src))
                    .ForMember(dst => dst.Artist, opt => opt.MapFrom(src => src.MovieArtists.Select(ma => ma.Artist)))
                    .ForMember(dst => dst.CriticRatings, opt => opt.MapFrom(src => src.CriticMovieRatings))
                    .ForMember(dst => dst.UserRatings, opt => opt.MapFrom(src => src.UserMovieRatings))
                    .ForMember(dst => dst.Distributors,
                        opt => opt.MapFrom(src => src.MovieDistributors.Select(m => m.Distributor)));

                cfg.CreateMap<Movie, MovieSummaryDTO>()
                    .ForMember(dst => dst.Artist, opt => opt.MapFrom(src => src.MovieArtists.Select(ma => ma.Artist)))
                    .ForMember(dst => dst.CriticRating,
                        opt => opt.MapFrom(src => src.CriticMovieRatings.Average(c => c.Rating)))
                    .ForMember(dst => dst.UserRating, 
                        opt => opt.MapFrom(src => src.UserMovieRatings.Average(c => c.Rating)));

                cfg.CreateMap<MoviePhotoArtist, MoviePhotoArtistDTO>();
                cfg.CreateMap<MoviePhotoArtistDTO, MoviePhotoArtist>();

                cfg.CreateMap<MoviePhoto, MoviePhotoDTO>()
                    .ForMember(dst => dst.MoviePhotoArtists, opt => opt.MapFrom(src => src.MoviePhotoArtists));

                cfg.CreateMap<MovieTrailer, MovieTrailerDTO>();
                cfg.CreateMap<MovieTrailerDTO, MovieTrailer>();
            });
        }
    }
}
