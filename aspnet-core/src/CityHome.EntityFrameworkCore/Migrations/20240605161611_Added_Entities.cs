using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityHome.Migrations
{
    /// <inheritdoc />
    public partial class Added_Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "AppPgs");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "AppPgs");

            migrationBuilder.DropColumn(
                name: "Opendate",
                table: "AppPgs");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "AppPgs");

            migrationBuilder.AddColumn<Guid>(
                name: "PgAddressId",
                table: "AppPgs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PgMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepositAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JobLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermanentAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Signature = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PgId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_PgMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PgMembers_Addresses_JobLocationId",
                        column: x => x.JobLocationId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PgMembers_Addresses_PermanentAddressId",
                        column: x => x.PermanentAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PgMembers_AppPgs_PgId",
                        column: x => x.PgId,
                        principalTable: "AppPgs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdharCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdharCardFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PassportSizePhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDocuments_PgMembers_UserId",
                        column: x => x.UserId,
                        principalTable: "PgMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppPgs_PgAddressId",
                table: "AppPgs",
                column: "PgAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PgMembers_JobLocationId",
                table: "PgMembers",
                column: "JobLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PgMembers_PermanentAddressId",
                table: "PgMembers",
                column: "PermanentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PgMembers_PgId",
                table: "PgMembers",
                column: "PgId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDocuments_UserId",
                table: "UserDocuments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppPgs_Addresses_PgAddressId",
                table: "AppPgs",
                column: "PgAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppPgs_Addresses_PgAddressId",
                table: "AppPgs");

            migrationBuilder.DropTable(
                name: "UserDocuments");

            migrationBuilder.DropTable(
                name: "PgMembers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_AppPgs_PgAddressId",
                table: "AppPgs");

            migrationBuilder.DropColumn(
                name: "PgAddressId",
                table: "AppPgs");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "AppPgs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "AppPgs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Opendate",
                table: "AppPgs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pincode",
                table: "AppPgs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
