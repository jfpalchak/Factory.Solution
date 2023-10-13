using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class ChangeStatusToActiveTypeBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Engineers");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Engineers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Engineers");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Engineers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
