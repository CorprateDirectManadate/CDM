using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoNise.Domain;
using AutoNise.Mapping;
using NHibernate.Mapping.ByCode;

namespace CDM.Domain
{
   
    public class UserGroup : BaseEntity<int>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }

    class UserGroupMap : BaseEntityMap<UserGroup, int>
    {
        public UserGroupMap()
        {
            this.Table("UserGroups");
            this.Lazy(true);
            this.Id<int>(x => x.Id, mp => { mp.Column("Id"); mp.Generator(Generators.Native); });

            this.Property<string>(x => x.Name, mp => { mp.Column("Name"); });
            this.Property<string>(x => x.Description, mp => { mp.Column("Description"); });


        }


    }
}
