using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmDataGridView : Form
    {
        bool bandera = false;
        public frmDataGridView()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                dgPrueba.AllowUserToAddRows = false;
                bandera = true;
            }
            else
            {
                dgPrueba.AllowUserToAddRows = true;
                bandera = false;
            }
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            frmPrueba2 prb = new frmPrueba2(0);
            prb.ShowDialog();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            dgPrueba.Columns["prueba"].Visible = false;
        }
    }
}
