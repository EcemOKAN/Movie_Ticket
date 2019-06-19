using Movie_Ticket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Areas.admin.ViewModels
{
    public class AdminSalonViewModelListele
    {
        public IEnumerable<Salon> Salonlar { get; set; }
    }
    public class HallAdd
    {
        public string SalonAdi { get; set; }
        public int Kapasite { get; set; }
        public int Satir { get; set; }
        public int Sutun { get; set; }
    }
}