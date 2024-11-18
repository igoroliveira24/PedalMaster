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
    public partial class FrmFinalizarPedido : Form
    {
        public FrmFinalizarPedido()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void FrmFinalizarPedido_Load(object sender, EventArgs e)
        {
            var itempedido = ItemPedido.ObterValorTotal(Program.VARFinalizarpedidoNovo.Id);
            txtTotal.Text = itempedido.ValorUnit.ToString("#0.00");
            txtAberto.Text = itempedido.ValorUnit.ToString("#0.00");


        }

        public void CarregaGrid()
        {
            var lista = Pagamentos.ObterListaPagamentosPorPedido(Program.VARFinalizarpedidoNovo.Id);

            dataGridView1.Rows.Clear();
            int cont = 0;

            foreach (var pagamentos in lista)// para cada usuario na lista
            {
                dataGridView1.Rows.Add();//linhas do datagrid usuarios adiciona
                dataGridView1.Rows[cont].Cells[0].Value = cont + 1;
                dataGridView1.Rows[cont].Cells[1].Value = pagamentos.Tipo;
                dataGridView1.Rows[cont].Cells[2].Value = pagamentos.Valor;
                dataGridView1.Rows[cont].Cells[3].Value = pagamentos.Parcelas;


                cont++;//{cont esta em loop para listar os usuarios}
            }
        }

        private void txtRecebido_TextChanged(object sender, EventArgs e)
        {


            if (txtRecebido.Text != string.Empty)
            {
                if (double.Parse(txtRecebido.Text) > double.Parse(txtTotal.Text))
                {
                    txtRecebido.Text = txtTotal.Text;
                }
            }
            else
            {
                txtRecebido.Text = "0";
            }



        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            /*if ()
            {

            }*/

            Pagamentos pagamentos = new(
                double.Parse(txtRecebido.Text),
                cmbparcelas.SelectedItem.ToString(),
                Pedidos.ObterPorId(Program.VARFinalizarpedidoNovo.Id),
                cmbFrmPag.SelectedItem.ToString()
                );
            pagamentos.Inserir();

            var valorrestante = double.Parse(txtTotal.Text) - double.Parse(txtRecebido.Text);
            if (valorrestante > 0)
            {
                txtAberto.Text = valorrestante.ToString("#0.00");
            }
            else
            {
                Close();
            }
            CarregaGrid();
        }

        private void cmbFrmPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFrmPag.SelectedItem.ToString() == "C. CRÉDITO")
            {
                cmbparcelas.Enabled = true;
                var x = 2;
                var y = 2;
                var valorparaParcela = 100;
                var valoresmatriz = "1X";

                while (valorparaParcela <= double.Parse(txtRecebido.Text))
                {
                    x++;
                    valorparaParcela += 50;
                }
                while (y < x)
                {
                    valoresmatriz += "," + y.ToString() + "X";
                    y++;
                }

                cmbparcelas.DataSource = valoresmatriz.Split(',');

            }
            btnProsseguir.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }
    }
}
