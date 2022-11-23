using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
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
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    RatersCount = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salons_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Salons_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Salons_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalonServices",
                columns: table => new
                {
                    SalonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalonServices", x => new { x.SalonId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_SalonServices_Salons_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalonServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SalonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Appointments_Salons_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_SalonServices_SalonId_ServiceId",
                        columns: x => new { x.SalonId, x.ServiceId },
                        principalTable: "SalonServices",
                        principalColumns: new[] { "SalonId", "ServiceId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35ca7aad-d2b3-49f4-ad0c-1fdbc2ed7ed8", "1b39fd11-6793-457b-9cee-f095f0f070ad", new DateTime(2022, 11, 23, 21, 46, 22, 245, DateTimeKind.Local).AddTicks(4893), new DateTime(2022, 11, 23, 21, 46, 22, 245, DateTimeKind.Local).AddTicks(4906), false, new DateTime(2022, 11, 23, 21, 46, 22, 245, DateTimeKind.Local).AddTicks(4902), "Administrator", "ADMINISTRATOR" },
                    { "ab2e09bf-cc27-43b5-bed9-1cc81c957abb", "b32fb2cf-1c1a-4668-b492-c68a03deab52", new DateTime(2022, 11, 23, 21, 46, 22, 245, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 11, 23, 21, 46, 22, 245, DateTimeKind.Local).AddTicks(4918), false, new DateTime(2022, 11, 23, 21, 46, 22, 245, DateTimeKind.Local).AddTicks(4917), "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "044d5ec8-3699-471c-be73-8a9b29a8a3c5", 0, "26b0556f-d5ef-4b65-9521-9378b7c68d78", new DateTime(2022, 11, 23, 21, 46, 22, 254, DateTimeKind.Local).AddTicks(7531), new DateTime(2022, 11, 23, 21, 46, 22, 254, DateTimeKind.Local).AddTicks(7534), "user2@user.com", false, false, true, new DateTimeOffset(new DateTime(2022, 11, 23, 18, 46, 22, 254, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2022, 11, 23, 21, 46, 22, 254, DateTimeKind.Local).AddTicks(7533), "USER1@USER.COM", "USER2@USER.COM", "AQAAAAEAACcQAAAAEN9Poi2qaoLIMT1OODpPj25YrjQgxqD5hUFRE6DzVLKNQgYFUKcGoMIUcbnQjtnNfQ==", "+905554443322", false, "c015ff47-aee6-4b64-9fc8-ed9bc41e09c5", false, "user2@user.com" },
                    { "4764c00a-422f-4fe1-bfd5-cc43895c14f3", 0, "2cdd2d50-af98-4ea2-9e8c-6d7912546d2b", new DateTime(2022, 11, 23, 21, 46, 22, 246, DateTimeKind.Local).AddTicks(9626), new DateTime(2022, 11, 23, 21, 46, 22, 246, DateTimeKind.Local).AddTicks(9633), "user1@user.com", false, false, true, new DateTimeOffset(new DateTime(2022, 11, 23, 18, 46, 22, 246, DateTimeKind.Unspecified).AddTicks(9619), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2022, 11, 23, 21, 46, 22, 246, DateTimeKind.Local).AddTicks(9631), "USER1@USER.COM", "USER1@USER.COM", "AQAAAAEAACcQAAAAEPKxEnAgNpvt/UxyNj415jy4auZgr27TTEKKFSsi+doXccA4KTIlAyFZlWc0rCul+w==", "+905554443322", false, "eb596ef2-9ef0-42f9-bdd2-2326b56edc40", false, "user1@user.com" },
                    { "b4a23211-6cba-4cd1-9e27-0b50aa6294d9", 0, "824f10db-1812-40ee-977a-4060b12c94ab", new DateTime(2022, 11, 23, 21, 46, 22, 270, DateTimeKind.Local).AddTicks(1055), new DateTime(2022, 11, 23, 21, 46, 22, 270, DateTimeKind.Local).AddTicks(1058), "manager@manager.com", false, false, true, new DateTimeOffset(new DateTime(2022, 11, 23, 18, 46, 22, 270, DateTimeKind.Unspecified).AddTicks(1052), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2022, 11, 23, 21, 46, 22, 270, DateTimeKind.Local).AddTicks(1057), "MANAGER@MANAGER.COM", "MANAGER@MANAGER.COM", "AQAAAAEAACcQAAAAECza8b1ObxeLKrLHdFFNfecXC5PBMrzBGjNDtKROFrlmxmdonqGrPApdmZgHcLx1HQ==", "+905554443322", false, "27ef6515-18f7-461b-bdfa-a15a12b2fccc", false, "manager@manager.com" },
                    { "e26796d3-0f85-48fe-a864-4f523107c3bb", 0, "075ae475-dca8-4196-9573-1c2ea16618c0", new DateTime(2022, 11, 23, 21, 46, 22, 262, DateTimeKind.Local).AddTicks(4132), new DateTime(2022, 11, 23, 21, 46, 22, 262, DateTimeKind.Local).AddTicks(4137), "admin@admin.com", false, false, true, new DateTimeOffset(new DateTime(2022, 11, 23, 18, 46, 22, 262, DateTimeKind.Unspecified).AddTicks(4127), new TimeSpan(0, 0, 0, 0, 0)), new DateTime(2022, 11, 23, 21, 46, 22, 262, DateTimeKind.Local).AddTicks(4136), "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHwEfmCcI9plDlzTCCnGf5DUK6pZWA/a/WoWwi/7kbrspXMd5muadqn0cGpTmS7mAQ==", "+905554443322", false, "f04fe7ab-46d7-4fe8-85b2-cde90762da0e", false, "admin@admin.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "ImageUrl", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(2978), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(2994), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", "../images/Categories/ManCategory.jfif", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(2988), "Erkek" },
                    { 2, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(2996), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(2998), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", "../images/Categories/WomanCategory.jpg", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(2996), "Kadın" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(3773), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(3779), false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(3777), "Ankara" },
                    { 2, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(3782), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(3785), false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(3783), "İstanbul" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { "ab2e09bf-cc27-43b5-bed9-1cc81c957abb", "b4a23211-6cba-4cd1-9e27-0b50aa6294d9", "ApplicationUserRole" },
                    { "35ca7aad-d2b3-49f4-ad0c-1fdbc2ed7ed8", "e26796d3-0f85-48fe-a864-4f523107c3bb", "ApplicationUserRole" }
                });

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "Address", "CategoryId", "CityId", "CreatedOn", "DeletedOn", "ImageUrl", "IsDeleted", "ModifiedOn", "Name", "OwnerId", "RatersCount", "Rating" },
                values: new object[,]
                {
                    { "salon1", "Zeytinburnu", 1, 2, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4136), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4143), "../images/Salons/ManSalon.jfif", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4141), "Erkek Kuaför 1", null, 0, 0.0 },
                    { "salon10", "Keçiören", 2, 1, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4196), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4198), "../images/Salons/WomanSalon.jpg", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4197), "Kadın Kuaför 5", null, 0, 0.0 },
                    { "salon11", "Keçiören", 2, 1, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4200), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4202), "../images/Salons/WomanSalon.jpg", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4201), "Kadın Kuaför 6", null, 0, 0.0 },
                    { "salon2", "Zeytinburnu", 1, 2, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4157), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4159), "../images/Salons/ManSalon.jfif", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4158), "Erkek Kuaför 2", null, 0, 0.0 },
                    { "salon3", "Zeytinburnu", 1, 2, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4163), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4165), "../images/Salons/ManSalon.jfif", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4164), "Erkek Kuaför 3", null, 0, 0.0 },
                    { "salon4", "Zeytinburnu", 1, 2, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4168), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4170), "../images/Salons/ManSalon.jfif", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4169), "Erkek Kuaför 4", null, 0, 0.0 },
                    { "salon5", "Zeytinburnu", 1, 2, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4173), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4175), "../images/Salons/ManSalon.jfif", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4174), "Erkek Kuaför 5", null, 0, 0.0 },
                    { "salon6", "Keçiören", 2, 1, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4177), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4179), "../images/Salons/WomanSalon.jpg", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4178), "Kadın Kuaför 1", null, 0, 0.0 },
                    { "salon7", "Keçiören", 2, 1, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4182), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4184), "../images/Salons/WomanSalon.jpg", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4183), "Kadın Kuaför 2", null, 0, 0.0 },
                    { "salon8", "Keçiören", 2, 1, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4186), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4188), "../images/Salons/WomanSalon.jpg", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4187), "Kadın Kuaför 3", null, 0, 0.0 },
                    { "salon9", "Keçiören", 2, 1, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4191), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4193), "../images/Salons/WomanSalon.jpg", false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(4192), "Kadın Kuaför 4", null, 0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "DeletedOn", "Description", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(604), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(610), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(608), "Saç Traşı" },
                    { 2, 1, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(614), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(616), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(615), "Sakal Traşı" },
                    { 3, 2, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(619), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(620), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(619), "Fön" },
                    { 4, 2, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(625), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(627), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(626), "Mini Kesim Kırık Temizleme" },
                    { 5, 2, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(630), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(632), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(631), "Örgü" },
                    { 6, 2, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(634), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(636), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(635), "Saç Düzleştirme (Brezilya Fönü)" },
                    { 7, 2, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(638), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(640), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(639), "Boya(Dip)" },
                    { 8, 2, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(642), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(644), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(643), "Boya(Tüm Saç)" },
                    { 9, 2, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(646), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(648), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(647), "Renk Değişimi" },
                    { 10, 2, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(650), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(652), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(651), "Röfle" },
                    { 11, 2, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(655), new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(656), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec qu", false, new DateTime(2022, 11, 23, 21, 46, 22, 281, DateTimeKind.Local).AddTicks(655), "Dip Açma" }
                });

            migrationBuilder.InsertData(
                table: "SalonServices",
                columns: new[] { "SalonId", "ServiceId", "Available", "CreatedOn", "DeletedOn", "Id", "IsDeleted", "ModifiedOn" },
                values: new object[,]
                {
                    { "salon1", 1, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9679), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9686), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9684) },
                    { "salon1", 2, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9692), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9691) },
                    { "salon10", 3, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9926), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9928), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9927) },
                    { "salon10", 4, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9929), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9931), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9930) },
                    { "salon10", 5, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9934), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9936), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9934) },
                    { "salon10", 6, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9937), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9939), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9938) },
                    { "salon10", 7, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9941), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9943), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9942) },
                    { "salon10", 8, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9945), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9947), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9946) },
                    { "salon10", 9, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9949), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9951), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9950) },
                    { "salon10", 10, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9953), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9955), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9954) },
                    { "salon10", 11, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9957), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9959), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9958) },
                    { "salon11", 3, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9963), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9962) },
                    { "salon11", 4, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9966), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9968), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9967) },
                    { "salon11", 5, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9972), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9971) },
                    { "salon11", 6, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9974), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9976), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9975) },
                    { "salon11", 7, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9978), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9979), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9978) },
                    { "salon11", 8, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9981), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9983), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9982) },
                    { "salon11", 9, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9985), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9987), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9986) },
                    { "salon11", 10, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9989), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9991), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9990) },
                    { "salon11", 11, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9992), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9994), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9993) },
                    { "salon2", 1, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9694), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9695), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9695) },
                    { "salon2", 2, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9697), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9699), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9698) },
                    { "salon3", 1, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9701), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9702), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9701) },
                    { "salon3", 2, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9704), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9706), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9705) },
                    { "salon4", 1, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9709), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9711), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9709) },
                    { "salon4", 2, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9718), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9720), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9719) },
                    { "salon5", 1, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9721), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9723), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9722) },
                    { "salon5", 2, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9725), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9726), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9725) },
                    { "salon6", 3, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9728), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9730), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9729) },
                    { "salon6", 4, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9732), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9734), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9733) },
                    { "salon6", 5, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9735), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9737), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9736) },
                    { "salon6", 6, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9739), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9741), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9740) },
                    { "salon6", 7, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9742), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9744), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9743) },
                    { "salon6", 8, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9747), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9749), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9747) },
                    { "salon6", 9, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9753), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9752) },
                    { "salon6", 10, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9755), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9756), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9755) },
                    { "salon6", 11, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9758), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9760), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9759) },
                    { "salon7", 3, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9761), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9763), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9762) },
                    { "salon7", 4, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9765), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9767), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9766) },
                    { "salon7", 5, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9772), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9771) },
                    { "salon7", 6, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9774), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9776), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9775) },
                    { "salon7", 7, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9779), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9781), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9780) }
                });

            migrationBuilder.InsertData(
                table: "SalonServices",
                columns: new[] { "SalonId", "ServiceId", "Available", "CreatedOn", "DeletedOn", "Id", "IsDeleted", "ModifiedOn" },
                values: new object[,]
                {
                    { "salon7", 8, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9783), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9785), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9784) },
                    { "salon7", 9, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9787), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9789), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9788) },
                    { "salon7", 10, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9790), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9792), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9791) },
                    { "salon7", 11, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9794), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9796), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9795) },
                    { "salon8", 3, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9855), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9858), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9856) },
                    { "salon8", 4, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9860), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9862), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9861) },
                    { "salon8", 5, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9864), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9866), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9865) },
                    { "salon8", 6, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9868), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9869), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9868) },
                    { "salon8", 7, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9873), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9874), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9873) },
                    { "salon8", 8, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9876), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9878), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9877) },
                    { "salon8", 9, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9882), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9881) },
                    { "salon8", 10, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9884), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9886), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9885) },
                    { "salon8", 11, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9888), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9889), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9888) },
                    { "salon9", 3, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9891), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9893), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9892) },
                    { "salon9", 4, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9896), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9898), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9897) },
                    { "salon9", 5, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9899), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9902), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9900) },
                    { "salon9", 6, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9904), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9905), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9904) },
                    { "salon9", 7, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9907), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9909), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9908) },
                    { "salon9", 8, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9911), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9913), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9912) },
                    { "salon9", 9, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9915), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9917), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9915) },
                    { "salon9", 10, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9919), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9921), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9920) },
                    { "salon9", 11, true, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9922), new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9924), 0, false, new DateTime(2022, 11, 23, 21, 46, 22, 280, DateTimeKind.Local).AddTicks(9923) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SalonId_ServiceId",
                table: "Appointments",
                columns: new[] { "SalonId", "ServiceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceId",
                table: "Appointments",
                column: "ServiceId");

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
                name: "IX_Salons_CategoryId",
                table: "Salons",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Salons_CityId",
                table: "Salons",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Salons_OwnerId",
                table: "Salons",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalonServices_ServiceId",
                table: "SalonServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryId",
                table: "Services",
                column: "CategoryId");
        }

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
                name: "SalonServices");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Salons");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
