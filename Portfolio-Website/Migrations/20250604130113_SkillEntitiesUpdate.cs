using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio_Website.Migrations
{
    /// <inheritdoc />
    public partial class SkillEntitiesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SkillHead",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillHead",
                table: "Skills");
        }
    }
}
