using Movie_Ticket.App_Start;
using System.Web.Mvc;
using System.Web.Optimization;

namespace Movie_Ticket.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            RegisterBundles();



            #region AdminMovie
            context.MapRoute(name: "Movies", url: "admin/filmler", defaults: new { controller = "Movie", action = "Index" });
            context.MapRoute(name: "AddMovie", url: "admin/filmEkle", defaults: new { controller = "Movie", action = "Add" });
            context.MapRoute(name: "EditMovie", url: "admin/filmDuzenle/{ID}", defaults: new { controller = "Movie", action = "Edit", ID = UrlParameter.Optional });
            context.MapRoute(name: "DeleteMovie", url: "admin/filmSil", defaults: new { controller = "Movie", action = "Delete" });
            #endregion

            #region AdminUsers
            context.MapRoute(name: "Users", url: "admin/kullanicilar", defaults: new { controller = "Users", action = "Index" });
            context.MapRoute(name: "AddUsers", url: "admin/kullaniciEkle", defaults: new { controller = "Users", action = "Add" });
            context.MapRoute(name: "EditUsers", url: "admin/kullaniciDuzenle/{ID}", defaults: new { controller = "Users", action = "Edit", ID = UrlParameter.Optional });
            context.MapRoute(name: "DeleteUsers", url: "admin/kullaniciSil", defaults: new { controller = "Users", action = "Delete" });
            #endregion

            #region AdminSalon
            context.MapRoute(name: "Halls", url: "admin/salonlar", defaults: new { controller = "Hall", action = "Index" });
            context.MapRoute(name: "AddHall", url: "admin/salonEkle", defaults: new { controller = "Hall", action = "Add" });
            context.MapRoute(name: "EditHall", url: "admin/salonDuzenle/{ID}", defaults: new { controller = "Hall", action = "Edit", ID = UrlParameter.Optional });
            context.MapRoute(name: "DeleteHall", url: "admin/salonSil", defaults: new { controller = "Hall", action = "Delete" });
            #endregion

            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new {controller="Home", action = "Index", id = UrlParameter.Optional }

            );
            context.MapRoute(name: "AdminHome", url: "admin/", defaults: new { controller = "Home", action = "Index" });

        }


        private void RegisterBundles()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}