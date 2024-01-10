using DocumentFormat.OpenXml.Math;
using InventarioTI.Entites;
using InventarioTI.Extencions;
using InventarioTI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base = InventarioTI.Services.Base;

namespace InventarioTI.View
{
    public partial class frmMover : Form
    {
        public FormInventario FI { get; set; } 
        private string _u { get; set; }
        public frmMover(List<Unidade> unidades)
        {
            InitializeComponent();
            dgvMover.DataSource = unidades;
            dgvMover.Estilo();
            dgvMover.ScrollBars = ScrollBars.Vertical;
        }

        private void btnCamcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMover_Load(object sender, EventArgs e)
        {
            Location = new Point(FI.Location.X + 350, FI.Location.Y + 55);
            this.Arrastar();
            this.Escala();

        }

        private void dgvMover_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMover.Columns[e.ColumnIndex] == dgvMover.Columns["Chek"] && e.RowIndex != -1)
            {
                for (int i = 0; i < dgvMover.RowCount; i++)
                {
                    dgvMover.Rows[i].Cells["Chek"].Value = false;
                    if (i == e.RowIndex)
                    {
                        dgvMover.Rows[i].Cells["Chek"].Value = true;
                        _u = dgvMover.Rows[i].Cells["Sigla"].Value.ToString();
                    }
                }
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
