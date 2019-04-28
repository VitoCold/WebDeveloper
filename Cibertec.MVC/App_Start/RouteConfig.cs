using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cibertec.MVC
{
    //Se define la tabla de enrutamiento del sitio web
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            //INdica al motor de ruteo que los request que involucren
            // recursos axd no se van a tomar en cuenta, van a ser gestionados directamente
            // por IIS
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Ruta estática
            //routes.MapRoute(
            //    name: "ClientesEstatica",
            //    url: "Clientes",
            //    defaults: new { controller = "Customer", action = "Index"}
            //);

            ////Ruta dinámica
            //routes.MapRoute(
            //    name: "ClientesDinamica",
            //    url:"Clientes/{id}/{action}",
            //    defaults: new {controller="Customer", action="Details"},
            //    constraints: new {id=@"\d+"}
            //        );

            ////Ruta SEO
            //routes.MapRoute(
            //    name: "ClientesSEO",
            //    url: "{clientName}",
            //    defaults: new { controller = "Customer", action = "DetailsName" }
            //        );

            //Esto es el metodo generico, siempre se deja al final
            //OJOOOOOO
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
