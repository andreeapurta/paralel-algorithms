using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentProj_EntityFramework.Migrations
{
    public partial class rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Specialitate",
                table: "Students",
                newName: "Department");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Students",
                newName: "Specialitate");
        }
    }
}
