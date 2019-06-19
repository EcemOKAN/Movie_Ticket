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
    public class UsersController : Controller
    {
        // GET: admin/Users
        public ActionResult Index()
        {
            AdminKullaniciViewModelListele AdminKullaniciViewModelListele = new AdminKullaniciViewModelListele()
            {
                Kullanici = Database.Session.Query<Kullanici>().ToList()
            };
            return View(AdminKullaniciViewModelListele);

        }
        public ActionResult Add()
        {
            KullaniciAdd KullaniciAdd = new KullaniciAdd
            {
                Roles = Database.Session.Query<Role>().ToList()
            };

            return View(KullaniciAdd);
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}