using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentMagament.Migrations
{
    public partial class CreateStudentManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(maxLength: 40, nullable: false),
                    DateOfBirth = table.Column<int>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    classRoomClassId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_ClassRooms_classRoomClassId",
                        column: x => x.classRoomClassId,
                        principalTable: "ClassRooms",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "ClassId", "ClassName" },
                values: new object[,]
                {
                    { 1, "Toan Hoc" },
                    { 2, "Sinh Hoc" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassId", "DateOfBirth", "Email", "Gender", "StudentName", "classRoomClassId" },
                values: new object[,]
                {
                    { 1, 2, 2000, "duy.tran@gmail.com", true, "Duy Tran", null },
                    { 2, 1, 1999, "thanh.ho@gmail.com", true, "Thanh Ho", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_classRoomClassId",
                table: "Students",
                column: "classRoomClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ClassRooms");
        }
    }
}
