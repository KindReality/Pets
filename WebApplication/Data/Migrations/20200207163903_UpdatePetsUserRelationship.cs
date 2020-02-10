using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Data.Migrations
{
    public partial class UpdatePetsUserRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomIdentityUserID",
                table: "Pets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_CustomIdentityUserID",
                table: "Pets",
                column: "CustomIdentityUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_AspNetUsers_CustomIdentityUserID",
                table: "Pets",
                column: "CustomIdentityUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_AspNetUsers_CustomIdentityUserID",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_CustomIdentityUserID",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "CustomIdentityUserID",
                table: "Pets");
        }
    }
}
