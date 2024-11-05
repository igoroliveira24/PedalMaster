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
            comboBox1.DataSource = input.Cor.Split(',');
        }
    }
}
