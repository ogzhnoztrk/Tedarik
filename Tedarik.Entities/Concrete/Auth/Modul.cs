using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedarik.Entities.Concrete.Auth
{
    [Table("TBL_MODUL_TANIM")]
    public class Modul
    {

        [Key, Column("mdul_id")]
        public Guid? Id { get; set; }

        [Column("mdul_no")]
        public int? ModulNo { get; set; }

        [Column("modl_adi")]
        public string? ModulAdi { get; set; }
    }
}
