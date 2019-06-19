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
    [Authorize]
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Details(int ID)
        {

            FilmDetayViewModel filmdetay = new FilmDetayViewModel
            {
                Film = Database.Session.Get<Film>(ID),
                Salon = Database.Session.Query<Salon>().ToList(),
                Seans = Database.Session.Query<Seans>().ToList()
            };

            return View(filmdetay);
        }

        public string KoltukGetir(int ID)
        {
            Salon Salons = Database.Session.Query<Salon>().SingleOrDefault(x => x.ID.Equals(ID));
            return $"{Salons.Sutun}x{Salons.Satir}";
        }

        public string SalonGetir(int ID)
        {
            int salonID = Database.Session.Get<Seans>(ID).SalonID;
            Salon Salons = Database.Session.Query<Salon>().SingleOrDefault(x => x.ID.Equals(salonID));
            return $"{Salons.ID}x{Salons.SalonAdi}";
        }

        public string Rezerve(int ID)
        {
            //test verisi
            string rezerveKoltuklar = "";

            foreach (Bilet item in Database.Session.Query<Bilet>().Where(x => x.SeansID.Equals(ID)).ToList())
            {
                rezerveKoltuklar += $"{item.KoltukNo}_";
            }

            if (rezerveKoltuklar.Length > 0)
            {
                rezerveKoltuklar = rezerveKoltuklar.Remove(rezerveKoltuklar.Length - 1);
            }

            return rezerveKoltuklar;
        }


        public void BiletSat(string KoltukNo, int SeansID)
        {
            string[] koltuklar = KoltukNo.Split(',');

            int KullaniciID = Database.Session.Query<Kullanici>().SingleOrDefault(x => x.Email.Equals(User.Identity.Name)).ID;
            foreach (string koltuk in koltuklar)
            {
                Bilet bilet = new Bilet()
                {
                    SatisTarihi = DateTime.Now.ToShortDateString(),
                    KoltukNo = koltuk,
                    BiletTurID = 1,
                    SeansID = SeansID,
                    KullaniciID = KullaniciID
                };
                Database.Session.Save(bilet);
            }

        }
    }
}