using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDesign;
using Unplugged.EmailGatherer.Controllers;
using Unplugged.EmailGatherer.Models;

namespace Unplugged.EmailGatherer.Tests
{
    [TestClass]
    public class HomeControllerTest : TestBase<HomeController>
    {
        [TestMethod]
        public void ShouldHaveHomeController()
        {
            Assert.IsInstanceOfType(Subject, typeof(Controller));
        }

        [TestMethod]
        public void ShouldHaveDatabaseContext()
        {
            // Arrange
            Contacts context = Subject.Context;

            // Assert
            Assert.IsNotNull(context);
        }
    }
}
