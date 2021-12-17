using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelAPI.Migrations
{
    public partial class migtn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    SectorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SectorName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "StockExchange",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    StockExchangeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Brief = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ContactAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockExchange", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StockPrice",
                columns: table => new
                {
                    PriceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CurrentStockPrice = table.Column<double>(type: "float", nullable: false),
                    StockExchangeId = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPrice", x => x.PriceId);
                    table.ForeignKey(
                        name: "FK_StockPrice_StockExchange_StockExchangeId",
                        column: x => x.StockExchangeId,
                        principalTable: "StockExchange",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyTurnOver = table.Column<float>(type: "real", nullable: false),
                    CEO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardOfDirectors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListedInStockExchanges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyBrief = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CompanyCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SectorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyName);
                    table.ForeignKey(
                        name: "FK_Company_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "SectorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_StockPrice_CompanyCode",
                        column: x => x.CompanyCode,
                        principalTable: "StockPrice",
                        principalColumn: "PriceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IPOList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockExchangeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerShare = table.Column<long>(type: "bigint", nullable: false),
                    TotalShare = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OpenDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPOList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPOList_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_CompanyCode",
                table: "Company",
                column: "CompanyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Company_SectorId",
                table: "Company",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_IPOList_CompanyId",
                table: "IPOList",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_StockExchangeId",
                table: "StockPrice",
                column: "StockExchangeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IPOList");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "StockPrice");

            migrationBuilder.DropTable(
                name: "StockExchange");
        }
    }
}
