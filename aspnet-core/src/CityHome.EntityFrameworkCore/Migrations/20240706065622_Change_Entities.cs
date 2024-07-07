using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityHome.Migrations
{
    /// <inheritdoc />
    public partial class Change_Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PgMembers_Addresses_JobLocationId",
                table: "PgMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_PgMembers_Addresses_PermanentAddressId",
                table: "PgMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_PgMembers_AppPgs_PgId",
                table: "PgMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDocuments_PgMembers_UserId",
                table: "UserDocuments");

            migrationBuilder.DropTable(
                name: "AppPgs");

            migrationBuilder.DropIndex(
                name: "IX_PgMembers_JobLocationId",
                table: "PgMembers");

            migrationBuilder.DropIndex(
                name: "IX_PgMembers_PermanentAddressId",
                table: "PgMembers");

            migrationBuilder.DropColumn(
                name: "AdharCardFile",
                table: "UserDocuments");

            migrationBuilder.DropColumn(
                name: "PassportSizePhoto",
                table: "UserDocuments");

            migrationBuilder.DropColumn(
                name: "JobLocationId",
                table: "PgMembers");

            migrationBuilder.DropColumn(
                name: "PermanentAddressId",
                table: "PgMembers");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "PgMembers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserDocuments",
                newName: "PgMemberId");

            migrationBuilder.RenameColumn(
                name: "AdharCardNumber",
                table: "UserDocuments",
                newName: "DocumentType");

            migrationBuilder.RenameIndex(
                name: "IX_UserDocuments_UserId",
                table: "UserDocuments",
                newName: "IX_UserDocuments_PgMemberId");

            migrationBuilder.RenameColumn(
                name: "Rent",
                table: "PgMembers",
                newName: "RentAmount");

            migrationBuilder.RenameColumn(
                name: "ParentNumber",
                table: "PgMembers",
                newName: "PermanentAddress");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PgMembers",
                newName: "JobCollegeOtherOption");

            migrationBuilder.RenameColumn(
                name: "DepositAmount",
                table: "PgMembers",
                newName: "DepositedAmount");

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "UserDocuments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "UserDocuments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentPath",
                table: "UserDocuments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserDocuments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "PgMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyMobileNumber",
                table: "PgMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "PgMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobCollegeAddress",
                table: "PgMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Addresses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Addresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "PgMemberId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Pgs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vacancy = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PgAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PgRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PgOpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pgs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PgMemberId",
                table: "Addresses",
                column: "PgMemberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_PgMembers_PgMemberId",
                table: "Addresses",
                column: "PgMemberId",
                principalTable: "PgMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PgMembers_Pgs_PgId",
                table: "PgMembers",
                column: "PgId",
                principalTable: "Pgs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDocuments_PgMembers_PgMemberId",
                table: "UserDocuments",
                column: "PgMemberId",
                principalTable: "PgMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_PgMembers_PgMemberId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_PgMembers_Pgs_PgId",
                table: "PgMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDocuments_PgMembers_PgMemberId",
                table: "UserDocuments");

            migrationBuilder.DropTable(
                name: "Pgs");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PgMemberId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "UserDocuments");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "UserDocuments");

            migrationBuilder.DropColumn(
                name: "DocumentPath",
                table: "UserDocuments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserDocuments");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "PgMembers");

            migrationBuilder.DropColumn(
                name: "EmergencyMobileNumber",
                table: "PgMembers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "PgMembers");

            migrationBuilder.DropColumn(
                name: "JobCollegeAddress",
                table: "PgMembers");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PgMemberId",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "PgMemberId",
                table: "UserDocuments",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "DocumentType",
                table: "UserDocuments",
                newName: "AdharCardNumber");

            migrationBuilder.RenameIndex(
                name: "IX_UserDocuments_PgMemberId",
                table: "UserDocuments",
                newName: "IX_UserDocuments_UserId");

            migrationBuilder.RenameColumn(
                name: "RentAmount",
                table: "PgMembers",
                newName: "Rent");

            migrationBuilder.RenameColumn(
                name: "PermanentAddress",
                table: "PgMembers",
                newName: "ParentNumber");

            migrationBuilder.RenameColumn(
                name: "JobCollegeOtherOption",
                table: "PgMembers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DepositedAmount",
                table: "PgMembers",
                newName: "DepositAmount");

            migrationBuilder.AddColumn<byte[]>(
                name: "AdharCardFile",
                table: "UserDocuments",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PassportSizePhoto",
                table: "UserDocuments",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<Guid>(
                name: "JobLocationId",
                table: "PgMembers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PermanentAddressId",
                table: "PgMembers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<byte[]>(
                name: "Signature",
                table: "PgMembers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine2",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AppPgs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PgAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PgName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Vacancy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppPgs_Addresses_PgAddressId",
                        column: x => x.PgAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PgMembers_JobLocationId",
                table: "PgMembers",
                column: "JobLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PgMembers_PermanentAddressId",
                table: "PgMembers",
                column: "PermanentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPgs_PgAddressId",
                table: "AppPgs",
                column: "PgAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_PgMembers_Addresses_JobLocationId",
                table: "PgMembers",
                column: "JobLocationId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PgMembers_Addresses_PermanentAddressId",
                table: "PgMembers",
                column: "PermanentAddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PgMembers_AppPgs_PgId",
                table: "PgMembers",
                column: "PgId",
                principalTable: "AppPgs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDocuments_PgMembers_UserId",
                table: "UserDocuments",
                column: "UserId",
                principalTable: "PgMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
