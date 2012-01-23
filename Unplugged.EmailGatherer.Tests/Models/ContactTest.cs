using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDesign;
using Unplugged.EmailGatherer.Models;

namespace Unplugged.EmailGatherer.Tests.Models
{
    [TestClass]
    public class ContactTest : TestBase<Contact>
    {
        [TestMethod]
        public void ShouldHaveEmailAddress()
        {
            // Arrange
            string emailAddress = Subject.EmailAddress;

            // Assert
            Assert.IsNull(emailAddress);
        }

        [TestMethod]
        public void ShouldHavePrimaryKey()
        {
            // Arrange
            int contactId = Subject.ContactId;

            // Assert
            Assert.AreEqual(0, contactId);
        }
    }
}
