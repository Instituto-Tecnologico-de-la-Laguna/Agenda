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
        Datos datos= new Datos();
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
    }
}
