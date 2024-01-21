using InventarioTI.Entites;
using ClosedXML.Excel;
using InventarioTI.Entites.Exceptions;
using System.Diagnostics;
using System.Data;
using DataTable = System.Data.DataTable;
using InventarioTI.Entites.emuns;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System.Runtime.Intrinsics.X86;
using System.Collections.ObjectModel;
using DocumentFormat.OpenXml.Wordprocessing;

namespace InventarioTI.Services
{
    static class Base
    {
        public static Dictionary<Type, DataTable> Ta { get; set; } = new Dictionary<Type, DataTable>();
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
            var tableAnterior = Ta as IDisposable;

            invAterior?.Dispose();
            tmmsAnterior?.Dispose();
            memoriasAnterior?.Dispose();
            processadoresAnterior?.Dispose();
            unidadesAnterior?.Dispose();
            admsAnterior?.Dispose();
            Ta.Clear();

            tableAnterior?.Dispose();

            Inv = new List<Inventario>();
            TMMs = new List<TMM>();
            Memorias = new List<Memoria>();
            Processadores = new List<Processador>();
            Unidades = new List<Unidade>();
            Adms = new List<Adm>();

            Ta.Add(typeof(Inventario), new DataTable());
            Ta.Add(typeof(TMM), new DataTable());
            Ta.Add(typeof(Memoria), new DataTable());
            Ta.Add(typeof(Processador), new DataTable());
            Ta.Add(typeof(Unidade), new DataTable());
            Ta.Add(typeof(Adm), new DataTable());

            try
            {
                Validar.BD();// -->função já coloca a tabela inventário dentro de Dictionary

                Inv = TableToList<Inventario>(Ta[typeof(Inventario)]);

                using (OleDbConnection Conexao = new OleDbConnection(new Conection(new TMM()).String))
                {
                    Conexao.Open();
                    string Sql;
                    OleDbCommand Comandos = new OleDbCommand();
                    OleDbDataAdapter adp = new OleDbDataAdapter();
                    foreach (var t in Ta)
                    {
                        if (t.Key != typeof(Inventario))
                        {
                            Sql = "SELECT * FROM [" + t.Key.Name + "$]";
                            Comandos = new OleDbCommand(Sql, Conexao);
                            adp = new OleDbDataAdapter(Comandos);
                            adp.Fill(Ta[t.Key]);
                        }
                    }
                    Inv = TableToList<Inventario>(Ta[typeof(Inventario)]);
                    TMMs = TableToList<TMM>(Ta[typeof(TMM)]);
                    Processadores = TableToList<Processador>(Ta[typeof(Processador)]);
                    Memorias = TableToList<Memoria>(Ta[typeof(Memoria)]);
                    Unidades = TableToList<Entites.Unidade>(Ta[typeof(Entites.Unidade)]);
                    Adms = TableToList<Adm>(Ta[typeof(Adm)]);

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


        private static List<T> TableToList<T>(DataTable tabela) where T : new()
        {
            T t = new T();
            List<T> list = new List<T>();
            var p = t.GetType().GetProperties();

            list = tabela.AsEnumerable().Select(x => x.RowToType<T>()).ToList();
            return list;
        }

        private static T RowToType<T>(this DataRow x) where T : new()
        {
            T t = new T();
            var p = t.GetType().GetProperties();
            for (int i = 0; i < p.Length; i++)
            {
                p[i].SetValue(t, x.Field<object>(p[i].Name).ToString());
            }
            return t;
        }

        private static DataRow TypeToRow<T>(this T t, DataTable dt)
        {
            DataRow row = dt.NewRow();
            var p = t.GetType().GetProperties();

            foreach (var prop in p)
            {
                row.SetField(dt.Columns[prop.Name], prop.GetValue(t));
            }
            return row;
        }

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
            using (OleDbConnection conexao = new OleDbConnection(new Conection(list[0]).String))
            {
                try
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
                        sql = "INSERT INTO [" + item.GetType().Name + "$] " + val + " VALUES " + par;
                        Comandos.CommandText = sql;
                        Comandos.Connection = conexao;
                        conexao.Open();

                        Comandos.ExecuteNonQuery();

                        if (item.GetType().Name == "Inventario") Inv.Add(item as Inventario);
                        else if (item is TMM) TMMs.Add(item as TMM);
                        else if (item is Processador) Processadores.Add(item as Processador);
                        else if (item is Memoria) Memorias.Add(item as Memoria);
                        else if (item is Adm) Adms.Add(item as Adm);
                        else if (item is Unidade) Unidades.Add(item as Unidade);

                        if (item.GetType().Name != "Movimentacao") Ta[item.GetType()].Rows.Add(item.TypeToRow(Ta[item.GetType()]));
                    }
                    FI.Atualizar();
                }
                catch { throw new DomainException("Ocorreu um erro ao Inserir os Dados!"); }
                finally { conexao.Close(); }
            }
        }


        public static void UpdateBase<T>(List<T> alterados, List<T> geral)
        {
            //try
            //{
            //    using var workbook = new XLWorkbook(new Conection().Path);
            //    var worksheet = workbook.Worksheet(alterados.FirstOrDefault().GetType().Name);
            //    var headerRow = worksheet.FirstRow();
            //    worksheet.AutoFilter.Clear();
            //    var tabela = worksheet.RangeUsed().AsTable();

            //    foreach (var alterado in alterados)
            //    {
            //        var properties = alterado.GetType().GetProperties();
            //        foreach (var p in properties)
            //        {
            //            int c = headerRow.CellsUsed(c => c.Value.ToString() == p.Name.ToUpper()).FirstOrDefault().WorksheetColumn().ColumnNumber();
            //            int l = geral.IndexOf(alterado) + 2;
            //            worksheet.Cell(l, c).Value = (c == 1 || c == 12) ? int.Parse(p.GetValue(alterado).ToString()) : p.GetValue(alterado).ToString();
            //        }
            //    }

            //    if (double.TryParse(tabela.LastRow().Cell(1).Value.ToString(), out double valorNumerico1))
            //    {
            //        tabela.LastRow().Cell(1).SetValue(valorNumerico1);
            //    }

            //    if (double.TryParse(tabela.LastRow().Cell(12).Value.ToString(), out double valorNumerico12))
            //    {
            //        tabela.LastRow().Cell(12).SetValue(valorNumerico12);
            //    }

            //    worksheet.RangeUsed().SetAutoFilter();
            //    worksheet.AutoFilter.Sort(4, XLSortOrder.Ascending, false, true);

            //    workbook.Save();
            //    workbook.Dispose();
            //}
            //catch (DomainException ex) { MessageBox.Show(ex.Message); }
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void RemoveBase(object o, int index)
        {
            try
            {
                using (var workbook = new XLWorkbook(new Conection(new TMM()).Path))
                {                   
                    var worksheet = workbook.Worksheet(o.GetType().Name);
                    worksheet.Row(index + 2).Delete();
                    Ta[o.GetType()].Rows.RemoveAt(index);
                    switch (o.GetType().Name)
                    {
                        case "TMM":
                            TMMs.RemoveAt(index);
                            break;
                        case "Processador":

                            Processadores.RemoveAt(index);
                            break;
                        case "Memoria":
                            Memorias.RemoveAt(index);
                            break;
                        case "Unidade":
                            Unidades.RemoveAt(index);
                            break;
                    }
                    FI.Atualizar();
                    workbook.Save();
                    workbook.Dispose();
                }
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
