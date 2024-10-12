using System.ComponentModel;

namespace PedalMasterDesk
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmClientes = new();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
        
        }
 
    }
}
