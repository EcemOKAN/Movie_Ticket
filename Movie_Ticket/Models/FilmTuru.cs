using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Models
{
    public class FilmTuru
    {
        public virtual int ID { get; set; }
        public virtual string Turu { get; set; }
    }

    public class FilmTuruMap : ClassMapping<FilmTuru>
    {
        public FilmTuruMap()
        {
            Table("FilmTurleri");
            Id(x => x.ID, x => x.Generator(Generators.Identity));
            Property(x => x.Turu, x => x.NotNullable(true));
        }
    }
}