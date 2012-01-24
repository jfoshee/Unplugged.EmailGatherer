using System;
using System.Web.Management;
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
            try
            {
                ContactsDb.ContactSet.Add(contact);
                ContactsDb.SaveChanges();
            }
            catch (Exception ex)
            {
                new LogEvent(ex).Raise();
            }
            return RedirectToAction("Thanks");
        }

        public ViewResult Thanks()
        {
            return View();
        }
    }

    public class LogEvent : WebRequestErrorEvent
    {
        public LogEvent(Exception ex)
            : base(null, null, 100001, ex)
        {
        }

        public LogEvent(string message)
            : base(null, null, 100001, new Exception(message))
        {
        }
    }
}
