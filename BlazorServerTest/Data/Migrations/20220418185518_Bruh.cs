﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerTest.Data.Migrations
{
    public partial class Bruh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserCollectionId",
                table: "UserCollectionMembers",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserCollectionMembers",
                newName: "UserCollectionId");
        }
    }
}
