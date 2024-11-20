using Google.Protobuf.WellKnownTypes;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PedalMasterDesk
{
    public partial class FrmPedidoNovo : Form
    {
        public int idPedido { get; set; }
        public string CodBar { get; set; }
        public int removerdgv { get; set; }
        public double valunit { get; set; }
        public double desc { get; set; }
        public int quant { get; set; }

        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dataGridView1.CurrentRow.Index;
            var quantidade = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[3].Value);
            var senderGrid = (DataGridView)sender;
            removerdgv = 0;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["buttonmenos"].Index)
                {
                    if (quantidade > 1)
                    {
                        quantidade = quantidade - 1;
                        var desconto = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[6].Value);
                        if (quantidade < 10)
                        {
                            desconto = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[6].Value) - 10;
                        }
                        ItemPedido itempedido = new(
                            Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[9].Value),
                            quantidade,
                            desconto
                            );
                        itempedido.Atualizar();








                        /*if (Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[3].Value) < 10)
                        {
                            itempedido.AtualizarDescontoAtacado(Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[6].Value), Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[9].Value));
                        }*/


                    }

                }
                if (e.ColumnIndex == dataGridView1.Columns["buttonmais"].Index)
                {
                    quantidade += 1;
                    var desconto = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[6].Value);
                    if (quantidade == 10)
                    {
                        desconto = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[6].Value) + 10;
                    }
                    ItemPedido itempedido = new(
                        Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[9].Value),
                        quantidade,
                        desconto
                        );
                    itempedido.Atualizar();






                }
                if (e.ColumnIndex == dataGridView1.Columns["Remover"].Index)
                {

                    var id = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[9].Value);
                    var codbar = dataGridView1.Rows[PosicaoLinha].Cells[1].Value.ToString();

                    valunit = Convert.ToDouble(dataGridView1.Rows[PosicaoLinha].Cells[5].Value);
                    quant = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[3].Value);
                    desc = Convert.ToDouble(dataGridView1.Rows[PosicaoLinha].Cells[6].Value);

                    ItemPedido itempedido = new();
                    Produto idProduto = new();
                    idProduto.ObterPorIdPorCodBar(codbar);
                    itempedido.Deletar(id);



                    Estoque estoque = new();
                    estoque = Estoque.ObterQuantidadePorProdutoId(idProduto.Id);
                    var quantidadeEstoque = estoque.Quantidade + 1;
                    estoque.Alterar(quantidadeEstoque, idProduto.Id, "");

                    removerdgv = 1;
                }


            }

            CarregaGrid();
        }

        public void CarregaGrid()
        {

            var lista = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));

            dataGridView1.Rows.Clear();
            int cont = 0;
            double desconto = 0;
            double total = 0;
            double subtotal = 0;

            //int PosicaoLinha = dataGridView1.CurrentRow.Index;
            //var quantidade = Convert.ToInt32(dataGridView1.Rows[PosicaoLinha].Cells[3].Value);

            foreach (var itempedido in lista)// para cada usuario na lista
            {
                dataGridView1.Rows.Add();//linhas do datagrid usuarios adiciona
                dataGridView1.Rows[cont].Cells[0].Value = cont + 1;
                dataGridView1.Rows[cont].Cells[1].Value = itempedido.Produto.CodBar;
                dataGridView1.Rows[cont].Cells[3].Value = itempedido.Quantidade;
                dataGridView1.Rows[cont].Cells[5].Value = itempedido.ValorUnit;
                dataGridView1.Rows[cont].Cells[6].Value = itempedido.Desconto;
                dataGridView1.Rows[cont].Cells[7].Value = itempedido.ValorUnit * itempedido.Quantidade * (1 - (itempedido.Desconto / 100));
                dataGridView1.Rows[cont].Cells[9].Value = itempedido.Id;

                cont++;//{cont esta em loop para listar os usuarios}

                if (removerdgv == 1)
                {
                    total -= valunit * quant * (1 - (desc / 100));
                    subtotal -= valunit * quant;
                    desconto += subtotal - total;

                    total += double.Parse(txtValorTotalPedido.Text);
                    subtotal += double.Parse(txtSubTotaPedido.Text);
                    desconto += double.Parse(txtDescontoProdutos.Text);

                    txtSubTotaPedido.Text = subtotal.ToString("#0.00");
                    txtValorTotalPedido.Text = total.ToString("#0.00");
                    txtDescontoProdutos.Text = desconto.ToString("#0.00");
                }
                else
                {


                    total += itempedido.ValorUnit * itempedido.Quantidade * (1 - (itempedido.Desconto / 100));
                    subtotal += itempedido.ValorUnit * itempedido.Quantidade;
                    desconto = subtotal - total;

                    txtValorTotalPedido.Text = total.ToString("#0.00");
                    txtDescontoProdutos.Text = desconto.ToString("#0.00");
                    txtSubTotaPedido.Text = subtotal.ToString("#0.00");
                }
            }
            if (dataGridView1.RowCount == 0)
            {
                txtSubTotaPedido.Text = "0";
                txtDescontoProdutos.Text = "0";
                txtDescontoEscritoPedido.Text = "0";
                txtValorTotalPedido.Text = "0";
            }



            dataGridView1.Columns[7].DefaultCellStyle.Format = "N2";
            removerdgv = 0;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            if (Program.PedidoemAberto.Id != 0)
            {
                var pedido = Pedidos.ObterPorId(Program.PedidoemAberto.Id);
                txtIdPedido.Text = pedido.Id.ToString();

                var cliente = Cliente.ObterId(pedido.IdCliente.Id);
                txtIdCliente.Text = $" {cliente.Id}";
                txtCpfCliente.Text = $" {cliente.Cpf}";
                txtNomeClientes.Text = $" {cliente.Nome}";

                if (pedido.Id > 0)
                {
                    txtIdPedido.Text = pedido.Id.ToString();

                    txtCodBarPedido.Enabled = true;
                    txtValorUnitPedido.Enabled = true;
                    txtValorTotPedido.Enabled = true;
                    txtDescontoPedido.Enabled = true;
                    btnInserir.Enabled = true;
                    nudQuantidadePedido.Enabled = true;
                    btnBuscarCliente.Enabled = false;
                    btnAdicionaPedido.Enabled = false;
                    btnCancelarPed.Enabled = true;
                    btnManterAberto.Enabled = true;
                    btnFinalizarPedido.Enabled = true;

                    CarregaGrid();



                }
            }


            nudQuantidadePedido.Value = 1;
            txtDescontoPedido.MaxLength = 2;
            txtFuncionarioPedido.Text = Program.UsuarioLogado.Id.ToString() + " - " + Program.UsuarioLogado.Nome;
            if (txtIdPedido.Text != string.Empty)
            {
                CarregaGrid();
            }

            Program.PedidoemAberto.Id = 0;
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
            if (textBoxVazias())
            {
                MessageBox.Show("Preencha todos os campos");

            }
            else
            {
                if (nudQuantidadePedido.Value > 0)
                {
                    Produto idProduto = new();
                    idProduto.ObterPorIdPorCodBar(txtCodBarPedido.Text);
                    double desconto = double.Parse(txtDescontoPedido.Text);
                    if (nudQuantidadePedido.Value >= 10)
                    {
                        desconto = double.Parse(txtDescontoPedido.Text) + 10;
                    }

                    if (idProduto.Id > 0)
                    {

                        Estoque estoque = new();
                        estoque = Estoque.ObterQuantidadePorProdutoId(idProduto.Id);

                        if (estoque.Quantidade > 0)
                        {
                            if (nudQuantidadePedido.Value <= estoque.Quantidade)
                            {
                                ItemPedido itemPedido = new(
                                        Pedidos.ObterPorId(int.Parse(txtIdPedido.Text)),
                                        Produto.ObterPorId(idProduto.Id),
                                        (int)nudQuantidadePedido.Value,
                                        desconto
                                        );

                                itemPedido.Inserir();
                                CarregaGrid();

                                txtCodBarPedido.Clear();
                                txtValorUnitPedido.Clear();
                                txtValorTotPedido.Clear();
                                txtDescontoPedido.Clear();
                                txtDescontoTotal.Clear();
                                nudQuantidadePedido.Value = 1;
                                lblDescontoAtacado.Text = "";
                                lblDescontoVarejo.Text = "";

                            }
                            else
                            {
                                MessageBox.Show("Produto Indisponivel (Estoque Insuficiente)");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Produto Indisponivel (Estoque Insuficiente)");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("A quantidade do produto deve ser superior a 0!!!");
                }
            }


        }

        private void txtDescontoPedido_TextChanged(object sender, EventArgs e)
        {
            if (txtDescontoPedido.Text == string.Empty)
            {
                txtDescontoPedido.Text = "0";
            }

            if (double.Parse(txtDescontoPedido.Text) > double.Parse(txtDescontoTotal.Text))
            {
                txtDescontoPedido.Text = "0";
            }



        }

        private void txtDescontoPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCodBarPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBarPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Produto produto = new();
                produto.ObterPorIdPorCodBar(txtCodBarPedido.Text);
                produto = Produto.ObterPorId(produto.Id);
                if (produto.Id > 0)
                {
                    CodBar = produto.CodBar;
                    txtValorUnitPedido.Text = produto.Preco.ToString();
                    txtValorTotPedido.Text = produto.Preco.ToString();
                    txtDescontoTotal.Text = (produto.Desconto * 100).ToString();
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtClientePedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmGdvBuscarCliente frmGdvBuscarCliente = new();
            frmGdvBuscarCliente.ShowDialog();
            txtIdCliente.Text = $" {Program.frmGdvBuscarCliente.Id}";
            txtCpfCliente.Text = $" {Program.frmGdvBuscarCliente.Cpf}";
            txtNomeClientes.Text = $" {Program.frmGdvBuscarCliente.Nome}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new(
                0,
                Funcionarios.ObrterPorID(Program.UsuarioLogado.Id),
                Cliente.ObterId(int.Parse(txtIdCliente.Text))
                );
            pedidos.Inserir();
            if (pedidos.Id > 0)
            {
                txtIdPedido.Text = pedidos.Id.ToString();

                txtCodBarPedido.Enabled = true;
                txtValorUnitPedido.Enabled = true;
                txtValorTotPedido.Enabled = true;
                txtDescontoPedido.Enabled = true;
                btnInserir.Enabled = true;
                nudQuantidadePedido.Enabled = true;
                btnBuscarCliente.Enabled = false;
                btnAdicionaPedido.Enabled = false;
                btnCancelarPed.Enabled = true;
                btnManterAberto.Enabled = true;
                btnFinalizarPedido.Enabled = true;

                CarregaGrid();

            }
            else
            {
                MessageBox.Show("Houve um erro na criação do pedido");
            }






        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtIdCliente.Text) > 0)
            {
                btnAdicionaPedido.Enabled = true;
            }
        }



        private bool textBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
        }



        private void nudQuantidadePedido_ValueChanged(object sender, EventArgs e)
        {
            if (nudQuantidadePedido.Value <= 0)
            {
                nudQuantidadePedido.Value = 1;
            }
            if (txtValorUnitPedido.Text != string.Empty)
            {
                var valortotal = decimal.Parse(txtValorUnitPedido.Text);



                txtValorTotPedido.Text = (valortotal * nudQuantidadePedido.Value).ToString();
            }


            if (nudQuantidadePedido.Value >= 10)
            {
                lblDescontoAtacado.Text = "10% desconto";
            }
            else
            {
                lblDescontoAtacado.Text = "";
            }

        }

        private void txtValorTotalPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

            if (txtDescontoEscritoPedido.Text == string.Empty)
            {
                txtDescontoEscritoPedido.Text = "0";
            }
            else
            {
                var valortotal = double.Parse(txtSubTotaPedido.Text) - double.Parse(txtDescontoProdutos.Text);

                valortotal -= double.Parse(txtDescontoEscritoPedido.Text);
                if (valortotal > 0)
                {
                    txtValorTotalPedido.Text = valortotal.ToString("#0.00");
                }
                else
                {
                    MessageBox.Show("O desconto do pedido não pode ser maior que o preço total");

                    txtDescontoEscritoPedido.Text = "0";
                }
            }


        }

        private void btnCancelarPed_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Deseja Cancelar esse pedido?", "Cancelar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (message == DialogResult.Yes)
            {

                var linhas = dataGridView1.RowCount;
                var cont = 0;
                if (linhas > 0)
                {
                    while (cont < linhas)
                    {
                        var id = Convert.ToInt32(dataGridView1.Rows[cont].Cells[9].Value);
                        var codbar = dataGridView1.Rows[cont].Cells[1].Value.ToString();

                        ItemPedido itempedido = new();
                        Produto idProduto = new();
                        idProduto.ObterPorIdPorCodBar(codbar);
                        itempedido.Deletar(id);



                        Estoque estoque = new();
                        estoque = Estoque.ObterQuantidadePorProdutoId(idProduto.Id);
                        var quantidadeEstoque = estoque.Quantidade + Convert.ToInt32(dataGridView1.Rows[cont].Cells[3].Value);
                        estoque.Alterar(quantidadeEstoque, idProduto.Id, "");
                        cont++;
                    }

                }

                Pedidos pedido = new();

                pedido.EstatusCancelado(int.Parse(txtIdPedido.Text));

                VoltaraoNormal();
            }

        }

        private void btnManterAberto_Click(object sender, EventArgs e)
        {


            Pedidos pedido = new(
                int.Parse(txtIdPedido.Text),
                "A",
                double.Parse(txtDescontoEscritoPedido.Text)
                );
            pedido.Atualizar();
            //pedido.EstatusAberto(int.Parse(txtIdPedido.Text));
            VoltaraoNormal();


        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            Program.VARFinalizarpedidoNovo.Id = int.Parse(txtIdPedido.Text);
            FrmFinalizarPedido frmfinalizarpedido = new();
            frmfinalizarpedido.ShowDialog();

            Pagamentos pagamento = new();
            pagamento = Pagamentos.ObterValorTotal(int.Parse(txtIdPedido.Text));
            if (pagamento.Valor == double.Parse(txtValorTotalPedido.Text))
            {
                Pedidos pedido = new(
                int.Parse(txtIdPedido.Text),
                "F",
                double.Parse(txtDescontoEscritoPedido.Text)
                );
                pedido.Atualizar();
                VoltaraoNormal();

                MessageBox.Show("Pedido Finalizado com SUCESSO!!!!");
            }
            else
            {
                var message = MessageBox.Show("Houve algum erro na efetuação de pagamento");
                Program.VARFinalizarpedidoNovo.Id = int.Parse(txtIdPedido.Text);
                frmfinalizarpedido.ShowDialog();
            }


        }
        public void VoltaraoNormal()
        {
            txtDescontoEscritoPedido.Text = "0";
            txtIdCliente.Text = "0";
            txtCpfCliente.Clear();
            txtNomeClientes.Clear();
            btnBuscarCliente.Enabled = true;
            btnAdicionaPedido.Enabled = false;
            txtCodBarPedido.Clear();
            txtCodBarPedido.Enabled = false;
            nudQuantidadePedido.Enabled = false;
            txtDescontoTotal.Text = "0";
            txtDescontoPedido.Clear();
            txtDescontoPedido.Enabled = false;
            btnInserir.Enabled = false;
            btnFinalizarPedido.Enabled = false;
            btnManterAberto.Enabled = false;
            btnCancelarPed.Enabled = false;
            txtIdPedido.Text = "0";
            CarregaGrid();

        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            if (txtIdPedido.Text != string.Empty && txtIdPedido.Text != "0")
            {
                MessageBox.Show("Existe um pedido e andamento. Conclua-os antes de fechar o caixa");
            }
            else
            {
                Close();
            }
        }
    }


}
