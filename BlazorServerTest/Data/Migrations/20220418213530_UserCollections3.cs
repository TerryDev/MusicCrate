using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerTest.Data.Migrations
{
    public partial class UserCollections3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCollectionMembers_UserCollections_CollectionId",
                table: "UserCollectionMembers");

            migrationBuilder.RenameColumn(
                name: "CollectionId",
                table: "UserCollectionMembers",
                newName: "UserCollectionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCollectionMembers_CollectionId",
                table: "UserCollectionMembers",
                newName: "IX_UserCollectionMembers_UserCollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCollectionMembers_UserCollections_UserCollectionId",
                table: "UserCollectionMembers",
                column: "UserCollectionId",
                principalTable: "UserCollections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCollectionMembers_UserCollections_UserCollectionId",
                table: "UserCollectionMembers");

            migrationBuilder.RenameColumn(
                name: "UserCollectionId",
                table: "UserCollectionMembers",
                newName: "CollectionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCollectionMembers_UserCollectionId",
                table: "UserCollectionMembers",
                newName: "IX_UserCollectionMembers_CollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCollectionMembers_UserCollections_CollectionId",
                table: "UserCollectionMembers",
                column: "CollectionId",
                principalTable: "UserCollections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
