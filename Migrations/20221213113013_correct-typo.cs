using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_Jeu_Role.Migrations
{
    public partial class correcttypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Situation_SituationId",
                table: "Answer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Situation",
                table: "Situation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer",
                table: "Answer");

            migrationBuilder.RenameTable(
                name: "Situation",
                newName: "Situations");

            migrationBuilder.RenameTable(
                name: "Player",
                newName: "Players");

            migrationBuilder.RenameTable(
                name: "Answer",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_SituationId",
                table: "Answers",
                newName: "IX_Answers_SituationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Situations",
                table: "Situations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Situations_SituationId",
                table: "Answers",
                column: "SituationId",
                principalTable: "Situations",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Situations_SituationId",
                table: "Answers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Situations",
                table: "Situations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Situations",
                newName: "Situation");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Player");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "Answer");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_SituationId",
                table: "Answer",
                newName: "IX_Answer_SituationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Situation",
                table: "Situation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer",
                table: "Answer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Situation_SituationId",
                table: "Answer",
                column: "SituationId",
                principalTable: "Situation",
                principalColumn: "Id");
        }
    }
}
