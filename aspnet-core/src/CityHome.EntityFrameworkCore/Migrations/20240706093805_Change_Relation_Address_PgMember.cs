using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityHome.Migrations
{
    /// <inheritdoc />
    public partial class Change_Relation_Address_PgMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Addresses_PgMemberId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "JobCollegeAddress",
                table: "PgMembers");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "PgMembers");

            migrationBuilder.AlterColumn<Guid>(
                name: "PgMemberId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "PgMemberId1",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PgMemberId2",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PgMemberId",
                table: "Addresses",
                column: "PgMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PgMemberId1",
                table: "Addresses",
                column: "PgMemberId1",
                unique: true,
                filter: "[PgMemberId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PgMemberId2",
                table: "Addresses",
                column: "PgMemberId2",
                unique: true,
                filter: "[PgMemberId2] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_PgMembers_PgMemberId1",
                table: "Addresses",
                column: "PgMemberId1",
                principalTable: "PgMembers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_PgMembers_PgMemberId2",
                table: "Addresses",
                column: "PgMemberId2",
                principalTable: "PgMembers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_PgMembers_PgMemberId1",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_PgMembers_PgMemberId2",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PgMemberId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PgMemberId1",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PgMemberId2",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PgMemberId1",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PgMemberId2",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "JobCollegeAddress",
                table: "PgMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "PgMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "PgMemberId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PgMemberId",
                table: "Addresses",
                column: "PgMemberId",
                unique: true);
        }
    }
}
