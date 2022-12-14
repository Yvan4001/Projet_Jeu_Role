using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_Jeu_Role.Migrations
{
    public partial class add_foreign_key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SituationIdExit",
                table: "Answers",
                newName: "SituationExitId");

            migrationBuilder.RenameColumn(
                name: "SituationIdEnter",
                table: "Answers",
                newName: "SituationEnterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SituationExitId",
                table: "Answers",
                newName: "SituationIdExit");

            migrationBuilder.RenameColumn(
                name: "SituationEnterId",
                table: "Answers",
                newName: "SituationIdEnter");
        }
    }
}
