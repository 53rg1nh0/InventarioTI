using ClosedXML.Excel;
using InventarioTI.Entites;
using InventarioTI.Entites.Exceptions;
using InventarioTI.Services;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
//using Microsoft.Office.Interop.Excel;

namespace InventarioTI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            try
            {
                //Stopwatch stopwatch = new Stopwatch();
                //stopwatch.Start();

                //using (var wb = new XLWorkbook(@"C:\Users\sesousa\OneDrive - SOLAR BEBIDAS S.A\Desktop\InventarioTI - Copia - Copia\BD.xlsx"))
                //{
                //    var ws = wb.Worksheet(1);
                //    DataTable dataTable = ws.RangeUsed().AsTable().AsNativeDataTable();
                //}

                //stopwatch.Stop();
                //MessageBox.Show(stopwatch.Elapsed.Milliseconds.ToString());
                // Seu código aqui
               

                ApplicationConfiguration.Initialize();
                Application.Run(new FormInventario());
            }
            catch (DomainException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}