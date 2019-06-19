using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Models
{
    public class Film
    {
        public virtual int ID { get; set; }
        public virtual string Adi { get; set; }
        public virtual string Afis { get; set; }
        public virtual string Ozet { get; set; }
        public virtual string Oyuncular { get; set; }
        public virtual string Dil { get; set; }
        public virtual string Suresi { get; set; }
        public virtual int TurID { get; set; }

        public virtual FilmTuru FilmTuru { get { return Database.Session.Get<FilmTuru>(TurID); } set { } }

        public Film()
        {
            FilmTuru = new FilmTuru();
        }
    }

    public class FilmMap: ClassMapping<Film>
    {
        public FilmMap()
        {
            Table("Filmler");

            Id(x => x.ID, x => x.Generator(Generators.Identity));
            Property(x => x.Adi, x => x.NotNullable(true));
            Property(x => x.Afis, x => x.NotNullable(true));
            Property(x => x.Ozet, x => x.NotNullable(true));
            Property(x => x.Oyuncular, x => x.NotNullable(true));
            Property(x => x.Dil, x => x.NotNullable(true));
            Property(x => x.Suresi, x => x.NotNullable(true));
            Property(x => x.TurID, x => x.NotNullable(true));

        }
    }
}