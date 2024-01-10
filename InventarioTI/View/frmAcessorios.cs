using InventarioTI.Extencions;
using InventarioTI.Services;
using System.Data;


namespace InventarioTI.View
{
    public partial class frmAcessorios : Form
    {
        public string Computador { get; set; }
        public frmAcessorios(string computador, bool cancel = true)
        {
            Computador = computador;
            InitializeComponent();
            btnCancel.Visible = cancel;
            ckbComputador.Visible = false;
        }

        private void btnAcessorio_Click(object sender, EventArgs e)
        {
           

        }

        private void frmAcessorios_Load(object sender, EventArgs e)
        {
            this.Escala();
            ckbCarregador.Visible = Computador == "Notebook";
            ckbMochila.Visible = Computador == "Notebook";
            ckbMouse.Visible = Computador == "Notebook";
            ckbTeclado.Visible = Computador == "Notebook";

            ckbComputador.Checked = true;
            ckbComputador.Enabled = false;

            btnAcessorio.Text = "Aplicar";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
