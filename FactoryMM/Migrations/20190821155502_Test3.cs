using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FactoryMM.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Increament",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 1,
                column: "JoiningDate",
                value: new DateTime(2019, 8, 21, 21, 55, 1, 273, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 2,
                column: "JoiningDate",
                value: new DateTime(2019, 8, 21, 21, 55, 1, 274, DateTimeKind.Local).AddTicks(5254));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Increament",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 1,
                column: "JoiningDate",
                value: new DateTime(2019, 8, 10, 20, 30, 44, 67, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 2,
                column: "JoiningDate",
                value: new DateTime(2019, 8, 10, 20, 30, 44, 68, DateTimeKind.Local).AddTicks(5031));
        }
    }
}
