using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2LinQFinal.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    KursId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KursNamn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.KursId);
                });

            migrationBuilder.CreateTable(
                name: "Lärare",
                columns: table => new
                {
                    LärareId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LärareNamn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lärare", x => x.LärareId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentNamn = table.Column<string>(nullable: true),
                    KursId = table.Column<int>(nullable: true),
                    LärareId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Kurs_KursId",
                        column: x => x.KursId,
                        principalTable: "Kurs",
                        principalColumn: "KursId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Lärare_LärareId",
                        column: x => x.LärareId,
                        principalTable: "Lärare",
                        principalColumn: "LärareId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ämne",
                columns: table => new
                {
                    ÄmneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ÄmneNamn = table.Column<string>(nullable: true),
                    LärareId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ämne", x => x.ÄmneId);
                    table.ForeignKey(
                        name: "FK_Ämne_Lärare_LärareId",
                        column: x => x.LärareId,
                        principalTable: "Lärare",
                        principalColumn: "LärareId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_KursId",
                table: "Student",
                column: "KursId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_LärareId",
                table: "Student",
                column: "LärareId");

            migrationBuilder.CreateIndex(
                name: "IX_Ämne_LärareId",
                table: "Ämne",
                column: "LärareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Ämne");

            migrationBuilder.DropTable(
                name: "Kurs");

            migrationBuilder.DropTable(
                name: "Lärare");
        }
    }
}
