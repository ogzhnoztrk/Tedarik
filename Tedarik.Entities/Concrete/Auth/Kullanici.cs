using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedarik.Entities.Concrete.Auth
{
    [Table("TBL_KULLANICILAR")]
    public class Kullanici
    {
        [Column("kllnc_id")]
        public Guid Id { get; set; }

        [Column("kllnc_adi")]
        public string KullaniciAdi { get; set; }

        [Column("kllnc_soyadi")]
        public string KullaniciSoyadi { get; set; }

        [Column("kllnc_posta")]
        public string KullaniciPosta { get; set; }


        [Column("kllnc_sifre_hash")]
        public byte[] SifreHash { get; set; }

        [Column("kllnc_sifre_salt")]
        public byte[] SifreSalt { get; set; }
         [Column("kllnc_aktif_mi")]
        public bool AktifMi{ get; set; }

      

    }
}
