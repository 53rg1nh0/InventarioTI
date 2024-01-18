using InventarioTI.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTI.Services
{
    static class Quantidade
    {
        public static int NotEst { get; set; }
        public static int DesEst { get; set; }
        public static int NotBkp { get; set; }
        public static int DesBkp { get; set; }
        public static int NotAtv { get; set; }
        public static int DesAtv { get; set; }

        public static void Calucular()
        {
            if (!string.IsNullOrEmpty(Base.Unidade))
            {
                DesAtv = Base.Inv.Where(e => e.FUNCIONARIO != "Backup TI" && e.FUNCIONARIO != "Estoque TI" && e.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First()).Where(e => e.EQUIPAMENTO == "Desktop").Count();
                NotAtv = Base.Inv.Where(e => e.FUNCIONARIO != "Backup TI" && e.FUNCIONARIO != "Estoque TI" && e.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First()).Where(e => e.EQUIPAMENTO == "Notebook").Count();
                if (Base.Unidade == "MRC")
                {
                    DesBkp = Base.Inv.Where(e => e.FUNCIONARIO == "Backup TI").Where(e => e.EQUIPAMENTO == "Desktop" && e.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First()).Count();
                    NotBkp = Base.Inv.Where(e => e.FUNCIONARIO == "Backup TI").Where(e => e.EQUIPAMENTO == "Notebook" && e.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First()).Count();
                    DesEst = Base.Inv.Where(e => e.FUNCIONARIO == "Estoque TI").Where(e => e.EQUIPAMENTO == "Desktop" && e.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First()).Count();
                    NotEst = Base.Inv.Where(e => e.FUNCIONARIO == "Estoque TI").Where(e => e.EQUIPAMENTO == "Notebook" && e.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First()).Count();
                }
                else
                {
                    DesBkp = 0;
                    NotBkp = 0;
                    DesEst = Base.Inv.Where(e => e.FUNCIONARIO == "Backup TI" || e.FUNCIONARIO == "Estoque TI").Where(e => e.EQUIPAMENTO == "Desktop" && e.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First()).Count();
                    NotEst = Base.Inv.Where(e => e.FUNCIONARIO == "Backup TI" || e.FUNCIONARIO == "Estoque TI").Where(e => e.EQUIPAMENTO == "Notebook" && e.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First()).Count();
                }
            }
        }
    }

    
}
