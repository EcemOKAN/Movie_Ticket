using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Ticket.Migrations
{
    [Migration(3)]
    public class _003_User_and_Roles : Migration
    {
        public override void Down()
        {
            Delete.Table("Roller");
            Delete.Table("Kullanicilar");
        }

        public override void Up()
        {
            Create.Table("Roller")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("Rol").AsString(128);

            Create.Table("Kullanicilar")
                .WithColumn("ID").AsInt32().Identity().PrimaryKey()
                .WithColumn("Ad").AsString(128)
                .WithColumn("Soyad").AsString(128)
                .WithColumn("Ceptel").AsString(11)
                .WithColumn("Email").AsCustom("VARCHAR(256)")
                .WithColumn("SifreHash").AsString(128)
                .WithColumn("RolID").AsInt32().ForeignKey("Roller", "ID");

        }
    }
}