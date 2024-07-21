using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitiazlizeUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 11, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 1, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 6, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 16, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 4, 7, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 6, 6, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 4, 27, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2024, 4, 17, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2024, 7, 17, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2024, 5, 4, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2024, 7, 21, 9, 47, 1, 358, DateTimeKind.Local).AddTicks(200));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");

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
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "ProductCommentId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2024, 7, 14, 13, 6, 10, 455, DateTimeKind.Local).AddTicks(8025));

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
    }
}
