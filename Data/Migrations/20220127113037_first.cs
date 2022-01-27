using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    CoverImage = table.Column<string>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true),
                    AuthorImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "AuthorImage", "AuthorName", "Category", "Content", "CoverImage", "Name" },
                values: new object[] { 1, "trainer-1.jpg", "Asdasd", "asdasd", "asdasd", "course-1.jpg", "sdfsdf" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "AuthorImage", "AuthorName", "Category", "Content", "CoverImage", "Name" },
                values: new object[] { 2, "trainer-1.jpg", "Asdasd", "asdasd", "asdasd", "course-1.jpg", "sdfsdf" });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "AuthorImage", "AuthorName", "Category", "Content", "CoverImage", "Name" },
                values: new object[] { 3, "trainer-1.jpg", "Asdasd", "asdasd", "asdasd", "course-1.jpg", "sdfsdf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
