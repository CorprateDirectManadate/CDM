using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AutoNise.Controllers;
using CDM.Domain;
using CDM.Service;
using api = CDM.Domain.API;

namespace CDM.WebAPI.Controllers
{
    public class OrganizationController : BaseApiController
    {
        private readonly IOrganizationService _organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        // GET: Organization
        public IHttpActionResult Create(api.Organization organization)
        {
            Organization org = new Organization()
            {
                Address = organization.Address,
                City = organization.City,
                Country = organization.Country,
                Email = organization.Email,
                MarkAsDeleted = organization.MarkAsDeleted,
                Name = organization.Name,
                PhoneNumber = organization.PhoneNumber,
                State = organization.State
            };

            _organizationService.CreateOrganization(org);

            return Ok(org.Id);
        }
    }
}