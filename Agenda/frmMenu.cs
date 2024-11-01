namespace Agenda
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAC usuarios= new frmAC();
            usuarios.Show();
        }
    }
}
