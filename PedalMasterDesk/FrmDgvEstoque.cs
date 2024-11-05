using PedalMasterLib;
using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedalMasterDesk
{
    public partial class FrmDgvEstoque : Form
    {
        public int EstoqueIdUNiQ { get; set; }
        public int EstoqueId{ get; set; }
        public int ProdutoId { get; set; }
        public FrmDgvEstoque()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmDgvEstoque_Load(object sender, EventArgs e)
        {

            var input = Estoque.ObterCorPorProdutoId(Program.frmdgvEstoque.Id);
            cmbCorEstoque.DataSource = input.Cor.Split(',');
            CarregaGrid();
            var estoque = Estoque.ObterPorId(Program.frmdgvEstoque.Id);
            ProdutoId = estoque.ProdutoId.Id;
            EstoqueIdUNiQ = estoque.Id;

        }

        private void dtgEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CarregaGrid()
        {

            var estoque = Estoque.ObterPorId(Program.frmdgvEstoque.Id);
            var lista = Estoque.ObterEstoquePorProdutoId(estoque.ProdutoId.Id);
            dtgEstoque.Rows.Clear();
            int cont = 0;


            foreach (var estoquelista in lista)// para cada usuario na lista
            {
                dtgEstoque.Rows.Add();//linhas do datagrid usuarios adiciona
                dtgEstoque.Rows[cont].Cells[0].Value = estoquelista.Id;
                dtgEstoque.Rows[cont].Cells[1].Value = estoquelista.ProdutoId.Nome;
                dtgEstoque.Rows[cont].Cells[2].Value = estoquelista.ProdutoId.CodBar;
                dtgEstoque.Rows[cont].Cells[3].Value = estoquelista.Quantidade;
                dtgEstoque.Rows[cont].Cells[4].Value = estoquelista.ProdutoId.EstoqueMin;
                dtgEstoque.Rows[cont].Cells[5].Value = estoquelista.Cor;


                cont++;//{cont esta em loop para listar os usuarios}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nudQuantidadeEstoque.Enabled = true;
            btnAdicionar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void dtgEstoque_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dtgEstoque.CurrentRow.Index;
            cmbCorEstoque.Text = dtgEstoque.Rows[PosicaoLinha].Cells[5].Value.ToString();
            nudQuantidadeEstoque.Value = Convert.ToInt32(dtgEstoque.Rows[PosicaoLinha].Cells[3].Value);
            EstoqueId = Convert.ToInt32(dtgEstoque.Rows[PosicaoLinha].Cells[0].Value);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            nudQuantidadeEstoque.Enabled = true;
            cmbCorEstoque.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnAdicionar.Enabled)
            {
                Estoque estoque = new();
                var estoqueCor = Estoque.VerificarCor(cmbCorEstoque.SelectedValue.ToString(),ProdutoId);
                if (estoqueCor.Cor != null)
                {
                    MessageBox.Show("Já existe um cadastro para esta cor");
                }
                else
                {
                    estoque.Inserir(ProdutoId, (int)nudQuantidadeEstoque.Value, cmbCorEstoque.SelectedValue.ToString());
                    estoque.AlterarEstoque(EstoqueIdUNiQ, ProdutoId);
                    FrmDgvEstoque_Load(sender, e);
                }
                

                   
            }
        }
    }
}
