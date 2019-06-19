using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Migrations
{
    [Migration(2)]
    public class _002_CinemaHall_and_Seance : Migration
    {
        public override void Down()
        {
            Delete.Table("Salonlar");
            Delete.Table("Seanslar");
        }

        public override void Up()
        {
            Create.Table("Salonlar")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("SalonAdi").AsString(128)
                .WithColumn("Kapasite").AsInt32()
                .WithColumn("Satir").AsInt32()
                .WithColumn("Sutun").AsInt32();

            Create.Table("Seanslar")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("Tarih").AsDate()
                .WithColumn("Saat").AsTime()
                .WithColumn("FilmID").AsInt32().ForeignKey("Filmler", "ID")
                .WithColumn("SalonID").AsInt32().ForeignKey("Salonlar", "ID");


        }
    }
}