using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OATools.Models;
using OATools.ViewModel;

namespace OATools.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

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
                PdfLinks = _context.FreePdfLinks.ToList()
            };

            return View(model);
        }
    }
}