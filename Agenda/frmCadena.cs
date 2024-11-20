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
    public partial class frmCadena : Form
    {
        public frmCadena()
        {
            InitializeComponent();
        }

        private void btnClave_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre=txtNombre.Text;
            int num = nombre.Length;
            nombre = nombre.Substring(0, 3);
            MessageBox.Show(nombre);
        }
    }
}
