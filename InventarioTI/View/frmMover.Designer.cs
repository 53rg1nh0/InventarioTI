namespace InventarioTI.View
{
    partial class frmMover
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMover = new Label();
            btnMover = new Button();
            btnCamcel = new Button();
            dgvMover = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Sigla = new DataGridViewTextBoxColumn();
            Chek = new DataGridViewCheckBoxColumn();
            unidadeBindingSource = new BindingSource(components);
            pnlMover = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unidadeBindingSource).BeginInit();
            pnlMover.SuspendLayout();
            SuspendLayout();
            // 
            // lblMover
            // 
            lblMover.AutoSize = true;
            lblMover.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMover.Location = new Point(12, 9);
            lblMover.Name = "lblMover";
            lblMover.Size = new Size(341, 23);
            lblMover.TabIndex = 3;
            lblMover.Text = "SELECIONE A UNIDADE PARA MOVER";
            // 
            // btnMover
            // 
            btnMover.BackColor = Color.FromArgb(196, 0, 6);
            btnMover.BackgroundImageLayout = ImageLayout.None;
            btnMover.FlatStyle = FlatStyle.Flat;
            btnMover.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMover.Location = new Point(305, 127);
            btnMover.Margin = new Padding(0);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(75, 26);
            btnMover.TabIndex = 1;
            btnMover.Text = "Mover";
            btnMover.UseVisualStyleBackColor = false;
            btnMover.Click += btnMover_Click;
            // 
            // btnCamcel
            // 
            btnCamcel.BackColor = Color.FromArgb(196, 0, 6);
            btnCamcel.BackgroundImageLayout = ImageLayout.None;
            btnCamcel.FlatAppearance.BorderSize = 0;
            btnCamcel.FlatStyle = FlatStyle.Flat;
            btnCamcel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCamcel.Location = new Point(226, 127);
            btnCamcel.Margin = new Padding(0);
            btnCamcel.Name = "btnCamcel";
            btnCamcel.Size = new Size(75, 26);
            btnCamcel.TabIndex = 2;
            btnCamcel.Text = "Cancel";
            btnCamcel.UseVisualStyleBackColor = false;
            btnCamcel.Click += btnCamcel_Click;
            // 
            // dgvMover
            // 
            dgvMover.AutoGenerateColumns = false;
            dgvMover.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMover.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, uFDataGridViewTextBoxColumn, Sigla, Chek });
            dgvMover.DataSource = unidadeBindingSource;
            dgvMover.Location = new Point(12, 42);
            dgvMover.Name = "dgvMover";
            dgvMover.RowTemplate.Height = 25;
            dgvMover.Size = new Size(368, 75);
            dgvMover.TabIndex = 0;
            dgvMover.CellContentClick += dgvMover_CellContentClick;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "NOME";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // uFDataGridViewTextBoxColumn
            // 
            uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            uFDataGridViewTextBoxColumn.HeaderText = "UF";
            uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            // 
            // Sigla
            // 
            Sigla.DataPropertyName = "Sigla";
            Sigla.HeaderText = "SIGLA";
            Sigla.Name = "Sigla";
            // 
            // Chek
            // 
            Chek.HeaderText = "SELECIONE";
            Chek.Name = "Chek";
            Chek.Resizable = DataGridViewTriState.True;
            Chek.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // unidadeBindingSource
            // 
            unidadeBindingSource.DataSource = typeof(Entites.Unidade);
            // 
            // pnlMover
            // 
            pnlMover.BorderStyle = BorderStyle.FixedSingle;
            pnlMover.Controls.Add(lblMover);
            pnlMover.Controls.Add(btnMover);
            pnlMover.Controls.Add(btnCamcel);
            pnlMover.Controls.Add(dgvMover);
            pnlMover.Dock = DockStyle.Fill;
            pnlMover.Location = new Point(0, 0);
            pnlMover.Margin = new Padding(0);
            pnlMover.Name = "pnlMover";
            pnlMover.Size = new Size(392, 163);
            pnlMover.TabIndex = 5;
            // 
            // frmMover
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(392, 163);
            Controls.Add(pnlMover);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMover";
            Text = "frmMover";
            Load += frmMover_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMover).EndInit();
            ((System.ComponentModel.ISupportInitialize)unidadeBindingSource).EndInit();
            pnlMover.ResumeLayout(false);
            pnlMover.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMover;
        private Button btnMover;
        private Button btnCamcel;
        public DataGridView dgvMover;
        private BindingSource unidadeBindingSource;
        private Panel pnlMover;
        private DataGridViewTextBoxColumn siglaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Sigla;
        private DataGridViewCheckBoxColumn Chek;
    }
}