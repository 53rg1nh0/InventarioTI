namespace InventarioTI.View
{
    partial class uctHome
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
            components = new System.ComponentModel.Container();
            tlphome = new TableLayoutPanel();
            pnlEquipamentoTop = new Panel();
            ptbTrocar = new PictureBox();
            lblTituloEquipamento = new Label();
            ptbMoverEquipamento = new PictureBox();
            ptbApagarEquipamento = new PictureBox();
            ptbRemoverEquipamento = new PictureBox();
            ptbEditarEquipamento = new PictureBox();
            ptbAdicionarEquipamento = new PictureBox();
            pnlCLienteTop = new Panel();
            lblTituloCLiente = new Label();
            ptbGerarTermo = new PictureBox();
            MoverCliente = new PictureBox();
            ptbApagarCampoCliente = new PictureBox();
            ptbRemoverCliente = new PictureBox();
            ptbEditarCliente = new PictureBox();
            ptbAdicionarCLinete = new PictureBox();
            pnlCliente = new Panel();
            ptbLupaNome = new PictureBox();
            ptbLupaUserID = new PictureBox();
            lblUnidade = new Label();
            txbUnidade = new TextBox();
            txbCargo = new TextBox();
            txbMatricula = new TextBox();
            txbNome = new TextBox();
            dgvCliente = new DataGridView();
            patrimonioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomenclaturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Serie = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            processadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            equipamentoBindingSource = new BindingSource(components);
            lblMatricula = new Label();
            lblCargo = new Label();
            lblArea = new Label();
            lblNome = new Label();
            lblUserID = new Label();
            txbArea = new TextBox();
            txbUserID = new TextBox();
            pnlEquipamento = new Panel();
            pictureBox1 = new PictureBox();
            ptbLupaPatrimonio = new PictureBox();
            cbxModelo = new ComboBox();
            cbxMarca = new ComboBox();
            cbxMemoria = new ComboBox();
            cbxProcessador = new ComboBox();
            cbxTipo = new ComboBox();
            lblModelo = new Label();
            lblMarca = new Label();
            txbSerie = new TextBox();
            lblSerie = new Label();
            txbPatrimonio = new TextBox();
            lblRam = new Label();
            lblProcessador = new Label();
            lblPatrimonio = new Label();
            lblMicrocomputador = new Label();
            dgvEquipamento = new DataGridView();
            userIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cargoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            lblCliente = new Label();
            lblEquipamento = new Label();
            tlphome.SuspendLayout();
            pnlEquipamentoTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTrocar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMoverEquipamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbApagarEquipamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbRemoverEquipamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbEditarEquipamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAdicionarEquipamento).BeginInit();
            pnlCLienteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbGerarTermo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MoverCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbApagarCampoCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbRemoverCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbEditarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAdicionarCLinete).BeginInit();
            pnlCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLupaNome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbLupaUserID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)equipamentoBindingSource).BeginInit();
            pnlEquipamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbLupaPatrimonio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tlphome
            // 
            tlphome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlphome.BackColor = Color.White;
            tlphome.ColumnCount = 1;
            tlphome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlphome.Controls.Add(pnlEquipamentoTop, 0, 2);
            tlphome.Controls.Add(pnlCLienteTop, 0, 0);
            tlphome.Controls.Add(pnlCliente, 0, 1);
            tlphome.Controls.Add(pnlEquipamento, 0, 3);
            tlphome.Dock = DockStyle.Fill;
            tlphome.Location = new Point(0, 0);
            tlphome.Margin = new Padding(0);
            tlphome.Name = "tlphome";
            tlphome.RowCount = 5;
            tlphome.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlphome.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlphome.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlphome.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlphome.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlphome.Size = new Size(1007, 367);
            tlphome.TabIndex = 0;
            // 
            // pnlEquipamentoTop
            // 
            pnlEquipamentoTop.Controls.Add(ptbTrocar);
            pnlEquipamentoTop.Controls.Add(lblTituloEquipamento);
            pnlEquipamentoTop.Controls.Add(ptbMoverEquipamento);
            pnlEquipamentoTop.Controls.Add(ptbApagarEquipamento);
            pnlEquipamentoTop.Controls.Add(ptbRemoverEquipamento);
            pnlEquipamentoTop.Controls.Add(ptbEditarEquipamento);
            pnlEquipamentoTop.Controls.Add(ptbAdicionarEquipamento);
            pnlEquipamentoTop.Dock = DockStyle.Fill;
            pnlEquipamentoTop.Location = new Point(0, 168);
            pnlEquipamentoTop.Margin = new Padding(0);
            pnlEquipamentoTop.Name = "pnlEquipamentoTop";
            pnlEquipamentoTop.Size = new Size(1007, 50);
            pnlEquipamentoTop.TabIndex = 2;
            // 
            // ptbTrocar
            // 
            ptbTrocar.Cursor = Cursors.Hand;
            ptbTrocar.Image = Properties.Resources.Trocar;
            ptbTrocar.Location = new Point(370, 7);
            ptbTrocar.Margin = new Padding(0);
            ptbTrocar.Name = "ptbTrocar";
            ptbTrocar.Size = new Size(40, 40);
            ptbTrocar.TabIndex = 6;
            ptbTrocar.TabStop = false;
            ptbTrocar.Click += ptbTrocar_Click;
            // 
            // lblTituloEquipamento
            // 
            lblTituloEquipamento.AutoSize = true;
            lblTituloEquipamento.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloEquipamento.Location = new Point(423, 18);
            lblTituloEquipamento.Name = "lblTituloEquipamento";
            lblTituloEquipamento.Size = new Size(114, 19);
            lblTituloEquipamento.TabIndex = 9;
            lblTituloEquipamento.Text = "Equipamento";
            // 
            // ptbMoverEquipamento
            // 
            ptbMoverEquipamento.Cursor = Cursors.Hand;
            ptbMoverEquipamento.Image = Properties.Resources.Mover;
            ptbMoverEquipamento.Location = new Point(301, 8);
            ptbMoverEquipamento.Margin = new Padding(0);
            ptbMoverEquipamento.Name = "ptbMoverEquipamento";
            ptbMoverEquipamento.Size = new Size(40, 40);
            ptbMoverEquipamento.TabIndex = 5;
            ptbMoverEquipamento.TabStop = false;
            ptbMoverEquipamento.Click += ptbMoverEquipamento_Click;
            // 
            // ptbApagarEquipamento
            // 
            ptbApagarEquipamento.Cursor = Cursors.Hand;
            ptbApagarEquipamento.Image = Properties.Resources.Borracha;
            ptbApagarEquipamento.Location = new Point(232, 8);
            ptbApagarEquipamento.Margin = new Padding(0);
            ptbApagarEquipamento.Name = "ptbApagarEquipamento";
            ptbApagarEquipamento.Size = new Size(40, 40);
            ptbApagarEquipamento.TabIndex = 4;
            ptbApagarEquipamento.TabStop = false;
            ptbApagarEquipamento.Click += ptbApagarEquipamento_Click;
            // 
            // ptbRemoverEquipamento
            // 
            ptbRemoverEquipamento.Cursor = Cursors.Hand;
            ptbRemoverEquipamento.Image = Properties.Resources.RemoverEquipamento;
            ptbRemoverEquipamento.Location = new Point(163, 8);
            ptbRemoverEquipamento.Margin = new Padding(0);
            ptbRemoverEquipamento.Name = "ptbRemoverEquipamento";
            ptbRemoverEquipamento.Size = new Size(40, 40);
            ptbRemoverEquipamento.TabIndex = 3;
            ptbRemoverEquipamento.TabStop = false;
            ptbRemoverEquipamento.Click += ptbRemoverEquipamento_Click;
            // 
            // ptbEditarEquipamento
            // 
            ptbEditarEquipamento.Cursor = Cursors.Hand;
            ptbEditarEquipamento.Image = Properties.Resources.EditarEquipamento;
            ptbEditarEquipamento.Location = new Point(94, 8);
            ptbEditarEquipamento.Margin = new Padding(0);
            ptbEditarEquipamento.Name = "ptbEditarEquipamento";
            ptbEditarEquipamento.Size = new Size(40, 40);
            ptbEditarEquipamento.TabIndex = 2;
            ptbEditarEquipamento.TabStop = false;
            ptbEditarEquipamento.Click += ptbEditarEquipamento_Click;
            // 
            // ptbAdicionarEquipamento
            // 
            ptbAdicionarEquipamento.Cursor = Cursors.Hand;
            ptbAdicionarEquipamento.Image = Properties.Resources.AdicionarEquipamento;
            ptbAdicionarEquipamento.Location = new Point(25, 8);
            ptbAdicionarEquipamento.Margin = new Padding(0);
            ptbAdicionarEquipamento.Name = "ptbAdicionarEquipamento";
            ptbAdicionarEquipamento.Size = new Size(40, 40);
            ptbAdicionarEquipamento.TabIndex = 1;
            ptbAdicionarEquipamento.TabStop = false;
            ptbAdicionarEquipamento.MouseClick += ptbAdicionarEquipamento_MouseClick;
            // 
            // pnlCLienteTop
            // 
            pnlCLienteTop.Controls.Add(lblTituloCLiente);
            pnlCLienteTop.Controls.Add(ptbGerarTermo);
            pnlCLienteTop.Controls.Add(MoverCliente);
            pnlCLienteTop.Controls.Add(ptbApagarCampoCliente);
            pnlCLienteTop.Controls.Add(ptbRemoverCliente);
            pnlCLienteTop.Controls.Add(ptbEditarCliente);
            pnlCLienteTop.Controls.Add(ptbAdicionarCLinete);
            pnlCLienteTop.Dock = DockStyle.Fill;
            pnlCLienteTop.Location = new Point(0, 0);
            pnlCLienteTop.Margin = new Padding(0);
            pnlCLienteTop.Name = "pnlCLienteTop";
            pnlCLienteTop.Size = new Size(1007, 50);
            pnlCLienteTop.TabIndex = 0;
            // 
            // lblTituloCLiente
            // 
            lblTituloCLiente.AutoSize = true;
            lblTituloCLiente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloCLiente.Location = new Point(448, 18);
            lblTituloCLiente.Name = "lblTituloCLiente";
            lblTituloCLiente.Size = new Size(63, 19);
            lblTituloCLiente.TabIndex = 9;
            lblTituloCLiente.Text = "Cliente";
            // 
            // ptbGerarTermo
            // 
            ptbGerarTermo.Cursor = Cursors.Hand;
            ptbGerarTermo.Image = Properties.Resources.termo;
            ptbGerarTermo.Location = new Point(370, 9);
            ptbGerarTermo.Margin = new Padding(0);
            ptbGerarTermo.Name = "ptbGerarTermo";
            ptbGerarTermo.Size = new Size(40, 40);
            ptbGerarTermo.TabIndex = 6;
            ptbGerarTermo.TabStop = false;
            ptbGerarTermo.Click += ptbGerarTermo_Click;
            // 
            // MoverCliente
            // 
            MoverCliente.Cursor = Cursors.Hand;
            MoverCliente.Image = Properties.Resources.Mover;
            MoverCliente.Location = new Point(301, 9);
            MoverCliente.Margin = new Padding(0);
            MoverCliente.Name = "MoverCliente";
            MoverCliente.Size = new Size(40, 40);
            MoverCliente.TabIndex = 5;
            MoverCliente.TabStop = false;
            MoverCliente.Click += MoverCliente_Click;
            // 
            // ptbApagarCampoCliente
            // 
            ptbApagarCampoCliente.Cursor = Cursors.Hand;
            ptbApagarCampoCliente.Image = Properties.Resources.Borracha;
            ptbApagarCampoCliente.Location = new Point(232, 9);
            ptbApagarCampoCliente.Margin = new Padding(0);
            ptbApagarCampoCliente.Name = "ptbApagarCampoCliente";
            ptbApagarCampoCliente.Size = new Size(40, 40);
            ptbApagarCampoCliente.TabIndex = 4;
            ptbApagarCampoCliente.TabStop = false;
            ptbApagarCampoCliente.Click += ptbApagarCampoCliente_Click;
            // 
            // ptbRemoverCliente
            // 
            ptbRemoverCliente.Cursor = Cursors.Hand;
            ptbRemoverCliente.Image = Properties.Resources.RemoverCliente;
            ptbRemoverCliente.Location = new Point(163, 9);
            ptbRemoverCliente.Margin = new Padding(0);
            ptbRemoverCliente.Name = "ptbRemoverCliente";
            ptbRemoverCliente.Size = new Size(40, 40);
            ptbRemoverCliente.TabIndex = 3;
            ptbRemoverCliente.TabStop = false;
            ptbRemoverCliente.Click += ptbRemoverCliente_Click;
            // 
            // ptbEditarCliente
            // 
            ptbEditarCliente.Cursor = Cursors.Hand;
            ptbEditarCliente.Image = Properties.Resources.EditarUsuário;
            ptbEditarCliente.Location = new Point(94, 9);
            ptbEditarCliente.Margin = new Padding(0);
            ptbEditarCliente.Name = "ptbEditarCliente";
            ptbEditarCliente.Size = new Size(40, 40);
            ptbEditarCliente.TabIndex = 2;
            ptbEditarCliente.TabStop = false;
            ptbEditarCliente.Click += ptbEditarCliente_Click;
            // 
            // ptbAdicionarCLinete
            // 
            ptbAdicionarCLinete.Cursor = Cursors.Hand;
            ptbAdicionarCLinete.Image = Properties.Resources.AdicionarCliente;
            ptbAdicionarCLinete.Location = new Point(25, 9);
            ptbAdicionarCLinete.Margin = new Padding(0);
            ptbAdicionarCLinete.Name = "ptbAdicionarCLinete";
            ptbAdicionarCLinete.Size = new Size(40, 40);
            ptbAdicionarCLinete.TabIndex = 1;
            ptbAdicionarCLinete.TabStop = false;
            ptbAdicionarCLinete.Click += ptbAdicionarCLinete_Click;
            // 
            // pnlCliente
            // 
            pnlCliente.BackColor = Color.White;
            pnlCliente.Controls.Add(ptbLupaNome);
            pnlCliente.Controls.Add(ptbLupaUserID);
            pnlCliente.Controls.Add(lblUnidade);
            pnlCliente.Controls.Add(txbUnidade);
            pnlCliente.Controls.Add(txbCargo);
            pnlCliente.Controls.Add(txbMatricula);
            pnlCliente.Controls.Add(txbNome);
            pnlCliente.Controls.Add(dgvCliente);
            pnlCliente.Controls.Add(lblMatricula);
            pnlCliente.Controls.Add(lblCargo);
            pnlCliente.Controls.Add(lblArea);
            pnlCliente.Controls.Add(lblNome);
            pnlCliente.Controls.Add(lblUserID);
            pnlCliente.Controls.Add(txbArea);
            pnlCliente.Controls.Add(txbUserID);
            pnlCliente.Dock = DockStyle.Fill;
            pnlCliente.Location = new Point(0, 50);
            pnlCliente.Margin = new Padding(0);
            pnlCliente.Name = "pnlCliente";
            pnlCliente.Size = new Size(1007, 118);
            pnlCliente.TabIndex = 1;
            // 
            // ptbLupaNome
            // 
            ptbLupaNome.Image = Properties.Resources.Lupa;
            ptbLupaNome.Location = new Point(459, 25);
            ptbLupaNome.Name = "ptbLupaNome";
            ptbLupaNome.Size = new Size(20, 20);
            ptbLupaNome.TabIndex = 19;
            ptbLupaNome.TabStop = false;
            // 
            // ptbLupaUserID
            // 
            ptbLupaUserID.Image = Properties.Resources.Lupa;
            ptbLupaUserID.Location = new Point(91, 25);
            ptbLupaUserID.Name = "ptbLupaUserID";
            ptbLupaUserID.Size = new Size(20, 20);
            ptbLupaUserID.TabIndex = 10;
            ptbLupaUserID.TabStop = false;
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Location = new Point(486, 4);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(58, 17);
            lblUnidade.TabIndex = 18;
            lblUnidade.Text = "Unidade";
            // 
            // txbUnidade
            // 
            txbUnidade.BackColor = Color.White;
            txbUnidade.BorderStyle = BorderStyle.FixedSingle;
            txbUnidade.Enabled = false;
            txbUnidade.Location = new Point(486, 24);
            txbUnidade.Name = "txbUnidade";
            txbUnidade.Size = new Size(59, 22);
            txbUnidade.TabIndex = 3;
            // 
            // txbCargo
            // 
            txbCargo.BackColor = Color.White;
            txbCargo.BorderStyle = BorderStyle.FixedSingle;
            txbCargo.Location = new Point(717, 24);
            txbCargo.Name = "txbCargo";
            txbCargo.Size = new Size(195, 22);
            txbCargo.TabIndex = 5;
            // 
            // txbMatricula
            // 
            txbMatricula.BackColor = Color.White;
            txbMatricula.BorderStyle = BorderStyle.FixedSingle;
            txbMatricula.Location = new Point(918, 24);
            txbMatricula.Name = "txbMatricula";
            txbMatricula.Size = new Size(80, 22);
            txbMatricula.TabIndex = 6;
            // 
            // txbNome
            // 
            txbNome.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txbNome.BackColor = Color.White;
            txbNome.BorderStyle = BorderStyle.FixedSingle;
            txbNome.Location = new Point(118, 24);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(362, 22);
            txbNome.TabIndex = 2;
            txbNome.KeyDown += txbNome_KeyDown;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { patrimonioDataGridViewTextBoxColumn, nomenclaturaDataGridViewTextBoxColumn, Serie, marcaDataGridViewTextBoxColumn, modeloDataGridViewTextBoxColumn, processadorDataGridViewTextBoxColumn, memoriaDataGridViewTextBoxColumn });
            dgvCliente.DataSource = equipamentoBindingSource;
            dgvCliente.Location = new Point(14, 52);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersWidth = 62;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCliente.Size = new Size(984, 50);
            dgvCliente.TabIndex = 13;
            dgvCliente.Visible = false;
            // 
            // patrimonioDataGridViewTextBoxColumn
            // 
            patrimonioDataGridViewTextBoxColumn.DataPropertyName = "Patrimonio";
            patrimonioDataGridViewTextBoxColumn.HeaderText = "     PATRIMÔNIO";
            patrimonioDataGridViewTextBoxColumn.MinimumWidth = 8;
            patrimonioDataGridViewTextBoxColumn.Name = "patrimonioDataGridViewTextBoxColumn";
            patrimonioDataGridViewTextBoxColumn.ReadOnly = true;
            patrimonioDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomenclaturaDataGridViewTextBoxColumn
            // 
            nomenclaturaDataGridViewTextBoxColumn.DataPropertyName = "Nomenclatura";
            nomenclaturaDataGridViewTextBoxColumn.HeaderText = "NOMENCLATURA";
            nomenclaturaDataGridViewTextBoxColumn.MinimumWidth = 8;
            nomenclaturaDataGridViewTextBoxColumn.Name = "nomenclaturaDataGridViewTextBoxColumn";
            nomenclaturaDataGridViewTextBoxColumn.ReadOnly = true;
            nomenclaturaDataGridViewTextBoxColumn.Width = 150;
            // 
            // Serie
            // 
            Serie.DataPropertyName = "Serie";
            Serie.HeaderText = "    SÉRIE";
            Serie.Name = "Serie";
            Serie.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            marcaDataGridViewTextBoxColumn.HeaderText = "    MARCA";
            marcaDataGridViewTextBoxColumn.MinimumWidth = 8;
            marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            marcaDataGridViewTextBoxColumn.ReadOnly = true;
            marcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            modeloDataGridViewTextBoxColumn.HeaderText = "    MODELO";
            modeloDataGridViewTextBoxColumn.MinimumWidth = 8;
            modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            modeloDataGridViewTextBoxColumn.ReadOnly = true;
            modeloDataGridViewTextBoxColumn.Width = 150;
            // 
            // processadorDataGridViewTextBoxColumn
            // 
            processadorDataGridViewTextBoxColumn.DataPropertyName = "Processador";
            processadorDataGridViewTextBoxColumn.HeaderText = "  PROCESSADOR";
            processadorDataGridViewTextBoxColumn.MinimumWidth = 8;
            processadorDataGridViewTextBoxColumn.Name = "processadorDataGridViewTextBoxColumn";
            processadorDataGridViewTextBoxColumn.ReadOnly = true;
            processadorDataGridViewTextBoxColumn.Width = 150;
            // 
            // memoriaDataGridViewTextBoxColumn
            // 
            memoriaDataGridViewTextBoxColumn.DataPropertyName = "Memoria";
            memoriaDataGridViewTextBoxColumn.HeaderText = " MEMÓRIA";
            memoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            memoriaDataGridViewTextBoxColumn.Name = "memoriaDataGridViewTextBoxColumn";
            memoriaDataGridViewTextBoxColumn.ReadOnly = true;
            memoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // equipamentoBindingSource
            // 
            equipamentoBindingSource.DataSource = typeof(Entites.Equipamento);
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(918, 4);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(65, 17);
            lblMatricula.TabIndex = 12;
            lblMatricula.Text = "Matrícula";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(717, 4);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(45, 17);
            lblCargo.TabIndex = 11;
            lblCargo.Text = "Cargo";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(551, 4);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(37, 17);
            lblArea.TabIndex = 10;
            lblArea.Text = "Área";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(118, 4);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 17);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(14, 4);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(45, 17);
            lblUserID.TabIndex = 8;
            lblUserID.Text = "UserID";
            // 
            // txbArea
            // 
            txbArea.BackColor = Color.White;
            txbArea.BorderStyle = BorderStyle.FixedSingle;
            txbArea.Location = new Point(551, 24);
            txbArea.Name = "txbArea";
            txbArea.Size = new Size(160, 22);
            txbArea.TabIndex = 4;
            // 
            // txbUserID
            // 
            txbUserID.AutoCompleteMode = AutoCompleteMode.Append;
            txbUserID.BackColor = Color.White;
            txbUserID.BorderStyle = BorderStyle.FixedSingle;
            txbUserID.Location = new Point(14, 24);
            txbUserID.Name = "txbUserID";
            txbUserID.Size = new Size(98, 22);
            txbUserID.TabIndex = 1;
            txbUserID.KeyDown += txbUserID_KeyDown;
            // 
            // pnlEquipamento
            // 
            pnlEquipamento.Controls.Add(pictureBox1);
            pnlEquipamento.Controls.Add(ptbLupaPatrimonio);
            pnlEquipamento.Controls.Add(cbxModelo);
            pnlEquipamento.Controls.Add(cbxMarca);
            pnlEquipamento.Controls.Add(cbxMemoria);
            pnlEquipamento.Controls.Add(cbxProcessador);
            pnlEquipamento.Controls.Add(cbxTipo);
            pnlEquipamento.Controls.Add(lblModelo);
            pnlEquipamento.Controls.Add(lblMarca);
            pnlEquipamento.Controls.Add(txbSerie);
            pnlEquipamento.Controls.Add(lblSerie);
            pnlEquipamento.Controls.Add(txbPatrimonio);
            pnlEquipamento.Controls.Add(lblRam);
            pnlEquipamento.Controls.Add(lblProcessador);
            pnlEquipamento.Controls.Add(lblPatrimonio);
            pnlEquipamento.Controls.Add(lblMicrocomputador);
            pnlEquipamento.Controls.Add(dgvEquipamento);
            pnlEquipamento.Dock = DockStyle.Fill;
            pnlEquipamento.Location = new Point(0, 218);
            pnlEquipamento.Margin = new Padding(0);
            pnlEquipamento.Name = "pnlEquipamento";
            pnlEquipamento.Size = new Size(1007, 118);
            pnlEquipamento.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lupa;
            pictureBox1.Location = new Point(311, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // ptbLupaPatrimonio
            // 
            ptbLupaPatrimonio.Image = Properties.Resources.Lupa;
            ptbLupaPatrimonio.Location = new Point(91, 24);
            ptbLupaPatrimonio.Name = "ptbLupaPatrimonio";
            ptbLupaPatrimonio.Size = new Size(20, 20);
            ptbLupaPatrimonio.TabIndex = 20;
            ptbLupaPatrimonio.TabStop = false;
            // 
            // cbxModelo
            // 
            cbxModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxModelo.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxModelo.FormattingEnabled = true;
            cbxModelo.Location = new Point(599, 22);
            cbxModelo.Name = "cbxModelo";
            cbxModelo.Size = new Size(207, 23);
            cbxModelo.TabIndex = 11;
            cbxModelo.SelectionChangeCommitted += cbxModelo_SelectionChangeCommitted;
            // 
            // cbxMarca
            // 
            cbxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMarca.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Location = new Point(464, 22);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(129, 23);
            cbxMarca.TabIndex = 10;
            cbxMarca.SelectionChangeCommitted += cbxMarca_SelectionChangeCommitted;
            // 
            // cbxMemoria
            // 
            cbxMemoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMemoria.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxMemoria.FormattingEnabled = true;
            cbxMemoria.Location = new Point(938, 23);
            cbxMemoria.Name = "cbxMemoria";
            cbxMemoria.Size = new Size(60, 23);
            cbxMemoria.TabIndex = 13;
            // 
            // cbxProcessador
            // 
            cbxProcessador.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProcessador.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxProcessador.FormattingEnabled = true;
            cbxProcessador.ItemHeight = 15;
            cbxProcessador.Location = new Point(812, 23);
            cbxProcessador.Name = "cbxProcessador";
            cbxProcessador.Size = new Size(120, 23);
            cbxProcessador.TabIndex = 12;
            // 
            // cbxTipo
            // 
            cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipo.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Location = new Point(338, 22);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(120, 23);
            cbxTipo.TabIndex = 9;
            cbxTipo.SelectionChangeCommitted += cbxTipo_SelectionChangeCommitted;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(599, 6);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(54, 17);
            lblModelo.TabIndex = 32;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(464, 5);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(47, 17);
            lblMarca.TabIndex = 30;
            lblMarca.Text = "Marca";
            // 
            // txbSerie
            // 
            txbSerie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txbSerie.BackColor = Color.White;
            txbSerie.BorderStyle = BorderStyle.FixedSingle;
            txbSerie.Location = new Point(118, 23);
            txbSerie.Name = "txbSerie";
            txbSerie.Size = new Size(214, 22);
            txbSerie.TabIndex = 8;
            txbSerie.KeyDown += txbSerie_KeyDown;
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(118, 4);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(38, 17);
            lblSerie.TabIndex = 28;
            lblSerie.Text = "Série";
            // 
            // txbPatrimonio
            // 
            txbPatrimonio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txbPatrimonio.BackColor = Color.White;
            txbPatrimonio.BorderStyle = BorderStyle.FixedSingle;
            txbPatrimonio.Location = new Point(12, 23);
            txbPatrimonio.Name = "txbPatrimonio";
            txbPatrimonio.Size = new Size(100, 22);
            txbPatrimonio.TabIndex = 7;
            txbPatrimonio.KeyDown += txbPatrimonio_KeyDown;
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Location = new Point(938, 6);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(34, 17);
            lblRam.TabIndex = 22;
            lblRam.Text = "Ram";
            // 
            // lblProcessador
            // 
            lblProcessador.AutoSize = true;
            lblProcessador.Location = new Point(812, 5);
            lblProcessador.Name = "lblProcessador";
            lblProcessador.Size = new Size(81, 17);
            lblProcessador.TabIndex = 21;
            lblProcessador.Text = "Processador";
            // 
            // lblPatrimonio
            // 
            lblPatrimonio.AutoSize = true;
            lblPatrimonio.Location = new Point(11, 5);
            lblPatrimonio.Name = "lblPatrimonio";
            lblPatrimonio.Size = new Size(72, 17);
            lblPatrimonio.TabIndex = 20;
            lblPatrimonio.Text = "Patrimonio";
            // 
            // lblMicrocomputador
            // 
            lblMicrocomputador.AutoSize = true;
            lblMicrocomputador.Location = new Point(338, 5);
            lblMicrocomputador.Name = "lblMicrocomputador";
            lblMicrocomputador.Size = new Size(32, 17);
            lblMicrocomputador.TabIndex = 19;
            lblMicrocomputador.Text = "Tipo";
            // 
            // dgvEquipamento
            // 
            dgvEquipamento.AllowUserToAddRows = false;
            dgvEquipamento.AllowUserToDeleteRows = false;
            dgvEquipamento.AutoGenerateColumns = false;
            dgvEquipamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamento.Columns.AddRange(new DataGridViewColumn[] { userIDDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, areaDataGridViewTextBoxColumn, cargoDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvEquipamento.DataSource = clienteBindingSource;
            dgvEquipamento.Location = new Point(12, 53);
            dgvEquipamento.Name = "dgvEquipamento";
            dgvEquipamento.ReadOnly = true;
            dgvEquipamento.RowHeadersWidth = 62;
            dgvEquipamento.RowTemplate.Height = 25;
            dgvEquipamento.Size = new Size(986, 50);
            dgvEquipamento.TabIndex = 24;
            dgvEquipamento.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            userIDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            userIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            userIDDataGridViewTextBoxColumn.ReadOnly = true;
            userIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.FillWeight = 50F;
            nomeDataGridViewTextBoxColumn.HeaderText = "NOME";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            areaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            areaDataGridViewTextBoxColumn.FillWeight = 25F;
            areaDataGridViewTextBoxColumn.HeaderText = "AREA";
            areaDataGridViewTextBoxColumn.MinimumWidth = 8;
            areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            cargoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            cargoDataGridViewTextBoxColumn.FillWeight = 25F;
            cargoDataGridViewTextBoxColumn.HeaderText = "CARGO";
            cargoDataGridViewTextBoxColumn.MinimumWidth = 8;
            cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.DataPropertyName = "UF";
            dataGridViewTextBoxColumn1.HeaderText = "UF";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.DataPropertyName = "Unidade";
            dataGridViewTextBoxColumn2.HeaderText = "UNIDADE";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Entites.Cliente);
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.Location = new Point(66, 13);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(63, 19);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblEquipamento
            // 
            lblEquipamento.AutoSize = true;
            lblEquipamento.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipamento.Location = new Point(40, 15);
            lblEquipamento.Name = "lblEquipamento";
            lblEquipamento.Size = new Size(114, 19);
            lblEquipamento.TabIndex = 1;
            lblEquipamento.Text = "Equipamento";
            // 
            // uctHome
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tlphome);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "uctHome";
            Size = new Size(1007, 367);
            Load += uctHome_Load;
            tlphome.ResumeLayout(false);
            pnlEquipamentoTop.ResumeLayout(false);
            pnlEquipamentoTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbTrocar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMoverEquipamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbApagarEquipamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbRemoverEquipamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbEditarEquipamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAdicionarEquipamento).EndInit();
            pnlCLienteTop.ResumeLayout(false);
            pnlCLienteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbGerarTermo).EndInit();
            ((System.ComponentModel.ISupportInitialize)MoverCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbApagarCampoCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbRemoverCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbEditarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAdicionarCLinete).EndInit();
            pnlCliente.ResumeLayout(false);
            pnlCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLupaNome).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbLupaUserID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)equipamentoBindingSource).EndInit();
            pnlEquipamento.ResumeLayout(false);
            pnlEquipamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbLupaPatrimonio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlphome;
        private Panel pnlCLienteTop;
        private Label lblCliente;
        private Panel pnlCliente;
        private Panel pnlEquipamentoTop;
        private Label lblEquipamento;
        private Label lblMatricula;
        private Label lblCargo;
        private Label lblArea;
        private Label lblNome;
        private Label lblUserID;
        private DataGridView dgvCliente;
        private Label lblTituloEquipamento;
        private Label lblUnidade;
        public TextBox txbUserID;
        public TextBox txbArea;
        public TextBox txbCargo;
        public TextBox txbMatricula;
        public TextBox txbNome;
        public TextBox txbUnidade;
        private BindingSource equipamentoBindingSource;
        private Panel pnlEquipamento;
        public ComboBox cbxModelo;
        public ComboBox cbxMarca;
        public ComboBox cbxMemoria;
        public ComboBox cbxProcessador;
        public ComboBox cbxTipo;
        private Label lblModelo;
        private Label lblMarca;
        public TextBox txbSerie;
        private Label lblSerie;
        public TextBox txbPatrimonio;
        private Label lblRam;
        private Label lblProcessador;
        private Label lblPatrimonio;
        private Label lblMicrocomputador;
        private DataGridView dgvEquipamento;
        private BindingSource clienteBindingSource;
        private PictureBox ptbLupaNome;
        private PictureBox ptbLupaUserID;
        private PictureBox pictureBox1;
        private PictureBox ptbLupaPatrimonio;
        public Label lblTituloCLiente;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public PictureBox ptbApagarEquipamento;
        private DataGridViewTextBoxColumn patrimonioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomenclaturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Serie;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn processadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memoriaDataGridViewTextBoxColumn;
        public PictureBox ptbRemoverCliente;
        public PictureBox ptbAdicionarCLinete;
        public PictureBox MoverCliente;
        public PictureBox ptbMoverEquipamento;
        public PictureBox ptbRemoverEquipamento;
        public PictureBox ptbAdicionarEquipamento;
        public PictureBox ptbEditarCliente;
        public PictureBox ptbGerarTermo;
        public PictureBox ptbApagarCampoCliente;
        public PictureBox ptbTrocar;
        public PictureBox ptbEditarEquipamento;
    }
}
