using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDepartmentApp.Migrations
{
    public partial class RenamePrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Did",
                table: "Departments",
                newName: "DepartmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Departments",
                newName: "Did");
        }
    }
}
