using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DamilahExercise.Migrations
{
    /// <inheritdoc />
    public partial class Kikser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Literatures_Subjects_SubjectId",
                table: "Literatures");

            migrationBuilder.DropIndex(
                name: "IX_Literatures_SubjectId",
                table: "Literatures");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Literatures");

            migrationBuilder.CreateTable(
                name: "LiteratureSubject",
                columns: table => new
                {
                    LiteratureUsedId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiteratureSubject", x => new { x.LiteratureUsedId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_LiteratureSubject_Literatures_LiteratureUsedId",
                        column: x => x.LiteratureUsedId,
                        principalTable: "Literatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LiteratureSubject_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LiteratureSubject_SubjectId",
                table: "LiteratureSubject",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiteratureSubject");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Literatures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Literatures_SubjectId",
                table: "Literatures",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Literatures_Subjects_SubjectId",
                table: "Literatures",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }
    }
}
