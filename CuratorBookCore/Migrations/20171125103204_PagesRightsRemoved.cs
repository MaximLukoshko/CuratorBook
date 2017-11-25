using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuratorBookCore.Migrations
{
    public partial class PagesRightsRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesRights_Roles_RolesId",
                table: "RolesRights");

            migrationBuilder.DropTable(
                name: "PagesRights");

            migrationBuilder.AlterColumn<int>(
                name: "RolesId",
                table: "RolesRights",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "RightsId",
                table: "Pages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_RightsId",
                table: "Pages",
                column: "RightsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Rights_RightsId",
                table: "Pages",
                column: "RightsId",
                principalTable: "Rights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesRights_Roles_RolesId",
                table: "RolesRights",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Rights_RightsId",
                table: "Pages");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesRights_Roles_RolesId",
                table: "RolesRights");

            migrationBuilder.DropIndex(
                name: "IX_Pages_RightsId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "RightsId",
                table: "Pages");

            migrationBuilder.AlterColumn<int>(
                name: "RolesId",
                table: "RolesRights",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PagesRights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PageId = table.Column<int>(nullable: false),
                    RightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagesRights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagesRights_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagesRights_Rights_RightId",
                        column: x => x.RightId,
                        principalTable: "Rights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PagesRights_PageId",
                table: "PagesRights",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_PagesRights_RightId",
                table: "PagesRights",
                column: "RightId");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesRights_Roles_RolesId",
                table: "RolesRights",
                column: "RolesId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
