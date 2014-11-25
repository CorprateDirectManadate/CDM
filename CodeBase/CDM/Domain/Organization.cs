using AutoNise.Domain;
using AutoNise.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Domain
{
    public class Organization : BaseEntity<int>
    {
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
        //public virtual string SalesTaxNumber { get; set; }
        //public virtual string VATNumber { get; set; }
    }

    class OrganizationMap : BaseEntityMap<Organization, int>
    {
        public OrganizationMap()
        {
            this.Table("Organizations");
            this.Lazy(true);
            this.Id<int>(x => x.Id, mp => { mp.Column("Id"); mp.Generator(Generators.Native); mp.UnsavedValue(0); });
            this.Property<string>(x => x.Name, mp => { mp.Column("Name"); mp.NotNullable(true); });
            this.Property<string>(x => x.Address, mp => { mp.Column("Address"); mp.NotNullable(true); });
            this.Property<string>(x => x.PhoneNumber, mp => { mp.Column("PhoneNumber"); mp.NotNullable(true); });
            this.Property<string>(x => x.Email, mp => { mp.Column("Email"); mp.NotNullable(true); });
            this.Property<string>(x => x.City, mp => { mp.Column("City"); mp.NotNullable(true); });
            this.Property<string>(x => x.State, mp => { mp.Column("State"); mp.NotNullable(true); });
            this.Property<string>(x => x.Country, mp => { mp.Column("Country"); mp.NotNullable(true); });
        }

    }
}
