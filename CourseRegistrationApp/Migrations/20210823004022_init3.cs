using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistrationApp.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    C_CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    C_CourseNumber = table.Column<int>(type: "int", nullable: false),
                    C_CourseName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    C_CourseDescrip = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.C_CourseId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    I_FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    C_CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Courses_C_CourseId",
                        column: x => x.C_CourseId,
                        principalTable: "Courses",
                        principalColumn: "C_CourseId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    S_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    C_CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.S_Id);
                    table.ForeignKey(
                        name: "FK_Students_Courses_C_CourseId",
                        column: x => x.C_CourseId,
                        principalTable: "Courses",
                        principalColumn: "C_CourseId",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "C_CourseId", "C_CourseDescrip", "C_CourseName", "C_CourseNumber" },
                values: new object[,]
                {
                    { 101, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Homeopathy", 2400 },
                    { 102, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Astrology", 2410 },
                    { 103, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Programming", 2420 },
                    { 104, "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", "Mathematics", 2430 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "I_Id", "C_CourseId", "I_Email", "I_FirstName", "I_LastName" },
                values: new object[,]
                {
                    { 2501, 101, "johndoe@gmail.com", "John", "Doe" },
                    { 2503, 102, "paulfisher@gmail.com", "Paul", "Fisher" },
                    { 2504, 103, "simonhil@gmail.com", "Simon", "Hill" },
                    { 2502, 104, "bellamandella@gmail.com", "Bella", "Mandella" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "S_Id", "C_CourseId", "S_Email", "S_FirstName", "S_LastName", "S_PhoneNumber" },
                values: new object[,]
                {
                    { 3102, 102, "ringoStarr@gmail.com", "Ringo", "Starr", "987-233-7755" },
                    { 3104, 102, "georgeharrison@gmail.com", "Geordge", "Harrison", "233-342-7754" },
                    { 3105, 103, "stevenLenon@gmail.com", "Steven", "Lenon", "123-456-67890" },
                    { 3106, 103, "rogerStarr@gmail.com", "Roger", "Starr", "987-233-7755" },
                    { 3107, 103, "bobmccartney@gmail.com", "Bob", "McCartney", "321-654-4532" },
                    { 3108, 103, "briantharrison@gmail.com", "Briant", "Harrison", "233-342-7754" },
                    { 3101, 104, "johnLenon@gmail.com", "John", "Lenon", "123-456-67890" },
                    { 3103, 104, "paulmccartney@gmail.com", "Paul", "McCartney", "321-654-4532" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_C_CourseId",
                table: "Instructors",
                column: "C_CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_C_CourseId",
                table: "Students",
                column: "C_CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
