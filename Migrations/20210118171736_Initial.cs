using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aprender_cs.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batalha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Descricao = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DtInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DtFim = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batalha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heroi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(16) CHARACTER SET utf8mb4", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    HeroiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arma_Heroi_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "Heroi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeroisBaTalhas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HeroiId = table.Column<int>(type: "int", nullable: false),
                    BatalhaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroisBaTalhas", x => x.id);
                    table.ForeignKey(
                        name: "FK_HeroisBaTalhas_Batalha_BatalhaId",
                        column: x => x.BatalhaId,
                        principalTable: "Batalha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroisBaTalhas_Heroi_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "Heroi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arma_HeroiId",
                table: "Arma",
                column: "HeroiId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroisBaTalhas_BatalhaId",
                table: "HeroisBaTalhas",
                column: "BatalhaId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroisBaTalhas_HeroiId",
                table: "HeroisBaTalhas",
                column: "HeroiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arma");

            migrationBuilder.DropTable(
                name: "HeroisBaTalhas");

            migrationBuilder.DropTable(
                name: "Batalha");

            migrationBuilder.DropTable(
                name: "Heroi");
        }
    }
}
