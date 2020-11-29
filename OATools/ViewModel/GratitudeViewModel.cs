using OATools.Models;
using System.Collections.Generic;

namespace OATools.ViewModel
{
    public class GratitudeViewModel
    {
        public Gratitude Gratitude { get; set; }
        public IEnumerable<Gratitude> Gratitudes { get; set; }
    }
}