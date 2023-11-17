using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "5932440c-2931-46df-a0d7-af70bb282166", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIb/peiEEfBxg3GpySCJU8osAI7NW8mLjLM1cgxADq7qCZ2RQdEYaJhyLj/Po5PJQQ==", null, false, "a581be3d-c4ec-468c-aace-4a356d584d9c", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(6453), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(6456), new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(6457), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(6811), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(6813), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(7019), new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(7020), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(7023), new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(7023), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(7024), new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(7025), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(7026), new DateTime(2023, 11, 17, 21, 14, 18, 94, DateTimeKind.Local).AddTicks(7027), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
