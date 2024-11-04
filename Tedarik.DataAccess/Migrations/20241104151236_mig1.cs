using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tedarik.DataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_KULLANICILAR",
                columns: table => new
                {
                    kllnc_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    kllnc_adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kllnc_soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kllnc_posta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kllnc_sifre_hash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    kllnc_sifre_salt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    kllnc_aktif_mi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_KULLANICILAR", x => x.kllnc_id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_MODUL_TANIM",
                columns: table => new
                {
                    mdul_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mdul_no = table.Column<int>(type: "int", nullable: true),
                    modl_adi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_MODUL_TANIM", x => x.mdul_id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TEDARIKLER",
                columns: table => new
                {
                    tdrk_TedarikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tdrk_SNo = table.Column<short>(type: "smallint", nullable: true),
                    tdrk_AlimMuhTarihNo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_AlimMuhNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_AlimEmriProNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdrk_ProjeYili = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_Kategori = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_Kuvvet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdrk_MalzemeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdrk_OlcuBirimi = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    tdrk_KisimMiktari = table.Column<int>(type: "int", nullable: true),
                    tdrk_KisimNo = table.Column<short>(type: "smallint", nullable: true),
                    tdrk_TaksitSayisi = table.Column<short>(type: "smallint", nullable: true),
                    tdrk_TaksitNumarasi = table.Column<short>(type: "smallint", nullable: true),
                    tdrk_TaksitMiktari = table.Column<int>(type: "int", nullable: true),
                    tdrk_ToplamAlimMiktari = table.Column<int>(type: "int", nullable: true),
                    tdrk_IhAlimUsul = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_YaklasikgidisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_YaklasikdonusTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_IhaleTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_KararTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_BirimFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_KararTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_KararTebligTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_SozlesmeDavetTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_SozlesmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_SozlesmeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdrk_Yukleyici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_TeslimBaslangicTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_TeslimBitisTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_KatiKabulTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_Sevk = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdrk_ProjeSorumlusu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_OncekiAlimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_OncekiAlimBolge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tdrk_OncekiAlimMiktar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_OncekiAlimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_Ufe = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_GuncelBirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_GuncelTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    tdrk_MalTeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuhtiraTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_TasinirkesilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_IkmalSevkTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuhtiraAlimTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuaTebligTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuaKomisyonBaskani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tdrk_MuaUye1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tdrk_MuaUye2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tdrk_MuaUye3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tdrk_MalSorumlusu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tdrk_GecikmeSebebi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tdrk_FizikselMuaTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_FizikselMuaSonuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_LabGidisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_LabDonusTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuakararTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuaSonuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tdrk_MuaAciklamasi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TEDARIKLER", x => x.tdrk_TedarikId);
                });

            migrationBuilder.CreateTable(
                name: "TBL_YETKI",
                columns: table => new
                {
                    ytki_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mdul_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    kllnc_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_YETKI", x => x.ytki_id);
                    table.ForeignKey(
                        name: "FK_TBL_YETKI_TBL_KULLANICILAR_kllnc_id",
                        column: x => x.kllnc_id,
                        principalTable: "TBL_KULLANICILAR",
                        principalColumn: "kllnc_id");
                    table.ForeignKey(
                        name: "FK_TBL_YETKI_TBL_MODUL_TANIM_mdul_id",
                        column: x => x.mdul_id,
                        principalTable: "TBL_MODUL_TANIM",
                        principalColumn: "mdul_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_YETKI_kllnc_id",
                table: "TBL_YETKI",
                column: "kllnc_id");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_YETKI_mdul_id",
                table: "TBL_YETKI",
                column: "mdul_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_TEDARIKLER");

            migrationBuilder.DropTable(
                name: "TBL_YETKI");

            migrationBuilder.DropTable(
                name: "TBL_KULLANICILAR");

            migrationBuilder.DropTable(
                name: "TBL_MODUL_TANIM");
        }
    }
}
