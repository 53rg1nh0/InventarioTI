using InventarioTI.Extencions;
using InventarioTI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTI.View
{
    public partial class frmObs : Form
    {
        public frmObs()
        {
            InitializeComponent();
        }

        private void btnObs_Click(object sender, EventArgs e)
        {
            Cache.Obs = txtObs.Text;
            this.Close();
        }

        private void frmObs_Load(object sender, EventArgs e)
        {
            this.Escala();
        }
    }
}
