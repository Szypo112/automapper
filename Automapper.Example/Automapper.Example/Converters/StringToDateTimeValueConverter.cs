using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automapper.Example.Converters
{
    class StringToDateTimeValueConverter : IValueConverter<string, DateTime>
    {
        public DateTime Convert(string sourceMember, ResolutionContext context)
        {
            return DateTime.ParseExact(sourceMember, "dd, MM,;; yyyy", null);
        }
    }
}
