using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Models
{
    public class Bilet
    {
        public virtual int ID { get; set; }
        public virtual string SatisTarihi { get; set; }
        public virtual string KoltukNo { get; set; }
        public virtual int BiletTurID { get; set; }
        public virtual int SeansID { get; set; }
        public virtual int KullaniciID { get; set; }

        public virtual IList<BiletTuru> Biletler { get; set; }
        public virtual IList<Seans> Seanslar { get; set; }
        public virtual IList<Kullanici> Kullanicilar { get; set; }
        public Bilet()
        {
            Biletler = new List<BiletTuru>();
            Seanslar = new List<Seans>();
            Kullanicilar = new List<Kullanici>();
        }
    }

    public class BiletMap : ClassMapping<Bilet>
    {
        public BiletMap()
        {
            Table("Biletler");
            Id(x => x.ID, x => x.Generator(Generators.Identity));
            Property(x => x.SatisTarihi, x => x.NotNullable(true));
            Property(x => x.KoltukNo, x => x.NotNullable(true));
            Property(x => x.BiletTurID, x => x.NotNullable(true));
            Property(x => x.SeansID, x => x.NotNullable(true));
            Property(x => x.KullaniciID, x => x.NotNullable(true));
        }
    }
}