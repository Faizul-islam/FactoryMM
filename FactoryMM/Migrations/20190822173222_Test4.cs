using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FactoryMM.Migrations
{
    public partial class Test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatInvId",
                table: "Productions");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Productions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "HDPE",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LDPE",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PP",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProdHour",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProdQuantity",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "T2OB",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "T2OR",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "T2OY",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Thinner",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Wastage",
                table: "Productions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 1,
                column: "JoiningDate",
                value: new DateTime(2019, 8, 22, 23, 32, 22, 73, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 2,
                column: "JoiningDate",
                value: new DateTime(2019, 8, 22, 23, 32, 22, 74, DateTimeKind.Local).AddTicks(5665));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "HDPE",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "LDPE",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "PP",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "ProdHour",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "ProdQuantity",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "T2OB",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "T2OR",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "T2OY",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "Thinner",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "Wastage",
                table: "Productions");

            migrationBuilder.AddColumn<int>(
                name: "MatInvId",
                table: "Productions",
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
    }
}
