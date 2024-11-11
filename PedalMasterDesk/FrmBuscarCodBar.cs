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
    public partial class FrmBuscarCodBar : Form
    {
        public FrmBuscarCodBar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CarregaGrid()
        {
            var lista = Produto.ObterLista();

            dataGridView1.Rows.Clear();
            int cont = 0;


            foreach (var produto in lista)// para cada usuario na lista
            {
                dataGridView1.Rows.Add();//linhas do datagrid usuarios adiciona
                dataGridView1.Rows[cont].Cells[0].Value = produto.Id;
                dataGridView1.Rows[cont].Cells[1].Value = produto.Nome;
                cont++;//{cont esta em loop para listar os usuarios}


            }

        }
        
}
}
