using System;
using System.Collections.Generic;
using System.Text;

namespace Automapper.Example.Model
{
    public class AddMovieRequest
    {
        public string Title { get; set; }
        public string Artist { get; set; }

        public string MoviePremiere { get; set; }
    }
}
