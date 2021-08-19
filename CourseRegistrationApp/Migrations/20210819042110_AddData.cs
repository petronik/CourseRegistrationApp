using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistrationApp.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "C_CourseId", "C_CourseDescrip", "C_CourseName", "C_CourseNumber", "StudentsS_Id" },
                values: new object[,]
                {
                    { 101, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Homeopathy", 2400, null },
                    { 102, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Astrology", 2410, null },
                    { 103, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Programming", 2420, null },
                    { 104, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Mathematics", 2430, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "S_Id", "C_CourseId", "S_Email", "S_FirstName", "S_LastName", "S_PhoneNumber" },
                values: new object[,]
                {
                    { 3101, 104, "johnLenon@gmail.com", "John", "Lenon", "123-456-67890" },
                    { 3102, 102, "ringoStarr@gmail.com", "Ringo", "Starr", "987-233-7755" },
                    { 3103, 104, "paulmccartney@gmail.com", "Paul", "McCartney", "321-654-4532" },
                    { 3104, 102, "georgeharrison@gmail.com", "Geordge", "Harrison", "233-342-7754" },
                    { 3105, 103, "stevenLenon@gmail.com", "Steven", "Lenon", "123-456-67890" },
                    { 3106, 103, "rogerStarr@gmail.com", "Roger", "Starr", "987-233-7755" },
                    { 3107, 103, "bobmccartney@gmail.com", "Bob", "McCartney", "321-654-4532" },
                    { 3108, 103, "briantharrison@gmail.com", "Briant", "Harrison", "233-342-7754" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "C_CourseId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "C_CourseId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "C_CourseId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "C_CourseId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3105);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3107);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "S_Id",
                keyValue: 3108);
        }
    }
}
