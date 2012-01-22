using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unplugged.EmailGatherer.Controllers;

namespace Unplugged.EmailGatherer.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void ShouldHaveHomeController()
        {
            Assert.IsInstanceOfType(new HomeController(), typeof(Controller));
        }
    }
}
