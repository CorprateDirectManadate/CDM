using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode.Conformist;

namespace CDM.Domain
{
    public class Hotel : ServiceProvider
    {
        public virtual int StarRating { get; set; }
    }

    class HotelMap: JoinedSubclassMapping<Hotel>
    {
        public HotelMap()
        {
            Table("Hotels");
            this.Lazy(true);
            Key(x =>
            {
                x.Column("ServiceProviderId");
                x.ForeignKey("Id");
                x.NotNullable(true);
                x.Unique(true);
                x.Update(true);
            });

            this.Property<int>(x => x.StarRating, mp => { mp.Column("StarRating"); });
        }
    }
}
