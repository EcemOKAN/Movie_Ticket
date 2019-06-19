using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Models
{
    public class Seans
    {
        public virtual int ID { get; set; }
        public virtual string Tarih { get; set; }
        public virtual string Saat { get; set; }
        public virtual int FilmID { get; set; }
        public virtual int SalonID { get; set; }

        public virtual Film Film { get { return Database.Session.Get<Film>(FilmID); } set { } }
        public virtual Salon Salon { get { return Database.Session.Get<Salon>(SalonID); } set { } }

        public Seans()
        {
            Film = new Film();
            Salon = new Salon();
        }

    }
    public class SeansMap: ClassMapping<Seans>
    {
        public SeansMap()
        {
            Table("Seanslar");
            Id(x => x.ID, x => x.Generator(Generators.Identity));
            Property(x => x.Tarih, x => x.NotNullable(true));
            Property(x => x.Saat, x => x.NotNullable(true));
            Property(x => x.FilmID, x => x.NotNullable(true));
            Property(x => x.SalonID, x => x.NotNullable(true));
        }
    }

}