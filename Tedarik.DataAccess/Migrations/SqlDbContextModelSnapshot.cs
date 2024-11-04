﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tedarik.DataAccess.Context;

#nullable disable

namespace Tedarik.DataAccess.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Tedarik.Entities.Concrete.Auth.Kullanici", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("kllnc_id");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit")
                        .HasColumnName("kllnc_aktif_mi");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("kllnc_adi");

                    b.Property<string>("KullaniciPosta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("kllnc_posta");

                    b.Property<string>("KullaniciSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("kllnc_soyadi");

                    b.Property<byte[]>("SifreHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("kllnc_sifre_hash");

                    b.Property<byte[]>("SifreSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("kllnc_sifre_salt");

                    b.HasKey("Id");

                    b.ToTable("TBL_KULLANICILAR");
                });

            modelBuilder.Entity("Tedarik.Entities.Concrete.Auth.Modul", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("mdul_id");

                    b.Property<string>("ModulAdi")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modl_adi");

                    b.Property<int?>("ModulNo")
                        .HasColumnType("int")
                        .HasColumnName("mdul_no");

                    b.HasKey("Id");

                    b.ToTable("TBL_MODUL_TANIM");
                });

            modelBuilder.Entity("Tedarik.Entities.Concrete.Auth.Yetki", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ytki_id");

                    b.Property<Guid?>("KullaniciId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("kllnc_id");

                    b.Property<Guid?>("ModulId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("mdul_id");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("ModulId");

                    b.ToTable("TBL_YETKI");
                });

            modelBuilder.Entity("Tedarik.Entities.Concrete.TedarikClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("tdrk_TedarikId");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_Aciklama");

                    b.Property<string>("AlimEmriProNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_AlimEmriProNo");

                    b.Property<string>("AlimMuhNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tdrk_AlimMuhNo");

                    b.Property<DateTime?>("AlimMuhTarih")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_AlimMuhTarihNo");

                    b.Property<decimal?>("BirimFiyati")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("tdrk_BirimFiyati");

                    b.Property<DateTime?>("FizikselMuaSonuc")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_FizikselMuaSonuc");

                    b.Property<DateTime?>("FizikselMuaTarih")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_FizikselMuaTarih");

                    b.Property<string>("GecikmeSebebi")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_GecikmeSebebi");

                    b.Property<decimal?>("GuncelBirimFiyat")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("tdrk_GuncelBirimFiyat");

                    b.Property<decimal?>("GuncelTutar")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("tdrk_GuncelTutar");

                    b.Property<string>("IhAlimUsul")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tdrk_IhAlimUsul");

                    b.Property<DateTime?>("IhaleTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_IhaleTarihi");

                    b.Property<DateTime?>("IkmalSevkTarih")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_IkmalSevkTarihi");

                    b.Property<DateTime?>("KararTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_KararTarihi");

                    b.Property<DateTime?>("KararTebligTarih")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_KararTebligTarih");

                    b.Property<decimal?>("KararTutari")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("tdrk_KararTutari");

                    b.Property<string>("Kategori")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tdrk_Kategori");

                    b.Property<DateTime?>("KatiKabulTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_KatiKabulTarihi");

                    b.Property<int?>("KisimMiktari")
                        .HasColumnType("int")
                        .HasColumnName("tdrk_KisimMiktari");

                    b.Property<short?>("KisimNumarasi")
                        .HasColumnType("smallint")
                        .HasColumnName("tdrk_KisimNo");

                    b.Property<string>("Kuvvet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_Kuvvet");

                    b.Property<DateTime?>("LabDonusTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_LabDonusTarihi");

                    b.Property<DateTime?>("LabGidisTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_LabGidisTarihi");

                    b.Property<string>("MalSorumlusu")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_MalSorumlusu");

                    b.Property<DateTime?>("MalTeslimTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_MalTeslimTarihi");

                    b.Property<string>("MalzemeAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_MalzemeAdi");

                    b.Property<DateTime?>("MuaAciklamasi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_MuaAciklamasi");

                    b.Property<string>("MuaKomisyonBaskani")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_MuaKomisyonBaskani");

                    b.Property<DateTime?>("MuaSonuc")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_MuaSonuc");

                    b.Property<DateTime?>("MuaTebligTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_MuaTebligTarihi");

                    b.Property<string>("MuaUye1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_MuaUye1");

                    b.Property<string>("MuaUye2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_MuaUye2");

                    b.Property<string>("MuaUye3")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_MuaUye3");

                    b.Property<DateTime?>("MuakararTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_MuakararTarihi");

                    b.Property<DateTime?>("MuhtiraAlimTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_MuhtiraAlimTarihi");

                    b.Property<DateTime?>("MuhtiraTarih")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_MuhtiraTarih");

                    b.Property<string>("OlcuBirimi")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("tdrk_OlcuBirimi");

                    b.Property<string>("OncekiAlimBolge")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tdrk_OncekiAlimBolge");

                    b.Property<decimal?>("OncekiAlimFiyat")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("tdrk_OncekiAlimFiyat");

                    b.Property<decimal?>("OncekiAlimMiktar")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("tdrk_OncekiAlimMiktar");

                    b.Property<DateTime?>("OncekiAlimTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_OncekiAlimTarihi");

                    b.Property<string>("ProjeSorumlusu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tdrk_ProjeSorumlusu");

                    b.Property<DateTime?>("ProjeYili")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_ProjeYili");

                    b.Property<short?>("SNo")
                        .HasColumnType("smallint")
                        .HasColumnName("tdrk_SNo");

                    b.Property<DateTime?>("Sevk")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_Sevk");

                    b.Property<DateTime?>("SozlesmeDavetTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_SozlesmeDavetTarihi");

                    b.Property<string>("SozlesmeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tdrk_SozlesmeNo");

                    b.Property<DateTime?>("SozlesmeTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_SozlesmeTarihi");

                    b.Property<int?>("TaksitMiktari")
                        .HasColumnType("int")
                        .HasColumnName("tdrk_TaksitMiktari");

                    b.Property<short?>("TaksitNumarasi")
                        .HasColumnType("smallint")
                        .HasColumnName("tdrk_TaksitNumarasi");

                    b.Property<short?>("TaksitSayisi")
                        .HasColumnType("smallint")
                        .HasColumnName("tdrk_TaksitSayisi");

                    b.Property<DateTime?>("TasinirkesilmeTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_TasinirkesilmeTarihi");

                    b.Property<DateTime?>("TeslimBaslangicTarih")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_TeslimBaslangicTarih");

                    b.Property<DateTime?>("TeslimBitisTarih")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_TeslimBitisTarih");

                    b.Property<int?>("ToplamAlimMiktari")
                        .HasColumnType("int")
                        .HasColumnName("tdrk_ToplamAlimMiktari");

                    b.Property<decimal?>("Ufe")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("tdrk_Ufe");

                    b.Property<DateTime?>("YaklasikdonusTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_YaklasikdonusTarihi");

                    b.Property<DateTime?>("YaklasikgidisTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("tdrk_YaklasikgidisTarihi");

                    b.Property<string>("Yukleyici")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tdrk_Yukleyici");

                    b.HasKey("Id");

                    b.ToTable("TBL_TEDARIKLER");
                });

            modelBuilder.Entity("Tedarik.Entities.Concrete.Auth.Yetki", b =>
                {
                    b.HasOne("Tedarik.Entities.Concrete.Auth.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId");

                    b.HasOne("Tedarik.Entities.Concrete.Auth.Modul", "Modul")
                        .WithMany()
                        .HasForeignKey("ModulId");

                    b.Navigation("Kullanici");

                    b.Navigation("Modul");
                });
#pragma warning restore 612, 618
        }
    }
}
