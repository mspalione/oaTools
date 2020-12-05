using OATools.Models;
using System.Collections.Generic;

namespace OATools.ViewModel
{
    public class SlogansViewModel
    {
        public IEnumerable<Slogan> Slogans { get; set; }
        public Slogan Slogan { get; set; }
    }
}