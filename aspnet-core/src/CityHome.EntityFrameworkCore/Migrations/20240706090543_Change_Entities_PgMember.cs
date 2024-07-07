using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityHome.Migrations
{
    /// <inheritdoc />
    public partial class Change_Entities_PgMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PgMembers_Pgs_PgId",
                table: "PgMembers");

            migrationBuilder.AlterColumn<Guid>(
                name: "PgId",
                table: "PgMembers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_PgMembers_Pgs_PgId",
                table: "PgMembers",
                column: "PgId",
                principalTable: "Pgs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PgMembers_Pgs_PgId",
                table: "PgMembers");

            migrationBuilder.AlterColumn<Guid>(
                name: "PgId",
                table: "PgMembers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PgMembers_Pgs_PgId",
                table: "PgMembers",
                column: "PgId",
                principalTable: "Pgs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
