namespace InventarioTI.View
{
    partial class frmObs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObs));
            lblObs = new Label();
            txtObs = new TextBox();
            lblTitulo = new Label();
            btnObs = new Button();
            SuspendLayout();
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblObs.Location = new Point(203, 9);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(140, 23);
            lblObs.TabIndex = 8;
            lblObs.Text = "OBSERVAÇÃO";
            // 
            // txtObs
            // 
            txtObs.Location = new Point(12, 35);
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(548, 22);
            txtObs.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 60);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 17);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Infome o motivo da remoção do equipamento";
            // 
            // btnObs
            // 
            btnObs.BackColor = Color.FromArgb(196, 0, 6);
            btnObs.BackgroundImageLayout = ImageLayout.None;
            btnObs.Cursor = Cursors.Hand;
            btnObs.FlatStyle = FlatStyle.Flat;
            btnObs.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnObs.Location = new Point(485, 60);
            btnObs.Margin = new Padding(0);
            btnObs.Name = "btnObs";
            btnObs.Size = new Size(75, 29);
            btnObs.TabIndex = 11;
            btnObs.Text = "OK";
            btnObs.UseVisualStyleBackColor = false;
            btnObs.Click += btnObs_Click;
            // 
            // frmObs
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(572, 99);
            Controls.Add(btnObs);
            Controls.Add(lblTitulo);
            Controls.Add(txtObs);
            Controls.Add(lblObs);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmObs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmObs";
            Load += frmObs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblObs;
        private Label lblTitulo;
        private Button btnObs;
        public TextBox txtObs;
    }
}