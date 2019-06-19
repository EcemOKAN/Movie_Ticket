using Movie_Ticket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Areas.admin.ViewModels
{
    public class AdminKullaniciViewModelListele
    {
        public IEnumerable<Kullanici> Kullanici { get; set; }
    }
    public class KullaniciAdd
    {
        public virtual string Ad { get; set; }
        public virtual string Soyad { get; set; }
        public virtual string Ceptel { get; set; }
        public virtual string Email { get; set; }
        public virtual string SifreHash { get; set; }
        public List<Role> Roles { get; set; }

    }
}