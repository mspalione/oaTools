using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OATools.Models;

namespace OATools.ViewModel
{
    public class HomePageViewModel
    {
        public IEnumerable<FreePdfBookTitle> BookTitles { get; set; }
        public IEnumerable<FreePdfLink> PdfLinks { get; set; }
    }
}