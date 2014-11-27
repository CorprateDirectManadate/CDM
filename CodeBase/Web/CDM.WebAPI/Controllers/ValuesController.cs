using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using CDM.Domain;
using AutoNise.Controllers;
using AutoNise.Core;
using AutoNise.Infrastructure;
using AutoNise.Service;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CDM.WebAPI.Controllers
{

    public class ValuesController : BaseApiController
    {
        private readonly IDateTimeHelper _dateTime;
        public ValuesController(IDateTimeHelper dateTime)
        {
            this._dateTime = dateTime;

        }

        //public ValuesController()
        //{

        //}
        // GET api/values
   //  [Authorize]
        public IEnumerable<string> Get()
        {
            //var _user = Membership.GetUser("victor@AutoNisetech.com");
            //var pInfo = new PersonalInformation
            //{
            //    FirstName = "Olawale",
            //    LastName = "Jekoyemi",
            //    UserRole = "SystemAdmin",
            //    UserId = new Guid(_user.ProviderUserKey.ToString()),
            //    EmailVerified = true,
            //    Email = "victor@AutoNisetech.com",
            //    PhoneNumber = "0394848412",
            //};
            ////MembershipCreateStatus status = new MembershipCreateStatus();
            //// Membership.CreateUser(pInfo.Email, "password1", pInfo.Email, "What's your Email Address?", pInfo.Email, true, out status);

            //var engineP = EngineContext.Current.Resolve<IRepository<PersonalInformation, long>>();
            //engineP.Add(pInfo);
            
            return new string[] { "value1", "value2"};
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
