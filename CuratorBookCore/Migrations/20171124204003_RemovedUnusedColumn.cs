using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuratorBookCore.Migrations
{
    public partial class RemovedUnusedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagesRights_Roles_RolesId",
                table: "PagesRights");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesRights_Rights_RightId",
                table: "RolesRights");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GroupId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_PagesRights_RolesId",
                table: "PagesRights");

            migrationBuilder.DropColumn(
                name: "RolesId",
                table: "PagesRights");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "RolesRights",
                newName: "RolesId");

            migrationBuilder.RenameColumn(
                name: "RightId",
                table: "RolesRights",
                newName: "RightsId");

            migrationBuilder.RenameIndex(
                name: "IX_RolesRights_RightId",
                table: "RolesRights",
                newName: "IX_RolesRights_RightsId");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_RolesRights_RolesId",
                table: "RolesRights",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_PagesRights_PageId",
                table: "PagesRights",
                column: "PageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PagesRights_Pages_PageId",
                table: "PagesRights",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_GroupId",
                table: "Users",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagesRights_Pages_PageId",
                table: "PagesRights");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesRights_Rights_RightsId",
                table: "RolesRights");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesRights_Roles_RolesId",
                table: "RolesRights");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Groups_GroupId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_RolesRights_RolesId",
                table: "RolesRights");

            migrationBuilder.DropIndex(
                name: "IX_PagesRights_PageId",
                table: "PagesRights");

            migrationBuilder.RenameColumn(
                name: "RolesId",
                table: "RolesRights",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "RightsId",
                table: "RolesRights",
                newName: "RightId");

            migrationBuilder.RenameIndex(
                name: "IX_RolesRights_RightsId",
                table: "RolesRights",
                newName: "IX_RolesRights_RightId");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RolesId",
                table: "PagesRights",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PagesRights_RolesId",
                table: "PagesRights",
                column: "RolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_PagesRights_Roles_RolesId",
                table: "PagesRights",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesRights_Rights_RightId",
                table: "RolesRights",
                column: "RightId",
                principalTable: "Rights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Groups_GroupId",
                table: "Users",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
