using InventarioTI.Entites;
using InventarioTI.Entites.Emuns;
using ClosedXML.Excel;
using System.Reflection;
using System.Collections.Generic;
using InventarioTI.Entites.Exceptions;
using System.Diagnostics;
using System.Data;
using DataTable = System.Data.DataTable;
using InventarioTI.Entites.emuns;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using InventarioTI.Extencions;
using System.Collections.ObjectModel;

namespace InventarioTI.Services
{
    static class Base
    {
        public static DataTable TableInv { get; set; } = new DataTable();
        public static DataTable TableTMMs { get; set; } = new DataTable();
        public static DataTable TableMemorias { get; set; } = new DataTable();
        public static DataTable TableProcessadores { get; set; } = new DataTable();
        public static DataTable TableUnidades { get; set; } = new DataTable();
        public static DataTable TableAdms { get; set; } = new DataTable();
        public static List<Inventario> Inv { get; set; } = new List<Inventario>();
        public static List<TMM> TMMs { get; set; } = new List<TMM>();
        public static List<Memoria> Memorias { get; set; } = new List<Memoria>();
        public static List<Processador> Processadores { get; set; } = new List<Processador>();
        public static List<Unidade> Unidades { get; set; } = new List<Unidade>();
        public static List<Adm> Adms { get; set; } = new List<Adm>();
        public static FormInventario FI { get; set; } = new FormInventario();

        public static string Unidade = Properties.Settings.Default.Unidade;

        public static void Atualizar(bool ajuste = false, bool home = false)
        {
           
            var tmmsAnterior = TMMs as IDisposable;
            var memoriasAnterior = Memorias as IDisposable;
            var processadoresAnterior = Processadores as IDisposable;
            var unidadesAnterior = Unidades as IDisposable;
            var invAterior = Inv as IDisposable;
            var admsAnterior = Adms as IDisposable;
            var tabletmmsAnterior = TableTMMs as IDisposable;
            var tablememoriasAnterior = TableMemorias as IDisposable;
            var tableprocessadoresAnterior = TableProcessadores as IDisposable;
            var tableunidadesAnterior = TableUnidades as IDisposable;
            var tableadmsAnterior = TableAdms as IDisposable;
            var tabeinvAterior = Inv as IDisposable;

            //if (Inv is IDisposable invdAterior) invdAterior.Dispose();
            invAterior?.Dispose();
            tmmsAnterior?.Dispose();
            memoriasAnterior?.Dispose();
            processadoresAnterior?.Dispose();
            unidadesAnterior?.Dispose();
            admsAnterior?.Dispose();
            //if (TableInv is IDisposable tableinvdAterior) tableinvdAterior.Dispose();
            tabeinvAterior?.Dispose();
            tabletmmsAnterior?.Dispose();
            tablememoriasAnterior?.Dispose();
            tableprocessadoresAnterior?.Dispose();
            tableunidadesAnterior?.Dispose();
            tableadmsAnterior?.Dispose();

            Inv = new List<Inventario>();
            TMMs = new List<TMM>();
            Memorias = new List<Memoria>();
            Processadores = new List<Processador>();
            Unidades = new List<Unidade>();
            Adms = new List<Adm>();
            TableInv = new DataTable();
            TableTMMs = new DataTable();
            TableMemorias = new DataTable();
            TableProcessadores = new DataTable();
            TableUnidades = new DataTable();
            TableAdms = new DataTable();

            try
            {
                Validar.BD();
                TableInv = Validar.Inv;
                Inv = TableInv.AsEnumerable().Select(x => new Inventario
                {
                    QUANT = x.Field<object>("QUANT").ToString(),
                    UND = x.Field<object>("UND").ToString(),
                    UF = x.Field<object>("UF").ToString(),
                    FUNCIONARIO = x.Field<object>("FUNCIONARIO").ToString(),
                    USERID = x.Field<object>("USERID").ToString(),
                    CARGO = x.Field<object>("CARGO").ToString(),
                    AREA = x.Field<object>("AREA").ToString(),
                    EQUIPAMENTO = x.Field<object>("EQUIPAMENTO").ToString(),
                    MARCA = x.Field<object>("MARCA").ToString(),
                    MODELO = x.Field<object>("MODELO").ToString(),
                    PROCESSADOR = x.Field<object>("PROCESSADOR").ToString(),
                    PATRIMONIO = x.Field<object>("PATRIMONIO").ToString(),
                    NOMENCLATURA = x.Field<object>("NOMENCLATURA").ToString(),
                    SERIE = x.Field<object>("SERIE").ToString(),
                    MEMORIA = x.Field<object>("MEMORIA").ToString()
                }).ToList();
                using (var wb = new XLWorkbook(Validar.Arquivo + @"\Info\Ajustes.xlsx"))
                {
                    TableTMMs = wb.Worksheet("TMM").RangeUsed().AsTable().AsNativeDataTable();
                    TMMs = TableTMMs.AsEnumerable().Select(x => new TMM
                    {
                        Tipo = x.Field<string>("TIPO"),
                        Marca = x.Field<string>("MARCA"),
                        Modelo = x.Field<string>("MODELO")

                    }).ToList();
                    TableProcessadores = wb.Worksheet("Processador").RangeUsed().AsTable().AsNativeDataTable();
                    Processadores = TableProcessadores.AsEnumerable().Select(x => new Processador
                    {
                        Tipo = x.Field<string>("TIPO")
                    }).ToList();
                    TableMemorias = wb.Worksheet("Memoria").RangeUsed().AsTable().AsNativeDataTable();
                    Memorias = TableMemorias.AsEnumerable().AsEnumerable().Select(x => new Memoria
                    {
                        Ram = x.Field<string>("RAM")
                    }).ToList();
                    TableUnidades = wb.Worksheet("Unidade").RangeUsed().AsTable().AsNativeDataTable();
                    Unidades = TableUnidades.AsEnumerable().Select(x => new Unidade
                    {
                        Regiao = x.Field<string>("REGIAO"),
                        UF = x.Field<string>("UF"),
                        Nome = x.Field<string>("NOME"),
                        Sigla = x.Field<string>("SIGLA")

                    }).ToList();
                    TableAdms = wb.Worksheet("Adm").RangeUsed().AsTable().AsNativeDataTable();
                    Adms = TableAdms.AsEnumerable().Select(x => new Adm
                    {
                        matricula = x.Field<object>("MATRICULA").ToString()

                    }).ToList();
                }
                if (!string.IsNullOrEmpty(Unidade))
                {
                    Quantidade.DesAtv = Inv.Where(e => e.FUNCIONARIO != "Backup TI" && e.FUNCIONARIO != "Estoque TI" && e.UND == Unidades.Where(x => x.Sigla == Unidade).Select(x => x.Nome).First()).Where(e => e.EQUIPAMENTO == "Desktop").Count();
                    Quantidade.NotAtv = Inv.Where(e => e.FUNCIONARIO != "Backup TI" && e.FUNCIONARIO != "Estoque TI" && e.UND == Unidades.Where(x => x.Sigla == Unidade).Select(x => x.Nome).First()).Where(e => e.EQUIPAMENTO == "Notebook").Count();
                    if (Unidade == "MRC")
                    {
                        Quantidade.DesBkp = Inv.Where(e => e.FUNCIONARIO == "Backup TI").Where(e => e.EQUIPAMENTO == "Desktop" && e.UND == Unidades.Where(x => x.Sigla == Unidade).Select(x => x.Nome).First()).Count();
                        Quantidade.NotBkp = Inv.Where(e => e.FUNCIONARIO == "Backup TI").Where(e => e.EQUIPAMENTO == "Notebook" && e.UND == Unidades.Where(x => x.Sigla == Unidade).Select(x => x.Nome).First()).Count();
                        Quantidade.DesEst = Inv.Where(e => e.FUNCIONARIO == "Estoque TI").Where(e => e.EQUIPAMENTO == "Desktop" && e.UND == Unidades.Where(x => x.Sigla == Unidade).Select(x => x.Nome).First()).Count();
                        Quantidade.NotEst = Inv.Where(e => e.FUNCIONARIO == "Estoque TI").Where(e => e.EQUIPAMENTO == "Notebook" && e.UND == Unidades.Where(x => x.Sigla == Unidade).Select(x => x.Nome).First()).Count();
                    }
                    else
                    {
                        Quantidade.DesBkp = 0;
                        Quantidade.NotBkp = 0;
                        Quantidade.DesEst = Inv.Where(e => e.FUNCIONARIO == "Backup TI" || e.FUNCIONARIO == "Estoque TI").Where(e => e.EQUIPAMENTO == "Desktop" && e.UND == Unidades.Where(x => x.Sigla == Unidade).Select(x => x.Nome).First()).Count();
                        Quantidade.NotEst = Inv.Where(e => e.FUNCIONARIO == "Backup TI" || e.FUNCIONARIO == "Estoque TI").Where(e => e.EQUIPAMENTO == "Notebook" && e.UND == Unidades.Where(x => x.Sigla == Unidade).Select(x => x.Nome).First()).Count();
                    }
                }
                FI.Atualizar();
                if (ajuste) FI.uctAjustes.Atualizar();
                if (home) FI.uctHome.Atualizar();
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static Inventario GetBackup(Inventario i, Unidade u)
        {
            i.USERID = "bkp";
            i.FUNCIONARIO = "Backup TI";
            i.AREA = "";
            i.CARGO = "";
            i.UF = u.UF;
            i.UND = u.Nome;
            i.QUANT = "1";
            return i;
        }

        public static void InsertBase()
        {
            try
            {
                //VerificaBases.Excel();



            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        public static void UpdateBase<T>(List<T> alterados, List<T> geral)
        {
            try
            {
                using var workbook = new XLWorkbook(new Conection<T>(alterados.FirstOrDefault()).Path);
                var worksheet = workbook.Worksheet(alterados.FirstOrDefault().GetType().Name);
                var headerRow = worksheet.FirstRow();
                worksheet.AutoFilter.Clear();
                var tabela = worksheet.RangeUsed().AsTable();

                foreach (var alterado in alterados)
                {
                    var properties = alterado.GetType().GetProperties();
                    foreach (var p in properties)
                    {
                        int c = headerRow.CellsUsed(c => c.Value.ToString() == p.Name.ToUpper()).FirstOrDefault().WorksheetColumn().ColumnNumber();
                        int l = geral.IndexOf(alterado) + 2;
                        worksheet.Cell(l, c).Value = (c == 1 || c == 12) ? int.Parse(p.GetValue(alterado).ToString()) : p.GetValue(alterado).ToString();
                    }
                }

                if (double.TryParse(tabela.LastRow().Cell(1).Value.ToString(), out double valorNumerico1))
                {
                    tabela.LastRow().Cell(1).SetValue(valorNumerico1);
                }

                if (double.TryParse(tabela.LastRow().Cell(12).Value.ToString(), out double valorNumerico12))
                {
                    tabela.LastRow().Cell(12).SetValue(valorNumerico12);
                }

                worksheet.RangeUsed().SetAutoFilter();
                worksheet.AutoFilter.Sort(4, XLSortOrder.Ascending, false, true);

                workbook.Save();
                workbook.Dispose();
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void RemoveBase<T>(List<T> list, List<T> geral = null, int index = -1)
        {
            try
            {

            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
