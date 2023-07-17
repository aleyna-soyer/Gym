using Microsoft.EntityFrameworkCore.Migrations;

namespace GymApp.Migrations
{
    public partial class manager_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "USerName",
                table: "managers",
                newName: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "managers",
                newName: "USerName");
        }
    }
}
