using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDesign;
using Unplugged.EmailGatherer.Models;

namespace Unplugged.EmailGatherer.Tests.Models
{
    [TestClass]
    public class ContactsDbTest : TestBase<ContactsDb>
    {
        [TestMethod]
        public void ShouldBeDbContext()
        {
            Assert.IsInstanceOfType(Subject, typeof(DbContext));
        }

        [TestMethod]
        public void ShouldHaveSetOfContacts()
        {
            // Arrange
            IDbSet<Contact> contactSet = Subject.ContactSet;

            // Assert
            Assert.IsNotNull(contactSet);
        }
    }
}
