using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmMostrarUsuarios : Form
    {
        public frmMostrarUsuarios()
        {
            InitializeComponent();
        }
        Datos datos = new Datos();
        private void frmMostrarUsuarios_Load(object sender, EventArgs e)
        {
            DataSet ds;
            ds = datos.consulta("Select Nombre, APaterno,Amaterno,CURP," +
                "FechaNacimiento,Sexo From Usuarios");
            if (ds != null)
            {
                dgvUsuarios.DataSource = ds.Tables[0];
            }
        }

        private void toolStripMenuEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                frmAC editar = new frmAC(
                    dgvUsuarios[0, dgvUsuarios.SelectedRows[0].Index].Value.ToString(),
                    dgvUsuarios[1, dgvUsuarios.SelectedRows[0].Index].Value.ToString(),
                    dgvUsuarios[2, dgvUsuarios.SelectedRows[0].Index].Value.ToString(),
                    dgvUsuarios[3, dgvUsuarios.SelectedRows[0].Index].Value.ToString(),
                    dgvUsuarios[4, dgvUsuarios.SelectedRows[0].Index].Value.ToString(),
                    dgvUsuarios[5, dgvUsuarios.SelectedRows[0].Index].Value.ToString());
                editar.ShowDialog();
            }
            else { MessageBox.Show("Debe seleccionar un registro", "Sistema", MessageBoxButtons.OK, 
                MessageBoxIcon.Error); }
        }
    }
}
