using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZarateSP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmInicio ventanaInicio = new frmInicio();
            ventanaInicio.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmInicio ventanaInicio = new frmInicio();
            ventanaInicio.ShowDialog();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
