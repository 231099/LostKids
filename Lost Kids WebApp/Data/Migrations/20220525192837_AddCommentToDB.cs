using Microsoft.EntityFrameworkCore.Migrations;

namespace Lost_Kids_WebApp.Data.Migrations
{
    public partial class AddCommentToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "SubComments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "MainComments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "SubComments");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "MainComments");
        }
    }
}
