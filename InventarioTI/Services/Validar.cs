﻿using InventarioTI.Entites.emuns;
using InventarioTI.Entites.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTI.Services
{
    public static class Validar
    {
        public static string Arquivo { get; set; } = Properties.Settings.Default.Path;

        public static DataTable Inv { get; set; }

        public static void ExistenciaPastasArquivos(string path)
        {
            string p = /*@"C:\Users\sesousa\OneDrive - SOLAR BEBIDAS S.A\Desktop\InventarioTI - Copia - Copia"*/ path;
            if (!Directory.Exists(p)) throw new DomainException("Pasta não existe!");
            if (!Directory.Exists(p + @"\Info")) throw new DomainException("Pasta Info não existe!");
            if (!File.Exists(p + @"\BD.xlsx")) throw new DomainException("Pasta não contem intentário!");
            if (!File.Exists(p + @"\Info\Ajustes.xlsx")) throw new DomainException("Pasta Info não contem Ajustes!");
            if (!File.Exists(p + @"\Info\Movimentacoes.xlsx")) throw new DomainException("Pasta Info não contem Movimentações!");

            Arquivo = /*p*/ path;

        }

        public static void ExcelFechado()
        {
            try
            {

                using (FileStream fileStream = File.Open(Arquivo + @"\BD.xlsx", FileMode.Open, FileAccess.ReadWrite, FileShare.None)) { }
                using (FileStream fileStream = File.Open(Arquivo + @"\Info\Ajustes.xlsx", FileMode.Open, FileAccess.ReadWrite, FileShare.None)) { }
                using (FileStream fileStream = File.Open(Arquivo + @"\Info\Movimentacoes.xlsx", FileMode.Open, FileAccess.ReadWrite, FileShare.None)) { }
            }
            catch
            {
                throw new DomainException("Feche as bases excel para o funcionamento do Programa!");
            }

        }

        public static void BD()
        {

            
            //ExcelFechado();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            using (OleDbConnection Conexao = new OleDbConnection(new Conection<Inventario>(new Inventario()).String))
            {
                string Sql = "SELECT * FROM [Inventario$]";

                OleDbCommand Comandos = new OleDbCommand(Sql, Conexao);


                Conexao.Open();

                OleDbDataAdapter adp = new OleDbDataAdapter(Comandos);
                DataTable dt = new DataTable();
                adp.Fill(dt);


                foreach (DataColumn c in dt.Columns)
                {
                    if (!(c.ColumnName == "QUANT" || c.ColumnName == "UND" || c.ColumnName == "UF" || c.ColumnName == "FUNCIONARIO" || c.ColumnName == "USERID"
                        || c.ColumnName == "CARGO" || c.ColumnName == "AREA" || c.ColumnName == "EQUIPAMENTO" || c.ColumnName == "MARCA" || c.ColumnName == "MODELO"
                         || c.ColumnName == "PROCESSADOR" || c.ColumnName == "PATRIMONIO" || c.ColumnName == "NOMENCLATURA" || c.ColumnName == "SERIE" || c.ColumnName == "MEMORIA"))
                        throw new Exception("Planilha BD fora do Padrão!");
                }
                Inv = dt;

                Conexao.Close();


            }


            //using (var wb = new XLWorkbook(Arquivo + @"\BD.xlsx"))
            //{
            //    var ws = wb.Worksheet("Inventario");
            //    DataTable dt = ws.RangeUsed().AsTable().AsNativeDataTable();
            //    foreach (DataColumn c in dt.Columns)
            //    {
            //        if (!(c.ColumnName == "QUANT" || c.ColumnName == "UND" || c.ColumnName == "UF" || c.ColumnName == "FUNCIONARIO" || c.ColumnName == "USERID"
            //            || c.ColumnName == "CARGO" || c.ColumnName == "AREA" || c.ColumnName == "EQUIPAMENTO" || c.ColumnName == "MARCA" || c.ColumnName == "MODELO"
            //             || c.ColumnName == "PROCESSADOR" || c.ColumnName == "PATRIMONIO" || c.ColumnName == "NOMENCLATURA" || c.ColumnName == "SERIE" || c.ColumnName == "MEMORIA"))
            //            throw new Exception("Planilha BD fora do Padrão!");
            //    }
            //    Inv = dt;
            //}

            stopwatch.Stop();

            MessageBox.Show("O processo levou " + stopwatch.ElapsedMilliseconds + " milissegundos para executar.");
        }

    }
}
