using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32ae1e3f-22dc-4f55-9708-193120a21906", "c01605b8-2b54-4724-88c4-dde2575075b4", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "582f06da-7d97-4ce5-9b2a-057d1ae8e1ac", "67c9b64d-e98a-4368-af01-7449cb434258", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7ffd140-b6e3-47db-92fc-3ac2e1bbcd42", "8490bd06-64b5-4ce8-8481-361bb8caf01b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32ae1e3f-22dc-4f55-9708-193120a21906");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "582f06da-7d97-4ce5-9b2a-057d1ae8e1ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7ffd140-b6e3-47db-92fc-3ac2e1bbcd42");
        }
    }
}
