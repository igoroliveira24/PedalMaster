using PedalMasterLib;
using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedalMasterDesk
{
    public partial class FrmEstoqueTodos : Form
    {
        public FrmEstoqueTodos()
        {
            InitializeComponent();
        }

        private void FrmEstoqueTodos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        public void CarregaGrid()
        {
            var lista = Estoque.ObterListaPorProdutoIdEstoqueTodos();
            dtgEstoque.Rows.Clear();
            int cont = 0;


            foreach (var estoque in lista)// para cada usuario na lista
            {
                dtgEstoque.Rows.Add();//linhas do datagrid usuarios adiciona
                dtgEstoque.Rows[cont].Cells[0].Value = estoque.Id;
                dtgEstoque.Rows[cont].Cells[1].Value = estoque.ProdutoId.Nome;
                dtgEstoque.Rows[cont].Cells[2].Value = estoque.ProdutoId.CodBar;
                dtgEstoque.Rows[cont].Cells[3].Value = estoque.Quantidade;
                dtgEstoque.Rows[cont].Cells[4].Value = estoque.ProdutoId.EstoqueMin;


                cont++;//{cont esta em loop para listar os usuarios}
            }
        }

        private void dtgEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dtgEstoque.CurrentRow.Index;
            Program.frmdgvEstoque.Id = Convert.ToInt32(dtgEstoque.Rows[PosicaoLinha].Cells[0].Value);
            Close();
            FrmDgvEstoque frmdgvestoque = new();
            frmdgvestoque.ShowDialog();
        }

        private void dtgEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
