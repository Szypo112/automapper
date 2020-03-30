using Automapper.Example.Model;
using Automapper.Example.Profiles;
using AutoMapper;
using System;

namespace Automapper.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MovieProfile()));

            var mapper = configuration.CreateMapper();

            var movie = new Movie() { ExternalId = new Guid(), Artist = "Art Artis", Title = "Title" };

            var movieDto = mapper.Map<MovieDto>(movie);

            var movieAgain = mapper.Map<Movie>(movieDto);

        }
    }
}
