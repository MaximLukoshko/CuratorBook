using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuratorBookCore.Migrations
{
    public partial class _03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UsersRights_UserId",
                table: "UsersRights",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesRights_RightsId",
                table: "RolesRights",
                column: "RightsId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerRows_FormId",
                table: "AnswerRows",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerRows_GroupId",
                table: "AnswerRows",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerRows_Forms_FormId",
                table: "AnswerRows",
                column: "FormId",
                principalTable: "Forms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerRows_Groups_GroupId",
                table: "AnswerRows",
                column: "GroupId",
                principalTable: "Groups",
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
                name: "FK_UsersRights_Users_UserId",
                table: "UsersRights",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerRows_Forms_FormId",
                table: "AnswerRows");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerRows_Groups_GroupId",
                table: "AnswerRows");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesRights_Rights_RightsId",
                table: "RolesRights");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersRights_Users_UserId",
                table: "UsersRights");

            migrationBuilder.DropIndex(
                name: "IX_UsersRights_UserId",
                table: "UsersRights");

            migrationBuilder.DropIndex(
                name: "IX_RolesRights_RightsId",
                table: "RolesRights");

            migrationBuilder.DropIndex(
                name: "IX_AnswerRows_FormId",
                table: "AnswerRows");

            migrationBuilder.DropIndex(
                name: "IX_AnswerRows_GroupId",
                table: "AnswerRows");
        }
    }
}
