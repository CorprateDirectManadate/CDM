using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDM.Utilities;

namespace CDM.Domain
{
    public class Flight
    {
        public virtual string From { get; set; }
        public virtual string To { get; set; }
        public virtual SystemEnums.FlightType Type { get; set; }
        public virtual SystemEnums.FlightKind Kind { get; set; }
        public virtual DateTime ArrivalDate { get; set; }
        public virtual DateTime DepartureDate { get; set; }
        public virtual int AdultPax { get; set; }
        public virtual int ChildPax { get; set; }
        public virtual int InfantPax { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual SystemEnums.TicketClass TicketClass { get; set; }
    }
}
