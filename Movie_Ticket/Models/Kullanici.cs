using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Models
{
    public class Kullanici
    {
        public virtual int ID { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Soyad { get; set; }
        public virtual string Ceptel { get; set; }
        public virtual string Email { get; set; }
        public virtual string SifreHash { get; set; }
        public virtual int RolID { get; set; }

        public virtual Role Rol { get { return Database.Session.Get<Role>(RolID); } set { } }

        public Kullanici()
        {
            Rol = new Role();
        }

    }
    public class KullaniciMap: ClassMapping<Kullanici>
    {
        public KullaniciMap()
        {
            Table("Kullanicilar");
            Id(x => x.ID, x => x.Generator(Generators.Identity));
            Property(x => x.Ad, x => x.NotNullable(true));
            Property(x => x.Soyad, x => x.NotNullable(true));
            Property(x => x.Ceptel, x => x.NotNullable(true));
            Property(x => x.Email, x => x.NotNullable(true));
            Property(x => x.SifreHash, x => x.NotNullable(true));
            Property(x => x.RolID, x => x.NotNullable(true));
        }
    }
}