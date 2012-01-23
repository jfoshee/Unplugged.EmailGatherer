using System.Data.Entity;

namespace Unplugged.EmailGatherer.Models
{
    public class ContactsDb : DbContext
    {
        public IDbSet<Contact> ContactSet { get; set; }
    }
}
