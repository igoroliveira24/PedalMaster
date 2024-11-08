using PedalMasterLib;
using SysPecNSLib;
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
            FrmLogin frmLogin = new();
            frmLogin.ShowDialog();
            Text += $" ({Program.EmailUsuarioLogado.Emails})";
            if (Program.UsuarioLogado.Id > 0)
            {
                toolStripStatusLabel1.Text = $" {Program.UsuarioLogado.Nome} - {Program.UsuarioLogado.IdFuncionarios.Cargo}";
                if (Program.UsuarioLogado.IdFuncionarios.Id == 3)
                {
                    clientestsmi.Enabled = false;
                    funcionariostsmi.Enabled = false;
                    tsddbCaixa.Enabled = false;
                }
                if (Program.UsuarioLogado.IdFuncionarios.Id == 4)
                {
                    funcionariostsmi.Enabled = false;
                    produtostsmi.Enabled = false;
                    tsddbCaixaEstoque.Enabled = false;
                }
            }
            else{
                Close();
            }
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
            Program.frmpreguiça.Quantidade = 1;
            FrmEstoque frmestoquetodos = new();
            frmestoquetodos.MdiParent = this;
            frmestoquetodos.Show();

        }

        private void emEstoqueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Program.frmpreguiça.Quantidade = 2;
            FrmEstoque frmestoquetodos = new();
            frmestoquetodos.MdiParent = this;
            frmestoquetodos.Show();

        }

        private void emFaltaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.frmpreguiça.Quantidade = 3;
            FrmEstoque frmestoquetodos = new();
            frmestoquetodos.MdiParent = this;
            frmestoquetodos.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frmpedidonovo = new();
            frmpedidonovo.MdiParent = this;
            frmpedidonovo.Show();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
