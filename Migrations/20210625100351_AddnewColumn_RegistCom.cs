using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApp.Migrations
{
    public partial class AddnewColumn_RegistCom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "RegistCom",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "RegistCom");
        }
    }
}
