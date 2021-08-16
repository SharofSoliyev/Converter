using Microsoft.EntityFrameworkCore.Migrations;

namespace Converter.Infostructure.Migrations
{
    public partial class migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ccy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CcyNm_RU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CcyNm_UZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CcyNm_UZC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CcyNm_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nominal = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Diff = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
