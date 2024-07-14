using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 1,
                columns: new[] { "CreationDate", "Rating" },
                values: new object[] { new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8014), (short)2 });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 2,
                columns: new[] { "CreationDate", "ProductId" },
                values: new object[] { new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8018), 1 });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 3,
                columns: new[] { "Comment", "CommenterName", "CreationDate", "ProductId", "Rating" },
                values: new object[] { "Fiyat kötü", "Tuğçe Toker", new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8020), 2, (short)3 });

            migrationBuilder.InsertData(
                table: "ProductComments",
                columns: new[] { "ProductCommentId", "Comment", "CommenterEmail", "CommenterName", "CreationDate", "IsActive", "Order", "ProductId", "Rating" },
                values: new object[,]
                {
                    { 4, "Ürün yani", "kaan@example.com", "Hande", new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8021), true, null, 2, (short)3 },
                    { 5, "Ürün yani", "haydaa@example.com", "Hande", new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8022), true, null, 3, (short)5 },
                    { 6, "Ürün çok zarif amakargo kötü", "urun@example.com", "Hande", new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8025), true, null, 3, (short)1 }
                });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 4, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 6, 24, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 6, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 9, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 3, 31, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 5, 30, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 4, 20, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 4, 10, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 7, 10, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 4, 27, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(7842));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 6);

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
                columns: new[] { "CreationDate", "Rating" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6340), (short)5 });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 2,
                columns: new[] { "CreationDate", "ProductId" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6345), 2 });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 3,
                columns: new[] { "Comment", "CommenterName", "CreationDate", "ProductId", "Rating" },
                values: new object[] { "Fiyat performans açısından çok iyi bir ürün.", "Ayşe Demir", new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6346), 3, (short)4 });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 10, 23, 10, 478, DateTimeKind.Local).AddTicks(6313));

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
    }
}
