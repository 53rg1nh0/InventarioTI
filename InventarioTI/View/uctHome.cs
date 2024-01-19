using DocumentFormat.OpenXml.Drawing.Diagrams;
using InventarioTI.Entites;
using InventarioTI.Entites.emuns;
using InventarioTI.Entites.Emuns;
using InventarioTI.Entites.Exceptions;
using InventarioTI.Extencions;
using InventarioTI.Services;

using System.Data;
using System.Diagnostics;

namespace InventarioTI.View
{
    public partial class uctHome : UserControl
    {
        public List<TMM> _filtro = new List<TMM>();

        public uctHome()
        {
            InitializeComponent();

        }

        public void Atualizar()
        {
            _filtro = Base.TMMs;

            AutoComplete();

            Combos();
        }

        private void AutoComplete()
        {
            if (!string.IsNullOrEmpty(Base.Unidade) && Base.Inv.Count > 0)
            {
                txbUserID.AutoCompleteCustomSource.Clear();
                txbUserID.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbUserID.AutoCompleteCustomSource.AddRange(Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First() && x.USERID != "obs").Select(c => c.USERID).Distinct().ToArray());

                txbNome.AutoCompleteCustomSource.Clear();
                txbNome.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbNome.AutoCompleteCustomSource.AddRange(Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First() && x.USERID != "obs").Select(c => c.FUNCIONARIO).Distinct().ToArray());

                txbPatrimonio.AutoCompleteCustomSource.Clear();
                txbPatrimonio.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbPatrimonio.AutoCompleteCustomSource.AddRange(Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First() && x.USERID != "obs").Select(c => c.PATRIMONIO).ToArray());

                txbSerie.AutoCompleteCustomSource.Clear();
                txbSerie.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbSerie.AutoCompleteCustomSource.AddRange(Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First() && x.USERID != "obs").Select(c => c.SERIE).ToArray());
            }
        }

        public void Combos(string campo = null, string filtro = null)
        {

            if (_filtro.Count != 0)
            {
                cbxTipo.Items.Clear();
                cbxMarca.Items.Clear();
                cbxModelo.Items.Clear();
                cbxProcessador.Items.Clear();
                cbxMemoria.Items.Clear();

                cbxTipo.Items.Add("");
                cbxMarca.Items.Add("");
                cbxModelo.Items.Add("");
                cbxProcessador.Items.Add("");
                cbxMemoria.Items.Add("");
                ;
                if (!string.IsNullOrEmpty(filtro))
                {
                    switch (campo)
                    {
                        case "tipo":
                            _filtro = _filtro.Where(c => c.Tipo == filtro).ToList();
                            break;
                        case "marca":
                            _filtro = _filtro.Where(c => c.Marca == filtro).ToList();
                            break;
                        case "modelo":
                            _filtro = _filtro.Where(c => c.Modelo == filtro).ToList();
                            break;
                    }
                }

                cbxTipo.Items.AddRange(_filtro.Select(c => c.Tipo).Distinct().ToArray());
                cbxMarca.Items.AddRange(_filtro.Select(c => c.Marca).Distinct().ToArray());
                cbxModelo.Items.AddRange(_filtro.Select(c => c.Modelo).Distinct().ToArray());

                cbxProcessador.Items.AddRange(Base.Processadores.Select(c => c.Tipo).Distinct().ToArray());
                cbxMemoria.Items.AddRange(Base.Memorias.Select(c => c.Ram).Distinct().ToArray());
            }
        }

        private void PreencherCliente(bool b, Equipamento e)
        {
            if (b)
            {
                txbUserID.Text = e.Cliente.UserID;
                txbNome.Text = e.Cliente.Nome;
                txbUnidade.Text = e.Cliente.Unidade.Substring(e.Cliente.Unidade.Length - 3);
                txbArea.Text = e.Cliente.Area;
                txbCargo.Text = e.Cliente.Cargo;

                dgvCliente.Visible = true;
                dgvCliente.DataSource = Base.Inv.Where(a => a.PATRIMONIO == e.Patrimonio).ToArray();
                dgvCliente.Estilo();
                dgvCliente.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvCliente.DefaultCellStyle.SelectionBackColor = SystemColors.Control;

                Cache.Cliente = e.Cliente.UserID;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado!");
            }
        }

        private void PreencherEquipamento(bool b, Equipamento e)
        {
            if (b)
            {
                txbPatrimonio.Text = e.Patrimonio;
                txbSerie.Text = e.Serie;
                cbxTipo.Text = e.Tipo;
                cbxMarca.Text = e.Marca;
                cbxModelo.Text = e.Modelo;
                cbxProcessador.Text = e.Processador;
                cbxMemoria.Text = e.Memoria;

                List<Cliente> clientes = new List<Cliente>();
                dgvEquipamento.Visible = true;
                clientes.Add(e.Cliente);
                dgvEquipamento.DataSource = clientes;
                dgvEquipamento.Estilo();
                dgvEquipamento.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvEquipamento.DefaultCellStyle.SelectionBackColor = SystemColors.Control;

                Cache.Equipamento = e.Patrimonio;
            }
            else
            {
                MessageBox.Show("Equipamento não existe!");
            }
        }

        private void uctHome_Load(object sender, EventArgs e)
        {
            //Atualizar();
        }
        private void ptbApagarCampoCliente_Click(object sender, EventArgs e)
        {
            txbUserID.Clear();
            txbNome.Clear();
            txbUnidade.Clear();
            txbArea.Clear();
            txbCargo.Clear();
            txbMatricula.Clear();

            dgvCliente.Visible = false;
            dgvCliente.DataSource = null;

            Cache.Cliente = null;
        }
        private void txbUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PreencherCliente(Base.Inv.Select(c => c.USERID).Contains(txbUserID.Text.ToLower()),
                   Transformar.GetEquipamento(Base.Inv.Where(c => c.USERID.ToLower() == txbUserID.Text.ToLower()).FirstOrDefault()));
            }
        }



        private void txbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PreencherCliente(Base.Inv.Select(c => c.FUNCIONARIO.ToLower()).Contains(txbNome.Text.ToLower()),
                    Transformar.GetEquipamento(Base.Inv.Where(c => c.FUNCIONARIO.ToLower() == txbNome.Text.ToLower()).FirstOrDefault()));
            }
        }

        private void txbPatrimonio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PreencherEquipamento(Base.Inv.Select(c => c.PATRIMONIO).Contains(txbPatrimonio.Text),
                    Transformar.GetEquipamento(Base.Inv.Where(c => c.PATRIMONIO == txbPatrimonio.Text).FirstOrDefault()));
            }
        }

        private void txbSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PreencherEquipamento(Base.Inv.Select(c => c.SERIE.ToLower()).Contains(txbSerie.Text.ToLower()),
                    Transformar.GetEquipamento(Base.Inv.Where(c => c.SERIE.ToLower() == txbSerie.Text.ToLower()).FirstOrDefault()));
            }
        }

        private void ptbApagarEquipamento_Click(object sender, EventArgs e)
        {
            txbPatrimonio.Clear();
            txbSerie.Clear();
            cbxTipo.Text = string.Empty;
            cbxMarca.Text = string.Empty;
            cbxModelo.Text = string.Empty;
            cbxProcessador.Text = string.Empty;
            cbxMemoria.Text = string.Empty;
            _filtro = Base.TMMs;
            Combos();

            dgvEquipamento.Visible = false;
            dgvEquipamento.DataSource = null;

            Cache.Equipamento = null;
        }
        private void cbxModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string aux = cbxModelo.Text;
            if (!string.IsNullOrEmpty(cbxModelo.Text))
            {
                TMM t = new TMM();
                t = Base.TMMs.Where(a => a.Modelo.ToLower() == cbxModelo.Text.ToLower()).FirstOrDefault(); ;

                Combos();

                cbxTipo.Text = t.Tipo;
                cbxMarca.Text = t.Marca;
                cbxModelo.Text = aux;
            }
            else
            {
                _filtro = Base.TMMs;
                Combos();
            }
        }

        private void cbxTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string aux1 = cbxTipo.Text;
            string aux2 = cbxMarca.Text;
            if (!string.IsNullOrEmpty(cbxTipo.Text))
            {
                Combos("tipo", cbxTipo.Text);
                cbxTipo.Text = aux1;
                cbxMarca.Text = aux2;
            }
            else
            {
                _filtro = Base.TMMs;
                Combos();
            }

        }

        private void cbxMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string aux1 = cbxMarca.Text;
            string aux2 = cbxTipo.Text;
            if (!string.IsNullOrEmpty(cbxMarca.Text))
            {
                Combos("marca", cbxMarca.Text);
                cbxMarca.Text = aux1;
                cbxTipo.Text = aux2;
            }
            else
            {
                _filtro = Base.TMMs;
                Combos();
            }

        }


        private void ptbAdicionarEquipamento_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Unidade unidade = Base.Unidades.Where(u => u.Sigla == Base.Unidade).FirstOrDefault();
                Inventario i = Base.GetBackup(new Inventario(), unidade);

                i.PATRIMONIO = txbPatrimonio.Text.Length > 8 ? throw new DomainException("Patrimonio só pode cconter 8 ou menos caracteres!") : txbPatrimonio.Text;
                i.EQUIPAMENTO = cbxTipo.Text;
                i.SERIE = txbSerie.Text;
                i.MARCA = cbxMarca.Text;
                i.MODELO = cbxModelo.Text;
                i.PROCESSADOR = cbxProcessador.Text;
                i.MEMORIA = cbxMemoria.Text;
                i.Nomenclatura();

                Base.Atualizar(false, false);

                foreach (var p in i.GetType().GetProperties())
                {
                    if (p.GetValue(i) is null)
                    {
                        throw new DomainException("Não pode haver campos vazios!");
                    }
                }
                if (Base.Inv.Where(x=>x.USERID == "obs").Select(a => a.PATRIMONIO).Contains(i.PATRIMONIO) ||
                    Base.Inv.Where(x => x.USERID == "obs").Select(a => a.NOMENCLATURA).Contains(i.NOMENCLATURA) ||
                    Base.Inv.Where(x => x.USERID == "obs").Select(a => a.SERIE).Contains(i.SERIE))
                {
                    MessageBox.Show("Equipamento está como obsoleto! Deseja reativa-lo?","Obsoleto",MessageBoxButtons.YesNo);

                    //tratativa

                    return;
                }
                if (Base.Inv.Select(a => a.PATRIMONIO).Contains(i.PATRIMONIO) ||
                    Base.Inv.Select(a => a.NOMENCLATURA).Contains(i.NOMENCLATURA) ||
                    Base.Inv.Select(a => a.SERIE).Contains(i.SERIE))
                {
                    throw new DomainException("Equipamento já existe!");
                }
                else
                {
                    Base.InsertBase(new List<Movimentacao> { new Movimentacao("adicionado",i) });

                    Task.Run(() => { MessageBox.Show("Equipamento Adicionado com sucesso!"); });

                    txbPatrimonio_KeyDown(sender, new KeyEventArgs(Keys.Enter));
                }
                Cache.Equipamento = txbPatrimonio.Text;
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        private void ptbEditarCliente_Click(object sender, EventArgs e)
        {

        }

        private void ptbRemoverEquipamento_Click(object sender, EventArgs e)
        {

        }

        private void ptbEditarEquipamento_Click(object sender, EventArgs e)
        {

        }

        private void ptbAdicionarCLinete_Click(object sender, EventArgs e)
        {

        }

        private void ptbRemoverCliente_Click(object sender, EventArgs e)
        {

        }

        private void ptbTrocar_Click(object sender, EventArgs e)
        {

        }

        private void MoverCliente_Click(object sender, EventArgs e)
        {

        }

        private void ptbMoverEquipamento_Click(object sender, EventArgs e)
        {


        }

        private void ptbGerarTermo_Click(object sender, EventArgs e)
        {

        }


    }
}
