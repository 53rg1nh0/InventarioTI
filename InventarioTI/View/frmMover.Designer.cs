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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMover));
            this.lblMover = new System.Windows.Forms.Label();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnCamcel = new System.Windows.Forms.Button();
            this.dgvMover = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chek = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMover = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            this.pnlMover.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMover
            // 
            this.lblMover.AutoSize = true;
            this.lblMover.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMover.Location = new System.Drawing.Point(25, 9);
            this.lblMover.Name = "lblMover";
            this.lblMover.Size = new System.Drawing.Size(341, 23);
            this.lblMover.TabIndex = 3;
            this.lblMover.Text = "SELECIONE A UNIDADE PARA MOVER";
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btnMover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMover.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMover.Location = new System.Drawing.Point(305, 127);
            this.btnMover.Margin = new System.Windows.Forms.Padding(0);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 26);
            this.btnMover.TabIndex = 1;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnCamcel
            // 
            this.btnCamcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btnCamcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCamcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamcel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCamcel.Location = new System.Drawing.Point(226, 127);
            this.btnCamcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCamcel.Name = "btnCamcel";
            this.btnCamcel.Size = new System.Drawing.Size(75, 26);
            this.btnCamcel.TabIndex = 2;
            this.btnCamcel.Text = "Cancel";
            this.btnCamcel.UseVisualStyleBackColor = false;
            this.btnCamcel.Click += new System.EventHandler(this.btnCamcel_Click);
            // 
            // dgvMover
            // 
            this.dgvMover.AutoGenerateColumns = false;
            this.dgvMover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.Sigla,
            this.Chek});
            this.dgvMover.DataSource = this.unidadeBindingSource;
            this.dgvMover.Location = new System.Drawing.Point(11, 42);
            this.dgvMover.Name = "dgvMover";
            this.dgvMover.RowTemplate.Height = 25;
            this.dgvMover.Size = new System.Drawing.Size(368, 75);
            this.dgvMover.TabIndex = 0;
            this.dgvMover.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMover_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            // 
            // Sigla
            // 
            this.Sigla.DataPropertyName = "Sigla";
            this.Sigla.HeaderText = "SIGLA";
            this.Sigla.Name = "Sigla";
            // 
            // Chek
            // 
            this.Chek.HeaderText = "SELECIONE";
            this.Chek.Name = "Chek";
            this.Chek.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Chek.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // unidadeBindingSource
            // 
            this.unidadeBindingSource.DataSource = typeof(InventarioTI.Entites.Unidade);
            // 
            // pnlMover
            // 
            this.pnlMover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMover.Controls.Add(this.lblMover);
            this.pnlMover.Controls.Add(this.btnMover);
            this.pnlMover.Controls.Add(this.btnCamcel);
            this.pnlMover.Controls.Add(this.dgvMover);
            this.pnlMover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMover.Location = new System.Drawing.Point(0, 0);
            this.pnlMover.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMover.Name = "pnlMover";
            this.pnlMover.Size = new System.Drawing.Size(392, 163);
            this.pnlMover.TabIndex = 5;
            // 
            // frmMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 163);
            this.Controls.Add(this.pnlMover);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMover";
            this.Text = "frmMover";
            this.Load += new System.EventHandler(this.frmMover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            this.pnlMover.ResumeLayout(false);
            this.pnlMover.PerformLayout();
            this.ResumeLayout(false);

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