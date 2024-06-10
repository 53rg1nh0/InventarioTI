using InventarioTI.Entites;
using InventarioTI.Extencions;
using InventarioTI.Services;
using System.Data;
using InventarioTI.Entites.Exceptions;
using InventarioTI.Entites.emuns;

namespace InventarioTI.View
{
    public partial class uctAjustes : UserControl
    {
        public uctAjustes()
        {
            InitializeComponent();
        }

        public void Preencher()
        {
            //Properties.Settings.Default.Path = "";
            //Properties.Settings.Default.Impressora = false;
            //Properties.Settings.Default.Responsavel = "";
            //Properties.Settings.Default.Matricula = "";
            //Properties.Settings.Default.Unidade = "";
            //Properties.Settings.Default.Save();

            var dgvTAnterior = dgvTMM.DataSource as IDisposable;
            var dgvPAnterior = dgvProcessadores.DataSource as IDisposable;
            var dgvMAnterior = dgvMemorias.DataSource as IDisposable;
            var dgvUAnterior = dgvUnidade.DataSource as IDisposable;

            if (dgvTAnterior != null) dgvTAnterior.Dispose();
            if (dgvPAnterior != null) dgvPAnterior.Dispose();
            if (dgvMAnterior != null) dgvMAnterior.Dispose();
            if (dgvUAnterior != null) dgvUAnterior.Dispose();

            txbPasta.Text = Properties.Settings.Default.Path;
            ckxImpressoraPadrão.Checked = Properties.Settings.Default.Impressora;
            txbResponsavel.Text = Properties.Settings.Default.Responsavel;
            txbMatricula.Text = Properties.Settings.Default.Matricula;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Path) && (Base.Unidade != cbxUnidade.Text || string.IsNullOrEmpty(cbxUnidade.Text)))
            {
                cbxUnidade.Items.Clear();

                cbxUnidade.Items.AddRange(Base.Unidades.Select(x => x.Sigla).ToArray());

                cbxUnidade.Text = Base.Unidade;

                Atualizar();
            }

        }
        public void Atualizar()
        {
            dgvTMM.Estilo();
            dgvTMM.DataSource = Base.Ta[typeof(TMM)];
            dgvProcessadores.Estilo();
            dgvProcessadores.DataSource = Base.Ta[typeof(Processador)];
            dgvMemorias.Estilo();
            dgvMemorias.DataSource = Base.Ta[typeof(Memoria)];
            dgvUnidade.Estilo();
            dgvUnidade.DataSource = Base.Ta[typeof(Unidade)];

            AtivarEdicao();
        }

        private void AtivarEdicao()
        {
            bool validacao = !string.IsNullOrEmpty(txbMatricula.Text) && Base.Adms.Select(x => x.matricula).ToArray().Contains(txbMatricula.Text);

            ptbTMM.Enabled = validacao;
            ptbMemoria.Enabled = validacao;
            ptbUnidade.Enabled = validacao;
            ptbProcessador.Enabled = validacao;

            dgvTMM.Enabled = validacao;
            dgvMemorias.Enabled = validacao;
            dgvUnidade.Enabled = validacao;
            dgvProcessadores.Enabled = validacao;
        }

        private void ptbPasta_Click(object sender, EventArgs e)
        {
            if (fbdPasta.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Validar.ExistenciaPastasArquivos(fbdPasta.SelectedPath);
                    txbPasta.Text = fbdPasta.SelectedPath;
                    Properties.Settings.Default.Path = fbdPasta.SelectedPath;

                    Base.Atualizar();
                    cbxUnidade.Items.AddRange(Base.Unidades.Select(x => x.Sigla).ToArray());
                    cbxUnidade.Text = "";

                    Preencher();

                }
                catch (DomainException ex) { MessageBox.Show(ex.Message); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void ptbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Path = txbPasta.Text;
                Properties.Settings.Default.Impressora = ckxImpressoraPadrão.Checked;
                Properties.Settings.Default.Responsavel = txbResponsavel.Text;
                Properties.Settings.Default.Matricula = txbMatricula.Text;
                Properties.Settings.Default.Save();

                AtivarEdicao();

                MessageBox.Show("Dados Salvos com sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro ao salvar os dados");
            }
        }

        private void uctAjustes_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Path))
            {
                Base.Atualizar();
                Preencher();
            }
        }

        private void dgvTMM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTMM.Columns[e.ColumnIndex] == dgvTMM.Columns["ExT"] && e.RowIndex != -1)
            {
                Base.RemoveBase(new TMM(), e.RowIndex);
                Preencher();
            }
        }

        private void dgvProcessadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProcessadores.Columns[e.ColumnIndex] == dgvProcessadores.Columns["ExP"] && e.RowIndex != -1)
            {
                Base.RemoveBase(new Processador(), e.RowIndex);
                Preencher();
            }
        }

        private void dgvMemorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMemorias.Columns[e.ColumnIndex] == dgvMemorias.Columns["ExM"] && e.RowIndex != -1)
            {
                Base.RemoveBase(new Memoria(), e.RowIndex);
                Preencher();
            }
        }

        private void dgvUnidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUnidade.Columns[e.ColumnIndex] == dgvUnidade.Columns["ExU"] && e.RowIndex != -1)
            {
                Base.RemoveBase(new Unidade(), e.RowIndex);
                Preencher();
            }
        }

        private void cbxUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxUnidade.Text) && Base.Unidade != cbxUnidade.Text)
            {
                Properties.Settings.Default.Unidade = cbxUnidade.Text;

                Base.Unidade = cbxUnidade.Text;

                if (!string.IsNullOrEmpty(Properties.Settings.Default.Path)) Preencher();

                Base.Atualizar();
            }
        }

        private void ptbTMM_Click(object sender, EventArgs e)
        {
            TMM tmm = new TMM { Tipo = txbTipo.Text, Marca = txbMarca.Text, Modelo = txbModelo.Text };
            try
            {
                if ((string.IsNullOrEmpty(tmm.Tipo) || string.IsNullOrEmpty(tmm.Marca) || string.IsNullOrEmpty(tmm.Modelo))) throw new DomainException("Não pode conter campos vazios!");
                if (Base.TMMs.Select(c => c.Tipo + c.Marca + c.Modelo).Contains(tmm.Tipo + tmm.Marca + tmm.Modelo)) throw new DomainException("Equipamento já existe!");

                Base.InsertBase(tmm);
                Preencher();
                txbTipo.Clear();
                txbMarca.Clear();
                txbModelo.Clear();
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbProcessador_Click(object sender, EventArgs e)
        {
            Processador pro = new Processador { Tipo = txbProcessadores.Text };
            try
            {
                if (string.IsNullOrEmpty(pro.Tipo)) throw new DomainException("Não pode conter campos vazios!");
                if (Base.Processadores.Select(c => c.Tipo).Contains(pro.Tipo)) throw new DomainException("Equipamento já existe!");

                Base.InsertBase(pro);
                Preencher();
                txbProcessadores.Clear();
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbMemoria_Click(object sender, EventArgs e)
        {
            Memoria mem = new Memoria { Ram = txbMemorias.Text };
            try
            {
                if (string.IsNullOrEmpty(mem.Ram)) throw new DomainException("Não pode conter campos vazios!");
                if (Base.Processadores.Select(c => c.Tipo).Contains(mem.Ram)) throw new DomainException("Equipamento já existe!");

                Base.InsertBase(mem);
                Preencher();
                txbMemorias.Clear();
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ptbUnidade_Click(object sender, EventArgs e)
        {
            Unidade uni = new Unidade { Regiao = txbRegiao.Text, UF = txbUF.Text, Nome = txbNome.Text, Sigla = txbSigla.Text };
            try
            {
                if (string.IsNullOrEmpty(uni.Regiao) || string.IsNullOrEmpty(uni.UF) || string.IsNullOrEmpty(uni.Nome) || string.IsNullOrEmpty(uni.Sigla)) throw new DomainException("Não pode conter campos vazios!");
                if (Base.Unidades.Select(c => c.Sigla).Contains(uni.Sigla)) throw new DomainException("Equipamento já existe!");

                Base.InsertBase(uni);
                Preencher();
                txbRegiao.Clear();
                txbUF.Clear();
                txbNome.Clear();
                txbSigla.Clear();
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
