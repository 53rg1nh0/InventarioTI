using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = iTextSharp.text.Image;
using Font = iTextSharp.text.Font;
using InventarioTI.Entites;
using Rectangle = iTextSharp.text.Rectangle;
using InventarioTI.Entites.emuns;

namespace InventarioTI.Services
{
    internal class Termo
    {
        private static Unidade _unidade = new();
        private static string _path, _file;


        public static void PDF(List<Inventario> list, string acessorios, bool equipamento = true, bool headset = false)
        {
            
        }

        private static void CriarPasta()
        {

            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
        }
    }
}
