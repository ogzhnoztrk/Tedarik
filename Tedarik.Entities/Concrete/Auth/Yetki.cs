using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedarik.Entities.Concrete.Auth
{
    [Table("TBL_YETKI")]
    public class Yetki
    {

        [Key, Column("ytki_id")]
        public Guid Id { get; set; }

        [Column("mdul_id"), ForeignKey(nameof(Modul))]
        [AllowNull]
        public Guid? ModulId { get; set; }
        [AllowNull]
        public Modul? Modul { get; set; }

        [Column("kllnc_id"), ForeignKey(nameof(Kullanici))]
        [AllowNull]

        public Guid? KullaniciId { get; set; }
        [AllowNull]
        public Kullanici? Kullanici { get; set; }

      

    }
}
