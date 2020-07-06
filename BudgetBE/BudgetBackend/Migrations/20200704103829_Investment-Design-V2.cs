using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetBackend.Migrations
{
    public partial class InvestmentDesignV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolio",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portfolio_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    portfolioId = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Current = table.Column<double>(nullable: false),
                    Initial = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Investment_Portfolio_portfolioId",
                        column: x => x.portfolioId,
                        principalTable: "Portfolio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvestmentHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InvestmentId = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestmentHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvestmentHistory_Investment_InvestmentId",
                        column: x => x.InvestmentId,
                        principalTable: "Investment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investment_portfolioId",
                table: "Investment",
                column: "portfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentHistory_InvestmentId",
                table: "InvestmentHistory",
                column: "InvestmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolio_UserId",
                table: "Portfolio",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvestmentHistory");

            migrationBuilder.DropTable(
                name: "Investment");

            migrationBuilder.DropTable(
                name: "Portfolio");
        }
    }
}
