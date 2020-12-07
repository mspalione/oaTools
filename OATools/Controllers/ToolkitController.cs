using OATools.Models;
using OATools.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace OATools.Controllers
{
    public class ToolkitController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToolkitController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Tools
        public ActionResult Index()
        {
            var viewmodel = new ToolkitViewModel
            {
                Tools = _context.Tools.ToList(),
                Toolkit = _context.Toolkit.ToList()
            };

            return View(viewmodel);
        }
    }
}