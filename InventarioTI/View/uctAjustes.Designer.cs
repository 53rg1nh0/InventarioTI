using System.Windows.Forms;

namespace InventarioTI.View
{
    partial class uctAjustes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblUnidade = new Label();
            lblNome = new Label();
            lblMatricula = new Label();
            cbxUnidade = new ComboBox();
            txbResponsavel = new TextBox();
            txbMatricula = new TextBox();
            txbPasta = new TextBox();
            lblPasta = new Label();
            ckxImpressoraPadrão = new CheckBox();
            ptbPasta = new PictureBox();
            ptbSalvar = new PictureBox();
            txbProcessadores = new TextBox();
            lblProcessador = new Label();
            ptbProcessador = new PictureBox();
            ptbMemoria = new PictureBox();
            txbMemorias = new TextBox();
            lblMemoria = new Label();
            txbTipo = new TextBox();
            lblTipo = new Label();
            txbMarca = new TextBox();
            lblMarca = new Label();
            txbModelo = new TextBox();
            lblModelo = new Label();
            ptbTMM = new PictureBox();
            fbdPasta = new FolderBrowserDialog();
            dgvProcessadores = new DataGridView();
            ProcessadorP = new DataGridViewTextBoxColumn();
            ExP = new DataGridViewImageColumn();
            dgvMemorias = new DataGridView();
            memoriaM = new DataGridViewTextBoxColumn();
            ExM = new DataGridViewImageColumn();
            tlpBak0 = new TableLayoutPanel();
            tlpMeio = new TableLayoutPanel();
            dgvUnidade = new DataGridView();
            regiaoUnidade = new DataGridViewTextBoxColumn();
            ufUnidade = new DataGridViewTextBoxColumn();
            nomeUnidade = new DataGridViewTextBoxColumn();
            siglaUnidade = new DataGridViewTextBoxColumn();
            ExU = new DataGridViewImageColumn();
            tlpBottonU = new TableLayoutPanel();
            tlpBottonU1 = new TableLayoutPanel();
            lblUF = new Label();
            txbUF = new TextBox();
            tlpBottonU0 = new TableLayoutPanel();
            lblRegiao = new Label();
            txbRegiao = new TextBox();
            tlpBottonU3 = new TableLayoutPanel();
            lblSigla = new Label();
            txbSigla = new TextBox();
            tlpBottonU2 = new TableLayoutPanel();
            lblNomeU = new Label();
            txbNome = new TextBox();
            ptbUnidade = new PictureBox();
            tlpBotton2 = new TableLayoutPanel();
            tlpBottonM = new TableLayoutPanel();
            tlpBotton0 = new TableLayoutPanel();
            tlpBottonT0 = new TableLayoutPanel();
            tlpBottonT2 = new TableLayoutPanel();
            tlpBottonT1 = new TableLayoutPanel();
            tlpBotton1 = new TableLayoutPanel();
            tlpBottonP = new TableLayoutPanel();
            dgvTMM = new DataGridView();
            tipoTMM = new DataGridViewTextBoxColumn();
            marcaTMM = new DataGridViewTextBoxColumn();
            modeloTMM = new DataGridViewTextBoxColumn();
            ExT = new DataGridViewImageColumn();
            tlpTop = new TableLayoutPanel();
            tlpTopResposavel = new TableLayoutPanel();
            tlpTop3 = new TableLayoutPanel();
            tlpTop1 = new TableLayoutPanel();
            tlpTop0 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)ptbPasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalvar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbProcessador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMemoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbTMM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProcessadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMemorias).BeginInit();
            tlpBak0.SuspendLayout();
            tlpMeio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnidade).BeginInit();
            tlpBottonU.SuspendLayout();
            tlpBottonU1.SuspendLayout();
            tlpBottonU0.SuspendLayout();
            tlpBottonU3.SuspendLayout();
            tlpBottonU2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbUnidade).BeginInit();
            tlpBotton2.SuspendLayout();
            tlpBottonM.SuspendLayout();
            tlpBotton0.SuspendLayout();
            tlpBottonT0.SuspendLayout();
            tlpBottonT2.SuspendLayout();
            tlpBottonT1.SuspendLayout();
            tlpBotton1.SuspendLayout();
            tlpBottonP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTMM).BeginInit();
            tlpTop.SuspendLayout();
            tlpTopResposavel.SuspendLayout();
            tlpTop3.SuspendLayout();
            tlpTop1.SuspendLayout();
            tlpTop0.SuspendLayout();
            SuspendLayout();
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Dock = DockStyle.Bottom;
            lblUnidade.Location = new Point(3, 20);
            lblUnidade.Margin = new Padding(3, 0, 0, 0);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(67, 15);
            lblUnidade.TabIndex = 0;
            lblUnidade.Text = "Unidade";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Dock = DockStyle.Bottom;
            lblNome.Location = new Point(3, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(297, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Responsável";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Dock = DockStyle.Bottom;
            lblMatricula.Location = new Point(3, 20);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(95, 15);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "Matrícula";
            // 
            // cbxUnidade
            // 
            cbxUnidade.Dock = DockStyle.Fill;
            cbxUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUnidade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxUnidade.FormattingEnabled = true;
            cbxUnidade.Location = new Point(3, 35);
            cbxUnidade.Margin = new Padding(3, 0, 3, 0);
            cbxUnidade.Name = "cbxUnidade";
            cbxUnidade.Size = new Size(64, 23);
            cbxUnidade.TabIndex = 2;
            cbxUnidade.SelectedIndexChanged += cbxUnidade_SelectedIndexChanged;
            // 
            // txbResponsavel
            // 
            txbResponsavel.BorderStyle = BorderStyle.FixedSingle;
            txbResponsavel.Dock = DockStyle.Fill;
            txbResponsavel.Location = new Point(3, 35);
            txbResponsavel.Margin = new Padding(3, 0, 3, 0);
            txbResponsavel.Name = "txbResponsavel";
            txbResponsavel.Size = new Size(297, 23);
            txbResponsavel.TabIndex = 3;
            // 
            // txbMatricula
            // 
            txbMatricula.BorderStyle = BorderStyle.FixedSingle;
            txbMatricula.Dock = DockStyle.Fill;
            txbMatricula.Location = new Point(3, 35);
            txbMatricula.Margin = new Padding(3, 0, 3, 0);
            txbMatricula.Name = "txbMatricula";
            txbMatricula.Size = new Size(95, 23);
            txbMatricula.TabIndex = 4;
            // 
            // txbPasta
            // 
            txbPasta.BorderStyle = BorderStyle.FixedSingle;
            txbPasta.Dock = DockStyle.Fill;
            txbPasta.Enabled = false;
            txbPasta.Location = new Point(20, 35);
            txbPasta.Margin = new Padding(20, 0, 3, 0);
            txbPasta.Name = "txbPasta";
            txbPasta.Size = new Size(280, 23);
            txbPasta.TabIndex = 1;
            txbPasta.TabStop = false;
            // 
            // lblPasta
            // 
            lblPasta.AutoSize = true;
            lblPasta.Dock = DockStyle.Bottom;
            lblPasta.Location = new Point(20, 20);
            lblPasta.Margin = new Padding(20, 0, 0, 0);
            lblPasta.Name = "lblPasta";
            lblPasta.Size = new Size(283, 15);
            lblPasta.TabIndex = 6;
            lblPasta.Text = "Caminho Pasta Inventário";
            // 
            // ckxImpressoraPadrão
            // 
            ckxImpressoraPadrão.AutoSize = true;
            ckxImpressoraPadrão.Location = new Point(20, 60);
            ckxImpressoraPadrão.Margin = new Padding(20, 3, 0, 0);
            ckxImpressoraPadrão.Name = "ckxImpressoraPadrão";
            ckxImpressoraPadrão.Size = new Size(257, 19);
            ckxImpressoraPadrão.TabIndex = 1;
            ckxImpressoraPadrão.Text = "Imprimir documento na impressora  padrão\r\n";
            ckxImpressoraPadrão.UseVisualStyleBackColor = true;
            // 
            // ptbPasta
            // 
            ptbPasta.BackColor = Color.White;
            ptbPasta.Cursor = Cursors.Hand;
            ptbPasta.Dock = DockStyle.Fill;
            ptbPasta.Image = Properties.Resources.Pasta;
            ptbPasta.Location = new Point(303, 25);
            ptbPasta.Margin = new Padding(0, 25, 0, 0);
            ptbPasta.Name = "ptbPasta";
            ptbPasta.Size = new Size(70, 55);
            ptbPasta.TabIndex = 12;
            ptbPasta.TabStop = false;
            ptbPasta.Click += ptbPasta_Click;
            // 
            // ptbSalvar
            // 
            ptbSalvar.BackColor = Color.White;
            ptbSalvar.Cursor = Cursors.Hand;
            ptbSalvar.Dock = DockStyle.Fill;
            ptbSalvar.Image = Properties.Resources.Salvar;
            ptbSalvar.Location = new Point(853, 9);
            ptbSalvar.Margin = new Padding(6, 9, 3, 3);
            ptbSalvar.Name = "ptbSalvar";
            ptbSalvar.Size = new Size(157, 68);
            ptbSalvar.TabIndex = 13;
            ptbSalvar.TabStop = false;
            ptbSalvar.Click += ptbSalvar_Click;
            // 
            // txbProcessadores
            // 
            txbProcessadores.BorderStyle = BorderStyle.FixedSingle;
            txbProcessadores.Dock = DockStyle.Fill;
            txbProcessadores.Location = new Point(10, 29);
            txbProcessadores.Margin = new Padding(10, 0, 3, 0);
            txbProcessadores.Name = "txbProcessadores";
            txbProcessadores.Size = new Size(109, 23);
            txbProcessadores.TabIndex = 10;
            // 
            // lblProcessador
            // 
            lblProcessador.AutoSize = true;
            lblProcessador.Dock = DockStyle.Bottom;
            lblProcessador.Location = new Point(10, 14);
            lblProcessador.Margin = new Padding(10, 0, 3, 0);
            lblProcessador.Name = "lblProcessador";
            lblProcessador.Size = new Size(109, 15);
            lblProcessador.TabIndex = 14;
            lblProcessador.Text = "Processador";
            // 
            // ptbProcessador
            // 
            ptbProcessador.BackColor = Color.White;
            ptbProcessador.Cursor = Cursors.Hand;
            ptbProcessador.Dock = DockStyle.Bottom;
            ptbProcessador.Enabled = false;
            ptbProcessador.Image = Properties.Resources.AdicionarEquipamento;
            ptbProcessador.Location = new Point(125, 16);
            ptbProcessador.Name = "ptbProcessador";
            ptbProcessador.Size = new Size(44, 40);
            ptbProcessador.TabIndex = 16;
            ptbProcessador.TabStop = false;
            ptbProcessador.Click += ptbProcessador_Click;
            // 
            // ptbMemoria
            // 
            ptbMemoria.BackColor = Color.White;
            ptbMemoria.Cursor = Cursors.Hand;
            ptbMemoria.Dock = DockStyle.Bottom;
            ptbMemoria.Enabled = false;
            ptbMemoria.Image = Properties.Resources.AdicionarEquipamento;
            ptbMemoria.Location = new Point(84, 16);
            ptbMemoria.Name = "ptbMemoria";
            ptbMemoria.Size = new Size(44, 40);
            ptbMemoria.TabIndex = 19;
            ptbMemoria.TabStop = false;
            ptbMemoria.Click += ptbMemoria_Click;
            // 
            // txbMemorias
            // 
            txbMemorias.BorderStyle = BorderStyle.FixedSingle;
            txbMemorias.Dock = DockStyle.Fill;
            txbMemorias.Location = new Point(10, 29);
            txbMemorias.Margin = new Padding(10, 0, 3, 0);
            txbMemorias.Name = "txbMemorias";
            txbMemorias.Size = new Size(68, 23);
            txbMemorias.TabIndex = 11;
            // 
            // lblMemoria
            // 
            lblMemoria.AutoSize = true;
            lblMemoria.Dock = DockStyle.Bottom;
            lblMemoria.Location = new Point(10, 14);
            lblMemoria.Margin = new Padding(10, 0, 3, 0);
            lblMemoria.Name = "lblMemoria";
            lblMemoria.Size = new Size(68, 15);
            lblMemoria.TabIndex = 17;
            lblMemoria.Text = "Memória";
            // 
            // txbTipo
            // 
            txbTipo.BorderStyle = BorderStyle.FixedSingle;
            txbTipo.Dock = DockStyle.Fill;
            txbTipo.Location = new Point(20, 29);
            txbTipo.Margin = new Padding(20, 0, 3, 0);
            txbTipo.Name = "txbTipo";
            txbTipo.Size = new Size(83, 23);
            txbTipo.TabIndex = 7;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Dock = DockStyle.Bottom;
            lblTipo.Location = new Point(20, 14);
            lblTipo.Margin = new Padding(20, 0, 3, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(83, 15);
            lblTipo.TabIndex = 20;
            lblTipo.Text = "Tipo";
            // 
            // txbMarca
            // 
            txbMarca.BorderStyle = BorderStyle.FixedSingle;
            txbMarca.Dock = DockStyle.Fill;
            txbMarca.Location = new Point(3, 29);
            txbMarca.Margin = new Padding(3, 0, 3, 0);
            txbMarca.Name = "txbMarca";
            txbMarca.Size = new Size(93, 23);
            txbMarca.TabIndex = 8;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Dock = DockStyle.Bottom;
            lblMarca.Location = new Point(3, 14);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(93, 15);
            lblMarca.TabIndex = 22;
            lblMarca.Text = "Marca";
            // 
            // txbModelo
            // 
            txbModelo.BorderStyle = BorderStyle.FixedSingle;
            txbModelo.Dock = DockStyle.Fill;
            txbModelo.Location = new Point(3, 29);
            txbModelo.Margin = new Padding(3, 0, 3, 0);
            txbModelo.Name = "txbModelo";
            txbModelo.Size = new Size(93, 23);
            txbModelo.TabIndex = 9;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Dock = DockStyle.Bottom;
            lblModelo.Location = new Point(3, 14);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(93, 15);
            lblModelo.TabIndex = 24;
            lblModelo.Text = "Modelo";
            // 
            // ptbTMM
            // 
            ptbTMM.BackColor = Color.White;
            ptbTMM.Cursor = Cursors.Hand;
            ptbTMM.Dock = DockStyle.Bottom;
            ptbTMM.Enabled = false;
            ptbTMM.Image = Properties.Resources.AdicionarEquipamento;
            ptbTMM.Location = new Point(307, 16);
            ptbTMM.Name = "ptbTMM";
            ptbTMM.Size = new Size(44, 40);
            ptbTMM.TabIndex = 26;
            ptbTMM.TabStop = false;
            ptbTMM.Click += ptbTMM_Click;
            // 
            // dgvProcessadores
            // 
            dgvProcessadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcessadores.Columns.AddRange(new DataGridViewColumn[] { ProcessadorP, ExP });
            dgvProcessadores.Dock = DockStyle.Fill;
            dgvProcessadores.Enabled = false;
            dgvProcessadores.Location = new Point(364, 62);
            dgvProcessadores.Margin = new Padding(10, 3, 10, 51);
            dgvProcessadores.Name = "dgvProcessadores";
            dgvProcessadores.RowHeadersWidth = 62;
            dgvProcessadores.RowTemplate.Height = 25;
            dgvProcessadores.Size = new Size(152, 117);
            dgvProcessadores.TabIndex = 28;
            dgvProcessadores.TabStop = false;
            dgvProcessadores.CellContentClick += dgvProcessadores_CellContentClick;
            // 
            // ProcessadorP
            // 
            ProcessadorP.DataPropertyName = "TIPO";
            ProcessadorP.HeaderText = "PROCESSADOR";
            ProcessadorP.Name = "ProcessadorP";
            // 
            // ExP
            // 
            ExP.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ExP.HeaderText = "EXCLUIR";
            ExP.Image = Properties.Resources.Lixeira20;
            ExP.MinimumWidth = 8;
            ExP.Name = "ExP";
            ExP.Resizable = DataGridViewTriState.True;
            ExP.SortMode = DataGridViewColumnSortMode.Automatic;
            ExP.Width = 60;
            // 
            // dgvMemorias
            // 
            dgvMemorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemorias.Columns.AddRange(new DataGridViewColumn[] { memoriaM, ExM });
            dgvMemorias.Dock = DockStyle.Fill;
            dgvMemorias.Enabled = false;
            dgvMemorias.Location = new Point(536, 62);
            dgvMemorias.Margin = new Padding(10, 3, 10, 51);
            dgvMemorias.Name = "dgvMemorias";
            dgvMemorias.RowHeadersWidth = 62;
            dgvMemorias.RowTemplate.Height = 25;
            dgvMemorias.Size = new Size(111, 117);
            dgvMemorias.TabIndex = 29;
            dgvMemorias.TabStop = false;
            dgvMemorias.CellContentClick += dgvMemorias_CellContentClick;
            // 
            // memoriaM
            // 
            memoriaM.DataPropertyName = "RAM";
            memoriaM.HeaderText = "MEMÓRIA";
            memoriaM.Name = "memoriaM";
            // 
            // ExM
            // 
            ExM.HeaderText = "EXCLUIR";
            ExM.Image = Properties.Resources.Lixeira20;
            ExM.MinimumWidth = 8;
            ExM.Name = "ExM";
            ExM.Width = 150;
            // 
            // tlpBak0
            // 
            tlpBak0.ColumnCount = 1;
            tlpBak0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBak0.Controls.Add(tlpMeio, 0, 1);
            tlpBak0.Controls.Add(tlpTop, 0, 0);
            tlpBak0.Dock = DockStyle.Fill;
            tlpBak0.Location = new Point(0, 0);
            tlpBak0.Margin = new Padding(0);
            tlpBak0.Name = "tlpBak0";
            tlpBak0.RowCount = 2;
            tlpBak0.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tlpBak0.RowStyles.Add(new RowStyle(SizeType.Percent, 74F));
            tlpBak0.Size = new Size(1013, 310);
            tlpBak0.TabIndex = 1;
            // 
            // tlpMeio
            // 
            tlpMeio.ColumnCount = 4;
            tlpMeio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpMeio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tlpMeio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tlpMeio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpMeio.Controls.Add(dgvUnidade, 3, 1);
            tlpMeio.Controls.Add(tlpBottonU, 3, 0);
            tlpMeio.Controls.Add(tlpBotton2, 2, 0);
            tlpMeio.Controls.Add(tlpBotton0, 0, 0);
            tlpMeio.Controls.Add(tlpBotton1, 1, 0);
            tlpMeio.Controls.Add(dgvMemorias, 2, 1);
            tlpMeio.Controls.Add(dgvProcessadores, 1, 1);
            tlpMeio.Controls.Add(dgvTMM, 0, 1);
            tlpMeio.Dock = DockStyle.Fill;
            tlpMeio.Location = new Point(0, 80);
            tlpMeio.Margin = new Padding(0);
            tlpMeio.Name = "tlpMeio";
            tlpMeio.RowCount = 2;
            tlpMeio.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tlpMeio.RowStyles.Add(new RowStyle(SizeType.Percent, 74F));
            tlpMeio.Size = new Size(1013, 230);
            tlpMeio.TabIndex = 1;
            // 
            // dgvUnidade
            // 
            dgvUnidade.AllowUserToAddRows = false;
            dgvUnidade.AllowUserToDeleteRows = false;
            dgvUnidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnidade.Columns.AddRange(new DataGridViewColumn[] { regiaoUnidade, ufUnidade, nomeUnidade, siglaUnidade, ExU });
            dgvUnidade.Dock = DockStyle.Fill;
            dgvUnidade.Enabled = false;
            dgvUnidade.Location = new Point(667, 62);
            dgvUnidade.Margin = new Padding(10, 3, 20, 51);
            dgvUnidade.Name = "dgvUnidade";
            dgvUnidade.ReadOnly = true;
            dgvUnidade.RowHeadersWidth = 62;
            dgvUnidade.RowTemplate.Height = 25;
            dgvUnidade.Size = new Size(326, 117);
            dgvUnidade.TabIndex = 28;
            dgvUnidade.TabStop = false;
            dgvUnidade.CellContentClick += dgvUnidade_CellContentClick;
            // 
            // regiaoUnidade
            // 
            regiaoUnidade.DataPropertyName = "REGIAO";
            regiaoUnidade.HeaderText = "REGIÃO";
            regiaoUnidade.Name = "regiaoUnidade";
            regiaoUnidade.ReadOnly = true;
            // 
            // ufUnidade
            // 
            ufUnidade.DataPropertyName = "UF";
            ufUnidade.HeaderText = "UF";
            ufUnidade.Name = "ufUnidade";
            ufUnidade.ReadOnly = true;
            // 
            // nomeUnidade
            // 
            nomeUnidade.DataPropertyName = "NOME";
            nomeUnidade.HeaderText = "NOME";
            nomeUnidade.Name = "nomeUnidade";
            nomeUnidade.ReadOnly = true;
            // 
            // siglaUnidade
            // 
            siglaUnidade.DataPropertyName = "SIGLA";
            siglaUnidade.HeaderText = "SIGLA";
            siglaUnidade.Name = "siglaUnidade";
            siglaUnidade.ReadOnly = true;
            // 
            // ExU
            // 
            ExU.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ExU.HeaderText = "EXCLUIR";
            ExU.Image = Properties.Resources.Lixeira20;
            ExU.MinimumWidth = 8;
            ExU.Name = "ExU";
            ExU.ReadOnly = true;
            ExU.Width = 60;
            // 
            // tlpBottonU
            // 
            tlpBottonU.ColumnCount = 5;
            tlpBottonU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tlpBottonU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpBottonU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tlpBottonU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tlpBottonU.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tlpBottonU.Controls.Add(tlpBottonU1, 0, 0);
            tlpBottonU.Controls.Add(tlpBottonU0, 0, 0);
            tlpBottonU.Controls.Add(tlpBottonU3, 2, 0);
            tlpBottonU.Controls.Add(tlpBottonU2, 1, 0);
            tlpBottonU.Controls.Add(ptbUnidade, 4, 0);
            tlpBottonU.Dock = DockStyle.Fill;
            tlpBottonU.Location = new Point(657, 0);
            tlpBottonU.Margin = new Padding(0);
            tlpBottonU.Name = "tlpBottonU";
            tlpBottonU.RowCount = 1;
            tlpBottonU.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonU.Size = new Size(356, 59);
            tlpBottonU.TabIndex = 1;
            // 
            // tlpBottonU1
            // 
            tlpBottonU1.ColumnCount = 1;
            tlpBottonU1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottonU1.Controls.Add(lblUF, 0, 0);
            tlpBottonU1.Controls.Add(txbUF, 0, 1);
            tlpBottonU1.Dock = DockStyle.Fill;
            tlpBottonU1.Location = new Point(85, 0);
            tlpBottonU1.Margin = new Padding(0);
            tlpBottonU1.Name = "tlpBottonU1";
            tlpBottonU1.RowCount = 2;
            tlpBottonU1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonU1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpBottonU1.Size = new Size(35, 59);
            tlpBottonU1.TabIndex = 1;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Dock = DockStyle.Bottom;
            lblUF.Location = new Point(3, 14);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(29, 15);
            lblUF.TabIndex = 24;
            lblUF.Text = "UF";
            // 
            // txbUF
            // 
            txbUF.BorderStyle = BorderStyle.FixedSingle;
            txbUF.Dock = DockStyle.Fill;
            txbUF.Location = new Point(3, 29);
            txbUF.Margin = new Padding(3, 0, 3, 0);
            txbUF.Name = "txbUF";
            txbUF.Size = new Size(29, 23);
            txbUF.TabIndex = 13;
            // 
            // tlpBottonU0
            // 
            tlpBottonU0.ColumnCount = 1;
            tlpBottonU0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottonU0.Controls.Add(lblRegiao, 0, 0);
            tlpBottonU0.Controls.Add(txbRegiao, 0, 1);
            tlpBottonU0.Dock = DockStyle.Fill;
            tlpBottonU0.Location = new Point(0, 0);
            tlpBottonU0.Margin = new Padding(0);
            tlpBottonU0.Name = "tlpBottonU0";
            tlpBottonU0.RowCount = 2;
            tlpBottonU0.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonU0.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpBottonU0.Size = new Size(85, 59);
            tlpBottonU0.TabIndex = 1;
            // 
            // lblRegiao
            // 
            lblRegiao.AutoSize = true;
            lblRegiao.Dock = DockStyle.Bottom;
            lblRegiao.Location = new Point(10, 14);
            lblRegiao.Margin = new Padding(10, 0, 3, 0);
            lblRegiao.Name = "lblRegiao";
            lblRegiao.Size = new Size(72, 15);
            lblRegiao.TabIndex = 20;
            lblRegiao.Text = "Região";
            // 
            // txbRegiao
            // 
            txbRegiao.BorderStyle = BorderStyle.FixedSingle;
            txbRegiao.Dock = DockStyle.Fill;
            txbRegiao.Location = new Point(10, 29);
            txbRegiao.Margin = new Padding(10, 0, 3, 0);
            txbRegiao.Name = "txbRegiao";
            txbRegiao.Size = new Size(72, 23);
            txbRegiao.TabIndex = 12;
            // 
            // tlpBottonU3
            // 
            tlpBottonU3.ColumnCount = 1;
            tlpBottonU3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottonU3.Controls.Add(lblSigla, 0, 0);
            tlpBottonU3.Controls.Add(txbSigla, 0, 1);
            tlpBottonU3.Dock = DockStyle.Fill;
            tlpBottonU3.Location = new Point(241, 0);
            tlpBottonU3.Margin = new Padding(0);
            tlpBottonU3.Name = "tlpBottonU3";
            tlpBottonU3.RowCount = 2;
            tlpBottonU3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonU3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpBottonU3.Size = new Size(56, 59);
            tlpBottonU3.TabIndex = 1;
            // 
            // lblSigla
            // 
            lblSigla.AutoSize = true;
            lblSigla.Dock = DockStyle.Bottom;
            lblSigla.Location = new Point(3, 14);
            lblSigla.Name = "lblSigla";
            lblSigla.Size = new Size(50, 15);
            lblSigla.TabIndex = 24;
            lblSigla.Text = "Sigla";
            // 
            // txbSigla
            // 
            txbSigla.BorderStyle = BorderStyle.FixedSingle;
            txbSigla.Dock = DockStyle.Fill;
            txbSigla.Location = new Point(3, 29);
            txbSigla.Margin = new Padding(3, 0, 3, 0);
            txbSigla.Name = "txbSigla";
            txbSigla.Size = new Size(50, 23);
            txbSigla.TabIndex = 15;
            // 
            // tlpBottonU2
            // 
            tlpBottonU2.ColumnCount = 1;
            tlpBottonU2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottonU2.Controls.Add(lblNomeU, 0, 0);
            tlpBottonU2.Controls.Add(txbNome, 0, 1);
            tlpBottonU2.Dock = DockStyle.Fill;
            tlpBottonU2.Location = new Point(120, 0);
            tlpBottonU2.Margin = new Padding(0);
            tlpBottonU2.Name = "tlpBottonU2";
            tlpBottonU2.RowCount = 2;
            tlpBottonU2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonU2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpBottonU2.Size = new Size(121, 59);
            tlpBottonU2.TabIndex = 1;
            // 
            // lblNomeU
            // 
            lblNomeU.AutoSize = true;
            lblNomeU.Dock = DockStyle.Bottom;
            lblNomeU.Location = new Point(3, 14);
            lblNomeU.Name = "lblNomeU";
            lblNomeU.Size = new Size(115, 15);
            lblNomeU.TabIndex = 22;
            lblNomeU.Text = "Nome";
            // 
            // txbNome
            // 
            txbNome.BorderStyle = BorderStyle.FixedSingle;
            txbNome.Dock = DockStyle.Fill;
            txbNome.Location = new Point(3, 29);
            txbNome.Margin = new Padding(3, 0, 3, 0);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(115, 23);
            txbNome.TabIndex = 14;
            // 
            // ptbUnidade
            // 
            ptbUnidade.BackColor = Color.White;
            ptbUnidade.Cursor = Cursors.Hand;
            ptbUnidade.Dock = DockStyle.Bottom;
            ptbUnidade.Enabled = false;
            ptbUnidade.Image = Properties.Resources.AdicionarEquipamento;
            ptbUnidade.Location = new Point(300, 16);
            ptbUnidade.Name = "ptbUnidade";
            ptbUnidade.Size = new Size(53, 40);
            ptbUnidade.TabIndex = 26;
            ptbUnidade.TabStop = false;
            ptbUnidade.Click += ptbUnidade_Click;
            // 
            // tlpBotton2
            // 
            tlpBotton2.ColumnCount = 2;
            tlpBotton2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tlpBotton2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpBotton2.Controls.Add(tlpBottonM, 0, 0);
            tlpBotton2.Controls.Add(ptbMemoria, 1, 0);
            tlpBotton2.Dock = DockStyle.Fill;
            tlpBotton2.Location = new Point(526, 0);
            tlpBotton2.Margin = new Padding(0);
            tlpBotton2.Name = "tlpBotton2";
            tlpBotton2.RowCount = 1;
            tlpBotton2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotton2.Size = new Size(131, 59);
            tlpBotton2.TabIndex = 1;
            // 
            // tlpBottonM
            // 
            tlpBottonM.ColumnCount = 1;
            tlpBottonM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottonM.Controls.Add(txbMemorias, 0, 1);
            tlpBottonM.Controls.Add(lblMemoria, 0, 0);
            tlpBottonM.Dock = DockStyle.Fill;
            tlpBottonM.Location = new Point(0, 0);
            tlpBottonM.Margin = new Padding(0);
            tlpBottonM.Name = "tlpBottonM";
            tlpBottonM.RowCount = 2;
            tlpBottonM.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonM.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpBottonM.Size = new Size(81, 59);
            tlpBottonM.TabIndex = 1;
            // 
            // tlpBotton0
            // 
            tlpBotton0.ColumnCount = 4;
            tlpBotton0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpBotton0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tlpBotton0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tlpBotton0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpBotton0.Controls.Add(ptbTMM, 3, 0);
            tlpBotton0.Controls.Add(tlpBottonT0, 0, 0);
            tlpBotton0.Controls.Add(tlpBottonT2, 2, 0);
            tlpBotton0.Controls.Add(tlpBottonT1, 1, 0);
            tlpBotton0.Dock = DockStyle.Fill;
            tlpBotton0.Location = new Point(0, 0);
            tlpBotton0.Margin = new Padding(0);
            tlpBotton0.Name = "tlpBotton0";
            tlpBotton0.RowCount = 1;
            tlpBotton0.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotton0.Size = new Size(354, 59);
            tlpBotton0.TabIndex = 1;
            // 
            // tlpBottonT0
            // 
            tlpBottonT0.ColumnCount = 1;
            tlpBottonT0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottonT0.Controls.Add(lblTipo, 0, 0);
            tlpBottonT0.Controls.Add(txbTipo, 0, 1);
            tlpBottonT0.Dock = DockStyle.Fill;
            tlpBottonT0.Location = new Point(0, 0);
            tlpBottonT0.Margin = new Padding(0);
            tlpBottonT0.Name = "tlpBottonT0";
            tlpBottonT0.RowCount = 2;
            tlpBottonT0.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonT0.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpBottonT0.Size = new Size(106, 59);
            tlpBottonT0.TabIndex = 1;
            // 
            // tlpBottonT2
            // 
            tlpBottonT2.ColumnCount = 1;
            tlpBottonT2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottonT2.Controls.Add(lblModelo, 0, 0);
            tlpBottonT2.Controls.Add(txbModelo, 0, 1);
            tlpBottonT2.Dock = DockStyle.Fill;
            tlpBottonT2.Location = new Point(205, 0);
            tlpBottonT2.Margin = new Padding(0);
            tlpBottonT2.Name = "tlpBottonT2";
            tlpBottonT2.RowCount = 2;
            tlpBottonT2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonT2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpBottonT2.Size = new Size(99, 59);
            tlpBottonT2.TabIndex = 3;
            // 
            // tlpBottonT1
            // 
            tlpBottonT1.ColumnCount = 1;
            tlpBottonT1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottonT1.Controls.Add(lblMarca, 0, 0);
            tlpBottonT1.Controls.Add(txbMarca, 0, 1);
            tlpBottonT1.Dock = DockStyle.Fill;
            tlpBottonT1.Location = new Point(106, 0);
            tlpBottonT1.Margin = new Padding(0);
            tlpBottonT1.Name = "tlpBottonT1";
            tlpBottonT1.RowCount = 2;
            tlpBottonT1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonT1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpBottonT1.Size = new Size(99, 59);
            tlpBottonT1.TabIndex = 1;
            // 
            // tlpBotton1
            // 
            tlpBotton1.ColumnCount = 2;
            tlpBotton1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71F));
            tlpBotton1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29F));
            tlpBotton1.Controls.Add(ptbProcessador, 1, 0);
            tlpBotton1.Controls.Add(tlpBottonP, 0, 0);
            tlpBotton1.Dock = DockStyle.Fill;
            tlpBotton1.Location = new Point(354, 0);
            tlpBotton1.Margin = new Padding(0);
            tlpBotton1.Name = "tlpBotton1";
            tlpBotton1.RowCount = 1;
            tlpBotton1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotton1.Size = new Size(172, 59);
            tlpBotton1.TabIndex = 1;
            // 
            // tlpBottonP
            // 
            tlpBottonP.ColumnCount = 1;
            tlpBottonP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBottonP.Controls.Add(txbProcessadores, 0, 1);
            tlpBottonP.Controls.Add(lblProcessador, 0, 0);
            tlpBottonP.Dock = DockStyle.Fill;
            tlpBottonP.Location = new Point(0, 0);
            tlpBottonP.Margin = new Padding(0);
            tlpBottonP.Name = "tlpBottonP";
            tlpBottonP.RowCount = 2;
            tlpBottonP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottonP.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpBottonP.Size = new Size(122, 59);
            tlpBottonP.TabIndex = 1;
            // 
            // dgvTMM
            // 
            dgvTMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTMM.Columns.AddRange(new DataGridViewColumn[] { tipoTMM, marcaTMM, modeloTMM, ExT });
            dgvTMM.Dock = DockStyle.Fill;
            dgvTMM.Enabled = false;
            dgvTMM.Location = new Point(20, 62);
            dgvTMM.Margin = new Padding(20, 3, 10, 51);
            dgvTMM.Name = "dgvTMM";
            dgvTMM.RowHeadersWidth = 62;
            dgvTMM.RowTemplate.Height = 25;
            dgvTMM.Size = new Size(324, 117);
            dgvTMM.TabIndex = 33;
            dgvTMM.TabStop = false;
            dgvTMM.CellContentClick += dgvTMM_CellContentClick;
            // 
            // tipoTMM
            // 
            tipoTMM.DataPropertyName = "TIPO";
            tipoTMM.HeaderText = "TIPO";
            tipoTMM.Name = "tipoTMM";
            // 
            // marcaTMM
            // 
            marcaTMM.DataPropertyName = "MARCA";
            marcaTMM.HeaderText = "MARCA";
            marcaTMM.Name = "marcaTMM";
            // 
            // modeloTMM
            // 
            modeloTMM.DataPropertyName = "MODELO";
            modeloTMM.HeaderText = "MODELO";
            modeloTMM.Name = "modeloTMM";
            // 
            // ExT
            // 
            ExT.HeaderText = "EXCLUIR";
            ExT.Image = Properties.Resources.Lixeira20;
            ExT.MinimumWidth = 8;
            ExT.Name = "ExT";
            ExT.Width = 150;
            // 
            // tlpTop
            // 
            tlpTop.ColumnCount = 6;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tlpTop.Controls.Add(ptbSalvar, 5, 0);
            tlpTop.Controls.Add(tlpTopResposavel, 3, 0);
            tlpTop.Controls.Add(tlpTop3, 4, 0);
            tlpTop.Controls.Add(tlpTop1, 2, 0);
            tlpTop.Controls.Add(tlpTop0, 0, 0);
            tlpTop.Controls.Add(ptbPasta, 1, 0);
            tlpTop.Dock = DockStyle.Fill;
            tlpTop.Location = new Point(0, 0);
            tlpTop.Margin = new Padding(0);
            tlpTop.Name = "tlpTop";
            tlpTop.RowCount = 1;
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTop.Size = new Size(1013, 80);
            tlpTop.TabIndex = 1;
            // 
            // tlpTopResposavel
            // 
            tlpTopResposavel.ColumnCount = 1;
            tlpTopResposavel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTopResposavel.Controls.Add(lblNome, 0, 0);
            tlpTopResposavel.Controls.Add(txbResponsavel, 0, 1);
            tlpTopResposavel.Dock = DockStyle.Fill;
            tlpTopResposavel.Location = new Point(443, 0);
            tlpTopResposavel.Margin = new Padding(0);
            tlpTopResposavel.Name = "tlpTopResposavel";
            tlpTopResposavel.RowCount = 3;
            tlpTopResposavel.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tlpTopResposavel.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpTopResposavel.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpTopResposavel.Size = new Size(303, 80);
            tlpTopResposavel.TabIndex = 1;
            // 
            // tlpTop3
            // 
            tlpTop3.ColumnCount = 1;
            tlpTop3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTop3.Controls.Add(lblMatricula, 0, 0);
            tlpTop3.Controls.Add(txbMatricula, 0, 1);
            tlpTop3.Dock = DockStyle.Fill;
            tlpTop3.Location = new Point(746, 0);
            tlpTop3.Margin = new Padding(0);
            tlpTop3.Name = "tlpTop3";
            tlpTop3.RowCount = 3;
            tlpTop3.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tlpTop3.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpTop3.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpTop3.Size = new Size(101, 80);
            tlpTop3.TabIndex = 1;
            // 
            // tlpTop1
            // 
            tlpTop1.ColumnCount = 1;
            tlpTop1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTop1.Controls.Add(lblUnidade, 0, 0);
            tlpTop1.Controls.Add(cbxUnidade, 0, 1);
            tlpTop1.Dock = DockStyle.Fill;
            tlpTop1.Location = new Point(373, 0);
            tlpTop1.Margin = new Padding(0);
            tlpTop1.Name = "tlpTop1";
            tlpTop1.RowCount = 3;
            tlpTop1.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tlpTop1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpTop1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpTop1.Size = new Size(70, 80);
            tlpTop1.TabIndex = 1;
            // 
            // tlpTop0
            // 
            tlpTop0.ColumnCount = 1;
            tlpTop0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTop0.Controls.Add(lblPasta, 0, 0);
            tlpTop0.Controls.Add(txbPasta, 0, 1);
            tlpTop0.Controls.Add(ckxImpressoraPadrão, 0, 2);
            tlpTop0.Dock = DockStyle.Fill;
            tlpTop0.Location = new Point(0, 0);
            tlpTop0.Margin = new Padding(0);
            tlpTop0.Name = "tlpTop0";
            tlpTop0.RowCount = 3;
            tlpTop0.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tlpTop0.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpTop0.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpTop0.Size = new Size(303, 80);
            tlpTop0.TabIndex = 1;
            // 
            // uctAjustes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tlpBak0);
            Margin = new Padding(0);
            Name = "uctAjustes";
            Size = new Size(1013, 310);
            Load += uctAjustes_Load;
            ((System.ComponentModel.ISupportInitialize)ptbPasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalvar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbProcessador).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMemoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbTMM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProcessadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMemorias).EndInit();
            tlpBak0.ResumeLayout(false);
            tlpMeio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUnidade).EndInit();
            tlpBottonU.ResumeLayout(false);
            tlpBottonU1.ResumeLayout(false);
            tlpBottonU1.PerformLayout();
            tlpBottonU0.ResumeLayout(false);
            tlpBottonU0.PerformLayout();
            tlpBottonU3.ResumeLayout(false);
            tlpBottonU3.PerformLayout();
            tlpBottonU2.ResumeLayout(false);
            tlpBottonU2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbUnidade).EndInit();
            tlpBotton2.ResumeLayout(false);
            tlpBottonM.ResumeLayout(false);
            tlpBottonM.PerformLayout();
            tlpBotton0.ResumeLayout(false);
            tlpBottonT0.ResumeLayout(false);
            tlpBottonT0.PerformLayout();
            tlpBottonT2.ResumeLayout(false);
            tlpBottonT2.PerformLayout();
            tlpBottonT1.ResumeLayout(false);
            tlpBottonT1.PerformLayout();
            tlpBotton1.ResumeLayout(false);
            tlpBottonP.ResumeLayout(false);
            tlpBottonP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTMM).EndInit();
            tlpTop.ResumeLayout(false);
            tlpTopResposavel.ResumeLayout(false);
            tlpTopResposavel.PerformLayout();
            tlpTop3.ResumeLayout(false);
            tlpTop3.PerformLayout();
            tlpTop1.ResumeLayout(false);
            tlpTop1.PerformLayout();
            tlpTop0.ResumeLayout(false);
            tlpTop0.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUnidade;
        private Label lblNome;
        private Label lblMatricula;
        private Label lblPasta;
        private PictureBox ptbPasta;
        private PictureBox ptbSalvar;
        private TextBox txbProcessadores;
        private Label lblProcessador;
        private TextBox txbMemorias;
        private Label lblMemoria;
        private TextBox txbTipo;
        private Label lblTipo;
        private TextBox txbMarca;
        private Label lblMarca;
        private TextBox txbModelo;
        private Label lblModelo;
        private FolderBrowserDialog fbdPasta;
        public ComboBox cbxUnidade;
        public TextBox txbResponsavel;
        public TextBox txbMatricula;
        public TextBox txbPasta;
        public CheckBox ckxImpressoraPadrão;
        private DataGridView dgvProcessadores;
        private DataGridView dgvMemorias;
        private TableLayoutPanel tlpBak0;
        private TableLayoutPanel tlpTop;
        private TableLayoutPanel tlpMeio;
        private TableLayoutPanel tlpTop0;
        private TableLayoutPanel tlpTop1;
        private TableLayoutPanel tlpTop3;
        private TableLayoutPanel tlpTopResposavel;
        private TableLayoutPanel tlpBotton0;
        private TableLayoutPanel tlpBotton2;
        private TableLayoutPanel tlpBotton1;
        private TableLayoutPanel tlpBottonM;
        private TableLayoutPanel tlpBottonT0;
        private TableLayoutPanel tlpBottonT2;
        private TableLayoutPanel tlpBottonT1;
        private TableLayoutPanel tlpBottonP;
        public PictureBox ptbProcessador;
        public PictureBox ptbMemoria;
        public PictureBox ptbTMM;
        private DataGridView dgvUnidade;
        private TableLayoutPanel tlpBottonU;
        public PictureBox ptbUnidade;
        private TableLayoutPanel tlpBottonU0;
        private Label lblRegiao;
        private TextBox txbRegiao;
        private TableLayoutPanel tlpBottonU3;
        private Label lblSigla;
        private TextBox txbSigla;
        private TableLayoutPanel tlpBottonU2;
        private Label lblNomeU;
        private TextBox txbNome;
        private TableLayoutPanel tlpBottonU1;
        private Label lblUF;
        private TextBox txbUF;
        private DataGridView dgvTMM;
        private DataGridViewTextBoxColumn ProcessadorP;
        private DataGridViewImageColumn ExP;
        private DataGridViewTextBoxColumn tipoTMM;
        private DataGridViewTextBoxColumn marcaTMM;
        private DataGridViewTextBoxColumn modeloTMM;
        private DataGridViewImageColumn ExT;
        private DataGridViewTextBoxColumn memoriaM;
        private DataGridViewImageColumn ExM;
        private DataGridViewTextBoxColumn regiaoUnidade;
        private DataGridViewTextBoxColumn ufUnidade;
        private DataGridViewTextBoxColumn nomeUnidade;
        private DataGridViewTextBoxColumn siglaUnidade;
        private DataGridViewImageColumn ExU;
    }
}
