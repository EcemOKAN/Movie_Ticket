using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Movie_Ticket
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(name: "Logout", url: "cikisyap", defaults: new { controller = "User", action = "Logout" });
            routes.MapRoute(name: "SignIn", url: "girisyap", defaults: new { controller = "User", action = "SignIn" });
            routes.MapRoute(name: "SignUp", url: "kayitol", defaults: new { controller = "User", action = "SignUp" });
            routes.MapRoute(name: "Detail", url: "detaylar/{ID}", defaults: new { controller = "Detail", action = "Details" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new [] { "Movie_Ticket.Controllers" });

            // routes.MapRoute(name: "KoltukGetir", url: "KoltukGetir", defaults: new { controller = "Detail", action = "KoltukGetir" });
            // routes.MapRoute(name: "Rezerve", url: "Rezerve", defaults: new { controller = "Detail", action = "Rezerve" });

            routes.MapRoute(name: "Home", url: "", defaults: new { controller = "Home", action = "Index" });



        }
    }
}
