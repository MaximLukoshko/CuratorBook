using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuratorBookCore.Migrations
{
    public partial class RemoveExtraColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormsControls_Forms_FormsId",
                table: "FormsControls");

            migrationBuilder.DropIndex(
                name: "IX_FormsControls_FormsId",
                table: "FormsControls");

            migrationBuilder.DropColumn(
                name: "FormsId",
                table: "FormsControls");

            migrationBuilder.CreateIndex(
                name: "IX_FormsControls_FormId",
                table: "FormsControls",
                column: "FormId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormsControls_Forms_FormId",
                table: "FormsControls",
                column: "FormId",
                principalTable: "Forms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormsControls_Forms_FormId",
                table: "FormsControls");

            migrationBuilder.DropIndex(
                name: "IX_FormsControls_FormId",
                table: "FormsControls");

            migrationBuilder.AddColumn<int>(
                name: "FormsId",
                table: "FormsControls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormsControls_FormsId",
                table: "FormsControls",
                column: "FormsId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormsControls_Forms_FormsId",
                table: "FormsControls",
                column: "FormsId",
                principalTable: "Forms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
