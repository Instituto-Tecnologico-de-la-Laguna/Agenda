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
    public partial class frmPrueba2 : Form
    {
        int admin = 0;
        public frmPrueba2(int admin)
        {
            InitializeComponent();
            this.admin = admin;
        }
        public frmPrueba2()
        {
            InitializeComponent();
    
        }

        private void frmPrueba2_Load(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            DataSet ds;
            ds = datos.consulta("Select logo from pub_info where pub_id=0736");
            if (ds != null)
            {
                string hex=ds.Tables[0].ToString();
                byte []r = StringToByteArray(hex);
                pictureBox1.Image = ByteArrayToImage(r);
            }
            if (admin == 1) { 
                btnAdministrador.Visible = false;
            }
           
        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
