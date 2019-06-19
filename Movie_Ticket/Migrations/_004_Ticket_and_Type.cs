using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Migrations
{
    [Migration(4)]
    public class _004_Ticket_and_Type : Migration
    {
        public override void Down()
        {
            Delete.Table("BiletTurleri");
            Delete.Table("Biletler");
        }

        public override void Up()
        {
            Create.Table("BiletTurleri")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("BiletTur").AsString(128)
                .WithColumn("Fiyat").AsInt32();

            Create.Table("Biletler")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("SatisTarihi").AsTime()
                .WithColumn("KoltukNo").AsString(128)
                .WithColumn("BiletTurID").AsInt32().ForeignKey("BiletTurleri", "ID")
                .WithColumn("SeansID").AsInt32().ForeignKey("Seanslar", "ID")
                .WithColumn("KullaniciID").AsInt32().ForeignKey("Kullanicilar", "ID");



        }
    }
}