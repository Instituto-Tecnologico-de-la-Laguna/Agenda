using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agenda
{
    public partial class frmAC : Form
    {
        bool bandera = false;
        int id;
        Datos datos = new Datos();
        public frmAC()
        {
            InitializeComponent();
        }

        public frmAC(string id, string nombre, string apaterno, string amaterno, string CURP, string fecha, string sexo)
        {
            InitializeComponent();
            this.id = Convert.ToInt32(id);
            txtNombre.Text = nombre;
            txtPaterno.Text = apaterno;
            txtMaterno.Text = amaterno;
            mtbCurp.Text = CURP;
            dtpFecha.Value = Convert.ToDateTime(fecha);
            cmbSexo.Text = sexo;
            bandera = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos son correctos?", "Sistema"
                , MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {
                    bool j = datos.ejecutarABC("Update Usuarios Set nombre='" + txtNombre.Text +
                        "', apaterno='" + txtPaterno.Text + "',amaterno='" + txtMaterno.Text +
                        "',curp='" + mtbCurp.Text + "',fechaNacimiento='" + dtpFecha.Value.ToString ("yyyy-MM-dd") +
                        "',Sexo='" + cmbSexo.Text + "' Where id=" + id);
                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Sistema", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool j = datos.ejecutarABC("Insert Into Usuarios(nombre,apaterno,amaterno," +
                        "curp,fechaNacimiento,sexo)" +
                        " Values('" + txtNombre.Text + "','" + txtPaterno.Text + "'," +
                        "'" + txtMaterno.Text + "','" + mtbCurp.Text + "','" +
                        dtpFecha.Value.ToShortDateString() + "','" + cmbSexo.Text + "')");
                    if (j == true)
                    {
                        MessageBox.Show("Datos Agregados Correctamente", "Sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtMaterno.Clear();
                        txtPaterno.Clear();
                        mtbCurp.Clear();
                        cmbSexo.Text = "";

                    }

                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    }

                }
            }

        }
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { errorProvider1.SetError(txtNombre, "Por favor, ingresa un valor"); }
            else
            {
                errorProvider1.SetError(txtNombre, string.Empty);
            }
        }
    }

}