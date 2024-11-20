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
    public partial class FrmTodosPedidos : Form
    {
        public FrmTodosPedidos()
        {
            InitializeComponent();
        }

        private void FrmTodosPedidos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        public void CarregaGrid()
        {
            if (Program.frmpreguiça.Quantidade == 1)
            {
                var lista = Pedidos.ObterLista();

                dtgPedido.Rows.Clear();
                int cont = 0;


                foreach (var pedidos in lista)// para cada usuario na lista
                {
                    dtgPedido.Rows.Add();//linhas do datagrid usuarios adiciona
                    dtgPedido.Rows[cont].Cells[0].Value = pedidos.Id;
                    dtgPedido.Rows[cont].Cells[1].Value = pedidos.Estatus;
                    dtgPedido.Rows[cont].Cells[2].Value = pedidos.Desconto;
                    dtgPedido.Rows[cont].Cells[3].Value = pedidos.DatPed;
                    dtgPedido.Rows[cont].Cells[4].Value = pedidos.IdFuncionarios.Nome;
                    dtgPedido.Rows[cont].Cells[5].Value = pedidos.IdCliente.Id;
                    cont++;//{cont esta em loop para listar os usuarios}


                }
            }
            else
            {
                if (Program.frmpreguiça.Quantidade == 2)
                {
                    var lista = Pedidos.ObterListaFechado();

                    dtgPedido.Rows.Clear();
                    int cont = 0;


                    foreach (var pedidos in lista)// para cada usuario na lista
                    {
                        dtgPedido.Rows.Add();//linhas do datagrid usuarios adiciona
                        dtgPedido.Rows[cont].Cells[0].Value = pedidos.Id;
                        dtgPedido.Rows[cont].Cells[1].Value = pedidos.Estatus;
                        dtgPedido.Rows[cont].Cells[2].Value = pedidos.Desconto;
                        dtgPedido.Rows[cont].Cells[3].Value = pedidos.DatPed;
                        dtgPedido.Rows[cont].Cells[4].Value = pedidos.IdFuncionarios.Nome;
                        dtgPedido.Rows[cont].Cells[5].Value = pedidos.IdCliente.Id;
                        cont++;//{cont esta em loop para listar os usuarios}


                    }
                }

                if (Program.frmpreguiça.Quantidade == 3)
                {
                    var lista = Pedidos.ObterListaEmAberto();

                    dtgPedido.Rows.Clear();
                    int cont = 0;


                    foreach (var pedidos in lista)// para cada usuario na lista
                    {
                        dtgPedido.Rows.Add();//linhas do datagrid usuarios adiciona
                        dtgPedido.Rows[cont].Cells[0].Value = pedidos.Id;
                        dtgPedido.Rows[cont].Cells[1].Value = pedidos.Estatus;
                        dtgPedido.Rows[cont].Cells[2].Value = pedidos.Desconto;
                        dtgPedido.Rows[cont].Cells[3].Value = pedidos.DatPed;
                        dtgPedido.Rows[cont].Cells[4].Value = pedidos.IdFuncionarios.Nome;
                        dtgPedido.Rows[cont].Cells[5].Value = pedidos.IdCliente.Id;
                        cont++;//{cont esta em loop para listar os usuarios}


                    }
                }

                if (Program.frmpreguiça.Quantidade == 4)
                {
                    var lista = Pedidos.ObterListaCancelado();

                    dtgPedido.Rows.Clear();
                    int cont = 0;


                    foreach (var pedidos in lista)// para cada usuario na lista
                    {
                        dtgPedido.Rows.Add();//linhas do datagrid usuarios adiciona
                        dtgPedido.Rows[cont].Cells[0].Value = pedidos.Id;
                        dtgPedido.Rows[cont].Cells[1].Value = pedidos.Estatus;
                        dtgPedido.Rows[cont].Cells[2].Value = pedidos.Desconto;
                        dtgPedido.Rows[cont].Cells[3].Value = pedidos.DatPed;
                        dtgPedido.Rows[cont].Cells[4].Value = pedidos.IdFuncionarios.Nome;
                        dtgPedido.Rows[cont].Cells[5].Value = pedidos.IdCliente.Id;
                        cont++;//{cont esta em loop para listar os usuarios}


                    }
                }

            }
        }

        private void dtgPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int PosicaoLinha = dtgPedido.CurrentRow.Index;
            if (dtgPedido.Rows[PosicaoLinha].Cells[1].Value.ToString() == "A")
            {
                Program.PedidoemAberto.Id = Convert.ToInt32(dtgPedido.Rows[PosicaoLinha].Cells[0].Value);
                Close();
                FrmPedidoNovo frmPedidoNovo = new();
                frmPedidoNovo.ShowDialog();
            }
            
        }
    }
}
