using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoNise.Controllers;
using AutoNise.Domain;
using AutoNise.Infrastructure;

namespace CDM.WebAPI.Controllers
{
    public class DataController : BaseApiController
    {
        private readonly IWebUserContext _IWebUserContext;

        public DataController(IWebUserContext IWebUserContext)
        {
            this._IWebUserContext = IWebUserContext;
        }
        public WebUser GetCurrentUser()
        {
           return this._IWebUserContext.GetCurrentUserName;
        }
    }
}
