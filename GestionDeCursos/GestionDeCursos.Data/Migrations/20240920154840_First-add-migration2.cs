using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeCursos.Data.Migrations
{
    /// <inheritdoc />
    public partial class Firstaddmigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseDescription",
                schema: "Management",
                table: "Courses",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseDescription",
                schema: "Management",
                table: "Courses");
        }
    }
}
