using InventarioTI.Entites.emuns;
using InventarioTI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTI.Entites.Emuns
{
    public class Movimentacoes
    {
        public string STATUS { get; set; }
        public Inventario Inventario { get; set; }
        public string RESPONSAVEL { get; set; }
        public DateTime DATA { get; set; }
        public string OBSERVACAO { get; set; }

        public Movimentacoes(string status, Inventario inventario, string origem = null,bool troca = false)
        {
            STATUS = status;
            Inventario = inventario;
            //RESPONSAVEL = Base.FI.uctAjustes.txbResponsavel.Text;
            DATA = DateTime.Now;
            switch (STATUS)
            {
                case "adicionado":
                    OBSERVACAO = "Equipamento " + Inventario.PATRIMONIO + " adicionado";
                    break;
                case "obsoleto":
                    OBSERVACAO = "Equipamento " + Inventario.PATRIMONIO + " removido. "+ origem;
                    break;
                case "novato":
                    OBSERVACAO = "Cliente novato " + Inventario.USERID + " adicionado";
                    break;
                case "editado":
                    OBSERVACAO = "Informações de equipamento " + Inventario.PATRIMONIO + " editada";
                    break;
                case "desligado":
                    OBSERVACAO = "Cliente " + Inventario.USERID + " desligado";
                    break;
                case "movido":
                    OBSERVACAO = ((Inventario.USERID != "bkp" && Inventario.USERID != "est") && !troca ) ? "Cliente " + Inventario.USERID + " movido de: " + origem + " para: " + Inventario.UND :
                        "Equipamento " + Inventario.PATRIMONIO + " movido de: " + origem + " para: " + Inventario.UND;
                    break;
                case "troca":
                    OBSERVACAO = "Cliente " + Inventario.USERID + " trocou equipamento de patrimonio " + origem + " para equipamento patrimônio: " + inventario.PATRIMONIO;
                    break;

            }
        }
    }
}
