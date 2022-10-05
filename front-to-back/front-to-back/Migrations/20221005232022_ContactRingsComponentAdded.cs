using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace front_to_back.Migrations
{
    public partial class ContactRingsComponentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "ContactRingsComponents",
                newName: "FilePath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "ContactRingsComponents",
                newName: "Icon");
        }
    }
}
