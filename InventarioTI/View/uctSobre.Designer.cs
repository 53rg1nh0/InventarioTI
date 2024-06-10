namespace InventarioTI.View
{
    partial class uctSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctSobre));
            lblSobre = new Label();
            ptbSobre = new PictureBox();
            ptbSobreSolar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbSobre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSobreSolar).BeginInit();
            SuspendLayout();
            // 
            // lblSobre
            // 
            lblSobre.AutoSize = true;
            lblSobre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSobre.Location = new Point(381, 61);
            lblSobre.Name = "lblSobre";
            lblSobre.Size = new Size(667, 231);
            lblSobre.TabIndex = 0;
            lblSobre.Text = resources.GetString("lblSobre.Text");
            // 
            // ptbSobre
            // 
            ptbSobre.BackgroundImage = Properties.Resources.Programa;
            ptbSobre.BackgroundImageLayout = ImageLayout.Stretch;
            ptbSobre.Location = new Point(88, 61);
            ptbSobre.Name = "ptbSobre";
            ptbSobre.Size = new Size(290, 290);
            ptbSobre.TabIndex = 1;
            ptbSobre.TabStop = false;
            // 
            // ptbSobreSolar
            // 
            ptbSobreSolar.BackgroundImage = Properties.Resources.SolarCocaCola;
            ptbSobreSolar.BackgroundImageLayout = ImageLayout.Stretch;
            ptbSobreSolar.Location = new Point(770, 257);
            ptbSobreSolar.Name = "ptbSobreSolar";
            ptbSobreSolar.Size = new Size(278, 94);
            ptbSobreSolar.TabIndex = 2;
            ptbSobreSolar.TabStop = false;
            // 
            // uctSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ptbSobreSolar);
            Controls.Add(ptbSobre);
            Controls.Add(lblSobre);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "uctSobre";
            Size = new Size(1084, 473);
            ((System.ComponentModel.ISupportInitialize)ptbSobre).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSobreSolar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSobre;
        private PictureBox ptbSobre;
        private PictureBox ptbSobreSolar;
    }
}
