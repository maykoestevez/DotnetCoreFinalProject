using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProjectApi.Migrations
{
    public partial class changingColumnRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role",
                table: "user",
                newName: "is_admin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "is_admin",
                table: "user",
                newName: "role");
        }
    }
}
