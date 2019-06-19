using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Models
{
    public class Role
    {
        public virtual int ID { get; set; }
        public virtual string Rol { get; set; }
    }
    public class RoleMap : ClassMapping<Role>
    {
        public RoleMap()
        {
            Table("Roller");

            Id(x => x.ID, x => x.Generator(Generators.Identity));
            Property(x => x.Rol, x => x.NotNullable(true));
        }

    }
}