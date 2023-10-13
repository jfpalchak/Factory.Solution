using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class AddStatusWithValidationForEngineer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Engineers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Engineers");
        }
    }
}
