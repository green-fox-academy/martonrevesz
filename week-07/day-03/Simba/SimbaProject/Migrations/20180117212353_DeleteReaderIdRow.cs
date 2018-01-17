using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SimbaProject.Migrations
{
    public partial class DeleteReaderIdRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Readers_ReaderId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ReaderId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ReaderId",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReaderId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_ReaderId",
                table: "Books",
                column: "ReaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Readers_ReaderId",
                table: "Books",
                column: "ReaderId",
                principalTable: "Readers",
                principalColumn: "ReaderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
