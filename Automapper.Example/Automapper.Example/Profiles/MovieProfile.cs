using Automapper.Example.Converters;
using Automapper.Example.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automapper.Example.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            //CreateMap<string, DateTime>().ConvertUsing<StringToDateTimeConverter>();
            CreateMap<Movie, MovieDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ExternalId))
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.ExternalId, opt => opt.MapFrom(src => src.Id));

            CreateMap<AddMovieRequest, Movie>()
                .ForMember(dst => dst.MoviePremiere,
                opt => opt.ConvertUsing(new StringToDateTimeValueConverter(), src=> src.MoviePremiere));

            CreateMap<AddMovieRequestTwo, Movie>();
        }
    }
}
