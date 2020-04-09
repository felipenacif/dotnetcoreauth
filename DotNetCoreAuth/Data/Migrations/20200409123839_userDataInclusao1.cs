using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreAuth.Data.Migrations
{
    public partial class userDataInclusao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeInclusao",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeInclusao",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);
        }
    }
}
