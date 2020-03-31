using System;
using System.Collections.Generic;
using System.Text;

namespace Automapper.Example.Model
{
    public class AddMovieRequest
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public string ArtistSurname { get; set; }

        public string MoviePremiere { get; set; }
    }
}
