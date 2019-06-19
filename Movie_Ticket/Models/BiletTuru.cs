using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Models
{
    public class BiletTuru
    {
        public virtual int ID { get; set; }
        public virtual string BiletTur { get; set; }
        public virtual int Fiyat { get; set; }
    }
    public class BiletTuruMap : ClassMapping<BiletTuru>
    {
        public  BiletTuruMap()
        {
            Table("BiletTurleri");
            Id(x => x.ID, x => x.Generator(Generators.Identity));
            Property(x => x.BiletTur, x => x.NotNullable(true));
            Property(x => x.Fiyat, x => x.NotNullable(true));
        }
    }
}