using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApp.Migrations
{
    public partial class AddSubmision_RegistCom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Submision",
                table: "RegistCom",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Submision",
                table: "RegistCom");
        }
    }
}
