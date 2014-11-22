using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Web.Routing;
using AutoNise.Infrastructure.WebApi;

using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace CDM.FrontWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Formatters.Clear();

            ////config.Formatters.Add(new XmlMediaTypeFormatter());
            //var _formater = new JsonMediaTypeFormatter();
            //_formater.SerializerSettings.Converters.Add(new DateTimeConverterHelper());

            //config.Formatters.Add(_formater);

            //// Web API configuration and services
            //// Configure Web API to use only bearer token authentication.
            //config.SuppressDefaultHostAuthentication();
            //config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));


            ////Enable CORS for all origins, all headers, and all methods,
            //var cors = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                //routeTemplate: "api/{controller}/{id}",
                    routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}
