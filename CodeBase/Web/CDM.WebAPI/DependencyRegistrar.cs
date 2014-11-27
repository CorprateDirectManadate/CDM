using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.WebApi;
using CDM.WebAPI.Controllers;
using AutoNise.Core.Infrastructure;
using AutoNise.Logic;
using AutoNise.Service;
using Autofac.Integration.Mvc;

namespace CDM.WebAPI
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(Autofac.ContainerBuilder builder, AutoNise.Core.ITypeFinder typeFinder)
        {
            builder.RegisterControllers(typeFinder.GetAssemblies().ToArray());

           builder.RegisterHttpRequestMessage(GlobalConfiguration.Configuration);
           


        }

        public int Order
        {
            get { return 0; }
        }
    }
}