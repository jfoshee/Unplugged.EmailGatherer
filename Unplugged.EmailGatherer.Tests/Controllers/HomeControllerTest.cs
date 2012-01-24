using System.Data.Entity;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
            ContactsDb context = Subject.ContactsDb;

            // Assert
            Assert.IsNotNull(context);
        }

        [TestMethod]
        public void AddActionShouldAddNewContact()
        {
            // Arrange
            string emailAddress = "expected";
            var mockDbSet = MockDbSet();

            // Act
            Subject.Add(emailAddress);

            // Assert
            mockDbSet.Verify(set => set.Add(It.Is<Contact>(c => c.EmailAddress == emailAddress)));
        }

        // TODO: Figure out how to mock the ContactsDb...
        [TestMethod, Ignore]
        public void AddActionShouldSaveChanges()
        {
            // Arrange
            var mockDb = new Mock<ContactsDb>();
            Subject.ContactsDb = mockDb.Object;

            // Act
            Subject.Add("abc");

            // Assert
            mockDb.Verify(context => context.SaveChanges());
        }

        // TODO: Should only support post

        [TestMethod]
        public void ShouldReturnViewResult()
        {
            // Arrange
            MockDbSet();

            // Act
            ActionResult result = Subject.Add("a@b.com");

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldHaveThanksAction()
        {
            // Arrange

            // Act
            ViewResult result = Subject.Thanks();

            // Assert
            Assert.IsNotNull(result);
        }

        // TODO: Test logging

        private Mock<IDbSet<Contact>> MockDbSet()
        {
            var mockDbSet = new Mock<IDbSet<Contact>>();
            Subject.ContactsDb.ContactSet = mockDbSet.Object;
            return mockDbSet;
        }
    }
}
