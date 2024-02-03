using InventarioTI.Entites.Exceptions;
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
        }

        private void btnAcessorio_Click(object sender, EventArgs e)
        {
            try
            {
                Termo.PDF(Base.Inv.Where(x => x.USERID == Cache.Cliente).ToList(), ListaAcessorio());
                lblMensagem.Visible = true;

                Task.Run(() =>
                {
                    Thread.Sleep(1600);
                    this.Close();
                });
            }
            catch (DomainException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string ListaAcessorio()
        {
            string acessorios = "";
            foreach (Control item in this.Controls)
            {
                if (item is CheckBox && (item as CheckBox).Checked)
                {
                    acessorios += item.Text + ", ";
                }
            }
            return acessorios.Trim(' ').Trim(',');
        }

        private void frmAcessorios_Load(object sender, EventArgs e)
        {
            this.Escala();
            ckbCarregador.Visible = Computador == "Notebook";
            ckbMochila.Visible = Computador == "Notebook";
            ckbMouse.Visible = Computador == "Notebook";
            ckbTeclado.Visible = Computador == "Notebook";
            this.Location = new Point(Base.FI.Location.X + 375, Base.FI.Location.Y + 82);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
