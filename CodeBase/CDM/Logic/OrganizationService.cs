using AutoNise.Service;
using CDM.Domain;
using CDM.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Logic
{
    public class OrganizationService: IOrganizationService
    {
        private readonly IRepository<Organization, int> _orgRepo;

        public OrganizationService(IRepository<Organization, int> orgRepo)
        {
            _orgRepo = orgRepo;
        }

        public int CreateOrganization(Organization organization)
        {
            _orgRepo.Add(organization);
            return organization.Id;
        }
    }
}
