using PedalMasterLib;
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
    public partial class FrmListaFuncionarios : Form
    {
        public FrmListaFuncionarios()
        {
            InitializeComponent();
            CarregaGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregaGrid()
        {
            var lista = Funcionarios.ObrterLista();
            dataGridView1.Rows.Clear();
            int cont = 0;


            foreach (var funcionarios in lista)// para cada usuario na lista
            {
                dataGridView1.Rows.Add();//linhas do datagrid usuarios adiciona
                dataGridView1.Rows[cont].Cells[0].Value = funcionarios.Id;
                dataGridView1.Rows[cont].Cells[1].Value = funcionarios.Nome;
                dataGridView1.Rows[cont].Cells[2].Value = funcionarios.Cpf;
                dataGridView1.Rows[cont].Cells[3].Value = funcionarios.Rg;
                dataGridView1.Rows[cont].Cells[4].Value = funcionarios.DataNasc;
                dataGridView1.Rows[cont].Cells[5].Value = funcionarios.IdFuncionarios.Cargo;
                dataGridView1.Rows[cont].Cells[6].Value = funcionarios.Ativo;


                cont++;//{cont esta em loop para listar os usuarios}
            }



        }

        private void clik_table_cliente(object sender, EventArgs e)
        {
            // vamos obter a linha da célula selecionada
            DataGridViewRow linhaAtual = dataGridView1.CurrentRow;

            // vamos exibir o índice da linha atual
            int indice = linhaAtual.Index;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dataGridView1.CurrentRow.Index;
            Program.frmDgvFuncionario.Id = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[0].Value);
            Program.frmDgvFuncionario.Nome = dataGridView1.Rows[PosicaoLinha].Cells[1].Value.ToString();
            Close();
            FrmDgvFuncionariosListagem frmDgvFuncionariosListagem = new();
            frmDgvFuncionariosListagem.ShowDialog();
        }

        private void FrmListaFuncionarios_Load(object sender, EventArgs e)
        {

        }
    }
}
