using Microsoft.EntityFrameworkCore.Migrations;

namespace Lost_Kids_WebApp.Data.Migrations
{
    public partial class AddCommentToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainComments_Posts_PostId",
                table: "MainComments");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "MainComments",
                newName: "Postid");

            migrationBuilder.RenameIndex(
                name: "IX_MainComments_PostId",
                table: "MainComments",
                newName: "IX_MainComments_Postid");

            migrationBuilder.AddColumn<int>(
                name: "Postid",
                table: "SubComments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Postid",
                table: "MainComments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MainComments_Posts_Postid",
                table: "MainComments",
                column: "Postid",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainComments_Posts_Postid",
                table: "MainComments");

            migrationBuilder.DropColumn(
                name: "Postid",
                table: "SubComments");

            migrationBuilder.RenameColumn(
                name: "Postid",
                table: "MainComments",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_MainComments_Postid",
                table: "MainComments",
                newName: "IX_MainComments_PostId");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "MainComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MainComments_Posts_PostId",
                table: "MainComments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
