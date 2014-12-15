using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDM.Domain;

namespace CDM.Service
{
    public interface IClaimService
    {
        Claim GetClaim();
    }
}
