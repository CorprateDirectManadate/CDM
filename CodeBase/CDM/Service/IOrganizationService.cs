using CDM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Service
{
    public interface IOrganizationService
    {
        int CreateOrganization(Organization organization);
    }
}
