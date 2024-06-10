namespace InventarioTI.View
{
    partial class uctInventario
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
            lblInventario = new Label();
            dgvInventario = new DataGridView();
            FUNCIONARIO = new DataGridViewTextBoxColumn();
            USERID = new DataGridViewTextBoxColumn();
            PATRIMONIO = new DataGridViewTextBoxColumn();
            SERIE = new DataGridViewTextBoxColumn();
            EQUIPAMENTO = new DataGridViewTextBoxColumn();
            MARCA = new DataGridViewTextBoxColumn();
            MODELO = new DataGridViewTextBoxColumn();
            DATA = new DataGridViewTextBoxColumn();
            Inventario = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblInventario.Location = new Point(489, 15);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(102, 23);
            lblInventario.TabIndex = 0;
            lblInventario.Text = "Inventário";
            // 
            // dgvInventario
            // 
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { FUNCIONARIO, USERID, PATRIMONIO, SERIE, EQUIPAMENTO, MARCA, MODELO, DATA, Inventario });
            dgvInventario.Location = new Point(82, 55);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.Size = new Size(1003, 308);
            dgvInventario.TabIndex = 1;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // FUNCIONARIO
            // 
            FUNCIONARIO.DataPropertyName = "FUNCIONARIO";
            FUNCIONARIO.FillWeight = 25F;
            FUNCIONARIO.HeaderText = "FUNCIONARIO";
            FUNCIONARIO.Name = "FUNCIONARIO";
            FUNCIONARIO.Width = 200;
            // 
            // USERID
            // 
            USERID.DataPropertyName = "USERID";
            USERID.FillWeight = 10F;
            USERID.HeaderText = "USERID";
            USERID.Name = "USERID";
            USERID.Width = 60;
            // 
            // PATRIMONIO
            // 
            PATRIMONIO.DataPropertyName = "PATRIMONIO";
            PATRIMONIO.FillWeight = 10F;
            PATRIMONIO.HeaderText = "PATRIMONIO";
            PATRIMONIO.Name = "PATRIMONIO";
            PATRIMONIO.Width = 60;
            // 
            // SERIE
            // 
            SERIE.DataPropertyName = "SERIE";
            SERIE.FillWeight = 10F;
            SERIE.HeaderText = "SERIE";
            SERIE.Name = "SERIE";
            SERIE.Width = 60;
            // 
            // EQUIPAMENTO
            // 
            EQUIPAMENTO.DataPropertyName = "EQUIPAMENTO";
            EQUIPAMENTO.FillWeight = 10F;
            EQUIPAMENTO.HeaderText = "EQUIPAMENTO";
            EQUIPAMENTO.Name = "EQUIPAMENTO";
            EQUIPAMENTO.Width = 50;
            // 
            // MARCA
            // 
            MARCA.DataPropertyName = "MARCA";
            MARCA.FillWeight = 10F;
            MARCA.HeaderText = "MARCA";
            MARCA.Name = "MARCA";
            MARCA.Width = 50;
            // 
            // MODELO
            // 
            MODELO.DataPropertyName = "MODELO";
            MODELO.FillWeight = 10F;
            MODELO.HeaderText = "MODELO";
            MODELO.Name = "MODELO";
            MODELO.Width = 60;
            // 
            // DATA
            // 
            DATA.DataPropertyName = "DATA";
            DATA.FillWeight = 25F;
            DATA.HeaderText = "DATA";
            DATA.Name = "DATA";
            DATA.Width = 200;
            // 
            // Inventario
            // 
            Inventario.FillWeight = 5F;
            Inventario.HeaderText = "CH.";
            Inventario.Image = Properties.Resources.Check20;
            Inventario.Name = "Inventario";
            Inventario.Width = 30;
            // 
            // uctInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvInventario);
            Controls.Add(lblInventario);
            Name = "uctInventario";
            Size = new Size(1104, 386);
            Load += uctInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventario;
        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn FUNCIONARIO;
        private DataGridViewTextBoxColumn USERID;
        private DataGridViewTextBoxColumn PATRIMONIO;
        private DataGridViewTextBoxColumn SERIE;
        private DataGridViewTextBoxColumn EQUIPAMENTO;
        private DataGridViewTextBoxColumn MARCA;
        private DataGridViewTextBoxColumn MODELO;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewImageColumn Inventario;
    }
}
