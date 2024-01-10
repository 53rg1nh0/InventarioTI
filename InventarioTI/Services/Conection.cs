using InventarioTI.Entites;
using InventarioTI.Entites.emuns;
using InventarioTI.Entites.Emuns;
using System.Data;

namespace InventarioTI.Services
{
    class Conection<T>
    {
        public string Path { get; }
        public string String { get; }

        public Conection(T t, string unidade = null)
        {

            if (t is Inventario)
            {
                Inventario i = t as Inventario;
                if (unidade == null) unidade = Base.Unidades.FirstOrDefault(u => u.Nome == i.UND).Sigla;
                this.Path = Properties.Settings.Default.Path + @"\" + t.GetType().Name + "_" + unidade + ".xlsx";
                String = @"provider =Microsoft.ACE.OLEDB.12.0;Data Source= " + this.Path + " ;Extended Properties=Excel 12.0";
            }
            else
            {
                this.Path = Properties.Settings.Default.Path + @"\Info\" + (t is Movimentacoes ? t.GetType().Name : "Ajustes") + ".xlsx";
                String = @"provider =Microsoft.ACE.OLEDB.12.0;Data Source= " + this.Path + " ;Extended Properties=Excel 12.0";
            }
        }
    }
    //class Conection
    //{
    //    public string Path { get; }
    //    public Conection(DataTable dt)
    //    {
    //        if (dt.TableName == "Inventario") Path = Properties.Settings.Default.Path + @"\BD.xlsx";              
    //        else
    //        {
    //            Path = Properties.Settings.Default.Path + @"\Info\";
    //            Path += dt.TableName == "Movimentacoes" ? @"Movimentacoes.xlsx" : @"Ajustes.xlsx";
    //        }
    //    }
    //}
}

