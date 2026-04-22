using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRenterBirthYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Renters",
                newName: "BirthYear");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthYear",
                table: "Renters",
                newName: "Age");
        }
    }
}
