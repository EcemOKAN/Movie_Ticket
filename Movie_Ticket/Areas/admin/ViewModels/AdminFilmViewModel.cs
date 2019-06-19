using Movie_Ticket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Areas.admin.ViewModels
{
    public class adminFilmViewModelListe
    {
            public IEnumerable<Film> Films { get; set; }
            // public IEnumerable<FilmTur> Films { get; set; }
    }


    public class movieAdd
    {
        public string Adi { get; set; }
        public string Afis { get; set; }
        public string Ozet { get; set; }
        public string Oyuncular { get; set; }
        public string Dil { get; set; }
        public string Suresi { get; set; }
        public int TurID { get; set; }

    }
}