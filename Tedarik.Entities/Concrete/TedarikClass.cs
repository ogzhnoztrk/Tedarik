using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedarik.Entities.Concrete
{
	[Table("TBL_TEDARIKLER")]
	public class TedarikClass
	{

		//tedarik
		[Key]
		[Column("tdrk_TedarikId")]
		public Guid Id { get; set; }  // Primary Key

		[Column("tdrk_SNo")]
		[AllowNull]public short? SNo { get; set; }

		[Column("tdrk_AlimMuhTarihNo")]
		public DateTime? AlimMuhTarih { get; set; }

		[Column("tdrk_AlimMuhNo")]
		[MaxLength(50)]
		public string AlimMuhNo { get; set; }


		[Column("tdrk_AlimEmriProNo")]
		public string AlimEmriProNo { get; set; }


		[Column("tdrk_ProjeYili")]
		[AllowNull] public DateTime? ProjeYili { get; set; }

		//[Column("tdrk_Donem")]
		//public short? Donem { get; set; }

		[Column("tdrk_Kategori")]
		[MaxLength(50)]
		public string Kategori { get; set; }

		[Column("tdrk_Kuvvet")]
		public string Kuvvet { get; set; }

		[Column("tdrk_MalzemeAdi")]
		//[MaxLength(200)]
		public string MalzemeAdi { get; set; }

		//[Column("tdrk_Cins")]
		//[MaxLength(50)]
		//public string Cins { get; set; }

		[Column("tdrk_OlcuBirimi")]
		[MaxLength(10)]
		public string OlcuBirimi { get; set; }

		[Column("tdrk_KisimMiktari")]
		[AllowNull] public int? KisimMiktari { get; set; }

		[Column("tdrk_KisimNo")]
		[AllowNull] public short? KisimNumarasi { get; set; }

		[Column("tdrk_TaksitSayisi")]
		[AllowNull] public short? TaksitSayisi { get; set; }

		[Column("tdrk_TaksitNumarasi")]
		[AllowNull] public short? TaksitNumarasi { get; set; }

		[Column("tdrk_TaksitMiktari")]
		[AllowNull] public int? TaksitMiktari { get; set; }

		[Column("tdrk_ToplamAlimMiktari")]
		[AllowNull] public int? ToplamAlimMiktari { get; set; }

		[Column("tdrk_IhAlimUsul")]
		[MaxLength(50)]
		public string IhAlimUsul { get; set; }

		[Column("tdrk_YaklasikgidisTarihi")]
		[AllowNull] public DateTime? YaklasikgidisTarihi { get; set; }

		[Column("tdrk_YaklasikdonusTarihi")]
		[AllowNull] public DateTime? YaklasikdonusTarihi { get; set; }

		[Column("tdrk_IhaleTarihi")]
		[AllowNull] public DateTime? IhaleTarihi { get; set; }

		[Column("tdrk_KararTarihi")]
		[AllowNull] public DateTime? KararTarihi { get; set; }

		[Column("tdrk_BirimFiyati")]
		[AllowNull] public decimal? BirimFiyati { get; set; }

		[Column("tdrk_KararTutari")]
		[AllowNull] public decimal? KararTutari { get; set; }

		[Column("tdrk_KararTebligTarih")]
		[AllowNull] public DateTime? KararTebligTarih { get; set; }

		[Column("tdrk_SozlesmeDavetTarihi")]
		[AllowNull] public DateTime? SozlesmeDavetTarihi { get; set; }

		[Column("tdrk_SozlesmeTarihi")]
		[AllowNull] public DateTime? SozlesmeTarihi { get; set; }

		[Column("tdrk_SozlesmeNo")]
		public string SozlesmeNo { get; set; }

		[Column("tdrk_Yukleyici")]
		[MaxLength(50)]
		public string Yukleyici { get; set; }

		[Column("tdrk_TeslimBaslangicTarih")]
		[AllowNull] public DateTime? TeslimBaslangicTarih { get; set; }

		[Column("tdrk_TeslimBitisTarih")]
		[AllowNull] public DateTime? TeslimBitisTarih { get; set; }

		[Column("tdrk_KatiKabulTarihi")]
		[AllowNull] public DateTime? KatiKabulTarihi { get; set; }

		[Column("tdrk_Sevk")]
		[AllowNull] public DateTime? Sevk { get; set; }

		[Column("tdrk_Aciklama")]
		public string Aciklama { get; set; }

		[Column("tdrk_ProjeSorumlusu")]
		[MaxLength(50)]
		public string ProjeSorumlusu { get; set; }
		//tedarikson


		//plan
		[Column("tdrk_OncekiAlimTarihi")]
		[AllowNull] public DateTime? OncekiAlimTarihi { get; set; }

		[Column("tdrk_OncekiAlimBolge")]
		[MaxLength(50)]
		[AllowNull] public string? OncekiAlimBolge { get; set; }

		[Column("tdrk_OncekiAlimMiktar")]
		[AllowNull] public decimal? OncekiAlimMiktar { get; set; }

		[Column("tdrk_OncekiAlimFiyat")]
		[AllowNull] public decimal? OncekiAlimFiyat { get; set; }

		[Column("tdrk_Ufe")]
		[AllowNull]public decimal? Ufe { get; set; }

		[Column("tdrk_GuncelBirimFiyat")]
		[AllowNull] public decimal? GuncelBirimFiyat { get; set; }

		[Column("tdrk_GuncelTutar")]
		[AllowNull] public decimal? GuncelTutar { get; set; }
		//planSon


		//lojistik
		[Column("tdrk_MalTeslimTarihi")]
		[AllowNull] public DateTime? MalTeslimTarihi { get; set; }

		[Column("tdrk_MuhtiraTarih")]
		[AllowNull] public DateTime? MuhtiraTarih { get; set; }

		[Column("tdrk_TasinirkesilmeTarihi")]
		[AllowNull] public DateTime? TasinirkesilmeTarihi { get; set; }

		[Column("tdrk_IkmalSevkTarihi")]
		[AllowNull] public DateTime? IkmalSevkTarih { get; set; }
		//lojistikson









		//muayane
		[Column("tdrk_MuhtiraAlimTarihi")]
		[AllowNull] public DateTime? MuhtiraAlimTarihi { get; set; }

		[Column("tdrk_MuaTebligTarihi")]
		[AllowNull] public DateTime? MuaTebligTarihi { get; set; }

		[Column("tdrk_MuaKomisyonBaskani")]
		[AllowNull] public string? MuaKomisyonBaskani { get; set; }
		[Column("tdrk_MuaUye1")]
		[AllowNull] public string? MuaUye1 { get; set; }
		[Column("tdrk_MuaUye2")]
		[AllowNull] public string? MuaUye2 { get; set; }
		[Column("tdrk_MuaUye3")]
		public string? MuaUye3 { get; set; }
		[Column("tdrk_MalSorumlusu")]
		[AllowNull] public string? MalSorumlusu { get; set; }
		[Column("tdrk_GecikmeSebebi")]
		[AllowNull] public string? GecikmeSebebi { get; set; }

		[Column("tdrk_FizikselMuaTarih")]
		[AllowNull] public DateTime? FizikselMuaTarih { get; set; }
		[Column("tdrk_FizikselMuaSonuc")]
		[AllowNull] public DateTime? FizikselMuaSonuc { get; set; }

		[Column("tdrk_LabGidisTarihi")]
		[AllowNull] public DateTime? LabGidisTarihi { get; set; }

		[Column("tdrk_LabDonusTarihi")]
		[AllowNull] public DateTime? LabDonusTarihi { get; set; }

		[Column("tdrk_MuakararTarihi")]
		[AllowNull] public DateTime? MuakararTarihi { get; set; }

		[Column("tdrk_MuaSonuc")]
		[AllowNull] public DateTime? MuaSonuc { get; set; }
		[Column("tdrk_MuaAciklamasi")]
		[AllowNull] public DateTime? MuaAciklamasi { get; set; }


		//muayaneson
	}
}
