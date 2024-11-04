using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
		public short? SNo { get; set; }

		[Column("tdrk_AlimMuhTarihNo")]
		public DateTime? AlimMuhTarih { get; set; }

		[Column("tdrk_AlimMuhNo")]
		[MaxLength(50)]
		public string AlimMuhNo { get; set; }


		[Column("tdrk_AlimEmriProNo")]
		public string AlimEmriProNo { get; set; }


		[Column("tdrk_AlimMuhTarihNo")]
		public DateTime? ProjeYili { get; set; }

		//[Column("tdrk_Donem")]
		//public short? Donem { get; set; }

		[Column("tdrk_Kategori")]
		[MaxLength(50)]
		public string Kategori { get; set; }

		[Column("tdrk_Kuvvet")]
		//[MaxLength(50)]
		public string Kuvvet { get; set; }

		[Column("tdrk_Kuvvet")]
		//[MaxLength(200)]
		public string MalzemeAdi { get; set; }

		//[Column("tdrk_Cins")]
		//[MaxLength(50)]
		//public string Cins { get; set; }

		[Column("tdrk_OlcuBirimi")]
		[MaxLength(10)]
		public string OlcuBirimi { get; set; }

		[Column("tdrk_KisimMiktari")]
		public int? KisimMiktari { get; set; }

		[Column("tdrk_KisimNo")]
		public short? KisimNumarasi { get; set; }

		[Column("tdrk_TaksitSayisi")]
		public short? TaksitSayisi { get; set; }

		[Column("tdrk_TaksitNumarasi")]
		public short? TaksitNumarasi { get; set; }

		[Column("tdrk_TaksitMiktari")]
		public int? TaksitMiktari { get; set; }

		[Column("tdrk_ToplamAlimMiktari")]
		public int? ToplamAlimMiktari { get; set; }

		[Column("tdrk_IhAlimUsul")]
		[MaxLength(50)]
		public string IhAlimUsul { get; set; }

		[Column("tdrk_YaklasikgidisTarihi")]
		public DateTime? YaklasikgidisTarihi { get; set; }

		[Column("tdrk_YaklasikdonusTarihi")]
		public DateTime? YaklasikdonusTarihi { get; set; }

		[Column("tdrk_IhaleTarihi")]
		public DateTime? IhaleTarihi { get; set; }

		[Column("tdrk_KararTarihi")]
		public DateTime? KararTarihi { get; set; }

		[Column("tdrk_BirimFiyati")]
		public decimal? BirimFiyati { get; set; }

		[Column("tdrk_KararTutari")]
		public decimal? KararTutari { get; set; }

		[Column("tdrk_KararTebligTarih")]
		public DateTime? KararTebligTarih { get; set; }

		[Column("tdrk_SozlesmeDavetTarihi")]
		public DateTime? SozlesmeDavetTarihi { get; set; }

		[Column("tdrk_SozlesmeTarihi")]
		public DateTime? SozlesmeTarihi { get; set; }

		[Column("tdrk_SozlesmeNo")]
		public string SozlesmeNo { get; set; }

		[Column("tdrk_Yukleyici")]
		[MaxLength(50)]
		public string Yukleyici { get; set; }

		[Column("tdrk_TeslimBaslangicTarih")]
		public DateTime? TeslimBaslangicTarih { get; set; }

		[Column("tdrk_TeslimBitisTarih")]
		public DateTime? TeslimBitisTarih { get; set; }

		[Column("tdrk_KatiKabulTarihi")]
		public DateTime? KatiKabulTarihi { get; set; }

		[Column("tdrk_Sevk")]
		public DateTime? Sevk { get; set; }

		[Column("tdrk_Aciklama")]
		public string Aciklama { get; set; }

		[Column("tdrk_ProjeSorumlusu")]
		[MaxLength(50)]
		public string ProjeSorumlusu { get; set; }
		//tedarikson


		//plan
		[Column("tdrk_OncekiAlimTarihi")]
		public DateTime? OncekiAlimTarihi { get; set; }

		[Column("tdrk_OncekiAlimBolge")]
		[MaxLength(50)]
		public string OncekiAlimBolge { get; set; }

		[Column("tdrk_OncekiAlimMiktar")]
		public decimal? OncekiAlimMiktar { get; set; }

		[Column("tdrk_OncekiAlimFiyat")]
		public decimal? OncekiAlimFiyat { get; set; }

		[Column("tdrk_Ufe")]
		public decimal? Ufe { get; set; }

		[Column("tdrk_GuncelBirimFiyat")]
		public decimal? GuncelBirimFiyat { get; set; }

		[Column("tdrk_GuncelTutar")]
		public decimal? GuncelTutar { get; set; }
		//planSon


		//lojistik
		[Column("tdrk_MalTeslimTarihi")]
		public DateTime? MalTeslimTarihi { get; set; }

		[Column("tdrk_MuhtiraTarih")]
		public DateTime? MuhtiraTarih { get; set; }

		[Column("tdrk_TasinirkesilmeTarihi")]
		public DateTime? TasinirkesilmeTarihi { get; set; }

		[Column("tdrk_IkmalSevkTarihi")]
		public DateTime? IkmalSevkTarih { get; set; }
		//lojistikson









		//muayane
		[Column("tdrk_MuhtiraAlimTarihi")]
		public DateTime? MuhtiraAlimTarihi { get; set; }

		[Column("tdrk_MuaTebligTarihi")]
		public DateTime? MuaTebligTarihi { get; set; }

		[Column("tdrk_MuaKomisyonBaskani")]
		public string? MuaKomisyonBaskani { get; set; }
		[Column("tdrk_MuaUye1")]
		public string? MuaUye1 { get; set; }
		[Column("tdrk_MuaUye2")]
		public string? MuaUye2 { get; set; }
		[Column("tdrk_MuaUye3")]
		public string? MuaUye3 { get; set; }
		[Column("tdrk_MalSorumlusu")]
		public string? MalSorumlusu { get; set; }
		[Column("tdrk_GecikmeSebebi")]
		public string? GecikmeSebebi { get; set; }

		[Column("tdrk_FizikselMuaTarih")]
		public DateTime? FizikselMuaTarih { get; set; }
		[Column("tdrk_FizikselMuaSonuc")]
		public DateTime? FizikselMuaSonuc { get; set; }

		[Column("tdrk_LabGidisTarihi")]
		public DateTime? LabGidisTarihi { get; set; }

		[Column("tdrk_LabDonusTarihi")]
		public DateTime? LabDonusTarihi { get; set; }

		[Column("tdrk_MuakararTarihi")]
		public DateTime? MuakararTarihi { get; set; }

		[Column("tdrk_MuaSonuc")]
		public DateTime? MuaSonuc { get; set; }
		[Column("tdrk_MuaAciklamasi")]
		public DateTime? MuaAciklamasi { get; set; }


		//muayaneson
	}
}
