using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoNise.Domain;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CDM.Domain
{
    public class ServiceProvider: BaseEntity<int>
    {
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Website { get; set; }
        public virtual string Description { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual string City { get; set; }
        public virtual State State { get; set; }
        public virtual int StateId { get; set; }
        public virtual Country Country { get; set; }
        public virtual int CountryId { get; set; }
        public virtual bool MarkAsDeleted { get; set; }
    }

    class ServiceProviderMap : ClassMapping<ServiceProvider>
    {
        public ServiceProviderMap()
        {
            this.Table("ServiceProviders");
            this.Lazy(true);
            this.Id<long>(x => x.Id, mp =>
            {
                mp.Column("Id");
                mp.Generator(Generators.Native);
            });

            Property<string>(x=>x.Name, mp=> { mp.Column("Name"); mp.NotNullable(true); });
            Property<string>(x=>x.Address, mp=>{mp.Column("Address");});
            Property(x=>x.Website, mp=>{mp.Column("Website");});
            Property(x => x.Description, mp => { mp.Column("Description"); mp.NotNullable(true); });
            Property(x => x.PhoneNumber, mp => { mp.Column("PhoneNumber"); mp.NotNullable(true); });
            Property(x=>x.MarkAsDeleted, mp=>{mp.Column("MarkAsDeleted");});
            Property(x=>x.Email, mp=>{mp.Column("Email");});
            //Property(x=>x.Country, mp=>{mp.Column("Country");});
            this.Property<int>(x => x.CountryId, mp => { mp.Column("CountryId"); });

            this.ManyToOne<Country>(x => x.Country, mp => { mp.Lazy(LazyRelation.Proxy); mp.Update(false); mp.Insert(false); mp.Column("CountryId"); });
            this.Property<int>(x => x.StateId, mp => { mp.Column("StateId"); });

            this.ManyToOne<State>(x => x.State, mp => { mp.Lazy(LazyRelation.Proxy); mp.Update(false); mp.Insert(false); mp.Column("StateId"); });
            Property(x=>x.City, mp=>{mp.Column("City");});

        }
    }
}
