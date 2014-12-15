using AutoNise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace CDM.Domain
{
    public class Country: BaseEntity<int>
    {
        public virtual string Name { get; set; }
    }

    class CountryMap : ClassMapping<Country>
    {
        public CountryMap()
        {
            this.Table("Countries");
            this.Lazy(true);
            this.Id<int>(x => x.Id, mp => { mp.Column("Id"); mp.Generator(Generators.Native); mp.UnsavedValue(0); });
            Property<string>(x => x.Name, mp => { mp.Column("Name"); mp.NotNullable(true); });

        }
    }
}
