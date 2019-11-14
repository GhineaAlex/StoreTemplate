using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HeadphonesStore.Migrations
{
    public partial class test0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "headphones",
                columns: table => new
                {
                    HeadphonesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageHumbnailUrl = table.Column<string>(nullable: true),
                    PopularHeadphones = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_headphones", x => x.HeadphonesId);
                    table.ForeignKey(
                        name: "FK_headphones_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "In-Ear", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "On-Ear", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Overhead", null });

            migrationBuilder.InsertData(
                table: "headphones",
                columns: new[] { "HeadphonesId", "CategoryId", "Description", "ImageHumbnailUrl", "ImageUrl", "InStock", "Name", "PopularHeadphones", "Price" },
                values: new object[] { 2, 1, "", "https://www.sony.ro/image/53d5d860b293bac0afad1a5181e6e02a?fmt=pjpeg&wid=165&bgcolor=FFFFFF&bgc=FFFFFF", "https://www.sony.ro/image/888927839ebfd97a069947fff3642c85?fmt=png-alpha&wid=720", true, "Sony WF-1000XM3", true, 63.4m });

            migrationBuilder.InsertData(
                table: "headphones",
                columns: new[] { "HeadphonesId", "CategoryId", "Description", "ImageHumbnailUrl", "ImageUrl", "InStock", "Name", "PopularHeadphones", "Price" },
                values: new object[] { 3, 2, "", "https://s12emagst.akamaized.net/products/17615/17614584/images/res_51d859e1a2a77e187ecd0a45f6b680c6_80x80_rah.jpg", "https://s12emagst.akamaized.net/products/17615/17614584/images/res_51d859e1a2a77e187ecd0a45f6b680c6_450x450_b05e.jpg", true, "JBL Tune 500 BT", true, 34.4m });

            migrationBuilder.InsertData(
                table: "headphones",
                columns: new[] { "HeadphonesId", "CategoryId", "Description", "ImageHumbnailUrl", "ImageUrl", "InStock", "Name", "PopularHeadphones", "Price" },
                values: new object[] { 1, 3, "Over head phones", "data:image/jpeg;base64,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", "https://assets.sennheiser.com/img/18209/product_detail_x2_desktop_HD_559_Sennheiser_01.jpg", true, "Sennheiser HD559", true, 123.4m });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_headphones_CategoryId",
                table: "headphones",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "headphones");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
