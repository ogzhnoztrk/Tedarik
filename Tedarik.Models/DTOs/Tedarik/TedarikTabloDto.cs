using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedarik.Models.DTOs.Tedarik
{
    public class TedarikTabloDto
    {
        public Guid? Id { get; set; }
        public short? Sno { get; set; }
        public string? AlimMuhtarasiNo { get; set; }
        public string? AlimEmriProjeNo { get; set; }
        public DateTime? ProjeYili { get; set; }
        public string? Kategori { get; set; }
        public string? Kuvvet { get; set; }
        public string? MalzemeAdi { get; set; }
        public string? OlcuBirimi { get; set; }
        public int? KisimMiktari { get; set; }
        public short? KisimNumarasi { get; set; }
        public short? TaksitSayisi { get; set; }
        public string? SozlesmeNo { get; set; }
    }
}
