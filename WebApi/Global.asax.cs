using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using WebApiContrib.Formatting.Jsonp;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Formatters.Clear();
            GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());
            int NewIndex = GlobalConfiguration.Configuration.Formatters.Count;
            GlobalConfiguration.Configuration.Formatters.Insert(NewIndex, new JsonpMediaTypeFormatter(new JsonMediaTypeFormatter()));
        }
    }
}
