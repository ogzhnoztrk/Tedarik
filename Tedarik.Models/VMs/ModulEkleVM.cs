using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Entities.Concrete.Auth;

namespace Tedarik.Models.VMs
{
    public class ModulEkleVM
    {
        public List<Modul>? Moduller { get; set; }
        public string? KullaniciId { get; set; }
        public List<string>? ModulIdListe { get; set; }
        public bool ModulVarMi { get; set; }
        public List<Yetki>? Yetkiler { get; set; }
    }
}
