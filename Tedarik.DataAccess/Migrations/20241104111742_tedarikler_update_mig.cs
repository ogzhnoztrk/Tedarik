using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tedarik.DataAccess.Migrations
{
    public partial class tedarikler_update_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_TEDARIK",
                table: "TBL_TEDARIK");

            migrationBuilder.DropColumn(
                name: "tdrk_AlimFiyati",
                table: "TBL_TEDARIK");

            migrationBuilder.DropColumn(
                name: "tdrk_Cins",
                table: "TBL_TEDARIK");

            migrationBuilder.DropColumn(
                name: "tdrk_Donem",
                table: "TBL_TEDARIK");

            migrationBuilder.RenameTable(
                name: "TBL_TEDARIK",
                newName: "TBL_TEDARIKLER");

            migrationBuilder.RenameColumn(
                name: "tdrk_MalteslimTarihi",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_MalTeslimTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_LabgidisTarihi",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_LabGidisTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_LabdonusTarihi",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_LabDonusTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_YaklasikMaliyet",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_OncekiAlimMiktar");

            migrationBuilder.RenameColumn(
                name: "tdrk_Usul",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_Yukleyici");

            migrationBuilder.RenameColumn(
                name: "tdrk_ToplamMiktar",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_ToplamAlimMiktari");

            migrationBuilder.RenameColumn(
                name: "tdrk_TeslimBitis",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_TeslimBitisTarih");

            migrationBuilder.RenameColumn(
                name: "tdrk_TeslimBaslangic",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_TeslimBaslangicTarih");

            migrationBuilder.RenameColumn(
                name: "tdrk_TaksitNu",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_TaksitSayisi");

            migrationBuilder.RenameColumn(
                name: "tdrk_Taksit",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_TaksitNumarasi");

            migrationBuilder.RenameColumn(
                name: "tdrk_Proje",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_ProjeSorumlusu");

            migrationBuilder.RenameColumn(
                name: "tdrk_OncekiTutar",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_OncekiAlimFiyat");

            migrationBuilder.RenameColumn(
                name: "tdrk_OncekiTarih",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_SozlesmeDavetTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_OncekiMiktar",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_KararTutari");

            migrationBuilder.RenameColumn(
                name: "tdrk_OncekiBolge",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_OncekiAlimBolge");

            migrationBuilder.RenameColumn(
                name: "tdrk_Olcu",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_OlcuBirimi");

            migrationBuilder.RenameColumn(
                name: "tdrk_MuhtiraAlim",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_OncekiAlimTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_MuaTarihi",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_MuhtiraAlimTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_Miktar",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_KisimMiktari");

            migrationBuilder.RenameColumn(
                name: "tdrk_Kisim",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_KisimNo");

            migrationBuilder.RenameColumn(
                name: "tdrk_KatiKabul",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_MuaTebligTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_KararTeblig",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_MuaSonuc");

            migrationBuilder.RenameColumn(
                name: "tdrk_IhaleTutari",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_GuncelBirimFiyat");

            migrationBuilder.RenameColumn(
                name: "tdrk_GuncelFiyat",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_BirimFiyati");

            migrationBuilder.RenameColumn(
                name: "tdrk_Eniyifirma",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_IhAlimUsul");

            migrationBuilder.RenameColumn(
                name: "tdrk_Davet",
                table: "TBL_TEDARIKLER",
                newName: "tdrk_MuaAciklamasi");

            migrationBuilder.AlterColumn<string>(
                name: "tdrk_Kuvvet",
                table: "TBL_TEDARIKLER",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<DateTime>(
                name: "tdrk_FizikselMuaSonuc",
                table: "TBL_TEDARIKLER",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "tdrk_FizikselMuaTarih",
                table: "TBL_TEDARIKLER",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tdrk_GecikmeSebebi",
                table: "TBL_TEDARIKLER",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "tdrk_IkmalSevkTarihi",
                table: "TBL_TEDARIKLER",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "tdrk_KararTebligTarih",
                table: "TBL_TEDARIKLER",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "tdrk_KatiKabulTarihi",
                table: "TBL_TEDARIKLER",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tdrk_MalSorumlusu",
                table: "TBL_TEDARIKLER",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tdrk_MuaKomisyonBaskani",
                table: "TBL_TEDARIKLER",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tdrk_MuaUye1",
                table: "TBL_TEDARIKLER",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tdrk_MuaUye2",
                table: "TBL_TEDARIKLER",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tdrk_MuaUye3",
                table: "TBL_TEDARIKLER",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_TEDARIKLER",
                table: "TBL_TEDARIKLER",
                column: "tdrk_TedarikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_TEDARIKLER",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_FizikselMuaSonuc",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_FizikselMuaTarih",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_GecikmeSebebi",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_IkmalSevkTarihi",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_KararTebligTarih",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_KatiKabulTarihi",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_MalSorumlusu",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_MuaKomisyonBaskani",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_MuaUye1",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_MuaUye2",
                table: "TBL_TEDARIKLER");

            migrationBuilder.DropColumn(
                name: "tdrk_MuaUye3",
                table: "TBL_TEDARIKLER");

            migrationBuilder.RenameTable(
                name: "TBL_TEDARIKLER",
                newName: "TBL_TEDARIK");

            migrationBuilder.RenameColumn(
                name: "tdrk_MalTeslimTarihi",
                table: "TBL_TEDARIK",
                newName: "tdrk_MalteslimTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_LabGidisTarihi",
                table: "TBL_TEDARIK",
                newName: "tdrk_LabgidisTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_LabDonusTarihi",
                table: "TBL_TEDARIK",
                newName: "tdrk_LabdonusTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_Yukleyici",
                table: "TBL_TEDARIK",
                newName: "tdrk_Usul");

            migrationBuilder.RenameColumn(
                name: "tdrk_ToplamAlimMiktari",
                table: "TBL_TEDARIK",
                newName: "tdrk_ToplamMiktar");

            migrationBuilder.RenameColumn(
                name: "tdrk_TeslimBitisTarih",
                table: "TBL_TEDARIK",
                newName: "tdrk_TeslimBitis");

            migrationBuilder.RenameColumn(
                name: "tdrk_TeslimBaslangicTarih",
                table: "TBL_TEDARIK",
                newName: "tdrk_TeslimBaslangic");

            migrationBuilder.RenameColumn(
                name: "tdrk_TaksitSayisi",
                table: "TBL_TEDARIK",
                newName: "tdrk_TaksitNu");

            migrationBuilder.RenameColumn(
                name: "tdrk_TaksitNumarasi",
                table: "TBL_TEDARIK",
                newName: "tdrk_Taksit");

            migrationBuilder.RenameColumn(
                name: "tdrk_SozlesmeDavetTarihi",
                table: "TBL_TEDARIK",
                newName: "tdrk_OncekiTarih");

            migrationBuilder.RenameColumn(
                name: "tdrk_ProjeSorumlusu",
                table: "TBL_TEDARIK",
                newName: "tdrk_Proje");

            migrationBuilder.RenameColumn(
                name: "tdrk_OncekiAlimTarihi",
                table: "TBL_TEDARIK",
                newName: "tdrk_MuhtiraAlim");

            migrationBuilder.RenameColumn(
                name: "tdrk_OncekiAlimMiktar",
                table: "TBL_TEDARIK",
                newName: "tdrk_YaklasikMaliyet");

            migrationBuilder.RenameColumn(
                name: "tdrk_OncekiAlimFiyat",
                table: "TBL_TEDARIK",
                newName: "tdrk_OncekiTutar");

            migrationBuilder.RenameColumn(
                name: "tdrk_OncekiAlimBolge",
                table: "TBL_TEDARIK",
                newName: "tdrk_OncekiBolge");

            migrationBuilder.RenameColumn(
                name: "tdrk_OlcuBirimi",
                table: "TBL_TEDARIK",
                newName: "tdrk_Olcu");

            migrationBuilder.RenameColumn(
                name: "tdrk_MuhtiraAlimTarihi",
                table: "TBL_TEDARIK",
                newName: "tdrk_MuaTarihi");

            migrationBuilder.RenameColumn(
                name: "tdrk_MuaTebligTarihi",
                table: "TBL_TEDARIK",
                newName: "tdrk_KatiKabul");

            migrationBuilder.RenameColumn(
                name: "tdrk_MuaSonuc",
                table: "TBL_TEDARIK",
                newName: "tdrk_KararTeblig");

            migrationBuilder.RenameColumn(
                name: "tdrk_MuaAciklamasi",
                table: "TBL_TEDARIK",
                newName: "tdrk_Davet");

            migrationBuilder.RenameColumn(
                name: "tdrk_KisimNo",
                table: "TBL_TEDARIK",
                newName: "tdrk_Kisim");

            migrationBuilder.RenameColumn(
                name: "tdrk_KisimMiktari",
                table: "TBL_TEDARIK",
                newName: "tdrk_Miktar");

            migrationBuilder.RenameColumn(
                name: "tdrk_KararTutari",
                table: "TBL_TEDARIK",
                newName: "tdrk_OncekiMiktar");

            migrationBuilder.RenameColumn(
                name: "tdrk_IhAlimUsul",
                table: "TBL_TEDARIK",
                newName: "tdrk_Eniyifirma");

            migrationBuilder.RenameColumn(
                name: "tdrk_GuncelBirimFiyat",
                table: "TBL_TEDARIK",
                newName: "tdrk_IhaleTutari");

            migrationBuilder.RenameColumn(
                name: "tdrk_BirimFiyati",
                table: "TBL_TEDARIK",
                newName: "tdrk_GuncelFiyat");

            migrationBuilder.AlterColumn<string>(
                name: "tdrk_Kuvvet",
                table: "TBL_TEDARIK",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "tdrk_AlimFiyati",
                table: "TBL_TEDARIK",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tdrk_Cins",
                table: "TBL_TEDARIK",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "tdrk_Donem",
                table: "TBL_TEDARIK",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_TEDARIK",
                table: "TBL_TEDARIK",
                column: "tdrk_TedarikId");
        }
    }
}
