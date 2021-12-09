using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.StockAPI.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropColumn(
                name: "StockExchange",
                table: "StockPrice");

            migrationBuilder.RenameColumn(
                name: "PriceStock",
                table: "StockPrice",
                newName: "CurrentStockPrice");

            migrationBuilder.AddColumn<string>(
                name: "StockExchangeId",
                table: "StockPrice",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_StockExchangeId",
                table: "StockPrice",
                column: "StockExchangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockPrice_StockExchange_StockExchangeId",
                table: "StockPrice",
                column: "StockExchangeId",
                principalTable: "StockExchange",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockPrice_StockExchange_StockExchangeId",
                table: "StockPrice");

            migrationBuilder.DropIndex(
                name: "IX_StockPrice_StockExchangeId",
                table: "StockPrice");

            migrationBuilder.DropColumn(
                name: "StockExchangeId",
                table: "StockPrice");

            migrationBuilder.RenameColumn(
                name: "CurrentStockPrice",
                table: "StockPrice",
                newName: "PriceStock");

            migrationBuilder.AddColumn<string>(
                name: "StockExchange",
                table: "StockPrice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });
        }
    }
}
