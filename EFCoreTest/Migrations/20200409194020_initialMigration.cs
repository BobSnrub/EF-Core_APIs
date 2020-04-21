using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTest.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "puppyPosts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    price = table.Column<string>(nullable: true),
                    dateBorn = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    coat = table.Column<string>(nullable: true),
                    eyes = table.Column<string>(nullable: true),
                    imgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_puppyPosts", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "puppyPosts",
                columns: new[] { "id", "coat", "dateBorn", "description", "eyes", "imgUrl", "name", "price" },
                values: new object[] { 1, "blue merle", "12/12/2020", "Ugly", "blue", "https://www.idontgiveoneshit.com/someimg", "Sniffy", "2000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "puppyPosts");
        }
    }
}
