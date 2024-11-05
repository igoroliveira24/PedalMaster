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

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario frmFuncionario = new();
            frmFuncionario.MdiParent = this;
            frmFuncionario.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaFuncionarios frmListaFuncionarios = new();
            frmListaFuncionarios.MdiParent = this;
            frmListaFuncionarios.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProdutos frmprodutos = new();
            frmprodutos.MdiParent = this;
            frmprodutos.Show();
        }

        private void lisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaClientes frmlistacliente = new();
            frmlistacliente.MdiParent = this;
            frmlistacliente.Show();
        }

        private void emEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstoqueTodos frmestoquetodos = new();
            frmestoquetodos.MdiParent = this;
            frmestoquetodos.Show();
        }
    }
}
