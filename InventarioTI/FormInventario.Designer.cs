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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.cbxResolucao = new System.Windows.Forms.ComboBox();
            this.ptbSobre = new System.Windows.Forms.PictureBox();
            this.ptbAjustes = new System.Windows.Forms.PictureBox();
            this.ptbHome = new System.Windows.Forms.PictureBox();
            this.ptbPrograma = new System.Windows.Forms.PictureBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.tlbBotton = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDeskAtivo = new System.Windows.Forms.Panel();
            this.lblBotton3 = new System.Windows.Forms.Label();
            this.lblDeskAtv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBotton3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotAtv = new System.Windows.Forms.Label();
            this.ptbBotton3 = new System.Windows.Forms.PictureBox();
            this.pnlBotton0 = new System.Windows.Forms.Panel();
            this.lblNotEst = new System.Windows.Forms.Label();
            this.lblBotton0 = new System.Windows.Forms.Label();
            this.ptbBotton0 = new System.Windows.Forms.PictureBox();
            this.pnlBotton1 = new System.Windows.Forms.Panel();
            this.lblBotton1 = new System.Windows.Forms.Label();
            this.ptbBotton1 = new System.Windows.Forms.PictureBox();
            this.lblDeskEst = new System.Windows.Forms.Label();
            this.pnlBotton2 = new System.Windows.Forms.Panel();
            this.lblBotton4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlUnidade = new System.Windows.Forms.Panel();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.ptbFechar = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.ttpForm = new System.Windows.Forms.ToolTip(this.components);
            this.uctSobre = new InventarioTI.View.uctSobre();
            this.uctAjustes = new InventarioTI.View.uctAjustes();
            this.uctHome = new InventarioTI.View.uctHome();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrograma)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.tlbBotton.SuspendLayout();
            this.pnlDeskAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBotton3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotton3)).BeginInit();
            this.pnlBotton0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotton0)).BeginInit();
            this.pnlBotton1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotton1)).BeginInit();
            this.pnlBotton2.SuspendLayout();
            this.pnlUnidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.pnlLateral.Controls.Add(this.cbxResolucao);
            this.pnlLateral.Controls.Add(this.ptbSobre);
            this.pnlLateral.Controls.Add(this.ptbAjustes);
            this.pnlLateral.Controls.Add(this.ptbHome);
            this.pnlLateral.Controls.Add(this.ptbPrograma);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(65, 338);
            this.pnlLateral.TabIndex = 0;
            // 
            // cbxResolucao
            // 
            this.cbxResolucao.AutoCompleteCustomSource.AddRange(new string[] {
            "100%",
            "150%"});
            this.cbxResolucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResolucao.FormattingEnabled = true;
            this.cbxResolucao.Items.AddRange(new object[] {
            "100%",
            "150%"});
            this.cbxResolucao.Location = new System.Drawing.Point(0, 17);
            this.cbxResolucao.Name = "cbxResolucao";
            this.cbxResolucao.Size = new System.Drawing.Size(65, 24);
            this.cbxResolucao.TabIndex = 7;
            this.cbxResolucao.Visible = false;
            this.cbxResolucao.SelectionChangeCommitted += new System.EventHandler(this.cbxResolucao_SelectionChangeCommitted);
            // 
            // ptbSobre
            // 
            this.ptbSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.ptbSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSobre.Image = global::InventarioTI.Properties.Resources.Sobre;
            this.ptbSobre.Location = new System.Drawing.Point(0, 259);
            this.ptbSobre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbSobre.Name = "ptbSobre";
            this.ptbSobre.Padding = new System.Windows.Forms.Padding(7, 2, 5, 2);
            this.ptbSobre.Size = new System.Drawing.Size(65, 52);
            this.ptbSobre.TabIndex = 6;
            this.ptbSobre.TabStop = false;
            this.ptbSobre.Click += new System.EventHandler(this.ptbSobre_Click);
            // 
            // ptbAjustes
            // 
            this.ptbAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.ptbAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAjustes.Image = global::InventarioTI.Properties.Resources.Ajustes;
            this.ptbAjustes.Location = new System.Drawing.Point(0, 168);
            this.ptbAjustes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbAjustes.Name = "ptbAjustes";
            this.ptbAjustes.Padding = new System.Windows.Forms.Padding(7, 2, 5, 2);
            this.ptbAjustes.Size = new System.Drawing.Size(65, 52);
            this.ptbAjustes.TabIndex = 5;
            this.ptbAjustes.TabStop = false;
            this.ptbAjustes.Click += new System.EventHandler(this.ptbAjustes_Click);
            // 
            // ptbHome
            // 
            this.ptbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.ptbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbHome.Image = global::InventarioTI.Properties.Resources.Home;
            this.ptbHome.Location = new System.Drawing.Point(0, 77);
            this.ptbHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbHome.Name = "ptbHome";
            this.ptbHome.Padding = new System.Windows.Forms.Padding(7, 2, 5, 2);
            this.ptbHome.Size = new System.Drawing.Size(65, 52);
            this.ptbHome.TabIndex = 4;
            this.ptbHome.TabStop = false;
            this.ptbHome.Click += new System.EventHandler(this.ptbHome_Click);
            // 
            // ptbPrograma
            // 
            this.ptbPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.ptbPrograma.BackgroundImage = global::InventarioTI.Properties.Resources.Programa;
            this.ptbPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbPrograma.Location = new System.Drawing.Point(0, 0);
            this.ptbPrograma.Margin = new System.Windows.Forms.Padding(0);
            this.ptbPrograma.Name = "ptbPrograma";
            this.ptbPrograma.Size = new System.Drawing.Size(65, 61);
            this.ptbPrograma.TabIndex = 2;
            this.ptbPrograma.TabStop = false;
            this.ptbPrograma.Click += new System.EventHandler(this.ptbPrograma_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Black;
            this.pnlButton.Controls.Add(this.tlbBotton);
            this.pnlButton.ForeColor = System.Drawing.Color.White;
            this.pnlButton.Location = new System.Drawing.Point(0, 311);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1075, 28);
            this.pnlButton.TabIndex = 1;
            // 
            // tlbBotton
            // 
            this.tlbBotton.ColumnCount = 6;
            this.tlbBotton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlbBotton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbBotton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbBotton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbBotton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbBotton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlbBotton.Controls.Add(this.pnlDeskAtivo, 3, 0);
            this.tlbBotton.Controls.Add(this.pnlBotton3, 4, 0);
            this.tlbBotton.Controls.Add(this.pnlBotton0, 2, 0);
            this.tlbBotton.Controls.Add(this.pnlBotton1, 1, 0);
            this.tlbBotton.Controls.Add(this.pnlBotton2, 5, 0);
            this.tlbBotton.Controls.Add(this.pnlUnidade, 0, 0);
            this.tlbBotton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbBotton.Location = new System.Drawing.Point(0, 0);
            this.tlbBotton.Margin = new System.Windows.Forms.Padding(0);
            this.tlbBotton.Name = "tlbBotton";
            this.tlbBotton.RowCount = 1;
            this.tlbBotton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbBotton.Size = new System.Drawing.Size(1075, 28);
            this.tlbBotton.TabIndex = 7;
            // 
            // pnlDeskAtivo
            // 
            this.pnlDeskAtivo.Controls.Add(this.lblBotton3);
            this.pnlDeskAtivo.Controls.Add(this.lblDeskAtv);
            this.pnlDeskAtivo.Controls.Add(this.pictureBox1);
            this.pnlDeskAtivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeskAtivo.Location = new System.Drawing.Point(550, 0);
            this.pnlDeskAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDeskAtivo.Name = "pnlDeskAtivo";
            this.pnlDeskAtivo.Size = new System.Drawing.Size(175, 28);
            this.pnlDeskAtivo.TabIndex = 11;
            // 
            // lblBotton3
            // 
            this.lblBotton3.AutoSize = true;
            this.lblBotton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBotton3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBotton3.Location = new System.Drawing.Point(28, 0);
            this.lblBotton3.Name = "lblBotton3";
            this.lblBotton3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblBotton3.Size = new System.Drawing.Size(45, 22);
            this.lblBotton3.TabIndex = 7;
            this.lblBotton3.Text = "Ativos:";
            // 
            // lblDeskAtv
            // 
            this.lblDeskAtv.AutoSize = true;
            this.lblDeskAtv.BackColor = System.Drawing.Color.White;
            this.lblDeskAtv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeskAtv.ForeColor = System.Drawing.Color.Black;
            this.lblDeskAtv.Location = new System.Drawing.Point(79, 6);
            this.lblDeskAtv.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblDeskAtv.Name = "lblDeskAtv";
            this.lblDeskAtv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeskAtv.Size = new System.Drawing.Size(37, 16);
            this.lblDeskAtv.TabIndex = 3;
            this.lblDeskAtv.Text = "label";
            this.lblDeskAtv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::InventarioTI.Properties.Resources.Desktop;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBotton3
            // 
            this.pnlBotton3.Controls.Add(this.label1);
            this.pnlBotton3.Controls.Add(this.lblNotAtv);
            this.pnlBotton3.Controls.Add(this.ptbBotton3);
            this.pnlBotton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotton3.Location = new System.Drawing.Point(725, 0);
            this.pnlBotton3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotton3.Name = "pnlBotton3";
            this.pnlBotton3.Size = new System.Drawing.Size(175, 28);
            this.pnlBotton3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ativos:";
            // 
            // lblNotAtv
            // 
            this.lblNotAtv.AutoSize = true;
            this.lblNotAtv.BackColor = System.Drawing.Color.White;
            this.lblNotAtv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotAtv.ForeColor = System.Drawing.Color.Black;
            this.lblNotAtv.Location = new System.Drawing.Point(79, 6);
            this.lblNotAtv.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblNotAtv.Name = "lblNotAtv";
            this.lblNotAtv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotAtv.Size = new System.Drawing.Size(37, 16);
            this.lblNotAtv.TabIndex = 3;
            this.lblNotAtv.Text = "label";
            this.lblNotAtv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ptbBotton3
            // 
            this.ptbBotton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbBotton3.Image = global::InventarioTI.Properties.Resources.Notebook;
            this.ptbBotton3.Location = new System.Drawing.Point(0, 0);
            this.ptbBotton3.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ptbBotton3.Name = "ptbBotton3";
            this.ptbBotton3.Size = new System.Drawing.Size(28, 28);
            this.ptbBotton3.TabIndex = 10;
            this.ptbBotton3.TabStop = false;
            // 
            // pnlBotton0
            // 
            this.pnlBotton0.Controls.Add(this.lblNotEst);
            this.pnlBotton0.Controls.Add(this.lblBotton0);
            this.pnlBotton0.Controls.Add(this.ptbBotton0);
            this.pnlBotton0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotton0.Location = new System.Drawing.Point(375, 0);
            this.pnlBotton0.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotton0.Name = "pnlBotton0";
            this.pnlBotton0.Size = new System.Drawing.Size(175, 28);
            this.pnlBotton0.TabIndex = 8;
            // 
            // lblNotEst
            // 
            this.lblNotEst.AutoSize = true;
            this.lblNotEst.BackColor = System.Drawing.Color.White;
            this.lblNotEst.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotEst.ForeColor = System.Drawing.Color.Black;
            this.lblNotEst.Location = new System.Drawing.Point(89, 6);
            this.lblNotEst.Name = "lblNotEst";
            this.lblNotEst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotEst.Size = new System.Drawing.Size(37, 16);
            this.lblNotEst.TabIndex = 1;
            this.lblNotEst.Text = "label";
            this.lblNotEst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBotton0
            // 
            this.lblBotton0.AutoSize = true;
            this.lblBotton0.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBotton0.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBotton0.Location = new System.Drawing.Point(28, 0);
            this.lblBotton0.Name = "lblBotton0";
            this.lblBotton0.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblBotton0.Size = new System.Drawing.Size(55, 22);
            this.lblBotton0.TabIndex = 7;
            this.lblBotton0.Text = "Backup:";
            // 
            // ptbBotton0
            // 
            this.ptbBotton0.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbBotton0.Image = global::InventarioTI.Properties.Resources.Notebook;
            this.ptbBotton0.Location = new System.Drawing.Point(0, 0);
            this.ptbBotton0.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ptbBotton0.Name = "ptbBotton0";
            this.ptbBotton0.Size = new System.Drawing.Size(28, 28);
            this.ptbBotton0.TabIndex = 10;
            this.ptbBotton0.TabStop = false;
            // 
            // pnlBotton1
            // 
            this.pnlBotton1.Controls.Add(this.lblBotton1);
            this.pnlBotton1.Controls.Add(this.ptbBotton1);
            this.pnlBotton1.Controls.Add(this.lblDeskEst);
            this.pnlBotton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotton1.Location = new System.Drawing.Point(200, 0);
            this.pnlBotton1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotton1.Name = "pnlBotton1";
            this.pnlBotton1.Size = new System.Drawing.Size(175, 28);
            this.pnlBotton1.TabIndex = 7;
            // 
            // lblBotton1
            // 
            this.lblBotton1.AutoSize = true;
            this.lblBotton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBotton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBotton1.Location = new System.Drawing.Point(28, 0);
            this.lblBotton1.Name = "lblBotton1";
            this.lblBotton1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblBotton1.Size = new System.Drawing.Size(55, 22);
            this.lblBotton1.TabIndex = 7;
            this.lblBotton1.Text = "Backup:";
            // 
            // ptbBotton1
            // 
            this.ptbBotton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbBotton1.Image = global::InventarioTI.Properties.Resources.Desktop;
            this.ptbBotton1.Location = new System.Drawing.Point(0, 0);
            this.ptbBotton1.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ptbBotton1.Name = "ptbBotton1";
            this.ptbBotton1.Size = new System.Drawing.Size(28, 28);
            this.ptbBotton1.TabIndex = 10;
            this.ptbBotton1.TabStop = false;
            // 
            // lblDeskEst
            // 
            this.lblDeskEst.AutoSize = true;
            this.lblDeskEst.BackColor = System.Drawing.Color.White;
            this.lblDeskEst.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeskEst.ForeColor = System.Drawing.Color.Black;
            this.lblDeskEst.Location = new System.Drawing.Point(89, 6);
            this.lblDeskEst.Name = "lblDeskEst";
            this.lblDeskEst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeskEst.Size = new System.Drawing.Size(37, 16);
            this.lblDeskEst.TabIndex = 100;
            this.lblDeskEst.Text = "label";
            this.lblDeskEst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlBotton2
            // 
            this.pnlBotton2.Controls.Add(this.lblBotton4);
            this.pnlBotton2.Controls.Add(this.lblTotal);
            this.pnlBotton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotton2.Location = new System.Drawing.Point(900, 0);
            this.pnlBotton2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBotton2.Name = "pnlBotton2";
            this.pnlBotton2.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.pnlBotton2.Size = new System.Drawing.Size(175, 28);
            this.pnlBotton2.TabIndex = 10;
            // 
            // lblBotton4
            // 
            this.lblBotton4.AutoSize = true;
            this.lblBotton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBotton4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBotton4.Location = new System.Drawing.Point(60, 0);
            this.lblBotton4.Name = "lblBotton4";
            this.lblBotton4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblBotton4.Size = new System.Drawing.Size(38, 22);
            this.lblBotton4.TabIndex = 7;
            this.lblBotton4.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(104, 6);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 16);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "label";
            // 
            // pnlUnidade
            // 
            this.pnlUnidade.Controls.Add(this.lblUnidade);
            this.pnlUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUnidade.Location = new System.Drawing.Point(0, 0);
            this.pnlUnidade.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUnidade.Name = "pnlUnidade";
            this.pnlUnidade.Size = new System.Drawing.Size(200, 28);
            this.pnlUnidade.TabIndex = 8;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUnidade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnidade.Location = new System.Drawing.Point(0, 0);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.lblUnidade.Size = new System.Drawing.Size(3, 21);
            this.lblUnidade.TabIndex = 7;
            // 
            // ptbFechar
            // 
            this.ptbFechar.BackColor = System.Drawing.Color.White;
            this.ptbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbFechar.Image = global::InventarioTI.Properties.Resources.Fechar;
            this.ptbFechar.Location = new System.Drawing.Point(1025, 7);
            this.ptbFechar.Margin = new System.Windows.Forms.Padding(0);
            this.ptbFechar.Name = "ptbFechar";
            this.ptbFechar.Size = new System.Drawing.Size(40, 38);
            this.ptbFechar.TabIndex = 2;
            this.ptbFechar.TabStop = false;
            this.ptbFechar.Click += new System.EventHandler(this.ptbFechar_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.BackColor = System.Drawing.Color.White;
            this.ptbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimizar.Image = global::InventarioTI.Properties.Resources.Minimizar;
            this.ptbMinimizar.Location = new System.Drawing.Point(975, 7);
            this.ptbMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(40, 38);
            this.ptbMinimizar.TabIndex = 3;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // uctSobre
            // 
            this.uctSobre.BackColor = System.Drawing.Color.White;
            this.uctSobre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uctSobre.Location = new System.Drawing.Point(727, 11);
            this.uctSobre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uctSobre.Name = "uctSobre";
            this.uctSobre.Size = new System.Drawing.Size(336, 262);
            this.uctSobre.TabIndex = 4;
            // 
            // uctAjustes
            // 
            this.uctAjustes.BackColor = System.Drawing.Color.White;
            this.uctAjustes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uctAjustes.Location = new System.Drawing.Point(444, 7);
            this.uctAjustes.Margin = new System.Windows.Forms.Padding(0);
            this.uctAjustes.Name = "uctAjustes";
            this.uctAjustes.Size = new System.Drawing.Size(300, 300);
            this.uctAjustes.TabIndex = 5;
            // 
            // uctHome
            // 
            this.uctHome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uctHome.Location = new System.Drawing.Point(93, 6);
            this.uctHome.Name = "uctHome";
            this.uctHome.Size = new System.Drawing.Size(300, 300);
            this.uctHome.TabIndex = 6;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 338);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.ptbMinimizar);
            this.Controls.Add(this.ptbFechar);
            this.Controls.Add(this.uctHome);
            this.Controls.Add(this.uctAjustes);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.uctSobre);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInventario";
            this.Text = "InventarioTI";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            this.pnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrograma)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.tlbBotton.ResumeLayout(false);
            this.pnlDeskAtivo.ResumeLayout(false);
            this.pnlDeskAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBotton3.ResumeLayout(false);
            this.pnlBotton3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotton3)).EndInit();
            this.pnlBotton0.ResumeLayout(false);
            this.pnlBotton0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotton0)).EndInit();
            this.pnlBotton1.ResumeLayout(false);
            this.pnlBotton1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBotton1)).EndInit();
            this.pnlBotton2.ResumeLayout(false);
            this.pnlBotton2.PerformLayout();
            this.pnlUnidade.ResumeLayout(false);
            this.pnlUnidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            this.ResumeLayout(false);

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
    }
}