using Movie_Ticket.Models;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket
{
    public class Database
    {
        private const string SessionKey = "Movie_Ticket.Database.SessionKey";

        private static ISessionFactory _sessionFactory;

        public static ISession Session
        {
            get
            {
                return (ISession)HttpContext.Current.Items[SessionKey];
            }
        }


        public static void Configure()
        {
            var config = new Configuration();
            config.Configure();

            var mapper = new ModelMapper();
            mapper.AddMapping<FilmMap>();
            mapper.AddMapping<SalonMap>();
            mapper.AddMapping<FilmTuruMap>();
            mapper.AddMapping<BiletMap>();
            mapper.AddMapping<BiletTuruMap>();
            mapper.AddMapping<KullaniciMap>();
            mapper.AddMapping<RoleMap>();
            mapper.AddMapping<SeansMap>();


            config.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());

            //creating sessionFactory
            _sessionFactory = config.BuildSessionFactory();

        }
        public static void OpenSession()
        {
            HttpContext.Current.Items[SessionKey] = _sessionFactory.OpenSession();
        }

        public static void CloseSession()
        {

            var session = HttpContext.Current.Items[SessionKey] as ISession;
            if (session != null)
            {
                session.Close();
            }

            HttpContext.Current.Items.Remove("Session");

        }
    }
}