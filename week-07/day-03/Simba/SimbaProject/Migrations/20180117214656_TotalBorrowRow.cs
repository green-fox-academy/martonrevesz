using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SimbaProject.Migrations
{
    public partial class TotalBorrowRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalBorrow",
                table: "Readers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalBorrow",
                table: "Readers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
