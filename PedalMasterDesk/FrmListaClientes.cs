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
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregaGrid()
        {
            var lista = Cliente.ObterLista();
            dataGridView1.Rows.Clear();
            int cont = 0;


            foreach (var cliente in lista)// para cada usuario na lista
            {
                dataGridView1.Rows.Add();//linhas do datagrid usuarios adiciona
                dataGridView1.Rows[cont].Cells[0].Value = cliente.Id;
                dataGridView1.Rows[cont].Cells[1].Value = cliente.Nome;
                dataGridView1.Rows[cont].Cells[2].Value = cliente.Cpf;
                dataGridView1.Rows[cont].Cells[3].Value = cliente.DataNasc;
                dataGridView1.Rows[cont].Cells[4].Value = cliente.DataCad;
                dataGridView1.Rows[cont].Cells[5].Value = cliente.Ativo;


                cont++;//{cont esta em loop para listar os usuarios}
            }



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dataGridView1.CurrentRow.Index;
            Program.frmDgvCliente.Id = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[0].Value);
            Program.frmDgvCliente.Nome = dataGridView1.Rows[PosicaoLinha].Cells[1].Value.ToString();
            Close();
            FrmDgvListaClientes frmdgvlistaclientes = new();
            frmdgvlistaclientes.ShowDialog();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
