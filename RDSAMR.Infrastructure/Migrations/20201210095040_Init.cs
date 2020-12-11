using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RDSAMR.Infrastructure.Migrations
{
    public partial class Init : Migration
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
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    EmailID = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTbl", x => x.UserID);
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
                name: "UserRoleTbl",
                columns: table => new
                {
                    UserRoleID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByID = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    UpdatedByID = table.Column<long>(nullable: true),
                    UpdationDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletionDate = table.Column<DateTime>(nullable: true),
                    DeletedByID = table.Column<long>(nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    RoleID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleTbl", x => x.UserRoleID);
                    table.ForeignKey(
                        name: "FK_UserRoleTbl_RoleTbl_RoleID",
                        column: x => x.RoleID,
                        principalTable: "RoleTbl",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleTbl_UserTbl_UserID",
                        column: x => x.UserID,
                        principalTable: "UserTbl",
                        principalColumn: "UserID",
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

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_StateID",
                table: "CityTbl",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_StateTbl_CountryID",
                table: "StateTbl",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleTbl_RoleID",
                table: "UserRoleTbl",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleTbl_UserID",
                table: "UserRoleTbl",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "UserRoleTbl");

            migrationBuilder.DropTable(
                name: "StateTbl");

            migrationBuilder.DropTable(
                name: "RoleTbl");

            migrationBuilder.DropTable(
                name: "UserTbl");

            migrationBuilder.DropTable(
                name: "CountryTbl");
        }
    }
}
