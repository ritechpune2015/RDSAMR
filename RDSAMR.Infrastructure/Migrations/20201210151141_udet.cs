using Microsoft.EntityFrameworkCore.Migrations;

namespace RDSAMR.Infrastructure.Migrations
{
    public partial class udet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserTbl");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "UserTbl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "UserTbl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "UserTbl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "UserTbl");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "UserTbl");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "UserTbl");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserTbl",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
