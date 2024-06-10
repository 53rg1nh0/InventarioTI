namespace InventarioTI
{
    partial class FormInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            pnlLateral = new Panel();
            ptbInventario = new PictureBox();
            cbxResolucao = new ComboBox();
            ptbSobre = new PictureBox();
            ptbAjustes = new PictureBox();
            ptbHome = new PictureBox();
            ptbPrograma = new PictureBox();
            pnlButton = new Panel();
            tlbBotton = new TableLayoutPanel();
            pnlDeskAtivo = new Panel();
            lblBotton3 = new Label();
            lblDeskAtv = new Label();
            pictureBox1 = new PictureBox();
            pnlBotton3 = new Panel();
            label1 = new Label();
            lblNotAtv = new Label();
            ptbBotton3 = new PictureBox();
            pnlBotton0 = new Panel();
            lblNotEst = new Label();
            lblBotton0 = new Label();
            ptbBotton0 = new PictureBox();
            pnlBotton1 = new Panel();
            lblBotton1 = new Label();
            ptbBotton1 = new PictureBox();
            lblDeskEst = new Label();
            pnlBotton2 = new Panel();
            lblBotton4 = new Label();
            lblTotal = new Label();
            pnlUnidade = new Panel();
            lblUnidade = new Label();
            ptbFechar = new PictureBox();
            ptbMinimizar = new PictureBox();
            ttpForm = new ToolTip(components);
            uctSobre = new View.uctSobre();
            uctAjustes = new View.uctAjustes();
            uctHome = new View.uctHome();
            uctInventario = new View.uctInventario();
            pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSobre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAjustes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPrograma).BeginInit();
            pnlButton.SuspendLayout();
            tlbBotton.SuspendLayout();
            pnlDeskAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBotton3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbBotton3).BeginInit();
            pnlBotton0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbBotton0).BeginInit();
            pnlBotton1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbBotton1).BeginInit();
            pnlBotton2.SuspendLayout();
            pnlUnidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimizar).BeginInit();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(196, 0, 6);
            pnlLateral.Controls.Add(ptbInventario);
            pnlLateral.Controls.Add(cbxResolucao);
            pnlLateral.Controls.Add(ptbSobre);
            pnlLateral.Controls.Add(ptbAjustes);
            pnlLateral.Controls.Add(ptbHome);
            pnlLateral.Controls.Add(ptbPrograma);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Margin = new Padding(3, 2, 3, 2);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(65, 438);
            pnlLateral.TabIndex = 0;
            // 
            // ptbInventario
            // 
            ptbInventario.BackColor = Color.FromArgb(196, 0, 6);
            ptbInventario.BackgroundImageLayout = ImageLayout.Center;
            ptbInventario.Cursor = Cursors.Hand;
            ptbInventario.Image = Properties.Resources.Inventario;
            ptbInventario.Location = new Point(0, 165);
            ptbInventario.Margin = new Padding(3, 2, 3, 2);
            ptbInventario.Name = "ptbInventario";
            ptbInventario.Padding = new Padding(7, 2, 5, 2);
            ptbInventario.Size = new Size(65, 52);
            ptbInventario.TabIndex = 8;
            ptbInventario.TabStop = false;
            ptbInventario.Click += ptbInventario_Click;
            // 
            // cbxResolucao
            // 
            cbxResolucao.AutoCompleteCustomSource.AddRange(new string[] { "100%", "150%" });
            cbxResolucao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxResolucao.FormattingEnabled = true;
            cbxResolucao.Items.AddRange(new object[] { "100%", "150%" });
            cbxResolucao.Location = new Point(0, 17);
            cbxResolucao.Name = "cbxResolucao";
            cbxResolucao.Size = new Size(65, 24);
            cbxResolucao.TabIndex = 7;
            cbxResolucao.Visible = false;
            cbxResolucao.SelectionChangeCommitted += cbxResolucao_SelectionChangeCommitted;
            // 
            // ptbSobre
            // 
            ptbSobre.BackColor = Color.FromArgb(196, 0, 6);
            ptbSobre.BackgroundImageLayout = ImageLayout.Center;
            ptbSobre.Cursor = Cursors.Hand;
            ptbSobre.Image = Properties.Resources.Sobre;
            ptbSobre.Location = new Point(0, 337);
            ptbSobre.Margin = new Padding(3, 2, 3, 2);
            ptbSobre.Name = "ptbSobre";
            ptbSobre.Padding = new Padding(7, 2, 5, 2);
            ptbSobre.Size = new Size(65, 52);
            ptbSobre.TabIndex = 6;
            ptbSobre.TabStop = false;
            ptbSobre.Click += ptbSobre_Click;
            // 
            // ptbAjustes
            // 
            ptbAjustes.BackColor = Color.FromArgb(196, 0, 6);
            ptbAjustes.BackgroundImageLayout = ImageLayout.Center;
            ptbAjustes.Cursor = Cursors.Hand;
            ptbAjustes.Image = Properties.Resources.Ajustes;
            ptbAjustes.Location = new Point(0, 251);
            ptbAjustes.Margin = new Padding(3, 2, 3, 2);
            ptbAjustes.Name = "ptbAjustes";
            ptbAjustes.Padding = new Padding(7, 2, 5, 2);
            ptbAjustes.Size = new Size(65, 52);
            ptbAjustes.TabIndex = 5;
            ptbAjustes.TabStop = false;
            ptbAjustes.Click += ptbAjustes_Click;
            // 
            // ptbHome
            // 
            ptbHome.BackColor = Color.FromArgb(196, 0, 6);
            ptbHome.BackgroundImageLayout = ImageLayout.Center;
            ptbHome.Cursor = Cursors.Hand;
            ptbHome.Image = Properties.Resources.Home;
            ptbHome.Location = new Point(0, 79);
            ptbHome.Margin = new Padding(3, 2, 3, 2);
            ptbHome.Name = "ptbHome";
            ptbHome.Padding = new Padding(7, 2, 5, 2);
            ptbHome.Size = new Size(65, 52);
            ptbHome.TabIndex = 4;
            ptbHome.TabStop = false;
            ptbHome.Click += ptbHome_Click;
            // 
            // ptbPrograma
            // 
            ptbPrograma.BackColor = Color.FromArgb(196, 0, 6);
            ptbPrograma.BackgroundImage = Properties.Resources.Programa;
            ptbPrograma.BackgroundImageLayout = ImageLayout.Stretch;
            ptbPrograma.Location = new Point(0, 0);
            ptbPrograma.Margin = new Padding(0);
            ptbPrograma.Name = "ptbPrograma";
            ptbPrograma.Size = new Size(65, 61);
            ptbPrograma.TabIndex = 2;
            ptbPrograma.TabStop = false;
            ptbPrograma.Click += ptbPrograma_Click;
            // 
            // pnlButton
            // 
            pnlButton.BackColor = Color.Black;
            pnlButton.Controls.Add(tlbBotton);
            pnlButton.ForeColor = Color.White;
            pnlButton.Location = new Point(0, 410);
            pnlButton.Margin = new Padding(3, 2, 3, 2);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(1075, 28);
            pnlButton.TabIndex = 1;
            // 
            // tlbBotton
            // 
            tlbBotton.ColumnCount = 6;
            tlbBotton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlbBotton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbBotton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbBotton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbBotton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbBotton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbBotton.Controls.Add(pnlDeskAtivo, 3, 0);
            tlbBotton.Controls.Add(pnlBotton3, 4, 0);
            tlbBotton.Controls.Add(pnlBotton0, 2, 0);
            tlbBotton.Controls.Add(pnlBotton1, 1, 0);
            tlbBotton.Controls.Add(pnlBotton2, 5, 0);
            tlbBotton.Controls.Add(pnlUnidade, 0, 0);
            tlbBotton.Dock = DockStyle.Fill;
            tlbBotton.Location = new Point(0, 0);
            tlbBotton.Margin = new Padding(0);
            tlbBotton.Name = "tlbBotton";
            tlbBotton.RowCount = 1;
            tlbBotton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlbBotton.Size = new Size(1075, 28);
            tlbBotton.TabIndex = 7;
            // 
            // pnlDeskAtivo
            // 
            pnlDeskAtivo.Controls.Add(lblBotton3);
            pnlDeskAtivo.Controls.Add(lblDeskAtv);
            pnlDeskAtivo.Controls.Add(pictureBox1);
            pnlDeskAtivo.Dock = DockStyle.Fill;
            pnlDeskAtivo.Location = new Point(550, 0);
            pnlDeskAtivo.Margin = new Padding(0);
            pnlDeskAtivo.Name = "pnlDeskAtivo";
            pnlDeskAtivo.Size = new Size(175, 28);
            pnlDeskAtivo.TabIndex = 11;
            // 
            // lblBotton3
            // 
            lblBotton3.AutoSize = true;
            lblBotton3.Dock = DockStyle.Left;
            lblBotton3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBotton3.Location = new Point(28, 0);
            lblBotton3.Name = "lblBotton3";
            lblBotton3.Padding = new Padding(0, 6, 0, 0);
            lblBotton3.Size = new Size(45, 22);
            lblBotton3.TabIndex = 7;
            lblBotton3.Text = "Ativos:";
            // 
            // lblDeskAtv
            // 
            lblDeskAtv.AutoSize = true;
            lblDeskAtv.BackColor = Color.White;
            lblDeskAtv.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeskAtv.ForeColor = Color.Black;
            lblDeskAtv.Location = new Point(79, 6);
            lblDeskAtv.Margin = new Padding(3, 0, 0, 0);
            lblDeskAtv.Name = "lblDeskAtv";
            lblDeskAtv.RightToLeft = RightToLeft.No;
            lblDeskAtv.Size = new Size(37, 16);
            lblDeskAtv.TabIndex = 3;
            lblDeskAtv.Text = "label";
            lblDeskAtv.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Desktop;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(30, 0, 0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pnlBotton3
            // 
            pnlBotton3.Controls.Add(label1);
            pnlBotton3.Controls.Add(lblNotAtv);
            pnlBotton3.Controls.Add(ptbBotton3);
            pnlBotton3.Dock = DockStyle.Fill;
            pnlBotton3.Location = new Point(725, 0);
            pnlBotton3.Margin = new Padding(0);
            pnlBotton3.Name = "pnlBotton3";
            pnlBotton3.Size = new Size(175, 28);
            pnlBotton3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 6, 0, 0);
            label1.Size = new Size(45, 22);
            label1.TabIndex = 7;
            label1.Text = "Ativos:";
            // 
            // lblNotAtv
            // 
            lblNotAtv.AutoSize = true;
            lblNotAtv.BackColor = Color.White;
            lblNotAtv.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotAtv.ForeColor = Color.Black;
            lblNotAtv.Location = new Point(79, 6);
            lblNotAtv.Margin = new Padding(3, 0, 0, 0);
            lblNotAtv.Name = "lblNotAtv";
            lblNotAtv.RightToLeft = RightToLeft.No;
            lblNotAtv.Size = new Size(37, 16);
            lblNotAtv.TabIndex = 3;
            lblNotAtv.Text = "label";
            lblNotAtv.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ptbBotton3
            // 
            ptbBotton3.Dock = DockStyle.Left;
            ptbBotton3.Image = Properties.Resources.Notebook;
            ptbBotton3.Location = new Point(0, 0);
            ptbBotton3.Margin = new Padding(30, 0, 0, 0);
            ptbBotton3.Name = "ptbBotton3";
            ptbBotton3.Size = new Size(28, 28);
            ptbBotton3.TabIndex = 10;
            ptbBotton3.TabStop = false;
            // 
            // pnlBotton0
            // 
            pnlBotton0.Controls.Add(lblNotEst);
            pnlBotton0.Controls.Add(lblBotton0);
            pnlBotton0.Controls.Add(ptbBotton0);
            pnlBotton0.Dock = DockStyle.Fill;
            pnlBotton0.Location = new Point(375, 0);
            pnlBotton0.Margin = new Padding(0);
            pnlBotton0.Name = "pnlBotton0";
            pnlBotton0.Size = new Size(175, 28);
            pnlBotton0.TabIndex = 8;
            // 
            // lblNotEst
            // 
            lblNotEst.AutoSize = true;
            lblNotEst.BackColor = Color.White;
            lblNotEst.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotEst.ForeColor = Color.Black;
            lblNotEst.Location = new Point(89, 6);
            lblNotEst.Name = "lblNotEst";
            lblNotEst.RightToLeft = RightToLeft.No;
            lblNotEst.Size = new Size(37, 16);
            lblNotEst.TabIndex = 1;
            lblNotEst.Text = "label";
            lblNotEst.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBotton0
            // 
            lblBotton0.AutoSize = true;
            lblBotton0.Dock = DockStyle.Left;
            lblBotton0.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBotton0.Location = new Point(28, 0);
            lblBotton0.Name = "lblBotton0";
            lblBotton0.Padding = new Padding(0, 6, 0, 0);
            lblBotton0.Size = new Size(55, 22);
            lblBotton0.TabIndex = 7;
            lblBotton0.Text = "Backup:";
            // 
            // ptbBotton0
            // 
            ptbBotton0.Dock = DockStyle.Left;
            ptbBotton0.Image = Properties.Resources.Notebook;
            ptbBotton0.Location = new Point(0, 0);
            ptbBotton0.Margin = new Padding(30, 0, 0, 0);
            ptbBotton0.Name = "ptbBotton0";
            ptbBotton0.Size = new Size(28, 28);
            ptbBotton0.TabIndex = 10;
            ptbBotton0.TabStop = false;
            // 
            // pnlBotton1
            // 
            pnlBotton1.Controls.Add(lblBotton1);
            pnlBotton1.Controls.Add(ptbBotton1);
            pnlBotton1.Controls.Add(lblDeskEst);
            pnlBotton1.Dock = DockStyle.Fill;
            pnlBotton1.Location = new Point(200, 0);
            pnlBotton1.Margin = new Padding(0);
            pnlBotton1.Name = "pnlBotton1";
            pnlBotton1.Size = new Size(175, 28);
            pnlBotton1.TabIndex = 7;
            // 
            // lblBotton1
            // 
            lblBotton1.AutoSize = true;
            lblBotton1.Dock = DockStyle.Left;
            lblBotton1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBotton1.Location = new Point(28, 0);
            lblBotton1.Name = "lblBotton1";
            lblBotton1.Padding = new Padding(0, 6, 0, 0);
            lblBotton1.Size = new Size(55, 22);
            lblBotton1.TabIndex = 7;
            lblBotton1.Text = "Backup:";
            // 
            // ptbBotton1
            // 
            ptbBotton1.Dock = DockStyle.Left;
            ptbBotton1.Image = Properties.Resources.Desktop;
            ptbBotton1.Location = new Point(0, 0);
            ptbBotton1.Margin = new Padding(30, 0, 0, 0);
            ptbBotton1.Name = "ptbBotton1";
            ptbBotton1.Size = new Size(28, 28);
            ptbBotton1.TabIndex = 10;
            ptbBotton1.TabStop = false;
            // 
            // lblDeskEst
            // 
            lblDeskEst.AutoSize = true;
            lblDeskEst.BackColor = Color.White;
            lblDeskEst.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeskEst.ForeColor = Color.Black;
            lblDeskEst.Location = new Point(89, 6);
            lblDeskEst.Name = "lblDeskEst";
            lblDeskEst.RightToLeft = RightToLeft.No;
            lblDeskEst.Size = new Size(37, 16);
            lblDeskEst.TabIndex = 100;
            lblDeskEst.Text = "label";
            lblDeskEst.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlBotton2
            // 
            pnlBotton2.Controls.Add(lblBotton4);
            pnlBotton2.Controls.Add(lblTotal);
            pnlBotton2.Dock = DockStyle.Fill;
            pnlBotton2.Location = new Point(900, 0);
            pnlBotton2.Margin = new Padding(0);
            pnlBotton2.Name = "pnlBotton2";
            pnlBotton2.Padding = new Padding(60, 0, 0, 0);
            pnlBotton2.Size = new Size(175, 28);
            pnlBotton2.TabIndex = 10;
            // 
            // lblBotton4
            // 
            lblBotton4.AutoSize = true;
            lblBotton4.Dock = DockStyle.Left;
            lblBotton4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBotton4.Location = new Point(60, 0);
            lblBotton4.Name = "lblBotton4";
            lblBotton4.Padding = new Padding(0, 6, 0, 0);
            lblBotton4.Size = new Size(38, 22);
            lblBotton4.TabIndex = 7;
            lblBotton4.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(104, 6);
            lblTotal.Margin = new Padding(3, 0, 0, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(37, 16);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "label";
            // 
            // pnlUnidade
            // 
            pnlUnidade.Controls.Add(lblUnidade);
            pnlUnidade.Dock = DockStyle.Fill;
            pnlUnidade.Location = new Point(0, 0);
            pnlUnidade.Margin = new Padding(0);
            pnlUnidade.Name = "pnlUnidade";
            pnlUnidade.Size = new Size(200, 28);
            pnlUnidade.TabIndex = 8;
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Dock = DockStyle.Left;
            lblUnidade.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnidade.Location = new Point(0, 0);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Padding = new Padding(3, 5, 0, 0);
            lblUnidade.Size = new Size(3, 21);
            lblUnidade.TabIndex = 7;
            // 
            // ptbFechar
            // 
            ptbFechar.BackColor = Color.White;
            ptbFechar.Cursor = Cursors.Hand;
            ptbFechar.Image = Properties.Resources.Fechar;
            ptbFechar.Location = new Point(1025, 7);
            ptbFechar.Margin = new Padding(0);
            ptbFechar.Name = "ptbFechar";
            ptbFechar.Size = new Size(40, 38);
            ptbFechar.TabIndex = 2;
            ptbFechar.TabStop = false;
            ptbFechar.Click += ptbFechar_Click;
            // 
            // ptbMinimizar
            // 
            ptbMinimizar.BackColor = Color.White;
            ptbMinimizar.Cursor = Cursors.Hand;
            ptbMinimizar.Image = Properties.Resources.Minimizar;
            ptbMinimizar.Location = new Point(975, 7);
            ptbMinimizar.Margin = new Padding(0);
            ptbMinimizar.Name = "ptbMinimizar";
            ptbMinimizar.Size = new Size(40, 38);
            ptbMinimizar.TabIndex = 3;
            ptbMinimizar.TabStop = false;
            ptbMinimizar.Click += ptbMinimizar_Click;
            // 
            // uctSobre
            // 
            uctSobre.BackColor = Color.White;
            uctSobre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uctSobre.Location = new Point(839, 108);
            uctSobre.Margin = new Padding(3, 2, 3, 2);
            uctSobre.Name = "uctSobre";
            uctSobre.Size = new Size(200, 200);
            uctSobre.TabIndex = 4;
            // 
            // uctAjustes
            // 
            uctAjustes.BackColor = Color.White;
            uctAjustes.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uctAjustes.Location = new Point(587, 108);
            uctAjustes.Margin = new Padding(0);
            uctAjustes.Name = "uctAjustes";
            uctAjustes.Size = new Size(200, 200);
            uctAjustes.TabIndex = 5;
            // 
            // uctHome
            // 
            uctHome.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uctHome.Location = new Point(83, 108);
            uctHome.Name = "uctHome";
            uctHome.Size = new Size(200, 200);
            uctHome.TabIndex = 6;
            // 
            // uctInventario
            // 
            uctInventario.Location = new Point(335, 108);
            uctInventario.Name = "uctInventario";
            uctInventario.Size = new Size(200, 200);
            uctInventario.TabIndex = 7;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1075, 438);
            Controls.Add(pnlButton);
            Controls.Add(ptbMinimizar);
            Controls.Add(ptbFechar);
            Controls.Add(uctHome);
            Controls.Add(uctAjustes);
            Controls.Add(pnlLateral);
            Controls.Add(uctSobre);
            Controls.Add(uctInventario);
            Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInventario";
            Text = "InventarioTI";
            Load += FormInventario_Load;
            pnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSobre).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAjustes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPrograma).EndInit();
            pnlButton.ResumeLayout(false);
            tlbBotton.ResumeLayout(false);
            pnlDeskAtivo.ResumeLayout(false);
            pnlDeskAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBotton3.ResumeLayout(false);
            pnlBotton3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbBotton3).EndInit();
            pnlBotton0.ResumeLayout(false);
            pnlBotton0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbBotton0).EndInit();
            pnlBotton1.ResumeLayout(false);
            pnlBotton1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbBotton1).EndInit();
            pnlBotton2.ResumeLayout(false);
            pnlBotton2.PerformLayout();
            pnlUnidade.ResumeLayout(false);
            pnlUnidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLateral;
        private PictureBox ptbPrograma;
        private Panel pnlButton;
        private PictureBox ptbFechar;
        private PictureBox ptbMinimizar;
        private ToolTip ttpForm;
        private PictureBox ptbHome;
        private PictureBox ptbSobre;
        private PictureBox ptbAjustes;
        private View.uctSobre uctSobre;
        private TableLayoutPanel tlbBotton;
        private Label lblTotal;
        private Label lblNotAtv;
        private Label lblNotEst;
        private Panel pnlBotton1;
        private Panel pnlBotton2;
        private Panel pnlBotton3;
        private PictureBox ptbBotton3;
        private Panel pnlBotton0;
        private PictureBox ptbBotton0;
        private Label lblBotton0;
        private Label lblBotton1;
        private Label label1;
        public Label lblDeskEst;
        private Panel pnlDeskAtivo;
        private Label lblBotton3;
        private Label lblDeskAtv;
        private PictureBox pictureBox1;
        private Label lblBotton4;
        public View.uctAjustes uctAjustes;
        public View.uctHome uctHome;
        private Panel pnlUnidade;
        private Label lblUnidade;
        private PictureBox ptbBotton1;
        private ComboBox cbxResolucao;
        private PictureBox ptbInventario;
        public View.uctInventario uctInventario;
    }
}