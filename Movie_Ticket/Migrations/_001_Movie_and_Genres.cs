using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Migrations
{

    [Migration(1)]
    public class _001_Movie_and_Genres : Migration
    {
        public override void Down()
        {
            Delete.Table("FilmTurleri");
            Delete.Table("Filmler");
        }

        public override void Up()
        {


            Create.Table("FilmTurleri")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("Turu").AsString(256);

            Create.Table("Filmler")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("Adi").AsString(256)
                .WithColumn("Afis").AsString(500)
                .WithColumn("Ozet").AsString(int.MaxValue)
                .WithColumn("Oyuncular").AsString(int.MaxValue)
                .WithColumn("Dil").AsString(50)
                .WithColumn("Suresi").AsString(50)
                .WithColumn("TurID").AsInt32().ForeignKey("FilmTurleri", "ID");


        }
    }
}