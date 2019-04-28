using Cibertec.Models;
using Cibertec.MVC.App_Start;
using Cibertec.MVC.Binders;
using Cibertec.MVC.ValueProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Cibertec.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DIConfig.ConfigureInjector();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            ////Para que el custom value provider sea usado primero
            //ValueProviderFactories.Factories.Insert(0, new ProductValueProviderFactory());

            ////Para que el custom value provider sea usado, en caso ninguno de los default haya
            ////podido resolverlo

            //ValueProviderFactories.Factories.Add(new ProductValueProviderFactory());

            //ModelBinders.Binders.Add(typeof(Product), new ProductBinder());

            log4net.Config.XmlConfigurator.Configure();


        }
    }
}
