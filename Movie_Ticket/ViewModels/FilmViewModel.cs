using Movie_Ticket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.ViewModels
{
    public class FilmIndex
    {

        public IEnumerable<Film> Films { get; set; }
       // public IEnumerable<FilmTur> Films { get; set; }


    }
    public class FilmDetayViewModel
    {
        public List< Seans> Seans { get; set; }
        public List< Salon> Salon { get; set; }
        public Film Film { get; set; }

    }

}