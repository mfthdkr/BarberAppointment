using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Barbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    RatersCount = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barbers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Barbers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BarberId = table.Column<int>(type: "int", nullable: false),
                    Confirmed = table.Column<bool>(type: "bit", nullable: true),
                    IsSalonRatedByTheUser = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Barbers_BarberId",
                        column: x => x.BarberId,
                        principalTable: "Barbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "IsDeleted", "ModifiedOn", "Name", "NormalizedName" },
                values: new object[] { "35ca7aad-d2b3-49f4-ad0c-1fdbc2ed7ed8", "77b88ce9-3ae7-4dea-8f85-a0a777617006", new DateTime(2023, 3, 24, 0, 18, 37, 335, DateTimeKind.Local).AddTicks(9569), new DateTime(2023, 3, 24, 0, 18, 37, 335, DateTimeKind.Local).AddTicks(9579), "Role", false, new DateTime(2023, 3, 24, 0, 18, 37, 335, DateTimeKind.Local).AddTicks(9576), "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "945e695c-63f5-4554-ba69-163040cbb16a", 0, "bbe71cbd-9449-4b93-b5b9-dc2d8a1865d4", new DateTime(2023, 3, 24, 0, 18, 37, 430, DateTimeKind.Local).AddTicks(776), new DateTime(2023, 3, 24, 0, 18, 37, 430, DateTimeKind.Local).AddTicks(790), "user2@user.com", false, false, true, new DateTimeOffset(new DateTime(2023, 3, 23, 21, 18, 37, 430, DateTimeKind.Unspecified).AddTicks(766), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2023, 3, 24, 0, 18, 37, 430, DateTimeKind.Local).AddTicks(787), "USER1@USER.COM", "USER2@USER.COM", "AQAAAAIAAYagAAAAEL9rTWSe2rWfoecwFiSdqqbdrxFABHIdGLtclt1a2IiMSYog0yfShOvdMSjMDAF/vg==", "+905554443322", false, "787a7048-d8ea-41f1-8480-6a82109b8aca", false, "user2@user.com" },
                    { "a6748beb-5f94-46ac-8e7f-5c098d72713f", 0, "79f51b71-9d47-44ca-9f81-2385a1a2a349", new DateTime(2023, 3, 24, 0, 18, 37, 336, DateTimeKind.Local).AddTicks(6715), new DateTime(2023, 3, 24, 0, 18, 37, 336, DateTimeKind.Local).AddTicks(6719), "user1@user.com", false, false, true, new DateTimeOffset(new DateTime(2023, 3, 23, 21, 18, 37, 336, DateTimeKind.Unspecified).AddTicks(6704), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2023, 3, 24, 0, 18, 37, 336, DateTimeKind.Local).AddTicks(6718), "USER1@USER.COM", "USER1@USER.COM", "AQAAAAIAAYagAAAAEMaoOZ8SoMuvqqffZ88eiVhkYuk5mf9b2D0gTD3271JwgmEoH3Tkwz7xCSdwLNvYmg==", "+905554443322", false, "7d2b3b9f-5717-492c-8c99-65acab95e956", false, "user1@user.com" },
                    { "e26796d3-0f85-48fe-a864-4f523107c3bb", 0, "b9fd559a-87b4-49b9-8674-95d9f618b83c", new DateTime(2023, 3, 24, 0, 18, 37, 522, DateTimeKind.Local).AddTicks(4961), new DateTime(2023, 3, 24, 0, 18, 37, 522, DateTimeKind.Local).AddTicks(4973), "admin@admin.com", false, false, true, new DateTimeOffset(new DateTime(2023, 3, 23, 21, 18, 37, 522, DateTimeKind.Unspecified).AddTicks(4923), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2023, 3, 24, 0, 18, 37, 522, DateTimeKind.Local).AddTicks(4970), "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJ9EFaI1kwRX+Sb3sGuQtyPe4/J280RsKQ1nHcHIbq/PVNHz3Fueq5eGhh0oifmh0g==", "+905554443322", false, "63604666-6af5-4892-8c1c-7e0628fd52f5", false, "admin@admin.com" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(6147), false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(6145), "Ankara" },
                    { 2, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(6150), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(6151), false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(6150), "İstanbul" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { "35ca7aad-d2b3-49f4-ad0c-1fdbc2ed7ed8", "e26796d3-0f85-48fe-a864-4f523107c3bb", "UserRole" });

            migrationBuilder.InsertData(
                table: "Barbers",
                columns: new[] { "Id", "Address", "CityId", "CreatedOn", "DeletedOn", "ImageUrl", "IsDeleted", "ModifiedOn", "Name", "RatersCount", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "Zeytinburnu", 2, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4129), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4143), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4140), "Erkek Kuaför 1", 0, 0.0, null },
                    { 2, "Keçiören", 1, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4147), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4148), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4147), "Erkek Kuaför 2", 0, 0.0, null },
                    { 3, "Zeytinburnu", 2, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4151), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4152), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4151), "Erkek Kuaför 3", 0, 0.0, null },
                    { 4, "Keçiören", 1, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4154), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4156), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4155), "Erkek Kuaför 4", 0, 0.0, null },
                    { 5, "Zeytinburnu", 2, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4159), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4161), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4160), "Erkek Kuaför 5", 0, 0.0, null },
                    { 6, "Çankaya", 1, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4164), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4163), "Erkek Kuaför 6", 0, 0.0, null },
                    { 7, "Bağcılar", 2, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4166), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4167), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4166), "Erkek Kuaför 7", 0, 0.0, null },
                    { 8, "Pursaklar", 1, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4169), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4171), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4170), "Erkek Kuaför 8", 0, 0.0, null },
                    { 9, "Bakırköy", 2, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4173), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4174), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4173), "Erkek Kuaför 9", 0, 0.0, null },
                    { 10, "Gölbaşı", 1, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4177), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4177), "Erkek Kuaför 10", 0, 0.0, null },
                    { 11, "Fatih", 2, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4181), "../images/Barbers/ManSalon.jfif", false, new DateTime(2023, 3, 24, 0, 18, 37, 334, DateTimeKind.Local).AddTicks(4180), "Erkek Kuaför 11", 0, 0.0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_BarberId",
                table: "Appointments",
                column: "BarberId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

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
                name: "IX_Barbers_CityId",
                table: "Barbers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Barbers_UserId",
                table: "Barbers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

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
                name: "Barbers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
