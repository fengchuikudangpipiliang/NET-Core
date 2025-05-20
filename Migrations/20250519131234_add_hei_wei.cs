using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET_Core.Migrations
{
    /// <inheritdoc />
    public partial class add_hei_wei : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "T_Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "T_Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "T_Persons");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "T_Persons");
        }
    }
}
