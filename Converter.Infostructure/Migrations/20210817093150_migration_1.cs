using Microsoft.EntityFrameworkCore.Migrations;

namespace Converter.Infostructure.Migrations
{
    public partial class migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrencyConverters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstCurrency = table.Column<string>(type: "TEXT", nullable: true),
                    SecondCurrency = table.Column<string>(type: "TEXT", nullable: true),
                    FirstSum = table.Column<double>(type: "REAL", nullable: false),
                    SecondSum = table.Column<double>(type: "REAL", nullable: false),
                    Date = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyConverters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrencyConverters");
        }
    }
}
