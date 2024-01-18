using InventarioTI.Entites.emuns;
using InventarioTI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventarioTI.Entites
{
    public class Movimentacao:Inventario
    {
        public string STATUS { get; set; }
        public string RESPONSAVEL { get; set; }
        public DateTime DATA { get; set; }
        public string OBSERVACAO { get; set; }

        public Movimentacao(string status, Inventario inventario, string origem = null, bool troca = false)
        {
            STATUS = status;
            QUANT = inventario.QUANT;
            UND = inventario.UND;
            UF = inventario.UF;
            FUNCIONARIO = inventario.FUNCIONARIO;
            USERID = inventario.USERID;
            CARGO = inventario.CARGO;
            AREA = inventario.AREA;
            EQUIPAMENTO = inventario.EQUIPAMENTO;
            MARCA = inventario.MARCA;
            MODELO = inventario.MODELO;
            PROCESSADOR = inventario.PROCESSADOR;
            PATRIMONIO = inventario.PATRIMONIO;
            NOMENCLATURA = inventario.NOMENCLATURA;
            SERIE = inventario.SERIE;
            MEMORIA = inventario.MEMORIA;
            RESPONSAVEL = Base.FI.uctAjustes.txbResponsavel.Text;
            DATA = DateTime.Now;
            switch (STATUS)
            {
                case "adicionado":
                    OBSERVACAO = "Equipamento " + PATRIMONIO + " adicionado";
                    break;
                case "obsoleto":
                    OBSERVACAO = "Equipamento " + PATRIMONIO + " removido. " + origem;
                    break;
                case "novato":
                    OBSERVACAO = "Cliente novato " + USERID + " adicionado";
                    break;
                case "editado":
                    OBSERVACAO = "Informações de equipamento " + PATRIMONIO + " editada";
                    break;
                case "desligado":
                    OBSERVACAO = "Cliente " + USERID + " desligado";
                    break;
                case "movido":
                    OBSERVACAO = USERID != "bkp" && USERID != "est" && !troca ? "Cliente " + USERID + " movido de: " + origem + " para: " + UND :
                        "Equipamento " + PATRIMONIO + " movido de: " + origem + " para: " + UND;
                    break;
                case "troca":
                    OBSERVACAO = "Cliente " + USERID + " trocou equipamento de patrimonio " + origem + " para equipamento patrimônio: " + inventario.PATRIMONIO;
                    break;
            }
        }
       
        public Inventario GetInventario()
        {
            Inventario inventario = new Inventario();

            inventario.QUANT = QUANT;
            inventario.UND = UND;
            inventario.UF = UF;
            inventario.FUNCIONARIO = FUNCIONARIO ;
            inventario.USERID = USERID;
            inventario.CARGO = CARGO;
            inventario.AREA = AREA;
            inventario.EQUIPAMENTO = EQUIPAMENTO;
            inventario.MARCA = MARCA;
            inventario.MODELO = MODELO;
            inventario.PROCESSADOR = PROCESSADOR;
            inventario.PATRIMONIO = PATRIMONIO;
            inventario.NOMENCLATURA = NOMENCLATURA;
            inventario.SERIE = SERIE;
            inventario.MEMORIA = MEMORIA;

            return inventario;
        }
    }
}
