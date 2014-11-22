using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CDM.WebAPI;
using CDM.WebAPI.App_Start;
using AutoNise.Core;
using AutoNise.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.WebHost;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoNise.Infrastructure.DI;
using AutoNise.Service;

namespace CDM.FrontWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            //EngineContext.Initialize(false);
            //var dependencyResolver = new CustomDependencyResolver();
            //DependencyResolver.SetResolver(dependencyResolver);
            //WebApiConfig.Register(GlobalConfiguration.Configuration);


            //ApiHandlerConfig.Register(GlobalConfiguration.Configuration);

            MVcBaseGlobalAsax.Application_Start();
            //base.Application_Start();
            WebApiConfig.Register(GlobalConfiguration.Configuration);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }
    }
}
