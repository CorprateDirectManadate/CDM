using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoNise.Domain;
using AutoNise.Mapping;

namespace CDM.Domain
{
    public class Currency : BaseEntity<int>
    {
        public virtual string currency { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual string Code { get; set; }
        public virtual string Symbol { get; set; }
        public virtual string Country { get; set; }
    }

    class CurrencyMap : BaseEntityMap<Currency, int>
    {
        public CurrencyMap()
        {
            this.Lazy(true);
            this.Table("Currencies");
            this.Id<int>(x => x.Id, mp => { mp.Column("Id");});
            this.Property<string>(x => x.Code, mp => { mp.Column("Code"); });
            this.Property<string>(x => x.Country, mp => { mp.Column("Country"); });
            this.Property<string>(x => x.Symbol, mp => { mp.Column("Symbol"); });
            this.Property<string>(x => x.currency, mp => { mp.Column("Currency"); });
            this.Property<bool>(x => x.Enabled, mp => { mp.Column("Enabled"); });
        }
    }
}
