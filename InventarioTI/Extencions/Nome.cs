using InventarioTI.Entites;
using InventarioTI.Entites.emuns;
using InventarioTI.Services;

namespace InventarioTI.Extencions
{
    public static class Nome
    {
        public static void Nomenclatura(this Inventario i)
        {
            if (i.PATRIMONIO.Length > 0) i.NOMENCLATURA = Base.Unidades.FirstOrDefault(x => x.Nome == i.UND).Sigla + new string('0', (8 - i.PATRIMONIO.Length)) + i.PATRIMONIO + i.EQUIPAMENTO[0];
        }
    }
}
