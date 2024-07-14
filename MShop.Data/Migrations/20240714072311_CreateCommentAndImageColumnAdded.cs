using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateCommentAndImageColumnAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "ProductImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "ProductComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductComments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ProductComments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 1,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6340), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 2,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6345), true, null });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 3,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6346), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 1,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6295), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 2,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6300), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 3,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6302), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 4,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6303), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 5,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6304), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 6,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6305), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 7,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6306), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 8,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6307), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 9,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6308), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 10,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6310), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 11,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6311), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 12,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6312), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 13,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6312), true, null });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 14,
                columns: new[] { "CreationDate", "IsActive", "Order" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6313), true, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 4, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 6, 24, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 6, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 9, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 31, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 5, 30, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 4, 20, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 4, 10, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 7, 10, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 4, 27, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6177));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "ProductComments");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductComments");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "ProductComments");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 4, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 6, 24, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 6, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 9, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 31, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 5, 30, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 4, 20, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 4, 10, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 7, 10, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 4, 27, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 8, 59, 52, 541, DateTimeKind.Local).AddTicks(9031));
        }
    }
}
