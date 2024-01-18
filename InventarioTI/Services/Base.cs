﻿using InventarioTI.Entites;
using ClosedXML.Excel;
using InventarioTI.Entites.Exceptions;
using System.Diagnostics;
using System.Data;
using DataTable = System.Data.DataTable;
using InventarioTI.Entites.emuns;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;

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
            var tableinvsAterior = Inv as IDisposable;

            //if (Inv is IDisposable invdAterior) invdAterior.Dispose();
            invAterior?.Dispose();
            tmmsAnterior?.Dispose();
            memoriasAnterior?.Dispose();
            processadoresAnterior?.Dispose();
            unidadesAnterior?.Dispose();
            admsAnterior?.Dispose();
            //if (TableInv is IDisposable tableinvdAterior) tableinvdAterior.Dispose();
            tableinvsAterior?.Dispose();
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
                Excel.EsperarFechar();
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
                using (OleDbConnection Conexao = new OleDbConnection(new Conection().String))
                {

                    Conexao.Open();
                    string Sql = "SELECT * FROM [TMM$]";
                    OleDbCommand Comandos = new OleDbCommand(Sql, Conexao);
                    OleDbDataAdapter adp = new OleDbDataAdapter(new OleDbCommand("SELECT * FROM [TMM$]", Conexao));
                    adp.Fill(TableTMMs);
                    TMMs = TableTMMs.AsEnumerable().Select(x => new TMM
                    {
                        Tipo = x.Field<string>("TIPO"),
                        Marca = x.Field<string>("MARCA"),
                        Modelo = x.Field<string>("MODELO")

                    }).ToList();

                    Sql = "SELECT * FROM [Processador$]";
                    Comandos = new OleDbCommand(Sql, Conexao);
                    adp = new OleDbDataAdapter(Comandos);
                    adp.Fill(TableProcessadores);
                    Processadores = TableProcessadores.AsEnumerable().Select(x => new Processador
                    {
                        Tipo = x.Field<string>("TIPO")
                    }).ToList();

                    Sql = "SELECT * FROM [Memoria$]";
                    Comandos = new OleDbCommand(Sql, Conexao);
                    adp = new OleDbDataAdapter(Comandos);
                    adp.Fill(TableMemorias);
                    Memorias = TableMemorias.AsEnumerable().AsEnumerable().Select(x => new Memoria
                    {
                        Ram = x.Field<string>("RAM")
                    }).ToList();

                    Sql = "SELECT * FROM [Unidade$]";
                    Comandos = new OleDbCommand(Sql, Conexao);
                    adp = new OleDbDataAdapter(Comandos);
                    adp.Fill(TableUnidades);
                    Unidades = TableUnidades.AsEnumerable().Select(x => new Unidade
                    {
                        Regiao = x.Field<string>("REGIAO"),
                        UF = x.Field<string>("UF"),
                        Nome = x.Field<string>("NOME"),
                        Sigla = x.Field<string>("SIGLA")

                    }).ToList();

                    Sql = "SELECT * FROM [Adm$]";
                    Comandos = new OleDbCommand(Sql, Conexao);
                    adp = new OleDbDataAdapter(Comandos);
                    adp.Fill(TableAdms);
                    Adms = TableAdms.AsEnumerable().Select(x => new Adm
                    {
                        matricula = x.Field<object>("MATRICULA").ToString()

                    }).ToList();

                    Conexao.Close();
                }

                Quantidade.Calucular();

                FI.Atualizar();
                if (ajuste) FI.uctAjustes.Atualizar();
                if (home) FI.uctHome.Atualizar();
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //private static List<T> TableToList<T>(DataTable tabela) where T : new()
        //{
        //    T t = new T();
        //    List<T> list = new List<T>();
        //    var p = t.GetType().GetProperties();
            
        //    for(int i=0; i < p.Length; i++)
        //    {
        //        p[i].SetValue(.Field<object>(p[i].Name), i);
        //    }

        //    list = tabela.AsEnumerable().Select(x => inv(x)).ToList();
        //    return list;
        //}

        //private static T inv<T>(DataRow x) where T : new()
        //{
        //    T t = new T();
        //    var p = t.GetType().GetProperties();
        //    for (int i = 0; i < p.Length; i++)
        //    {
        //        p[i].SetValue(x.Field<object>(p[i].Name), i);
        //    }
        //    return t;
        //}

        public static Inventario GetBackup(Inventario i, Unidade u)
        {
            i.USERID = "bkp";
            i.FUNCIONARIO = "Backup TI";
            i.AREA = "bkp";
            i.CARGO = "bkp";
            i.UF = u.UF;
            i.UND = u.Nome;
            i.QUANT = "1";
            return i;
        }

        public static void InsertBase<T>(List<T> list)
        {
            //Realizar tratamento caso aplicativo excel esteja aberto.
            //Excel.EsperarFechar();

            //try
            //{
            //    if (list[0] is Inventario)
            //    {
            //        foreach (var item in list)
            //        {
            //            Inv.Add(item as Inventario);
            //        }
            //    }
            //    else if (list[0] is TMM)
            //    {
            //        foreach (var item in list)
            //        {
            //            TMMs.Add(item as TMM);
            //        }
            //    }
            //    else if (list[0] is Processador)
            //    {
            //        foreach (var item in list)
            //        {
            //            Processadores.Add(item as Processador);
            //        }
            //    }
            //    else if (list[0] is Memoria)
            //    {
            //        foreach (var item in list)
            //        {
            //            Memorias.Add(item as Memoria);
            //        }
            //    }
            //    else if (list[0] is Adm)
            //    {
            //        foreach (var item in list)
            //        {
            //            Adms.Add(item as Adm);
            //        }
            //    }
            //    else if (list[0] is Unidade)
            //    {
            //        foreach (var item in list)
            //        {
            //            Unidades.Add(item as Unidade);
            //        }
            //    }
            //    FI.uctHome.Atualizar();
            //}
            //catch (DomainException ex) { MessageBox.Show(ex.Message); }
            //catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                //Excel.Abrir(new Conection().Path);

                T t = list[0];
                using (OleDbConnection conexao = new OleDbConnection(new Conection().String))
                {
                    foreach (var item in list)
                    {
                        var p = item.GetType().GetProperties(); 
                        string sql = "", val = "", par = "";

                        OleDbCommand Comandos = new OleDbCommand();

                        for (int i = 0; i < p.Length; i++)
                        {
                            if (i == 0) val += "(" + p[i].Name + ", ";
                            else if (i < p.Length - 1) val += p[i].Name + ", ";
                            else val += p[i].Name + ")";

                            Comandos.Parameters.AddWithValue("@" + p[i].Name, (p[i].Name == "QUANT" || p[i].Name == "PATRIMONIO") ? p[i].GetValue(item) : p[i].GetValue(item).ToString());
                        }
                        par = val.Replace("(", "(@").Replace(" ", " @");
                        sql = "INSERT INTO [" + t.GetType().Name + "$] " + val + " VALUES " + par;
                        Comandos.CommandText = sql;
                        Comandos.Connection = conexao;
                        conexao.Open();
                        try
                        {
                            Comandos.ExecuteNonQuery();

                            if (list[0] is Movimentacao)
                            {
                                foreach (var i in list)
                                {
                                    Inv.Add((i as Movimentacao).GetInventario());
                                }
                            }
                            else if (list[0] is TMM)
                            {
                                foreach (var i in list)
                                {
                                    TMMs.Add(i as TMM);
                                }
                            }
                            else if (list[0] is Processador)
                            {
                                foreach (var i in list)
                                {
                                    Processadores.Add(i as Processador);
                                }
                            }
                            else if (list[0] is Memoria)
                            {
                                foreach (var i in list)
                                {
                                    Memorias.Add(i as Memoria);
                                }
                            }
                            else if (list[0] is Adm)
                            {
                                foreach (var i in list)
                                {
                                    Adms.Add(i as Adm);
                                }
                            }
                            else if (list[0] is Unidade)
                            {
                                foreach (var i in list)
                                {
                                    Unidades.Add(i as Unidade);
                                }
                            }
                            Quantidade.Calucular();
                            FI.Atualizar();
                        }
                        catch
                        {
                            throw new DomainException("Ocorreu um erro ao Inserir os Dados!");
                        }
                        finally
                        {
                            conexao.Close();
                            //Thread.Sleep(3000);
                            //Excel.Fechar();
                        }
                    }
                }
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        public static void UpdateBase<T>(List<T> alterados, List<T> geral)
        {
            try
            {
                using var workbook = new XLWorkbook(new Conection().Path);
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
