namespace InventarioTI.View
{
    partial class frmAcessorios
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
            lblAcessorio = new Label();
            btnAcessorio = new Button();
            ckbHeadset = new CheckBox();
            ckbMonitor = new CheckBox();
            ckbMouse = new CheckBox();
            ckbTeclado = new CheckBox();
            ckbMochila = new CheckBox();
            ckbCarregador = new CheckBox();
            ckbComputador = new CheckBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblAcessorio
            // 
            lblAcessorio.AutoSize = true;
            lblAcessorio.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcessorio.Location = new Point(12, 10);
            lblAcessorio.Name = "lblAcessorio";
            lblAcessorio.Size = new Size(273, 23);
            lblAcessorio.TabIndex = 7;
            lblAcessorio.Text = "CLIENTE POSSUI ACESSÓRIO?";
            // 
            // btnAcessorio
            // 
            btnAcessorio.BackColor = Color.FromArgb(196, 0, 6);
            btnAcessorio.BackgroundImageLayout = ImageLayout.None;
            btnAcessorio.FlatStyle = FlatStyle.Flat;
            btnAcessorio.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcessorio.Location = new Point(210, 91);
            btnAcessorio.Margin = new Padding(0);
            btnAcessorio.Name = "btnAcessorio";
            btnAcessorio.Size = new Size(75, 29);
            btnAcessorio.TabIndex = 5;
            btnAcessorio.Text = "OK";
            btnAcessorio.UseVisualStyleBackColor = false;
            btnAcessorio.Click += btnAcessorio_Click;
            // 
            // ckbHeadset
            // 
            ckbHeadset.AutoSize = true;
            ckbHeadset.Location = new Point(12, 40);
            ckbHeadset.Name = "ckbHeadset";
            ckbHeadset.Size = new Size(77, 21);
            ckbHeadset.TabIndex = 8;
            ckbHeadset.Text = "Headset";
            ckbHeadset.UseVisualStyleBackColor = true;
            // 
            // ckbMonitor
            // 
            ckbMonitor.AutoSize = true;
            ckbMonitor.Location = new Point(204, 40);
            ckbMonitor.Name = "ckbMonitor";
            ckbMonitor.Size = new Size(73, 21);
            ckbMonitor.TabIndex = 9;
            ckbMonitor.Text = "Monitor";
            ckbMonitor.UseVisualStyleBackColor = true;
            // 
            // ckbMouse
            // 
            ckbMouse.AutoSize = true;
            ckbMouse.Location = new Point(12, 67);
            ckbMouse.Name = "ckbMouse";
            ckbMouse.Size = new Size(66, 21);
            ckbMouse.TabIndex = 10;
            ckbMouse.Text = "Mouse";
            ckbMouse.UseVisualStyleBackColor = true;
            // 
            // ckbTeclado
            // 
            ckbTeclado.AutoSize = true;
            ckbTeclado.Location = new Point(95, 67);
            ckbTeclado.Name = "ckbTeclado";
            ckbTeclado.Size = new Size(75, 21);
            ckbTeclado.TabIndex = 11;
            ckbTeclado.Text = "Teclado";
            ckbTeclado.UseVisualStyleBackColor = true;
            // 
            // ckbMochila
            // 
            ckbMochila.AutoSize = true;
            ckbMochila.Location = new Point(204, 67);
            ckbMochila.Name = "ckbMochila";
            ckbMochila.Size = new Size(75, 21);
            ckbMochila.TabIndex = 12;
            ckbMochila.Text = "Mochila";
            ckbMochila.UseVisualStyleBackColor = true;
            // 
            // ckbCarregador
            // 
            ckbCarregador.AutoSize = true;
            ckbCarregador.Location = new Point(95, 40);
            ckbCarregador.Name = "ckbCarregador";
            ckbCarregador.Size = new Size(96, 21);
            ckbCarregador.TabIndex = 13;
            ckbCarregador.Text = "Carregador";
            ckbCarregador.UseVisualStyleBackColor = true;
            // 
            // ckbComputador
            // 
            ckbComputador.AutoSize = true;
            ckbComputador.Location = new Point(12, 94);
            ckbComputador.Name = "ckbComputador";
            ckbComputador.Size = new Size(103, 21);
            ckbComputador.TabIndex = 14;
            ckbComputador.Text = "Computador";
            ckbComputador.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(196, 0, 6);
            btnCancel.BackgroundImageLayout = ImageLayout.None;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(123, 91);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAcessorios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 129);
            Controls.Add(btnCancel);
            Controls.Add(ckbComputador);
            Controls.Add(ckbCarregador);
            Controls.Add(ckbMochila);
            Controls.Add(ckbTeclado);
            Controls.Add(ckbMouse);
            Controls.Add(ckbMonitor);
            Controls.Add(ckbHeadset);
            Controls.Add(lblAcessorio);
            Controls.Add(btnAcessorio);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            Name = "frmAcessorios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAcessorios";
            Load += frmAcessorios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcessorio;
        private CheckBox ckbHeadset;
        private CheckBox ckbMonitor;
        private CheckBox ckbMouse;
        private CheckBox ckbTeclado;
        private CheckBox ckbMochila;
        private CheckBox ckbCarregador;
        private Button btnCancel;
        public CheckBox ckbComputador;
        private Button btnAcessorio;
    }
}