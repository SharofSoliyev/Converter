using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Converter.Infostructure.Migrations
{
    public partial class migration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrencyConverters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstCurrencyId = table.Column<int>(type: "int", nullable: false),
                    SecondCurrencyId = table.Column<int>(type: "int", nullable: false),
                    FirstSum = table.Column<double>(type: "float", nullable: false),
                    SecondSum = table.Column<double>(type: "float", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyConverters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrencyConverters_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyConverters_CurrencyId",
                table: "CurrencyConverters",
                column: "CurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrencyConverters");
        }
    }
}
