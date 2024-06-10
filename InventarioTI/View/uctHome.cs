using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Office.CustomUI;
using InventarioTI.Entites;
using InventarioTI.Entites.emuns;
using InventarioTI.Entites.Emuns;
using InventarioTI.Entites.Exceptions;
using InventarioTI.Extencions;
using InventarioTI.Services;
using Org.BouncyCastle.Crypto.Generators;
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
                txbUserID.AutoCompleteCustomSource.AddRange(Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First() && x.USERID != "obs" && x.USERID != "bkp").Select(c => c.USERID).Distinct().ToArray());

                txbNome.AutoCompleteCustomSource.Clear();
                txbNome.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbNome.AutoCompleteCustomSource.AddRange(Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First() && x.USERID != "obs" && x.USERID != "bkp").Select(c => c.FUNCIONARIO).Distinct().ToArray());

                txbPatrimonio.AutoCompleteCustomSource.Clear();
                txbPatrimonio.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbPatrimonio.AutoCompleteCustomSource.AddRange(Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First() && x.USERID != "obs").Select(c => c.PATRIMONIO).ToArray());

                txbSerie.AutoCompleteCustomSource.Clear();
                txbSerie.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txbSerie.AutoCompleteCustomSource.AddRange(Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First() && x.USERID != "obs").Select(c => c.SERIE).ToArray());
            }
        }

        public void Combos()
        {

            if (_filtro.Count != 0)
            {
                _filtro = Base.TMMs;

                string ti, ma, mo, me, pr;
                ti = cbxTipo.Text;
                ma = cbxMarca.Text;
                mo = cbxModelo.Text;
                pr = cbxProcessador.Text;
                me = cbxMemoria.Text;

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


                _filtro = _filtro.Where(x => (string.IsNullOrEmpty(ti) ? true : x.Tipo == ti) && (string.IsNullOrEmpty(ma) ? true : x.Marca == ma) &&
                (string.IsNullOrEmpty(mo) ? true : x.Modelo == mo)).ToList();

                cbxTipo.Items.AddRange(_filtro.Select(c => c.Tipo).Distinct().ToArray());
                cbxMarca.Items.AddRange(_filtro.Select(c => c.Marca).Distinct().ToArray());
                cbxModelo.Items.AddRange(_filtro.Select(c => c.Modelo).Distinct().ToArray());

                cbxProcessador.Items.AddRange(Base.Processadores.Select(c => c.Tipo).Distinct().ToArray());
                cbxMemoria.Items.AddRange(Base.Memorias.Select(c => c.Ram).Distinct().ToArray());



                if (!string.IsNullOrEmpty(ti)) cbxTipo.Text = ti;
                if (!string.IsNullOrEmpty(ma)) cbxMarca.Text = ma;
                if (!string.IsNullOrEmpty(mo)) cbxModelo.Text = mo;
                if (!string.IsNullOrEmpty(pr)) cbxProcessador.Text = pr;
                if (!string.IsNullOrEmpty(me)) cbxMemoria.Text = me;

                if (_filtro.Count == 1)
                {
                    cbxTipo.Text = _filtro.Select(x => x.Tipo).First();
                    cbxMarca.Text = _filtro.Select(x => x.Marca).First();
                }
            }
        }

        private void cbxModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxMarca.SelectionChangeCommitted -= cbxMarca_SelectionChangeCommitted;
            cbxTipo.SelectionChangeCommitted -= cbxTipo_SelectionChangeCommitted;

            if (string.IsNullOrEmpty(cbxModelo.Text))
            {
                cbxMarca.Text = "";
                cbxTipo.Text = "";
            }

            Combos();

            cbxMarca.SelectionChangeCommitted += cbxMarca_SelectionChangeCommitted;
            cbxTipo.SelectionChangeCommitted += cbxTipo_SelectionChangeCommitted;
        }

        private void cbxMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxModelo.SelectionChangeCommitted -= cbxModelo_SelectionChangeCommitted;
            cbxTipo.SelectionChangeCommitted -= cbxTipo_SelectionChangeCommitted;

            Combos();

            cbxModelo.SelectionChangeCommitted += cbxModelo_SelectionChangeCommitted;
            cbxTipo.SelectionChangeCommitted += cbxTipo_SelectionChangeCommitted;
        }

        private void cbxTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxModelo.SelectionChangeCommitted -= cbxModelo_SelectionChangeCommitted;
            cbxMarca.SelectionChangeCommitted -= cbxMarca_SelectionChangeCommitted;


            Combos();

            cbxModelo.SelectionChangeCommitted += cbxModelo_SelectionChangeCommitted;
            cbxMarca.SelectionChangeCommitted += cbxMarca_SelectionChangeCommitted;
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
                cbxModelo.Text = "";
                cbxMarca.Text = "";
                cbxTipo.Text = "";
                txbPatrimonio.Text = e.Patrimonio;
                txbSerie.Text = e.Serie;
                cbxModelo.Text = e.Modelo;
                cbxModelo_SelectionChangeCommitted(new object(), new EventArgs());
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
                PreencherCliente(Base.Inv.Where(x => x.USERID != "bkp" && x.USERID != "obs").Select(c => c.USERID).Contains(txbUserID.Text.ToLower()),
                   Transformar.GetEquipamento(Base.Inv.Where(c => c.USERID.ToLower() == txbUserID.Text.ToLower()).FirstOrDefault()));
            }
        }

        private void txbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PreencherCliente(Base.Inv.Where(x => x.USERID != "bkp" && x.USERID != "obs").Select(c => c.FUNCIONARIO.ToLower()).Contains(txbNome.Text.ToLower()),
                    Transformar.GetEquipamento(Base.Inv.Where(c => c.FUNCIONARIO.ToLower() == txbNome.Text.ToLower()).FirstOrDefault()));
            }
        }

        private void txbPatrimonio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PreencherEquipamento(Base.Inv.Where(x => x.USERID != "obs").Select(c => c.PATRIMONIO).Contains(txbPatrimonio.Text),
                    Transformar.GetEquipamento(Base.Inv.Where(c => c.PATRIMONIO == txbPatrimonio.Text).FirstOrDefault()));
            }
        }

        private void txbSerie_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    PreencherEquipamento(Base.Inv.Select(c => c.SERIE.ToLower()).Contains(txbSerie.Text.ToLower()),
                        Transformar.GetEquipamento(Base.Inv.Where(c => c.SERIE.ToLower() == txbSerie.Text.ToLower()).FirstOrDefault()));
                }
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
            Combos();

            dgvEquipamento.Visible = false;
            dgvEquipamento.DataSource = null;

            Cache.Equipamento = null;
        }

        private void ptbAdicionarEquipamento_Click(object sender, EventArgs e)
        {
            try
            {
                Unidade unidade = Base.Unidades.Where(u => u.Sigla == Base.Unidade).FirstOrDefault();
                Inventario i = Base.GetBackup(new Inventario(), unidade);

                i.PATRIMONIO = txbPatrimonio.Text.Length > 8 ? throw new DomainException("Patrimonio só pode conter 8 ou menos caracteres!") : txbPatrimonio.Text;
                i.EQUIPAMENTO = cbxTipo.Text;
                i.SERIE = txbSerie.Text;
                i.MARCA = cbxMarca.Text;
                i.MODELO = cbxModelo.Text;
                i.PROCESSADOR = cbxProcessador.Text;
                i.MEMORIA = cbxMemoria.Text;
                i.DATA = DateTime.Now.ToString("G");
                i.Nomenclatura();


                foreach (var p in i.GetType().GetProperties())
                {
                    if (p.GetValue(i) is null || string.IsNullOrEmpty(p.GetValue(i).ToString()))
                    {
                        throw new DomainException("Não pode haver campos vazios!");
                    }
                }

                Base.Atualizar(false, false);


                if (Base.Inv.Where(x => x.USERID == "obs").Select(a => a.PATRIMONIO).Contains(i.PATRIMONIO) ||
                    Base.Inv.Where(x => x.USERID == "obs").Select(a => a.NOMENCLATURA).Contains(i.NOMENCLATURA) ||
                    Base.Inv.Where(x => x.USERID == "obs").Select(a => a.SERIE).Contains(i.SERIE))
                {
                    if (MessageBox.Show("Equipamento está como obsoleto! Deseja reativa-lo?", "Obsoleto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cache.Equipamento = txbPatrimonio.Text;
                        Base.GetBackup(i, Base.Unidades.Where(x => x.Sigla == Base.Unidade).FirstOrDefault());
                        Base.UpdateBase(i);
                        Base.InsertBase(new Movimentacao("adicionado", i));

                        Task.Run(() => { MessageBox.Show("Equipamento Adicionado com sucesso!"); });

                        txbPatrimonio_KeyDown(sender, new KeyEventArgs(Keys.Enter));

                        Cache.Equipamento = txbPatrimonio.Text;
                    }

                    return;
                }
                if (Base.Inv.Select(a => a.PATRIMONIO).Contains(i.PATRIMONIO) ||
                    Base.Inv.Select(a => a.NOMENCLATURA).Contains(i.NOMENCLATURA) ||
                    Base.Inv.Select(a => a.SERIE).Contains(i.SERIE))
                {
                    throw new DomainException("Equipamento já existe!");
                }

                Base.InsertBase(i);
                Base.InsertBase(new Movimentacao("adicionado", i));

                Task.Run(() => { MessageBox.Show("Equipamento Adicionado com sucesso!"); });

                txbPatrimonio_KeyDown(sender, new KeyEventArgs(Keys.Enter));

                Cache.Equipamento = txbPatrimonio.Text;
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Cache.Cliente)) throw new Exception("Incira o cliente que deseja Editar!");
                Base.Atualizar(false, false);
                Inventario i = Base.Inv.Where(x => x.USERID == Cache.Cliente).FirstOrDefault();
                if (!Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First())
                    .Select(x => x.USERID).Contains(Cache.Cliente)) throw new DomainException("So podem ser editados equipamentos da unidade!");
                if (string.IsNullOrEmpty(txbUserID.Text) || string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbArea.Text) ||
                    string.IsNullOrEmpty(txbCargo.Text)) throw new DomainException("Não podem haver campos vazios!");
                if (i.USERID == txbUserID.Text && i.FUNCIONARIO == txbNome.Text && i.AREA == txbArea.Text && i.CARGO == txbCargo.Text) return;

                i.USERID = txbUserID.Text;
                i.FUNCIONARIO = txbNome.Text;
                i.AREA = txbArea.Text;
                i.CARGO = txbCargo.Text;

                Base.UpdateBase(i, false);
                Base.InsertBase(new Movimentacao("editado", i));

                Task.Run(() => { MessageBox.Show("Cliente Editado com sucesso!"); });
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbEditarEquipamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Cache.Equipamento)) throw new Exception("Incira o equipamento que deseja Editar!");
                Base.Atualizar(false, false);
                Inventario i = Base.Inv.Where(x => x.PATRIMONIO == Cache.Equipamento).FirstOrDefault();
                if (!Base.Inv.Where(x => x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).Select(x => x.Nome).First())
                    .Select(x => x.PATRIMONIO).Contains(Cache.Equipamento)) throw new DomainException("So podem ser editados equipamentos da unidade!");
                if (string.IsNullOrEmpty(txbPatrimonio.Text) || string.IsNullOrEmpty(txbSerie.Text) || string.IsNullOrEmpty(cbxTipo.Text) ||
                    string.IsNullOrEmpty(cbxMarca.Text) || string.IsNullOrEmpty(cbxModelo.Text) || string.IsNullOrEmpty(cbxProcessador.Text) ||
                    string.IsNullOrEmpty(cbxMemoria.Text)) throw new DomainException("Não podem haver campos vazios!");
                if (i.PATRIMONIO == txbPatrimonio.Text && i.SERIE == txbSerie.Text && i.EQUIPAMENTO == cbxTipo.Text && i.MARCA == cbxMarca.Text &&
                    i.MODELO == cbxModelo.Text && i.PROCESSADOR == cbxProcessador.Text && i.MEMORIA == cbxMemoria.Text) return;

                i.PATRIMONIO = txbPatrimonio.Text;
                i.SERIE = txbSerie.Text;
                i.EQUIPAMENTO = cbxTipo.Text;
                i.MARCA = cbxMarca.Text;
                i.MODELO = cbxModelo.Text;
                i.PROCESSADOR = cbxProcessador.Text;
                i.MEMORIA = cbxMemoria.Text;

                Base.UpdateBaseEdit(i);
                Base.InsertBase(new Movimentacao("editado", i));

                Task.Run(() => { MessageBox.Show("Equipamento Editado com sucesso!"); });
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbAdicionarCLinete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Cache.Equipamento)) throw new DomainException("Procure equipamento para cadastrar cliente!");
                Base.Atualizar(false, false);
                if (Base.Inv.Select(x => x.USERID).Contains(txbUserID.Text)) throw new DomainException("Cliente já existe no banco!");
                if (string.IsNullOrEmpty(txbUserID.Text) || string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbArea.Text) ||
                    string.IsNullOrEmpty(txbCargo.Text)) throw new DomainException("Não podem haver campos vazios!");
                if (!Base.Inv.Select(x => x.PATRIMONIO).Contains(Cache.Equipamento)) throw new DomainException("Equipamento não existe mais!");
                if (Base.Inv.Where(x => x.PATRIMONIO == Cache.Equipamento && x.USERID == "bkp" && x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).
                Select(x => x.Nome).First()).Count() == 0) throw new DomainException("Equipamento deve ser backup da unidade pada cadastra cliente");

                Inventario i = Base.Inv.Where(x => x.PATRIMONIO == Cache.Equipamento).FirstOrDefault();

                i.USERID = txbUserID.Text;
                i.FUNCIONARIO = txbNome.Text;
                i.AREA = txbArea.Text;
                i.CARGO = txbCargo.Text;

                Base.UpdateBase(i);
                Base.InsertBase(new Movimentacao("novato", i));

                Task.Run(() => { MessageBox.Show("Cliente Adicionado com sucesso!"); });

                txbPatrimonio_KeyDown(sender, new KeyEventArgs(Keys.Enter));
                txbUserID_KeyDown(sender, new KeyEventArgs(Keys.Enter));

                Cache.Cliente = i.USERID;

                ptbGerarTermo_Click(new object(), new EventArgs());
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbRemoverCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Cache.Cliente)) throw new DomainException("Escolha o cliente que será desligado!");
                Base.Atualizar(false, false);

                Inventario i = Base.Inv.Where(x => x.USERID == Cache.Cliente).FirstOrDefault();

                if (Base.Unidades.Where(x => x.Nome == i.UND).FirstOrDefault().Sigla != Base.Unidade)
                {
                    string origem = i.UND;
                    i.UND = Base.Unidades.Where(x => x.Sigla == Base.Unidade).FirstOrDefault().Nome;
                    i.UF = Base.Unidades.Where(x => x.Sigla == Base.Unidade).FirstOrDefault().UF;
                    Base.InsertBase(new Movimentacao("movido", i, origem));
                }

                Base.InsertBase(new Movimentacao("desligado", i));
                Base.GetBackup(i, Base.Unidades.Where(x => x.Sigla == Base.Unidade).FirstOrDefault());
                Base.UpdateBase(i);


                Task.Run(() => { MessageBox.Show("Cliete deu baixa com sucesso!"); });

                ptbApagarCampoCliente_Click(sender, e);

                Cache.Cliente = null;
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void MoverCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Cache.Cliente)) throw new DomainException("Escolha o cliente que será movido!");

                Base.Atualizar(false, false);
                frmMover m = new frmMover(Base.Inv.Where(x => x.USERID == Cache.Cliente).FirstOrDefault());
                m.ShowDialog();
                txbUserID_KeyDown(new object(), new KeyEventArgs(Keys.Enter));

            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void ptbMoverEquipamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Cache.Equipamento)) throw new DomainException("Escolha o Equipamento que será movido!");
                Base.Atualizar(false, false);
                if (Base.Inv.Where(x => x.PATRIMONIO == Cache.Equipamento).FirstOrDefault().USERID != "bkp") throw new DomainException("Somente equipamentos Backups pode ser movidos!");
                frmMover m = new frmMover(Base.Inv.Where(x => x.PATRIMONIO == Cache.Equipamento).FirstOrDefault());
                m.ShowDialog();
                txbPatrimonio_KeyDown(new object(), new KeyEventArgs(Keys.Enter));
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbTrocar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Cache.Equipamento)) throw new DomainException("Escolha o equipamento backup para a troca!");
                Base.Atualizar(false, false);
                if (Base.Inv.Where(x => x.PATRIMONIO == Cache.Equipamento && x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).FirstOrDefault().Nome).
                FirstOrDefault().USERID != "bkp") throw new DomainException("Somente equipamentos Backups da unidade podem trocar equipamento de cliente!");

                Inventario antigo = Base.Inv.Where(x => x.USERID == Cache.Cliente).FirstOrDefault();
                Inventario novo = Base.Inv.Where(x => x.PATRIMONIO == Cache.Equipamento).FirstOrDefault();
                Cliente cliente = new Cliente { UserID = antigo.USERID, Nome = antigo.FUNCIONARIO, Area = antigo.AREA, Cargo = antigo.CARGO, Unidade = antigo.UND, UF = antigo.UF };

                novo.UND = cliente.Unidade;
                novo.UF = cliente.UF;
                novo.FUNCIONARIO = cliente.Nome;
                novo.USERID = cliente.UserID;
                novo.AREA = cliente.Area;
                novo.CARGO = cliente.Cargo;
                novo.DATA = DateTime.Now.ToString("G");
                antigo.DATA = DateTime.Now.ToString("G");

                if (Base.Inv.Where(x => x.USERID == Cache.Cliente).FirstOrDefault().UND != Base.Unidades.Where(x => x.Sigla == Base.Unidade).FirstOrDefault().Nome)
                {
                    string origem = antigo.UND;
                    Base.GetBackup(antigo, Base.Unidades.Where(x => x.Sigla == Base.Unidade).FirstOrDefault());
                    antigo.Nomenclatura();
                    Base.InsertBase(new Movimentacao("movido", antigo, origem));
                    Base.UpdateBase(antigo);

                    origem = novo.UND;

                    novo.Nomenclatura();
                    Base.InsertBase(new Movimentacao("movido", novo, origem));
                    Base.UpdateBase(novo);

                    Base.InsertBase(new Movimentacao("troca", novo, antigo.PATRIMONIO));
                }
                else
                {
                    Base.GetBackup(antigo, Base.Unidades.Where(x => x.Sigla == Base.Unidade).FirstOrDefault());
                    Base.UpdateBase(antigo);
                    Base.UpdateBase(novo);
                    Base.InsertBase(new Movimentacao("troca", novo, antigo.PATRIMONIO));
                }

                ptbGerarTermo_Click(new object(), new EventArgs());

                txbUserID_KeyDown(new object(), new KeyEventArgs(Keys.Enter));
                txbPatrimonio.Text = antigo.PATRIMONIO;
                txbPatrimonio_KeyDown(new object(), new KeyEventArgs(Keys.Enter));
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbRemoverEquipamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Cache.Equipamento)) throw new DomainException("Escolha o equipamento que será removido!");
                if (Base.Inv.Where(x => x.PATRIMONIO == Cache.Equipamento && x.UND == Base.Unidades.Where(x => x.Sigla == Base.Unidade).FirstOrDefault().Nome).
                FirstOrDefault().USERID != "bkp") throw new DomainException("Somente equipamentos Backups da unidade ser obsoletos!");

                Inventario obsoleto = Base.Inv.Where(x => x.PATRIMONIO == Cache.Equipamento).FirstOrDefault();

                Base.GetObsoleto(obsoleto, Base.Unidades.Where(x => x.Nome == obsoleto.UND).FirstOrDefault());

                frmObs obs = new frmObs();
                obs.ShowDialog();

                Base.InsertBase(new Movimentacao("obsoleto", obsoleto, Cache.Obs));
                Base.UpdateBase(obsoleto);

                Cache.Equipamento = null;

                ptbApagarEquipamento_Click(new object(), new EventArgs());

                MessageBox.Show("Equipamento removido com sucesso!");
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbGerarTermo_Click(object sender, EventArgs e)
        {
            try
            {
                Termo.PDF(Base.Inv.Where(x => x.USERID == Cache.Cliente).ToList(), "teste");
                if (string.IsNullOrEmpty(Cache.Cliente)) throw new DomainException("Escolha o cliente para fazer o termo!");

                frmAcessorios a = new frmAcessorios((Base.Inv.Where(x => x.USERID == Cache.Cliente).Select(x => x.EQUIPAMENTO).Contains("Notebook")) ? "Notebook" : "Desktop");
                a.ShowDialog();
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
