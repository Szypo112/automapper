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

            var addMovieRequest = new AddMovieRequest() { Title = "title", Artist = "ABCD", MoviePremiere = "10, 12,;; 2020" };
            var movie = mapper.Map<Movie>(addMovieRequest);

        }
    }
}
