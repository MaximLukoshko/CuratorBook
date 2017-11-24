using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CuratorBookCore.Migrations
{
    public partial class AnswerRows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.CreateTable(
                name: "AnswerRows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FormId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    ISHidden = table.Column<bool>(nullable: false),
                    IsFreezed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerRows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnswerValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerRowsId = table.Column<int>(nullable: false),
                    ControlId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerValues_AnswerRows_AnswerRowsId",
                        column: x => x.AnswerRowsId,
                        principalTable: "AnswerRows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerValues_AnswerRowsId",
                table: "AnswerValues",
                column: "AnswerRowsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerValues");

            migrationBuilder.DropTable(
                name: "AnswerRows");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FormId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    ISHidden = table.Column<bool>(nullable: false),
                    IsFreezed = table.Column<bool>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });
        }
    }
}
