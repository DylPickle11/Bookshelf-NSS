using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf.Migrations
{
    public partial class Add_Dummy_Sandwiches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "d6570caf-a0e1-4f9e-8b9d-be3bc6711e62", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELnatfwl/rbCSxKiH+20pJiD4VPNjhxnoEyY2RPeQhM55mJ+hkaSwr4wWeQJCIPQhw==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[] { 3, "00000000-ffff-ffff-ffff-ffffffffffff", "Jimmy John" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[] { 4, "00000000-ffff-ffff-ffff-ffffffffffff", "Jersey Mike" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[] { 5, "00000000-ffff-ffff-ffff-ffffffffffff", "Jared Fogel" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "GenreId", "Rating", "Title", "YearPublished" },
                values: new object[] { 4, null, 3, "Sandwiches", 0, 10, "Free Smells", 1990 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "GenreId", "Rating", "Title", "YearPublished" },
                values: new object[] { 5, null, 4, "Sandwiches", 0, 1, "Jersey Subs", 2020 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "GenreId", "Rating", "Title", "YearPublished" },
                values: new object[] { 6, null, 5, "Instructional", 0, 0, "How to make a prison sandiwich", 2015 });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[] { 2, "00000000-ffff-ffff-ffff-ffffffffffff", 4, "What even is Jimmy Johns" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 5, "It smells like Jersey" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[] { 3, "00000000-ffff-ffff-ffff-ffffffffffff", 6, "how did he write this book" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff");
        }
    }
}
