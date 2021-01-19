using Microsoft.EntityFrameworkCore.Migrations;

namespace aprender_cs.Migrations
{
    public partial class correspondencias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arma_Heroi_HeroiId",
                table: "Arma");

            migrationBuilder.DropIndex(
                name: "IX_Arma_HeroiId",
                table: "Arma");

            migrationBuilder.DropColumn(
                name: "HeroiId",
                table: "Arma");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Heroi",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(16) CHARACTER SET utf8mb4",
                oldMaxLength: 16);

            migrationBuilder.AddColumn<int>(
                name: "ArmaId",
                table: "Heroi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Batalha",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Batalha",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Arma",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Arma",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Heroi_ArmaId",
                table: "Heroi",
                column: "ArmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroi_Arma_ArmaId",
                table: "Heroi",
                column: "ArmaId",
                principalTable: "Arma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroi_Arma_ArmaId",
                table: "Heroi");

            migrationBuilder.DropIndex(
                name: "IX_Heroi_ArmaId",
                table: "Heroi");

            migrationBuilder.DropColumn(
                name: "ArmaId",
                table: "Heroi");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Arma");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Heroi",
                type: "varchar(16) CHARACTER SET utf8mb4",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50) CHARACTER SET utf8mb4",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Batalha",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Batalha",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Arma",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "HeroiId",
                table: "Arma",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Arma_HeroiId",
                table: "Arma",
                column: "HeroiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arma_Heroi_HeroiId",
                table: "Arma",
                column: "HeroiId",
                principalTable: "Heroi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
