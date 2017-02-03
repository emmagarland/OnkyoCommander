using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace eg.Onkyo.API
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
        }
    }
}