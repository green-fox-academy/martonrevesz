using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SimbaProject.Migrations
{
    public partial class AddFieldsToReaderAndBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentBorrow",
                table: "Readers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalBorrow",
                table: "Readers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BorrowedCopies",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCopies",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentBorrow",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "TotalBorrow",
                table: "Readers");

            migrationBuilder.DropColumn(
                name: "BorrowedCopies",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TotalCopies",
                table: "Books");
        }
    }
}
