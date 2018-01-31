using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PallidaWareHouse.Migrations
{
    public partial class changeUnitPriceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "Clothes",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "UnitPrice",
                table: "Clothes",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
