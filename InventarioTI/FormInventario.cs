using InventarioTI.Extencions;
using InventarioTI.Services;
using InventarioTI.View;
using Microsoft.Win32;
using Org.BouncyCastle.Crypto.Generators;
using System.Data;
using System.Numerics;
using InventarioTI.Entites.emuns;

namespace InventarioTI
{
    public partial class FormInventario : Form
    {
        public Dictionary<string, Object[]> Paginas { get; set; } = new Dictionary<string, Object[]>();

        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {

            Excel.Abrir(new Conection<Inventario>(new Inventario()).Path);

            Properties.Settings.Default.Resolucao = Properties.Settings.Default.Resolucao == 0 ? 144f : Properties.Settings.Default.Resolucao;

            Properties.Settings.Default.Save();

            Base.FI = this;

            this.Escala();
            this.Arrastar();
            if (Properties.Settings.Default.Resolucao == 144f)
            {
                ptbHome.Padding = new Padding(13, 5, 0, 0);
                ptbAjustes.Padding = new Padding(13, 5, 0, 0);
                ptbSobre.Padding = new Padding(13, 5, 0, 0);
            }

            ttpForm.SetToolTip(ptbFechar, "Fechar");
            ttpForm.SetToolTip(ptbMinimizar, "Minimizar");
            ttpForm.SetToolTip(ptbHome, "Home");
            ttpForm.SetToolTip(ptbAjustes, "Ajustes");
            ttpForm.SetToolTip(ptbSobre, "Sobre o Software");
            ttpForm.SetToolTip(uctHome.ptbAdicionarCLinete, "Adicionar Cliente");
            ttpForm.SetToolTip(uctHome.ptbEditarCliente, "Editar Cliente");
            ttpForm.SetToolTip(uctHome.ptbRemoverCliente, "Remover Cliente");
            ttpForm.SetToolTip(uctHome.ptbApagarCampoCliente, "Apagar Campos");
            ttpForm.SetToolTip(uctHome.ptbGerarTermo, "Gerar Termo");
            ttpForm.SetToolTip(uctHome.MoverCliente, "Remover Cliente");
            ttpForm.SetToolTip(uctHome.ptbAdicionarEquipamento, "Adicionar Equipamento");
            ttpForm.SetToolTip(uctHome.ptbEditarEquipamento, "Editar Equipamento");
            ttpForm.SetToolTip(uctHome.ptbApagarEquipamento, "Apagar Campos");
            ttpForm.SetToolTip(uctHome.ptbRemoverEquipamento, "Remover Equipamentos");
            ttpForm.SetToolTip(uctHome.ptbMoverEquipamento, "Mover Equipamento");
            ttpForm.SetToolTip(uctHome.ptbTrocar, "Trocar equipamento");

            Paginas.Add("Home", new object[3] { Properties.Resources.HomeAnimado, ptbHome, uctHome });

            Paginas.Add("Ajustes", new object[3] { Properties.Resources.AjustesAnimado, ptbAjustes, uctAjustes });

            Paginas.Add("Sobre", new object[3] { Properties.Resources.SobreAnimado, ptbSobre, uctSobre });

            PassarPagina("Home");

            if (!string.IsNullOrEmpty(uctAjustes.cbxUnidade.Text))
            {
                Atualizar();
                uctHome.Atualizar();
            }
        }

        private void PassarPagina(string pagina)
        {

            ptbHome.Image = Properties.Resources.Home;
            ptbHome.BackColor = Color.Transparent;
            uctHome.Visible = false;
            uctHome.Dock = DockStyle.None;
            ptbAjustes.Image = Properties.Resources.Ajustes;
            ptbAjustes.BackColor = Color.Transparent;
            uctAjustes.Visible = false;
            uctAjustes.Dock = DockStyle.None;
            ptbSobre.Image = Properties.Resources.Sobre;
            ptbSobre.BackColor = Color.Transparent;
            uctSobre.Visible = false;
            uctSobre.Dock = DockStyle.None;

            PictureBox p = Paginas[pagina][1] as PictureBox;
            UserControl u = Paginas[pagina][2] as UserControl;
            p.Image = Paginas[pagina][0] as Image;
            p.BackColor = Color.White;
            u.Visible = true;
            u.Dock = DockStyle.Fill;
        }

        public void Atualizar()
        {
            if (!string.IsNullOrEmpty(Base.Unidade))
            {
                lblUnidade.Text = Base.Unidades.FirstOrDefault(u => u.Sigla == Base.Unidade).Nome;
                if (Properties.Settings.Default.Unidade == "MRC")
                {
                    lblBotton1.Text = "BKP + EST:";
                    lblBotton0.Text = "BKP + EST:";
                }
                else
                {
                    lblBotton1.Text = "Backup:";
                    lblBotton0.Text = "Backup:";
                }
                lblNotEst.Text = Properties.Settings.Default.Unidade == "MRC" ? Quantidade.NotBkp.ToString() + " + " + Quantidade.NotEst.ToString() : Quantidade.NotEst.ToString();
                lblDeskEst.Text = Properties.Settings.Default.Unidade == "MRC" ? Quantidade.DesBkp.ToString() + " + " + Quantidade.DesEst.ToString() : Quantidade.DesEst.ToString();
                lblDeskAtv.Text = Quantidade.DesAtv.ToString();
                lblNotAtv.Text = Quantidade.NotAtv.ToString();
                lblTotal.Text = (Quantidade.NotEst + Quantidade.DesEst + Quantidade.NotBkp + Quantidade.DesBkp + Quantidade.NotAtv + Quantidade.DesAtv).ToString();

                uctHome.Atualizar();
            }
        }

        private void ptbFechar_Click(object sender, EventArgs e)
        {
            Excel.Fechar();
            this.Close();
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbHome_Click(object sender, EventArgs e)
        {
            PassarPagina("Home");
        }

        private void ptbAjustes_Click(object sender, EventArgs e)
        {
            PassarPagina("Ajustes");
        }

        private void ptbSobre_Click(object sender, EventArgs e)
        {
            PassarPagina("Sobre");
        }

        private void ptbPrograma_Click(object sender, EventArgs e)
        {
            cbxResolucao.Visible = true;
        }

        private void cbxResolucao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxResolucao.Visible = false;
            if (cbxResolucao.Text == "100%")
            {
                Properties.Settings.Default.Resolucao = 96f;
            }
            else
            {
                Properties.Settings.Default.Resolucao = 144f;
            }
            Properties.Settings.Default.Save();
            System.Windows.Forms.Application.Restart();
        }
    }
}