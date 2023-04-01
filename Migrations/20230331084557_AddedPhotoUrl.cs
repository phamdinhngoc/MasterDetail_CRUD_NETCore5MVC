using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterDetail_CRUD_NETCore5MVC.Migrations
{
    public partial class AddedPhotoUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Applicants");
        }
    }
}
