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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PedalMasterDesk
{
    public partial class FrmPedidoNovo : Form
    {
        public int idPedido { get; set; }
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dataGridView1.CurrentRow.Index;
            var quantidade = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[3].Value);
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["buttonmenos"].Index)
                {
                    if (quantidade > 1)
                    {
                        quantidade -= 1;
                        ItemPedido itempedido = new(
                            Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[0].Value),
                            quantidade
                            );
                        itempedido.Atualizar();
                        CarregaGrid();
                    }

                }
                if (e.ColumnIndex == dataGridView1.Columns["buttonmais"].Index)
                {
                    quantidade += 1;
                    ItemPedido itempedido = new(
                        Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[0].Value),
                        quantidade
                        );
                    itempedido.Atualizar();
                    CarregaGrid();
                }
            }
        }

        public void CarregaGrid()
        {
            var lista = ItemPedido.ObterListaPorPedido(3);

            dataGridView1.Rows.Clear();
            int cont = 0;


            foreach (var estoque in lista)// para cada usuario na lista
            {
                dataGridView1.Rows.Add();//linhas do datagrid usuarios adiciona
                dataGridView1.Rows[cont].Cells[0].Value = estoque.Id;
                dataGridView1.Rows[cont].Cells[1].Value = estoque.Produto.CodBar;
                dataGridView1.Rows[cont].Cells[3].Value = estoque.Quantidade;

                cont++;//{cont esta em loop para listar os usuarios}


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (this.dataGridView1.Columns["buttonmenos"].Index ==
                e.ColumnIndex && e.RowIndex >= 0)
            {


                e.Paint(e.CellBounds, DataGridViewPaintParts.Background);

                var w = Properties.Resources.botao_de_menos.Width / 25;
                var h = (Properties.Resources.botao_de_menos.Height / 25);
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.botao_de_menos, new Rectangle(x, y, w, h));
                e.Handled = true;

            }

            if (this.dataGridView1.Columns["buttonmais"].Index ==
                e.ColumnIndex && e.RowIndex >= 0)
            {


                e.Paint(e.CellBounds, DataGridViewPaintParts.Background);

                var w = Properties.Resources.botao_mais.Width / 15;
                var h = (Properties.Resources.botao_mais.Height / 15);
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.botao_mais, new Rectangle(x, y, w, h));
                e.Handled = true;

            }

            if (this.dataGridView1.Columns["Remover"].Index ==
               e.ColumnIndex && e.RowIndex >= 0)
            {


                e.Paint(e.CellBounds, DataGridViewPaintParts.Background);

                var w = Properties.Resources.lixeira.Width / 25;
                var h = (Properties.Resources.lixeira.Height / 25);
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.lixeira, new Rectangle(x, y, w, h));
                e.Handled = true;

            }


        }






        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
