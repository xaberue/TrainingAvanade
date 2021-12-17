using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Training.DAL.Migrations
{
    public partial class InitialDbCreation_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AlbumId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AlbumId",
                table: "Books",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Albums_AlbumId",
                table: "Books",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Albums_AlbumId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Books_AlbumId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Books");
        }
    }
}
