using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf.Migrations
{
    public partial class Books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e8c723f-0c72-4279-ba79-738db01e6f74", "AQAAAAEAACcQAAAAEBGqC/0kocjCtWomOi6uj6tEnht4H2uY9k1rlOAqB3gN9nTIY76SEY1tBgkaMePB2Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76fd536b-cffd-4b83-8159-5db7ab86d4eb", "AQAAAAEAACcQAAAAEA3SKsJqSS04Bg89SmLQN385JtI5Sb6QhUYzLBqWhigdfs/Mmc7JgHwrfo/ddv3/xg==" });
        }
    }
}
