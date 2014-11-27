using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using AutoNise.Infrastructure.WebApi.Handlers;

namespace CDM.WebAPI.App_Start
{
    public static class ApiHandlerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MessageHandlers.Add(new ApiLoggerHandler());


          //  config.MessageHandlers.Add(new ApiTokenHandler());

        }
    }
}