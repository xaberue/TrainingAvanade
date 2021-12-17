using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Training.DAL.Migrations
{
    public partial class AddAlbumDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AlbumId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AlbumId",
                table: "Reservations",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Album_AlbumId",
                table: "Reservations",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Album_AlbumId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_AlbumId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Reservations");
        }
    }
}
