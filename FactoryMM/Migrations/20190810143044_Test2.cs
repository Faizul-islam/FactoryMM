using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FactoryMM.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReturnSelses",
                columns: table => new
                {
                    SaleReturnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProdInvId = table.Column<int>(nullable: false),
                    CustId = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ErturnDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnSelses", x => x.SaleReturnId);
                });

            migrationBuilder.CreateTable(
                name: "Saleses",
                columns: table => new
                {
                    SaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpId = table.Column<int>(nullable: false),
                    CustOrderId = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Paid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Due = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saleses", x => x.SaleId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReturnSelses");

            migrationBuilder.DropTable(
                name: "Saleses");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 1,
                column: "JoiningDate",
                value: new DateTime(2019, 8, 9, 9, 19, 24, 840, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpId",
                keyValue: 2,
                column: "JoiningDate",
                value: new DateTime(2019, 8, 9, 9, 19, 24, 841, DateTimeKind.Local).AddTicks(7256));
        }
    }
}
