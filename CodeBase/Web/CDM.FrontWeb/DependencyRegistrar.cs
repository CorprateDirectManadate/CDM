using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using AutoNise.Core.Infrastructure;
using AutoNise.Data.NHibernate;
using AutoNise.Infrastructure;
using AutoNise.Infrastructures.Caching;
using AutoNise.Infrastructures.Fake;
using AutoNise.Logic;
using AutoNise.Service;

namespace CDM.FrontWeb
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(Autofac.ContainerBuilder builder, AutoNise.Core.ITypeFinder typeFinder)
        {
          
          
            builder.RegisterControllers(typeFinder.GetAssemblies().ToArray());
         
            // builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //   builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

           
        }

        public int Order
        {
            get {  return 0; }
        }
    }
}