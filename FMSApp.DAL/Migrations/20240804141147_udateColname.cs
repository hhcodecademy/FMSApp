using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMSApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class udateColname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numer",
                table: "Players",
                newName: "Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Players",
                newName: "Numer");
        }
    }
}
