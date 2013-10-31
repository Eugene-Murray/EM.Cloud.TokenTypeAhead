using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EM.Cloud.TokenTypeAhead
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "list",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
