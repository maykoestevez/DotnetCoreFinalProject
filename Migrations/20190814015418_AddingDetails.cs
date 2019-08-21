using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProjectApi.Migrations
{
    public partial class AddingDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "details",
                table: "product",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "details",
                table: "product");
        }
    }
}
