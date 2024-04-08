using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations.EmployeeDb
{
    /// <inheritdoc />
    public partial class EmployeeContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    HireDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAddresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address1 = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    Address2 = table.Column<string>(type: "TEXT", maxLength: 35, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    State = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAddresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_EmployeeAddresses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePhones",
                columns: table => new
                {
                    PhoneNumberId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhoneType = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePhones", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_EmployeePhones_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAddresses_EmployeeId",
                table: "EmployeeAddresses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePhones_EmployeeId",
                table: "EmployeePhones",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeAddresses");

            migrationBuilder.DropTable(
                name: "EmployeePhones");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
