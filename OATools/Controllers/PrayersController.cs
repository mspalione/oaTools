using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OATools.Models;
using OATools.ViewModel;

namespace OATools.Controllers
{
    public class PrayersController : Controller
    {
        private ApplicationDbContext _context;

        public PrayersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Prayers
        public ActionResult Index()
        {
            var prayerList = _context.Prayers.ToList();

            return View(prayerList);
        }

    }
}