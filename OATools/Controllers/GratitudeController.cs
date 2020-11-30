using OATools.Models;
using OATools.ViewModel;
using System;
using System.Linq;
using System.Web.Mvc;

namespace OATools.Controllers
{
    public class GratitudeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GratitudeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Gratitude
        public ActionResult Index()
        {
            var gratitudes = new GratitudeViewModel
            {
                Gratitudes = _context.Gratitudes.AsEnumerable().Reverse().Take(100).ToList()
            };

            return View(gratitudes);
        }

        [HttpPost]
        public ActionResult New(Gratitude gratitude)
        {
            gratitude.Date = DateTime.Now;
            _context.Gratitudes.Add(gratitude);
            _context.SaveChanges();

            return RedirectToAction("Index", "Gratitude");
        }
    }
}