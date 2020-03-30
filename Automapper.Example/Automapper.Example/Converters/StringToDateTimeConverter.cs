using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automapper.Example.Converters
{
    public class StringToDateTimeConverter : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            return DateTime.ParseExact(source, "dd, MM,;; yyyy", null);
        }
    }
}
