using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kiemtra90.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hanghoa",
                columns: table => new
                {
                    HH_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HH_NHH_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    HH_MA = table.Column<string>(type: "TEXT", nullable: false),
                    HH_TEN = table.Column<string>(type: "TEXT", nullable: false),
                    HH_GIANHAP = table.Column<decimal>(type: "TEXT", nullable: false),
                    HH_GIABAN = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hanghoa", x => x.HH_ID);
                });

            migrationBuilder.CreateTable(
                name: "Nhomhanghoa",
                columns: table => new
                {
                    NHH_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NHH_Ma = table.Column<string>(type: "TEXT", nullable: false),
                    NHH_Ten = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhomhanghoa", x => x.NHH_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hanghoa");

            migrationBuilder.DropTable(
                name: "Nhomhanghoa");
        }
    }
}
