using OATools.Models;
using OATools.ViewModel;
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
                Slogans = _context.Slogans.ToList(),
                Steps = _context.Steps.ToList(),
                Traditions = _context.Traditions.ToList(),
                Promises = _context.Promises.ToList(),
                Principles = _context.Principles.ToList()
            };

            return View(model);
        }

        public ActionResult Slogans()
        {
            var slogans = _context.Slogans.ToList();
            return View(slogans);
        }
    }
}