using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicSystem.Dal.Migrations
{
    public partial class CorrecaoUserProfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentityId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "IdentityId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IdentityId",
                table: "Coordinator");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityId",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityId",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityId",
                table: "Coordinator",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
