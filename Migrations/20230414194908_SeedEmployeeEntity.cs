using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRM01.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "City", "Country", "CreatedBy", "CreatedDate", "DesignationId", "DisplayId", "JoinDate", "ModifiedBy", "ModifiedDate", "Name", "RoleId", "Skills", "SupervisorId", "Union" },
                values: new object[,]
                {
                    { 1L, null, null, 1L, new DateTime(2023, 4, 15, 1, 19, 8, 367, DateTimeKind.Local).AddTicks(6541), null, "Test001", null, 1L, new DateTime(2023, 4, 15, 1, 19, 8, 367, DateTimeKind.Local).AddTicks(6549), "Miller Cake", null, null, null, null },
                    { 2L, null, null, 1L, new DateTime(2023, 4, 15, 1, 19, 8, 367, DateTimeKind.Local).AddTicks(6552), null, "Test002", null, 1L, new DateTime(2023, 4, 15, 1, 19, 8, 367, DateTimeKind.Local).AddTicks(6553), "Gram Bell", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
