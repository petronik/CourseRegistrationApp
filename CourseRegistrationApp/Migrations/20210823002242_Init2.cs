using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistrationApp.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_C_CourseId",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_C_CourseId",
                table: "Students",
                column: "C_CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_C_CourseId",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_C_CourseId",
                table: "Students",
                column: "C_CourseId",
                unique: true);
        }
    }
}
