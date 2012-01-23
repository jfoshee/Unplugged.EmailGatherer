using System.Data.Entity;

namespace Unplugged.EmailGatherer.Models
{
    public class Contacts : DbContext
    {
        public IDbSet<Contact> ContactSet { get; set; }
    }
}
