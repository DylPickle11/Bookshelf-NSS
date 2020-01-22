using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf.Migrations
{
    public partial class Real_Dummy_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76fd536b-cffd-4b83-8159-5db7ab86d4eb", "AQAAAAEAACcQAAAAEA3SKsJqSS04Bg89SmLQN385JtI5Sb6QhUYzLBqWhigdfs/Mmc7JgHwrfo/ddv3/xg==" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "ApplicationUserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "ApplicationUserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "ApplicationUserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebac97d8-af03-46af-ae70-8d5f493fa5bf", "AQAAAAEAACcQAAAAEEfx9i7BL5K0XUcjDk9hDDRfvnGtLWVEKTqckQ9AyboNRHu9um7MLJlSMuCi6ni00Q==" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "ApplicationUserId",
                value: null);
        }
    }
}
