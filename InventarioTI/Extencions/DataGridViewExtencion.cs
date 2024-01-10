using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.Extencions
{
    static public class DataGridViewExtencion
    {
        public static void Estilo(this DataGridView dg)
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();

            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dg.AutoGenerateColumns = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.BackgroundColor = Color.White;
            dg.BorderStyle = BorderStyle.None;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(196, 0, 6);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9*Tela.Fator, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(196, 0, 6);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9*Tela.Fator, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dg.DefaultCellStyle = dataGridViewCellStyle3;
            dg.EnableHeadersVisualStyles = false;
            dg.GridColor = Color.Black;
            dg.ReadOnly = true;
            dg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9*Tela.Fator, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg.RowHeadersVisible = false;
            dg.ScrollBars = ScrollBars.None;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.ColumnHeadersHeight = 25;
        }
    }
}
