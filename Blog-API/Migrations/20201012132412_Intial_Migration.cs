using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog_API.Migrations
{
    public partial class Intial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Specialty = table.Column<int>(nullable: false),
                    Blogs = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    DatePublished = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Blogs", "Name", "Specialty" },
                values: new object[,]
                {
                    { 1, 2, "Sam", 1 },
                    { 2, 2, "John", 2 },
                    { 3, 2, "Mary", 0 }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AuthorId", "Content", "DatePublished", "Title" },
                values: new object[,]
                {
                    { 1, 1, "First Content", new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Blog" },
                    { 2, 2, "Second Content", new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Blog" },
                    { 3, 3, "Third Content", new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Blog" }
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
