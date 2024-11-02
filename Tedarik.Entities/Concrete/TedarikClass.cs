using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedarik.Entities.Concrete
{
    public class TedarikClass
    {
        [Key]
        [Column("tdrk_TedarikId")]
        public Guid Id { get; set; }  // Primary Key

        [Column("tdrk_SNo")]
        public short? SNo { get; set; }

        [Column("tdrk_AlimMuhTarihNo")]
        public DateTime? AlimMuhTarihNo { get; set; }

        [Column("tdrk_AlimMuhNo")]
        [MaxLength(50)]
        public string AlimMuhNo { get; set; }

        [Column("tdrk_AlimEmriProNo")]
        public string AlimEmriProNo { get; set; }

        [Column("tdrk_Donem")]
        public short? Donem { get; set; }

        [Column("tdrk_Kategori")]
        [MaxLength(50)]
        public string Kategori { get; set; }

        [Column("tdrk_Kuvvet")]
        [MaxLength(50)]
        public string Kuvvet { get; set; }

        [Column("tdrk_Cins")]
        [MaxLength(50)]
        public string Cins { get; set; }

        [Column("tdrk_Olcu")]
        [MaxLength(10)]
        public string Olcu { get; set; }

        [Column("tdrk_Miktar")]
        public int? Miktar { get; set; }

        [Column("tdrk_Kisim")]
        public short? Kisim { get; set; }

        [Column("tdrk_Taksit")]
        public short? Taksit { get; set; }

        [Column("tdrk_TaksitNu")]
        public short? TaksitNu { get; set; }

        [Column("tdrk_TaksitMiktari")]
        public int? TaksitMiktari { get; set; }

        [Column("tdrk_ToplamMiktar")]
        public int? ToplamMiktar { get; set; }

        [Column("tdrk_Usul")]
        [MaxLength(50)]
        public string Usul { get; set; }

        [Column("tdrk_YaklasikgidisTarihi")]
        public DateTime? YaklasikgidisTarihi { get; set; }

        [Column("tdrk_YaklasikdonusTarihi")]
        public DateTime? YaklasikdonusTarihi { get; set; }

        [Column("tdrk_IhaleTarihi")]
        public DateTime? IhaleTarihi { get; set; }

        [Column("tdrk_KararTarihi")]
        public DateTime? KararTarihi { get; set; }

        [Column("tdrk_AlimFiyati")]

        public decimal? AlimFiyati { get; set; }

        [Column("tdrk_IhaleTutari")]
        public decimal? IhaleTutari { get; set; }

        [Column("tdrk_KararTeblig")]
        public DateTime? KararTeblig { get; set; }

        [Column("tdrk_Davet")]
        public DateTime? Davet { get; set; }

        [Column("tdrk_SozlesmeTarihi")]
        public DateTime? SozlesmeTarihi { get; set; }

        [Column("tdrk_SozlesmeNo")]
        public string SozlesmeNo { get; set; }

        [Column("tdrk_Eniyifirma")]
        [MaxLength(50)]
        public string Eniyifirma { get; set; }

        [Column("tdrk_TeslimBaslangic")]
        public DateTime? TeslimBaslangic { get; set; }

        [Column("tdrk_TeslimBitis")]
        public DateTime? TeslimBitis { get; set; }

        [Column("tdrk_KatiKabul")]
        public DateTime? KatiKabul { get; set; }

        [Column("tdrk_Sevk")]
        public DateTime? Sevk { get; set; }

        [Column("tdrk_Aciklama")]
        public string Aciklama { get; set; }

        [Column("tdrk_Proje")]
        [MaxLength(50)]
        public string Proje { get; set; }

        [Column("tdrk_OncekiTarih")]
        public DateTime? OncekiTarih { get; set; }

        [Column("tdrk_OncekiBolge")]
        [MaxLength(50)]
        public string OncekiBolge { get; set; }

        [Column("tdrk_OncekiMiktar")]
        public decimal? OncekiMiktar { get; set; }

        [Column("tdrk_OncekiTutar")]

        public decimal? OncekiTutar { get; set; }

        [Column("tdrk_Ufe")]
        public decimal? Ufe { get; set; }

        [Column("tdrk_GuncelFiyat")]
        public decimal? GuncelFiyat { get; set; }

        [Column("tdrk_GuncelTutar")]
        public decimal? GuncelTutar { get; set; }

        [Column("tdrk_YaklasikMaliyet")]
        public decimal? YaklasikMaliyet { get; set; }

        [Column("tdrk_MalteslimTarihi")]
        public DateTime? MalteslimTarihi { get; set; }

        [Column("tdrk_MuhtiraTarih")]
        public DateTime? MuhtiraTarih { get; set; }

        [Column("tdrk_MuhtiraAlim")]
        public DateTime? MuhtiraAlim { get; set; }

        [Column("tdrk_MuaTarihi")]
        public DateTime? MuaTarihi { get; set; }

        [Column("tdrk_LabgidisTarihi")]
        public DateTime? LabgidisTarihi { get; set; }

        [Column("tdrk_LabdonusTarihi")]
        public DateTime? LabdonusTarihi { get; set; }

        [Column("tdrk_MuakararTarihi")]
        public DateTime? MuakararTarihi { get; set; }

        [Column("tdrk_TasinirkesilmeTarihi")]
        public DateTime? TasinirkesilmeTarihi { get; set; }
    }
}
