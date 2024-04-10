using Microsoft.EntityFrameworkCore.Migrations;

namespace LamBaiTap5.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Websites",
                columns: table => new
                {
                    STT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    WebSitee = table.Column<string>(nullable: true),
                    SoLuong = table.Column<int>(nullable: false),
                    TrangThai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Websites", x => x.STT);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Websites");
        }
    }
}
