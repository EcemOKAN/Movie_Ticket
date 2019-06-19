using Movie_Ticket.Areas.admin.ViewModels;
using Movie_Ticket.Models;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Ticket.Areas.admin.Controllers
{
    public class HallController : Controller
    {
        // GET: admin/Hall
        public ActionResult Index()
        {
            AdminSalonViewModelListele AdminSalonViewModelListele = new AdminSalonViewModelListele
            {
                Salonlar = Database.Session.Query<Salon>().ToList()
            };
            return View(AdminSalonViewModelListele);
        }
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(HallAdd model)
        {
            if (Database.Session.Query<Salon>().SingleOrDefault(x => x.SalonAdi.Equals(model.SalonAdi)) == null)
            {
                Salon salon = new Salon()
                {
                    SalonAdi = model.SalonAdi,
                    Kapasite = model.Kapasite,
                    Satir = model.Satir,
                    Sutun = model.Sutun

                };
                Database.Session.Save(salon);
                return View(salon);
            }
            else
            {
                ViewBag.ErrorMessage = "Bu salon adı kullanılıyor";
                return View(model);
            }


        }
        public ActionResult Edit(int ID)
        {
            //Salon salon = Database.Session.Query<Salon>().SingleOrDefault(x => x.ID.Equals(ID));
            Salon salon = Database.Session.Get<Salon>(ID);
            HallAdd model = new HallAdd()
            {
                Kapasite = salon.Kapasite,
                SalonAdi = salon.SalonAdi,
                Satir = salon.Satir,
                Sutun = salon.Sutun
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(HallAdd model)
        {
            Salon salon = new Salon()
            {

                SalonAdi = model.SalonAdi,
                Kapasite = model.Kapasite,
                Satir = model.Satir,
                Sutun = model.Sutun,
            };
            salon.ID = Convert.ToInt32(RouteData.Values["ID"]);
            Database.Session.Update(salon);
            Database.Session.Flush();
            return View();
        }
        public void Delete(int ID)
        {
            Salon salon = Database.Session.Get<Salon>(ID);
            Database.Session.Delete(salon);
            Database.Session.Flush();
        }
    }
}