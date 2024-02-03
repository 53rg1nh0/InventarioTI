using InventarioTI.Entites;
using InventarioTI.Entites.emuns;
using InventarioTI.Entites.Exceptions;
using InventarioTI.Extencions;
using System.Data;
using Base = InventarioTI.Services.Base;

namespace InventarioTI.View
{
    public partial class frmMover : Form
    {
        private string _u;
        private List<Unidade> _list = new List<Unidade>();
        private Inventario _i;
        public frmMover(Inventario i)
        {
            InitializeComponent();
            _i = i;
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
            try
            {
                if (string.IsNullOrEmpty(_u)) throw new DomainException("Selecione a Unidade destino!");
                Unidade u = Base.Unidades.Where(x => x.Sigla == _u).FirstOrDefault();
                string origem = _i.UND;
                _i.UND = u.Nome;
                _i.UF = u.UF;
                _i.Nomenclatura();
                Base.UpdateBase(_i);
                Base.InsertBase(new Movimentacao("movido", _i, origem));
                MessageBox.Show("Equipamento movido com sucesso!");
                this.Close();
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //tratativa

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
