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

        public Conection(T t)
        {

            if (t is Inventario)
            {
                Inventario i = t as Inventario;
                this.Path = Properties.Settings.Default.Path + @"\BD.xlsx";
                String = @"provider =Microsoft.ACE.OLEDB.12.0;Data Source= " + this.Path + " ;Extended Properties=Excel 12.0";
            }
            else
            {
                this.Path = Properties.Settings.Default.Path + @"\Info\" + ((t is Movimentacoes) ? t.GetType().Name : "Ajustes") + ".xlsx";
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

