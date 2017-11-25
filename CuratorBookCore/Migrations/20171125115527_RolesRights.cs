using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuratorBookCore.Migrations
{
    public partial class RolesRights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesRights_Rights_RightsId",
                table: "RolesRights");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesRights_Roles_RolesId",
                table: "RolesRights");

            migrationBuilder.DropIndex(
                name: "IX_RolesRights_RightsId",
                table: "RolesRights");

            migrationBuilder.AlterColumn<int>(
                name: "RolesId",
                table: "RolesRights",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesRights_Roles_RolesId",
                table: "RolesRights",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesRights_Roles_RolesId",
                table: "RolesRights");

            migrationBuilder.AlterColumn<int>(
                name: "RolesId",
                table: "RolesRights",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_RolesRights_RightsId",
                table: "RolesRights",
                column: "RightsId");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesRights_Rights_RightsId",
                table: "RolesRights",
                column: "RightsId",
                principalTable: "Rights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesRights_Roles_RolesId",
                table: "RolesRights",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
