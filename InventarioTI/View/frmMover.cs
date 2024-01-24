using DocumentFormat.OpenXml.Math;
using InventarioTI.Entites;
using InventarioTI.Entites.emuns;
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
        private string _u;
        private List<Unidade> _list = new List<Unidade>();
        public frmMover(Inventario i)
        {
            InitializeComponent();
            if (Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).Contains(i.UND))
            {
                _list = Base.Unidades.Where(x => x.Sigla != Base.Unidade).ToList();
            }
            else
            {
                _list = Base.Unidades.Where(x => x.Sigla == Base.Unidade).ToList();
            }
        }

        private void btnCamcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            //tratativa
            this.Close();
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

        private void frmMover_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Base.FI.Location.X + 375, Base.FI.Location.Y + 82);
            dgvMover.DataSource = _list;
            dgvMover.Estilo();
            dgvMover.ScrollBars = ScrollBars.Vertical;
        }
    }
}
