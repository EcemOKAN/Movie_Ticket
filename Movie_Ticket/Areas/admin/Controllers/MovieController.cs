using Movie_Ticket.Areas.admin.ViewModels;
using Movie_Ticket.Helpers;
using Movie_Ticket.Models;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Ticket.Areas.admin.Controllers
{
    public class MovieController : Controller
    {
        // GET: admin/Movie
        public ActionResult Index()
        {
            adminFilmViewModelListe adminFilmViewModelListe = new adminFilmViewModelListe
            {
                Films = Database.Session.Query<Film>().ToList()
            };
            return View(adminFilmViewModelListe);
            
        }
        public ActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Add(movieAdd model, HttpPostedFileBase image)
        {
          
            if (Database.Session.Query<Film>().SingleOrDefault(x => x.Adi.Equals(model.Adi)) == null)
            {
                Film film = new Film()
                {
                    Adi = model.Adi,
                    Ozet = model.Ozet,
                    Oyuncular=model.Oyuncular,
                    Dil=model.Dil,
                    Suresi=model.Suresi,
                    TurID=1
                };
                film.Afis = FileUpload.FileName(image);
                Database.Session.Save(film);
                return Redirect("/admin/filmler");
            }
            else
            {
                ViewBag.ErrorMessage = "Bu film adı kullanılıyor";
                return View(model);
            }


        }

        public ActionResult Edit()
        {
            return View();
        }

        public void Delete(int ID)
        {
            Film film = Database.Session.Get<Film>(ID);
            Database.Session.Delete(film);
            Database.Session.Flush();
        }
    }
}