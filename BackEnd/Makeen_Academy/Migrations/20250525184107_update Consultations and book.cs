using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makeen_Academy.Migrations
{
    /// <inheritdoc />
    public partial class updateConsultationsandbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "Consultations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "Consultations");
        }
    }
}
