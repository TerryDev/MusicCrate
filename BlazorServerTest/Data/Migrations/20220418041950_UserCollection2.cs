using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerTest.Data.Migrations
{
    public partial class UserCollection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCollectionMembers_Albums_AlbumId",
                table: "UserCollectionMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCollectionMembers_Tracks_TrackId",
                table: "UserCollectionMembers");

            migrationBuilder.AlterColumn<int>(
                name: "TrackId",
                table: "UserCollectionMembers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AlbumId",
                table: "UserCollectionMembers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCollectionMembers_Albums_AlbumId",
                table: "UserCollectionMembers",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCollectionMembers_Tracks_TrackId",
                table: "UserCollectionMembers",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCollectionMembers_Albums_AlbumId",
                table: "UserCollectionMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCollectionMembers_Tracks_TrackId",
                table: "UserCollectionMembers");

            migrationBuilder.AlterColumn<int>(
                name: "TrackId",
                table: "UserCollectionMembers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlbumId",
                table: "UserCollectionMembers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCollectionMembers_Albums_AlbumId",
                table: "UserCollectionMembers",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCollectionMembers_Tracks_TrackId",
                table: "UserCollectionMembers",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
