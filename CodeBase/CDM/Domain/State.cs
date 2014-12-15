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
    public class State: BaseEntity<int>
    {
        public virtual string Name { get; set; }      
    }

    class StateMap : ClassMapping<State>
    {
        public StateMap()
        {
            this.Table("States");
            this.Lazy(true);
            this.Id<long>(x => x.Id, mp =>
            {
                mp.Column("Id");
                mp.Generator(Generators.Native);
            });

            Property<string>(x => x.Name, mp => { mp.Column("Name"); mp.NotNullable(true); });
        }
    }
}
