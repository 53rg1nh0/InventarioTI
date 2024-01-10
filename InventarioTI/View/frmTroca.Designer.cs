using InventarioTI.Entites.emuns;

namespace InventarioTI.View
{
    partial class frmTroca
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
            dgvTroca = new DataGridView();
            Equipamento = new DataGridViewTextBoxColumn();
            Patrimonio = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Chek = new DataGridViewCheckBoxColumn();
            inventarioBindingSource = new BindingSource(components);
            btnTroca = new Button();
            btnCamcel = new Button();
            lblTroca = new Label();
            pnlTroca = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTroca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventarioBindingSource).BeginInit();
            pnlTroca.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTroca
            // 
            dgvTroca.AutoGenerateColumns = false;
            dgvTroca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTroca.Columns.AddRange(new DataGridViewColumn[] { Equipamento, Patrimonio, Marca, Modelo, Chek });
            dgvTroca.DataSource = inventarioBindingSource;
            dgvTroca.Location = new Point(12, 42);
            dgvTroca.Name = "dgvTroca";
            dgvTroca.RowTemplate.Height = 25;
            dgvTroca.Size = new Size(409, 75);
            dgvTroca.TabIndex = 0;
            dgvTroca.CellContentClick += dgvTroca_CellContentClick;
            // 
            // Equipamento
            // 
            Equipamento.DataPropertyName = "EQUIPAMENTO";
            Equipamento.HeaderText = "EQUIP.";
            Equipamento.Name = "Equipamento";
            // 
            // Patrimonio
            // 
            Patrimonio.DataPropertyName = "PATRIMONIO";
            Patrimonio.HeaderText = "PATRIM.";
            Patrimonio.Name = "Patrimonio";
            // 
            // Marca
            // 
            Marca.DataPropertyName = "MARCA";
            Marca.HeaderText = "MARCA";
            Marca.Name = "Marca";
            // 
            // Modelo
            // 
            Modelo.DataPropertyName = "MODELO";
            Modelo.HeaderText = "MODELO";
            Modelo.Name = "Modelo";
            // 
            // Chek
            // 
            Chek.HeaderText = "SELECIONE";
            Chek.Name = "Chek";
            Chek.Resizable = DataGridViewTriState.True;
            Chek.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // inventarioBindingSource
            // 
            inventarioBindingSource.DataSource = typeof(Inventario);
            // 
            // btnTroca
            // 
            btnTroca.BackColor = Color.FromArgb(196, 0, 6);
            btnTroca.BackgroundImageLayout = ImageLayout.None;
            btnTroca.FlatStyle = FlatStyle.Flat;
            btnTroca.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTroca.Location = new Point(346, 127);
            btnTroca.Margin = new Padding(0);
            btnTroca.Name = "btnTroca";
            btnTroca.Size = new Size(75, 26);
            btnTroca.TabIndex = 1;
            btnTroca.Text = "Troca";
            btnTroca.UseVisualStyleBackColor = false;
            btnTroca.Click += btnTroca_Click;
            // 
            // btnCamcel
            // 
            btnCamcel.BackColor = Color.FromArgb(196, 0, 6);
            btnCamcel.BackgroundImageLayout = ImageLayout.None;
            btnCamcel.FlatAppearance.BorderSize = 0;
            btnCamcel.FlatStyle = FlatStyle.Flat;
            btnCamcel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCamcel.Location = new Point(261, 127);
            btnCamcel.Margin = new Padding(0);
            btnCamcel.Name = "btnCamcel";
            btnCamcel.Size = new Size(75, 26);
            btnCamcel.TabIndex = 2;
            btnCamcel.Text = "Cancel";
            btnCamcel.UseVisualStyleBackColor = false;
            btnCamcel.Click += btnCamcel_Click;
            // 
            // lblTroca
            // 
            lblTroca.AutoSize = true;
            lblTroca.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTroca.Location = new Point(12, 9);
            lblTroca.Name = "lblTroca";
            lblTroca.Size = new Size(411, 23);
            lblTroca.TabIndex = 3;
            lblTroca.Text = "SELECIONE O EQUIPAMENTO PARA A TROCA";
            // 
            // pnlTroca
            // 
            pnlTroca.BorderStyle = BorderStyle.FixedSingle;
            pnlTroca.Controls.Add(lblTroca);
            pnlTroca.Controls.Add(btnTroca);
            pnlTroca.Controls.Add(btnCamcel);
            pnlTroca.Controls.Add(dgvTroca);
            pnlTroca.Dock = DockStyle.Fill;
            pnlTroca.Location = new Point(0, 0);
            pnlTroca.Margin = new Padding(0);
            pnlTroca.Name = "pnlTroca";
            pnlTroca.Size = new Size(434, 163);
            pnlTroca.TabIndex = 4;
            // 
            // frmTroca
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 163);
            Controls.Add(pnlTroca);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTroca";
            Text = "Form1";
            Load += frmTroca_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTroca).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventarioBindingSource).EndInit();
            pnlTroca.ResumeLayout(false);
            pnlTroca.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTroca;
        private Button btnCamcel;
        private Label lblTroca;
        public DataGridView dgvTroca;
        private BindingSource inventarioBindingSource;
        private Panel pnlTroca;
        private DataGridViewTextBoxColumn Equipamento;
        private DataGridViewTextBoxColumn Patrimonio;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewCheckBoxColumn Chek;
    }
}