using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using InventarioTI.Entites;
using InventarioTI.Entites.emuns;
using InventarioTI.Extencions;
using InventarioTI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace InventarioTI.View
{
    public partial class frmTroca : Form
    {
        public List<Inventario> EquipamentosCliente { get; set; } = new List<Inventario>();


        private string _patrimonio;



        public frmTroca()
        {
            InitializeComponent();
        }

        private void btnCamcel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmTroca_Load(object sender, EventArgs e)
        {
          
        }

        private void dgvTroca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTroca.Columns[e.ColumnIndex] == dgvTroca.Columns["Chek"] && e.RowIndex != -1)
            {
                for (int i = 0; i < dgvTroca.RowCount; i++)
                {
                    dgvTroca.Rows[i].Cells["Chek"].Value = false;
                    if (i == e.RowIndex)
                    {
                        dgvTroca.Rows[i].Cells["Chek"].Value = true;
                        _patrimonio = dgvTroca.Rows[i].Cells["Patrimonio"].Value.ToString();
                    }
                }
            }
        }
        private void btnTroca_Click(object sender, EventArgs e)
        {
          
        }


    }
}
