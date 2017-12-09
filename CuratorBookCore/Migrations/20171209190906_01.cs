using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuratorBookCore.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AnswerValues_ControlId",
                table: "AnswerValues",
                column: "ControlId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerValues_FormsControls_ControlId",
                table: "AnswerValues",
                column: "ControlId",
                principalTable: "FormsControls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerValues_FormsControls_ControlId",
                table: "AnswerValues");

            migrationBuilder.DropIndex(
                name: "IX_AnswerValues_ControlId",
                table: "AnswerValues");
        }
    }
}
