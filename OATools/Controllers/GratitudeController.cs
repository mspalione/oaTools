using OATools.Models;
using System;
using System.Web.Mvc;

namespace OATools.Controllers
{
    public class GratitudeController : Controller
    {
        private ApplicationDbContext _context;

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
            return View();
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