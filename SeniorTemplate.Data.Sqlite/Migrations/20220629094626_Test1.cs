using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeniorTemplate.Data.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("023f9bec-d736-4c54-94e8-69257af821e2"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("18b4a333-c4d9-4604-b816-71dce6cd6c67"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("55672e16-310a-49c4-a87e-5c429cc783e2"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("60e8efd0-8f74-49a2-895b-35913a9f05cb"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("6784be54-7648-469a-b158-f1e1affff931"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("8b015cb5-ffaa-4efe-a9b3-160c3e7bf1da"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("ab874d21-0824-4b43-a65d-7fd31a05f5af"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("c35abbae-4191-4541-8304-3dd071a7cd2c"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("c6b2e090-be68-4f3c-96c0-c62670b44934"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("dcfdfe8b-d61e-49e9-aa0a-bdf113a4f841"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("e3e61b63-f384-4a35-a163-7bde25af7c38"));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c4837a69-90c9-425a-8c39-f569e669bfc6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b6b183d1-c8ab-491a-8370-51d205d2ad05");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Registered", "SecurityStamp" },
                values: new object[] { "8f2c301a-77f6-4756-a97e-642274189c06", "AQAAAAEAACcQAAAAEG1N8nLfgGXAtY+27lBY5u4jjIeGCxCPtHne2qW+Yo65mfva7H819QEFXxPA954LKA==", new DateTime(2022, 6, 29, 9, 46, 25, 945, DateTimeKind.Utc).AddTicks(9081), "99b8df4f-4266-4851-85ee-5a2453f4ae70" });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("056ac5af-30a6-4008-bdfe-17146ed91d6f"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1639), "Big Sur Tea", 25m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("09c45f25-bfd4-4340-93a9-8a2ab708d92c"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1642), "Dragonwell", 30m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("387a1501-cf68-4d64-945c-c616d071ab56"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1648), "White Peach Tea", 29m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("4c619acc-8b4b-4c61-a6c7-df965950df19"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1650), "Chaga Chai Mushroom Tea", 20m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("4d3275de-88c9-446d-b0cf-26e9f1879d22"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1640), "Jasmine Pearls", 41m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("5401fde4-68a6-4f42-9df5-71826b6d2bb1"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1651), "Naked Pu-erh Tea", 27m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("7a28ddd4-c32d-42ea-804a-22541d9d3823"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1636), "English Breakfast Tea", 18m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("8634eb25-4064-4edf-a5ca-733b7067c5ac"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1638), "Big Sur Tea", 25m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("bffacc17-0a97-41f8-ab91-b977f8be324b"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1649), "Vanilla Berry Tea", 21m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("f37435af-3dfe-44ff-8775-91ac440e2910"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1634), "Rose Tea", 20m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("ff57d179-490c-493a-bae5-407ff6eee180"), new DateTime(2022, 6, 29, 9, 46, 25, 958, DateTimeKind.Utc).AddTicks(1014), "Earl Gray", 20m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("056ac5af-30a6-4008-bdfe-17146ed91d6f"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("09c45f25-bfd4-4340-93a9-8a2ab708d92c"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("387a1501-cf68-4d64-945c-c616d071ab56"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("4c619acc-8b4b-4c61-a6c7-df965950df19"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("4d3275de-88c9-446d-b0cf-26e9f1879d22"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("5401fde4-68a6-4f42-9df5-71826b6d2bb1"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("7a28ddd4-c32d-42ea-804a-22541d9d3823"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("8634eb25-4064-4edf-a5ca-733b7067c5ac"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("bffacc17-0a97-41f8-ab91-b977f8be324b"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("f37435af-3dfe-44ff-8775-91ac440e2910"));

            migrationBuilder.DeleteData(
                table: "Teas",
                keyColumn: "Id",
                keyValue: new Guid("ff57d179-490c-493a-bae5-407ff6eee180"));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "64c2b083-c54b-4d9f-ba16-1294ec1ceafa");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fdb2e068-85b3-4108-9830-3eb52c04f702");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Registered", "SecurityStamp" },
                values: new object[] { "777fd44b-5dde-4356-928e-654ff5840563", "AQAAAAEAACcQAAAAEMhMB5TD25L/FkonrYU9upx8wfsDCWCAD97/kNIhgkPcXvOuzoCJxe5L+fbPffZpmQ==", new DateTime(2022, 6, 19, 19, 42, 43, 802, DateTimeKind.Utc).AddTicks(6995), "5060a0f8-d33e-4f98-a6ab-16e61ea03c1e" });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("023f9bec-d736-4c54-94e8-69257af821e2"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5666), "Naked Pu-erh Tea", 27m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("18b4a333-c4d9-4604-b816-71dce6cd6c67"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5665), "Chaga Chai Mushroom Tea", 20m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("55672e16-310a-49c4-a87e-5c429cc783e2"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5649), "Rose Tea", 20m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("60e8efd0-8f74-49a2-895b-35913a9f05cb"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5654), "Big Sur Tea", 25m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("6784be54-7648-469a-b158-f1e1affff931"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5663), "White Peach Tea", 29m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("8b015cb5-ffaa-4efe-a9b3-160c3e7bf1da"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5664), "Vanilla Berry Tea", 21m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("ab874d21-0824-4b43-a65d-7fd31a05f5af"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5653), "Big Sur Tea", 25m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("c35abbae-4191-4541-8304-3dd071a7cd2c"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5662), "Dragonwell", 30m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("c6b2e090-be68-4f3c-96c0-c62670b44934"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(4869), "Earl Gray", 20m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("dcfdfe8b-d61e-49e9-aa0a-bdf113a4f841"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5652), "English Breakfast Tea", 18m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("e3e61b63-f384-4a35-a163-7bde25af7c38"), new DateTime(2022, 6, 19, 19, 42, 43, 814, DateTimeKind.Utc).AddTicks(5661), "Jasmine Pearls", 41m, null });
        }
    }
}
