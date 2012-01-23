using System.Web.Mvc;
using Unplugged.EmailGatherer.Models;

namespace Unplugged.EmailGatherer.Controllers
{
    public class HomeController : Controller
    {
        public ContactsDb ContactsDb { get; set; }

        public HomeController()
        {
            ContactsDb = new ContactsDb();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string emailAddress)
        {
            var contact = new Contact { EmailAddress = emailAddress };
            ContactsDb.ContactSet.Add(contact);
            ContactsDb.SaveChanges();
            return Redirect("http://www.google.com");
        }
    }
}
