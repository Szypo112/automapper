using System;
using System.Collections.Generic;
using System.Text;

namespace Automapper.Example.Model
{
    public class Movie
    {
        public string Id { get; set; }
        public Guid ExternalId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
    }
}
