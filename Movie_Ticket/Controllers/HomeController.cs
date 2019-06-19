using Movie_Ticket.Models;
using Movie_Ticket.ViewModels;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Ticket.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            FilmIndex filmIndex = new FilmIndex
            {
                Films = Database.Session.Query<Film>().ToList()
            };
            return View(filmIndex);
            
        }
    }
}