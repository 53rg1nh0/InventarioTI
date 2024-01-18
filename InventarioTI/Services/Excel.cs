using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using InventarioTI.Entites.emuns;
using System.Diagnostics;
using InventarioTI.Entites.Exceptions;

namespace InventarioTI.Services
{
    public static class Excel
    {

        private static Microsoft.Office.Interop.Excel.Application _app;
        private static Workbook _pasta;

        public static void Abrir(string path)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Path))
            {
                _app = new Microsoft.Office.Interop.Excel.Application();
                _pasta = _app.Workbooks.Open(path);
            }          
        }

        public static void Fechar()
        {
            Thread.Sleep(1000);
            Process[] processes = Process.GetProcessesByName("Excel");

            foreach (Process process in processes)
            {
                //process.Kill();
                //process.Close();

            }

            if (_pasta != null)
            {
                _pasta.Save();
                _pasta.Close();
                _app.Quit();
            }
        }

        public static bool Aberto()
        {
            Process[] processes = Process.GetProcessesByName("Excel");

            if (processes.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void EsperarFechar()
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            while (Aberto() && tempo.Elapsed.Milliseconds<5000) ;
            tempo.Stop();
            if(tempo.Elapsed.Milliseconds >= 5000)
            {
                throw new DomainException("Timeout! Feche o excel que está aberto e tente novamente");
            }
        }
    }
}
