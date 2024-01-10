using DocumentFormat.OpenXml.Spreadsheet;
using InventarioTI.Entites;
using InventarioTI.Entites.emuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InventarioTI.Services
{
    public static class Transformar
    {
        public static Equipamento GetEquipamento(this Inventario i)
        {
            Equipamento e = new Equipamento();
            Cliente c = new Cliente();
            if(i != null)
            {
                e.Patrimonio = i.PATRIMONIO.ToString();
                e.Nomenclatura = i.NOMENCLATURA;
                e.Serie = i.SERIE;
                e.Tipo = i.EQUIPAMENTO;
                e.Marca = i.MARCA;
                e.Modelo = i.MODELO;
                e.Processador = i.PROCESSADOR;
                e.Memoria = i.MEMORIA;

                c.UserID = i.USERID;
                c.Nome = i.FUNCIONARIO;
                c.Area = i.AREA;
                c.Cargo = i.CARGO;
                c.UF = i.UF;
                c.Unidade = i.UND;

                e.Cliente = c;
            }
            return e;
        }

        public static Unidade GetUnidade(this Inventario i)
        {
            Unidade u = new Unidade();

         

            return u;
        }
    }
}
