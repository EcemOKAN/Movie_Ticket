using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Models
{
    public class Salon
    {
        public virtual int ID { get; set; }
        public virtual string SalonAdi { get; set; }
        public virtual int Kapasite { get; set; }
        public virtual int Satir { get; set; }
        public virtual int Sutun { get; set; }
    }

    public class SalonMap:ClassMapping<Salon>
    {
        public SalonMap()
        {
            Table("Salonlar");
            Id(x => x.ID, x => x.Generator(Generators.Identity));
            Property(x => x.SalonAdi, x => x.NotNullable(true));
            Property(x => x.Kapasite, x => x.NotNullable(true));
            Property(x => x.Satir, x => x.NotNullable(true));
            Property(x => x.Sutun, x => x.NotNullable(true));
        }
    }

}