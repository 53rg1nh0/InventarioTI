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

namespace InventarioTI.View
{
    public partial class uctInventario : UserControl
    {
        public uctInventario()
        {
            InitializeComponent();
        }

        private void uctInventario_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        public void Atualizar()
        {
            dgvInventario.Estilo();
            dgvInventario.DataSource = Base.Inv.Where(x => x.USERID != "obsoleto" && x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First()
            && (DateTime.Now - DateTime.Parse(x.DATA)).Days > 360).ToList();

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventario.Columns[e.ColumnIndex] == dgvInventario.Columns["Inventario"] && e.RowIndex != -1)
            {

                Inventario i = Base.Inv.Where(x => x.PATRIMONIO == dgvInventario[2, e.RowIndex].Value.ToString()).FirstOrDefault();
                i.DATA = DateTime.Now.ToString();
                Base.UpdateBase(i);
                Base.InsertBase(new Movimentacao("inventario", i));
                Base.Atualizar();
                Atualizar();
                //MessageBox.Show(dgvInventario[2,e.RowIndex].Value.ToString());
            }
        }

        
    }
}
