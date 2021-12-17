using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.StockAPI.Migrations
{
    public partial class mighr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "StockPrice");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "StockPrice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "StockPrice",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "StockPrice");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "StockPrice");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "StockPrice",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
