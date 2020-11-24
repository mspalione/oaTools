using OATools.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OATools.Helpers
{
    public static class SloganExtentions
    {
        public static Slogan RandomSlogan(this HtmlHelper helper, int index, List<Slogan> slogans)
        {
            slogans.RemoveAt(index);
            Random rnd = new Random();
            var newIndex = rnd.Next(slogans.Count);
            var currentSlogan = slogans[newIndex];

            return currentSlogan;
        }
    }
}