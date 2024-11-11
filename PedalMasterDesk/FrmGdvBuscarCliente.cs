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
    public partial class FrmGdvBuscarCliente : Form
    {
        public FrmGdvBuscarCliente()
        {
            InitializeComponent();
        }

        private void FrmGdvBuscarCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid(txtBuscar.Text);
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Cliente.ObterLista(nome);
            dataGridView1.Rows.Clear();
            int cont = 0;


            foreach (var cliente in lista)// para cada usuario na lista
            {
                dataGridView1.Rows.Add();//linhas do datagrid usuarios adiciona
                dataGridView1.Rows[cont].Cells[0].Value = cliente.Id;//linhas do datagrid usuarios com linha varivael cont e coluna 0 vale usuario id
                dataGridView1.Rows[cont].Cells[1].Value = cliente.Nome;//linhas do datagrid usuarios com linha varivael cont e coluna 2 vale usuario Email
                dataGridView1.Rows[cont].Cells[2].Value = cliente.Cpf;//linhas do datagrid usuarios com linha varivael cont e coluna 3 vale nome de objeto nivel com a variavel usuario

                cont++;//{cont esta em loop para listar os usuarios}
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dataGridView1.CurrentRow.Index;
            Program.frmGdvBuscarCliente.Id = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[0].Value);
            Program.frmGdvBuscarCliente.Nome = Convert.ToString(dataGridView1.Rows[PosicaoLinha].Cells[1].Value);
            Program.frmGdvBuscarCliente.Cpf = Convert.ToString(dataGridView1.Rows[PosicaoLinha].Cells[2].Value);
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FrmGdvBuscarCliente_Load(sender, e);
        }
    }
}
