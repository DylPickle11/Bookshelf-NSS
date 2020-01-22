using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf.Migrations
{
    public partial class Phil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebac97d8-af03-46af-ae70-8d5f493fa5bf", "AQAAAAEAACcQAAAAEEfx9i7BL5K0XUcjDk9hDDRfvnGtLWVEKTqckQ9AyboNRHu9um7MLJlSMuCi6ni00Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6570caf-a0e1-4f9e-8b9d-be3bc6711e62", "AQAAAAEAACcQAAAAELnatfwl/rbCSxKiH+20pJiD4VPNjhxnoEyY2RPeQhM55mJ+hkaSwr4wWeQJCIPQhw==" });
        }
    }
}
