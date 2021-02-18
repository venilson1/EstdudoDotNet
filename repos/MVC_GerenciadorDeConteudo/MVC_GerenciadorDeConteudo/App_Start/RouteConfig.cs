using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "Sobre_Parametro",
               "Sobre/{id}/oi",
               new { controller = "Home", action = "About", id = 0 }
            );

            routes.MapRoute(
               "Sobre",
               "Sobre",
               new { controller = "Home", action = "About" }
            );

            routes.MapRoute(
               "Contato",
               "Contato",
               new { controller = "Home", action = "Contact" }
            );
           
            routes.MapRoute(
               "Paginas",
               "Paginas",
               new { controller = "Paginas", action = "Index" }
            );

            routes.MapRoute(
               "Paginas_criar",
               "Paginas/criar",
               new { controller = "Paginas", action = "criar" }
            );

            routes.MapRoute(
               "Paginas_novo",
               "Paginas/novo",
               new { controller = "Paginas", action = "Novo" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
