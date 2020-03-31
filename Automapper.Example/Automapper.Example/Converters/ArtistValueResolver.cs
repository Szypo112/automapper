using Automapper.Example.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automapper.Example.Converters
{
    public class ArtistValueResolver : IValueResolver<AddMovieRequest, Movie, string>
    {
        public string Resolve(AddMovieRequest source, Movie destination, string destMember, ResolutionContext context)
        {
            return source.ArtistName + " " + source.ArtistSurname;
        }
    }
}
