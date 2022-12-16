using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_Jeu_Role.Migrations
{
    public partial class populateDB_Situation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SituationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Situations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SituationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SituationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SituationEnterId = table.Column<int>(type: "int", nullable: false),
                    SituationExitId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Situations_SituationEnterId",
                        column: x => x.SituationEnterId,
                        principalTable: "Situations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Situations_SituationExitId",
                        column: x => x.SituationExitId,
                        principalTable: "Situations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Situations",
                columns: new[] { "Id", "SituationDescription", "SituationName" },
                values: new object[,]
                {
                    { 1, "Place du village", "Place du village" },
                    { 2, "Boulangerie", "Boulangerie" },
                    { 3, "Mairie", "Mairie" },
                    { 4, "Maison Johnny", "Maison Johnny" },
                    { 5, "Maison", "Maison" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_SituationEnterId",
                table: "Answers",
                column: "SituationEnterId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_SituationExitId",
                table: "Answers",
                column: "SituationExitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Situations");
        }
    }
}
