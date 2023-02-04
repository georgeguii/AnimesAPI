using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimesAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AnimeGenresManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeGenre_Animes_AnimesId",
                table: "AnimeGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimeGenre_Genres_GenresId",
                table: "AnimeGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeGenre",
                table: "AnimeGenre");

            migrationBuilder.RenameTable(
                name: "AnimeGenre",
                newName: "AnimeGenres");

            migrationBuilder.RenameIndex(
                name: "IX_AnimeGenre_GenresId",
                table: "AnimeGenres",
                newName: "IX_AnimeGenres_GenresId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Genres",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Studio",
                table: "Animes",
                type: "VARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Resume",
                table: "Animes",
                type: "VARCHAR(256)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animes",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Animes",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Animes",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeGenres",
                table: "AnimeGenres",
                columns: new[] { "AnimesId", "GenresId" });

            migrationBuilder.CreateIndex(
                name: "IX_Animes_Name",
                table: "Animes",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeGenres_Animes_AnimesId",
                table: "AnimeGenres",
                column: "AnimesId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeGenres_Genres_GenresId",
                table: "AnimeGenres",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeGenres_Animes_AnimesId",
                table: "AnimeGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimeGenres_Genres_GenresId",
                table: "AnimeGenres");

            migrationBuilder.DropIndex(
                name: "IX_Animes_Name",
                table: "Animes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeGenres",
                table: "AnimeGenres");

            migrationBuilder.RenameTable(
                name: "AnimeGenres",
                newName: "AnimeGenre");

            migrationBuilder.RenameIndex(
                name: "IX_AnimeGenres_GenresId",
                table: "AnimeGenre",
                newName: "IX_AnimeGenre_GenresId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Studio",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Resume",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(256)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Animes",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT");

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeGenre",
                table: "AnimeGenre",
                columns: new[] { "AnimesId", "GenresId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeGenre_Animes_AnimesId",
                table: "AnimeGenre",
                column: "AnimesId",
                principalTable: "Animes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeGenre_Genres_GenresId",
                table: "AnimeGenre",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
