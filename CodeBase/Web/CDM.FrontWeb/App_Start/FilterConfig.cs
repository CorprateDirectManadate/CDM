using System.Web;
using System.Web.Mvc;
using AutoNise.Infrastructure;

namespace CDM.FrontWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
           // filters.Add(new TransactionAttribute());
           // filters.Add(new TransactionApiAttribute());
        }
    }
}
