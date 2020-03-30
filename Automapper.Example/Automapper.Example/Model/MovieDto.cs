using System;
using System.Collections.Generic;
using System.Text;

namespace Automapper.Example.Model
{
    public class MovieDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
    }
}
