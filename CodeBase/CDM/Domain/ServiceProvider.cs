using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Domain
{
    public class ServiceProvider
    {
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Website { get; set; }
        public virtual string Description { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
        public virtual bool MarkAsDeleted { get; set; }
    }
}
