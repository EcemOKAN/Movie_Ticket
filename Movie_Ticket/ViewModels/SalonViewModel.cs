using Movie_Ticket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.ViewModels
{
    public class SalonIndex
    {
        public IEnumerable<Salon> Salons { get; set; }
    }
}