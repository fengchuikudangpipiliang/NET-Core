using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET_Core.Migrations
{
    /// <inheritdoc />
    public partial class Add_BirtPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "T_Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "T_Persons");
        }
    }
}
