using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Domain
{
    public class Hotel : ServiceProvider
    {
        public virtual int StarRating { get; set; }
    }
}
