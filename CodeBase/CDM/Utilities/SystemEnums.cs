using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Utilities
{
    public class SystemEnums
    {
        public enum FlightType
        {
            Domestic = 1,
            International = 2
        }

        public enum FlightKind
        {
            OneWay = 1,
            RoundTrip = 2,
            MultipleDestinations = 3
        }

        public enum TicketClass
        {
            Economy = 1,
            PremiumEconomy = 2,
            BusinessClass = 3,
            FirstClass = 4
        }

        public enum ProviderType
        {
            Airline = 1,
            Hotel = 2
        }
    }
}
