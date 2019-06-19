using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movie_Ticket.ViewModels
{
    public class KullaniciGirisi
    {
        [Required(ErrorMessage = "E-mail alanı için bilgi giriniz !")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Şifre alanı için bilgi giriniz !")]
        [DataType(DataType.Password)]
        public string SifreHash { get; set; }
    }

    public class UyeOl
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Ceptel { get; set; }
        public string Email { get; set; }
        public string SifreHash { get; set; }
        public int RolID { get; set; }
    }
}