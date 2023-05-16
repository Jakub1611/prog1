using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class ahah : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupy",
                columns: table => new
                {
                    gr_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gr_Kod_grupy = table.Column<int>(type: "int", nullable: false),
                    gr_Typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gr_Kierunek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gr_Semestr = table.Column<int>(type: "int", nullable: false),
                    gr_Rok_akad = table.Column<int>(type: "int", nullable: false),
                    gr_Tryb_stud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gr_Stopien_stud = table.Column<int>(type: "int", nullable: false),
                    gr_Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupy", x => x.gr_ID);
                });

            migrationBuilder.CreateTable(
                name: "Przedmioty",
                columns: table => new
                {
                    pr_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pr_Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pr_Typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pr_Liczba_h_tyg = table.Column<int>(type: "int", nullable: false),
                    pr_Kierunek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pr_Semestr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pr_Kod_sylabusa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pr_Rok_akademicki = table.Column<int>(type: "int", nullable: false),
                    pr_Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przedmioty", x => x.pr_ID);
                });

            migrationBuilder.CreateTable(
                name: "ObsadaGrup",
                columns: table => new
                {
                    Ob_ID = table.Column<int>(type: "int", nullable: false),
                    ob_stID = table.Column<int>(type: "int", nullable: false),
                    ob_Data_od = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ob_Data_do = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ob_Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObsadaGrup", x => x.Ob_ID);
                    table.ForeignKey(
                        name: "FK_ObsadaGrup_Grupy_Ob_ID",
                        column: x => x.Ob_ID,
                        principalTable: "Grupy",
                        principalColumn: "gr_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RealizacjaPlanu",
                columns: table => new
                {
                    re_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    re_ppID = table.Column<int>(type: "int", nullable: false),
                    re_Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    re_Grupa = table.Column<int>(type: "int", nullable: false),
                    re_Temat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    re_Uwagi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    re_Konspekt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    re_Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealizacjaPlanu", x => x.re_ID);
                    table.ForeignKey(
                        name: "FK_RealizacjaPlanu_Grupy_re_ppID",
                        column: x => x.re_ppID,
                        principalTable: "Grupy",
                        principalColumn: "gr_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Studenci",
                columns: table => new
                {
                    st_ID = table.Column<int>(type: "int", nullable: false),
                    st_Imię = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    st_Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    st_Rocznik_1s = table.Column<DateTime>(type: "datetime2", nullable: false),
                    st_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    st_Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenci", x => x.st_ID);
                    table.ForeignKey(
                        name: "FK_Studenci_ObsadaGrup_st_ID",
                        column: x => x.st_ID,
                        principalTable: "ObsadaGrup",
                        principalColumn: "Ob_ID");
                });

            migrationBuilder.CreateTable(
                name: "PozycjePlanu",
                columns: table => new
                {
                    pp_ID = table.Column<int>(type: "int", nullable: false),
                    pp_Nazwa = table.Column<int>(type: "int", nullable: false),
                    Przedmiotypr_ID = table.Column<int>(type: "int", nullable: false),
                    pp_Grupa = table.Column<int>(type: "int", nullable: false),
                    pp_Sala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pp_Dzień = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pp_Godzina_od = table.Column<TimeSpan>(type: "time", nullable: false),
                    pp_Godzina_do = table.Column<TimeSpan>(type: "time", nullable: false),
                    pp_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pp_Liczba_godzin = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PozycjePlanu", x => x.pp_ID);
                    table.ForeignKey(
                        name: "FK_PozycjePlanu_Przedmioty_Przedmiotypr_ID",
                        column: x => x.Przedmiotypr_ID,
                        principalTable: "Przedmioty",
                        principalColumn: "pr_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PozycjePlanu_Przedmioty_pp_ID",
                        column: x => x.pp_ID,
                        principalTable: "Przedmioty",
                        principalColumn: "pr_ID");
                    table.ForeignKey(
                        name: "FK_PozycjePlanu_RealizacjaPlanu_pp_ID",
                        column: x => x.pp_ID,
                        principalTable: "RealizacjaPlanu",
                        principalColumn: "re_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Frekwencja",
                columns: table => new
                {
                    fr_relID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fr_stID = table.Column<int>(type: "int", nullable: false),
                    fr_Obecny = table.Column<bool>(type: "bit", nullable: false),
                    fr_Notatka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fr_Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frekwencja", x => x.fr_relID);
                    table.ForeignKey(
                        name: "FK_Frekwencja_RealizacjaPlanu_fr_stID",
                        column: x => x.fr_stID,
                        principalTable: "RealizacjaPlanu",
                        principalColumn: "re_ID");
                    table.ForeignKey(
                        name: "FK_Frekwencja_Studenci_fr_stID",
                        column: x => x.fr_stID,
                        principalTable: "Studenci",
                        principalColumn: "st_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Frekwencja_fr_stID",
                table: "Frekwencja",
                column: "fr_stID");

            migrationBuilder.CreateIndex(
                name: "IX_PozycjePlanu_Przedmiotypr_ID",
                table: "PozycjePlanu",
                column: "Przedmiotypr_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RealizacjaPlanu_re_ppID",
                table: "RealizacjaPlanu",
                column: "re_ppID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frekwencja");

            migrationBuilder.DropTable(
                name: "PozycjePlanu");

            migrationBuilder.DropTable(
                name: "Studenci");

            migrationBuilder.DropTable(
                name: "Przedmioty");

            migrationBuilder.DropTable(
                name: "RealizacjaPlanu");

            migrationBuilder.DropTable(
                name: "ObsadaGrup");

            migrationBuilder.DropTable(
                name: "Grupy");
        }
    }
}
