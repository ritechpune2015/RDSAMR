using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RDSAMR.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryTbl",
                columns: table => new
                {
                    CountryID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    UpdatedByID = table.Column<long>(nullable: true),
                    UpdationDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionDate = table.Column<DateTime>(nullable: true),
                    DeletedByID = table.Column<long>(nullable: true),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryTbl", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "RoleTbl",
                columns: table => new
                {
                    RoleID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    UpdatedByID = table.Column<long>(nullable: true),
                    UpdationDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionDate = table.Column<DateTime>(nullable: true),
                    DeletedByID = table.Column<long>(nullable: true),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleTbl", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "SuperAdminTbl",
                columns: table => new
                {
                    SuperAdminID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    EmailID = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperAdminTbl", x => x.SuperAdminID);
                });

            migrationBuilder.CreateTable(
                name: "StateTbl",
                columns: table => new
                {
                    StateID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    UpdatedByID = table.Column<long>(nullable: true),
                    UpdationDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionDate = table.Column<DateTime>(nullable: true),
                    DeletedByID = table.Column<long>(nullable: true),
                    StateName = table.Column<string>(nullable: true),
                    CountryID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTbl", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_StateTbl_CountryTbl_CountryID",
                        column: x => x.CountryID,
                        principalTable: "CountryTbl",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTbl",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    UpdatedByID = table.Column<long>(nullable: true),
                    UpdationDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionDate = table.Column<DateTime>(nullable: true),
                    DeletedByID = table.Column<long>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    EmailID = table.Column<string>(nullable: true),
                    RoleID = table.Column<long>(nullable: false),
                    MobileNo = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTbl", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_UserTbl_RoleTbl_RoleID",
                        column: x => x.RoleID,
                        principalTable: "RoleTbl",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    UpdatedByID = table.Column<long>(nullable: true),
                    UpdationDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionDate = table.Column<DateTime>(nullable: true),
                    DeletedByID = table.Column<long>(nullable: true),
                    CityName = table.Column<string>(nullable: true),
                    StateID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_CityTbl_StateTbl_StateID",
                        column: x => x.StateID,
                        principalTable: "StateTbl",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RoleTbl",
                columns: new[] { "RoleID", "CreatedByID", "CreationDate", "DeletedByID", "DeletionDate", "IsDeleted", "RoleName", "UpdatedByID", "UpdationDate" },
                values: new object[] { 1L, null, null, null, null, false, "Admin", null, null });

            migrationBuilder.InsertData(
                table: "RoleTbl",
                columns: new[] { "RoleID", "CreatedByID", "CreationDate", "DeletedByID", "DeletionDate", "IsDeleted", "RoleName", "UpdatedByID", "UpdationDate" },
                values: new object[] { 2L, null, null, null, null, false, "Staff", null, null });

            migrationBuilder.InsertData(
                table: "SuperAdminTbl",
                columns: new[] { "SuperAdminID", "EmailID", "Name", "PasswordHash" },
                values: new object[] { 1L, "superadmin@gmail.com", "Achyut", "admin" });

            migrationBuilder.InsertData(
                table: "UserTbl",
                columns: new[] { "UserID", "Address", "CreatedByID", "CreationDate", "DeletedByID", "DeletionDate", "EmailID", "FirstName", "IsDeleted", "LastName", "MobileNo", "PasswordHash", "RoleID", "UpdatedByID", "UpdationDate" },
                values: new object[] { 1L, "Akurdi", null, null, null, null, "superadmin@gmail.com", "Achyut", false, "Kendre", "89894545898", "admin", 1L, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_StateID",
                table: "CityTbl",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_StateTbl_CountryID",
                table: "StateTbl",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserTbl_RoleID",
                table: "UserTbl",
                column: "RoleID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "SuperAdminTbl");

            migrationBuilder.DropTable(
                name: "UserTbl");

            migrationBuilder.DropTable(
                name: "StateTbl");

            migrationBuilder.DropTable(
                name: "RoleTbl");

            migrationBuilder.DropTable(
                name: "CountryTbl");
        }
    }
}
