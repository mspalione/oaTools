using OATools.Models;
using System.Collections.Generic;

namespace OATools.ViewModel
{
    public class HomePageViewModel
    {
        public IEnumerable<FreePdfBookTitle> BookTitles { get; set; }
        public IEnumerable<FreePdfLink> PdfLinks { get; set; }
        public IEnumerable<Slogan> Slogans { get; set; }
        public IEnumerable<Step> Steps { get; set; }
        public IEnumerable<Tradition> Traditions { get; set; }
        public IEnumerable<Promise> Promises { get; set; }
        public IEnumerable<Principle> Principles { get; set; }
    }
}