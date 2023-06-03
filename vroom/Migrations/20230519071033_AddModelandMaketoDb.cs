using Microsoft.EntityFrameworkCore.Migrations;

namespace vroom.Migrations
{
    public partial class AddModelandMaketoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Bikes",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "Bikes",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bikes",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "Bikes",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);
        }
    }
}
