using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateCreaDateAndIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Sliders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9880), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9896), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9898), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9900), true });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 1,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9944), true });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 2,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9949), true });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 3,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9951), true });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 4,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9952), true });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 5,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9954), true });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 6,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9957), true });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 7,
                columns: new[] { "CreationDate", "IsActive" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 11, 7, 599, DateTimeKind.Local).AddTicks(9958), true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Information", "MainDescription", "MarketPrice", "Order", "Price", "ProductName", "StockQuantity" },
                values: new object[] { 1, 1, "", "", "", 7.00m, null, 10.00m, "siyah tişört", (short)30 });
        }
    }
}
