using System.Web.Http;
using System.Web.Routing;

namespace eg.Onkyo.API
{
    public static class WebApiConfig
    {
        /// <summary>
        /// Register the Web API configuration and services
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            // Controllers with Actions
            config.Routes.MapHttpRoute(
               name: "ControllerAndAction",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional, extension = RouteParameter.Optional }
            );

            // Convention-based routing
            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional });
        }
    }
}
