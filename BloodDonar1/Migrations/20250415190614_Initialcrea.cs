using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodDonar1.Migrations
{
    /// <inheritdoc />
    public partial class Initialcrea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BloodType",
                table: "BloodDonar1s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodType",
                table: "BloodDonar1s");
        }
    }
}
