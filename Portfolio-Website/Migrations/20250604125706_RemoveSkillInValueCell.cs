using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio_Website.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSkillInValueCell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Skills");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
