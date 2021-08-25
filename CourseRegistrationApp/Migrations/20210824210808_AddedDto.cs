using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistrationApp.Migrations
{
    public partial class AddedDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_C_CourseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_C_CourseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "C_CourseId",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "C_CourseId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3101,
                column: "C_CourseId",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3102,
                column: "C_CourseId",
                value: 102);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3103,
                column: "C_CourseId",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3104,
                column: "C_CourseId",
                value: 102);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3105,
                column: "C_CourseId",
                value: 103);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3106,
                column: "C_CourseId",
                value: 103);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3107,
                column: "C_CourseId",
                value: 103);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3108,
                column: "C_CourseId",
                value: 103);

            migrationBuilder.CreateIndex(
                name: "IX_Students_C_CourseId",
                table: "Students",
                column: "C_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_C_CourseId",
                table: "Students",
                column: "C_CourseId",
                principalTable: "Courses",
                principalColumn: "C_CourseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
