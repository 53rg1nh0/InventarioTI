using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using InventarioTI.Entites.emuns;

namespace InventarioTI.Services
{
    public static class Excel
    {
        private static Microsoft.Office.Interop.Excel.Application _app = new Microsoft.Office.Interop.Excel.Application();
        private static Workbook _pasta;
        private static Worksheet _plan;


        public static void Abrir(string path)
        {
           if(!string.IsNullOrEmpty(Properties.Settings.Default.Path)) _pasta = _app.Workbooks.Open(path);           
        }

        public static void Fechar()
        {
            if (_pasta != null)
            {
                _pasta.Close();
                _app.Quit();
            }
        }
    }
}
