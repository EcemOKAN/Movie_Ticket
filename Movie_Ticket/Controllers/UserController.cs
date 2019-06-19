using Movie_Ticket.Models;
using Movie_Ticket.ViewModels;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Movie_Ticket.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(KullaniciGirisi formData, string ReturnUrl)
        {
            if (!ModelState.IsValid)
                return View(formData);

            Kullanici user = Database.Session.Query<Kullanici>().SingleOrDefault(x => x.Email.Equals(formData.Email) && x.SifreHash.Equals(formData.SifreHash));
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Email, true);

                if (!string.IsNullOrWhiteSpace(ReturnUrl))
                    return Redirect(ReturnUrl);
                return Redirect("/Home");
            }
            return View();

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Home");
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Kullanici model)
        {
            if (Database.Session.Query<Kullanici>().SingleOrDefault(x => x.Email.Equals(model.Email)) == null)
            {
                Kullanici kullanici = new Kullanici()
                {
                    Ad = model.Ad,
                    Soyad = model.Soyad,
                    Email = model.Email,
                    RolID = 3,
                    Ceptel=model.Ceptel,
                    SifreHash=model.SifreHash
                    
                };
                Database.Session.Save(kullanici);
                return Redirect("/girisyap");
            }
            else
            {
                ViewBag.ErrorMessage = "Bu kullanıcı adı kullanılıyor";
                return View(model);
            }


        }
    }
}