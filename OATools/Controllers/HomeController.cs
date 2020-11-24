using OATools.Models;
using OATools.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OATools.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {

            var model = new HomePageViewModel
            {
                BookTitles = _context.FreePdfBookTitles.ToList(),
                PdfLinks = _context.FreePdfLinks.ToList(),
                Slogans = _context.Slogans.ToList()
            };

            return View(model);
        }

        public ActionResult RenderRandomSlogan(List<Slogan> slogans, int currentSloganIndex)
        {
            slogans.RemoveAt(currentSloganIndex);
            Random rnd = new Random();
            var index = rnd.Next(slogans.Count);
            var currentSlogan = slogans[index];
            return PartialView("_Slogans", currentSlogan);
        }
    }
}