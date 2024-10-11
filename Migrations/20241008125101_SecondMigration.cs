using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthenticationApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2131ceb0-9bad-4ee7-a97b-ad1ca80d21b0", null, "seller", "seller" },
                    { "253b18d5-a5ed-4a4d-9d58-3e4b81f8b900", null, "client", "client" },
                    { "7bf75bba-98c0-4f70-addc-d532018a2898", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2131ceb0-9bad-4ee7-a97b-ad1ca80d21b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "253b18d5-a5ed-4a4d-9d58-3e4b81f8b900");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf75bba-98c0-4f70-addc-d532018a2898");
        }
    }
}
