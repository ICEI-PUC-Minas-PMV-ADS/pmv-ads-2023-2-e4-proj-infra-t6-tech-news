using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IngressoFacil.Catalog.API.Infrastructure.Migrations
{
    public partial class AddDateProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Sessions",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Sessions");
        }
    }
}
