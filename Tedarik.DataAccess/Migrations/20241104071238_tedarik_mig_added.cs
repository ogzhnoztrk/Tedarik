using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tedarik.DataAccess.Migrations
{
    public partial class tedarik_mig_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_TEDARIK",
                columns: table => new
                {
                    tdrk_TedarikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tdrk_SNo = table.Column<short>(type: "smallint", nullable: true),
                    tdrk_AlimMuhTarihNo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_AlimMuhNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_AlimEmriProNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdrk_Donem = table.Column<short>(type: "smallint", nullable: true),
                    tdrk_Kategori = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_Kuvvet = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_Cins = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_Olcu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tdrk_Miktar = table.Column<int>(type: "int", nullable: true),
                    tdrk_Kisim = table.Column<short>(type: "smallint", nullable: true),
                    tdrk_Taksit = table.Column<short>(type: "smallint", nullable: true),
                    tdrk_TaksitNu = table.Column<short>(type: "smallint", nullable: true),
                    tdrk_TaksitMiktari = table.Column<int>(type: "int", nullable: true),
                    tdrk_ToplamMiktar = table.Column<int>(type: "int", nullable: true),
                    tdrk_Usul = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_YaklasikgidisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_YaklasikdonusTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_IhaleTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_KararTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_AlimFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_IhaleTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_KararTeblig = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_Davet = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_SozlesmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_SozlesmeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdrk_Eniyifirma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_TeslimBaslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_TeslimBitis = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_KatiKabul = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_Sevk = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdrk_Proje = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_OncekiTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_OncekiBolge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_OncekiMiktar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_OncekiTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_Ufe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_GuncelFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_GuncelTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_YaklasikMaliyet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_MalteslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuhtiraTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuhtiraAlim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_LabgidisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_LabdonusTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuakararTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_TasinirkesilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TEDARIK", x => x.tdrk_TedarikId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_TEDARIK");
        }
    }
}
