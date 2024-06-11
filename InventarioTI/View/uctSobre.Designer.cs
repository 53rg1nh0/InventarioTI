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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ptbSobre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSobreSolar).BeginInit();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(770, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 94);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 44);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 0;
            label1.Text = "LOGO EMPRESA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(782, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 20);
            panel2.TabIndex = 4;
            // 
            // uctSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ptbSobreSolar);
            Controls.Add(ptbSobre);
            Controls.Add(lblSobre);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "uctSobre";
            Size = new Size(1084, 473);
            ((System.ComponentModel.ISupportInitialize)ptbSobre).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSobreSolar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSobre;
        private PictureBox ptbSobre;
        private PictureBox ptbSobreSolar;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}
