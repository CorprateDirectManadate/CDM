using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using CDM.Logic;
using CDM.Service;
using AutoNise.Core.Infrastructure;
using AutoNise.Data.NHibernate;
using AutoNise.Logic;
using AutoNise.Service;

namespace CDM
{
  public class DependencyRegistrar : IDependencyRegistrar
    {
    
      public void Register(Autofac.ContainerBuilder builder, AutoNise.Core.ITypeFinder typeFinder)
      {
          
          builder.RegisterType<CurrencyService>().As<ICurrencyService>().InstancePerLifetimeScope();
      
      
      }

      public int Order
      {
          get { return 0; }
      }
    }
}
