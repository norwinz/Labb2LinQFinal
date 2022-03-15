using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb2LinQFinal.Migrations
{
    public partial class StudentChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Kurs_KursId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Lärare_LärareId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Ämne_Lärare_LärareId",
                table: "Ämne");

            migrationBuilder.AlterColumn<int>(
                name: "LärareId",
                table: "Ämne",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LärareId",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KursId",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Kurs_KursId",
                table: "Student",
                column: "KursId",
                principalTable: "Kurs",
                principalColumn: "KursId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Lärare_LärareId",
                table: "Student",
                column: "LärareId",
                principalTable: "Lärare",
                principalColumn: "LärareId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ämne_Lärare_LärareId",
                table: "Ämne",
                column: "LärareId",
                principalTable: "Lärare",
                principalColumn: "LärareId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Kurs_KursId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Lärare_LärareId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Ämne_Lärare_LärareId",
                table: "Ämne");

            migrationBuilder.AlterColumn<int>(
                name: "LärareId",
                table: "Ämne",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LärareId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "KursId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Kurs_KursId",
                table: "Student",
                column: "KursId",
                principalTable: "Kurs",
                principalColumn: "KursId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Lärare_LärareId",
                table: "Student",
                column: "LärareId",
                principalTable: "Lärare",
                principalColumn: "LärareId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ämne_Lärare_LärareId",
                table: "Ämne",
                column: "LärareId",
                principalTable: "Lärare",
                principalColumn: "LärareId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
