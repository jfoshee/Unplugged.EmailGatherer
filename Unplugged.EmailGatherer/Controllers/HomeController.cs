using System.Web.Mvc;
using Unplugged.EmailGatherer.Models;

namespace Unplugged.EmailGatherer.Controllers
{
    public class HomeController : Controller
    {
        public Contacts Context { get; set; }

        public HomeController()
        {
            Context = new Contacts();
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
