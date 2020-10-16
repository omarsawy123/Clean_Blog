using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog_App.Migrations
{
    public partial class Intial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    DatePublished = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1", "Sam" },
                    { "2", "John" },
                    { "3", "Mary" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorId", "Category", "Content", "DatePublished", "Name" },
                values: new object[,]
                {
                    { "1", 1, "Hardware", "First Content", "15/10/2020", "First Blog" },
                    { "2", 2, "Software", "Second Content", "15/10/2020", "Second Blog" },
                    { "3", 3, "Technology", "Third Content", "15/10/2020", "Third Blog" },
                    { "4", 3, "Technology", "Fourth Content", "15/10/2020", "Fourth Blog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
