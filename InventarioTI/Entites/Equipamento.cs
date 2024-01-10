using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTI.Entites
{
    public class Equipamento
    {
        public string Patrimonio { get; set; }
        public string Nomenclatura { get; set; }
        public string Serie { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Processador { get; set; }
        public string Memoria { get; set; }
        public Cliente Cliente { get; set; }
    }
}
