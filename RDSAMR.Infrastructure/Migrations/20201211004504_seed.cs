using Microsoft.EntityFrameworkCore.Migrations;

namespace RDSAMR.Infrastructure.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoleTbl",
                columns: new[] { "RoleID", "CreatedByID", "CreationDate", "DeletedByID", "DeletionDate", "IsDeleted", "RoleName", "UpdatedByID", "UpdationDate" },
                values: new object[,]
                {
                    { 1L, null, null, null, null, false, "SuperAdmin", null, null },
                    { 2L, null, null, null, null, false, "Admin", null, null },
                    { 3L, null, null, null, null, false, "Staff", null, null },
                    { 4L, null, null, null, null, false, "Consumer", null, null }
                });

            migrationBuilder.InsertData(
                table: "UserTbl",
                columns: new[] { "UserID", "Address", "CreatedByID", "CreationDate", "DeletedByID", "DeletionDate", "EmailID", "FirstName", "IsDeleted", "LastName", "MobileNo", "PasswordHash", "UpdatedByID", "UpdationDate" },
                values: new object[] { 1L, "Akurdi", null, null, null, null, "achyut.kendre@gmail.com", "Achyut", false, "Kendre", "89894545898", "AMR2006", null, null });

            migrationBuilder.InsertData(
                table: "UserRoleTbl",
                columns: new[] { "UserRoleID", "CreatedByID", "CreationDate", "DeletedByID", "DeletionDate", "IsDeleted", "RoleID", "UpdatedByID", "UpdationDate", "UserID" },
                values: new object[] { 1L, null, null, null, null, false, 1L, null, null, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleTbl",
                keyColumn: "RoleID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "RoleTbl",
                keyColumn: "RoleID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "RoleTbl",
                keyColumn: "RoleID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserRoleTbl",
                keyColumn: "UserRoleID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "RoleTbl",
                keyColumn: "RoleID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserTbl",
                keyColumn: "UserID",
                keyValue: 1L);
        }
    }
}
