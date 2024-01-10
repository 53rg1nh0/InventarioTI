using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTI.Entites
{
    public class Cliente
    {
        public string UserID { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }
        public string Cargo { get; set; }
        public string UF { get; set; }
        public string Unidade { get; set; }
        //public List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();

    }
}
