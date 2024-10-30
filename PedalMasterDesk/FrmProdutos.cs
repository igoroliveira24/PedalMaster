using Microsoft.VisualBasic.Devices;
using PedalMasterLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PedalMasterDesk
{



    public partial class FrmProdutos : Form
    {

        public string? Codigodebarra { get; set; }
        public string? Desconto { get; set; }

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void txtCoresProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13 && txtCorProduto.Text != string.Empty)

            {

                Cores.Items.Add(txtCorProduto.Text);

                txtCorProduto.Clear();

            }
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            var tipoproduto = TipoProduto.ObterLista();

            cmbTipoProduto.DataSource = tipoproduto;

            cmbTipoProduto.DisplayMember = "Tipoproduto";

            cmbTipoProduto.ValueMember = "Id";

            txtDescontoProduto.MaxLength = 2;
            
        }

        private void btnLimparCor_Click(object sender, EventArgs e)
        {
            if (Cores.Text != string.Empty)

            {

                Cores.Items.RemoveAt(Cores.SelectedIndex);

            }
        }

        private void cmbTipoTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTamanhoProduto.ReadOnly = false;
        }

        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {

            txtCorProduto.Text = ".";
            int x = 0;

            string cores = "";

            while (Cores.Items.Count > x)

            {

                cores = cores + Cores.Items[x].ToString() + ",";

                x++;

            }

            if (textBoxVazias())
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos");
            }
            else
            {
                if (ComboBoxSelecinado())
                {
                    MessageBox.Show("Verifique se todos os campos estão preenchidos");
                }
                else
                {
                    int virgulaIndice = txtPrecoProduto.Text.IndexOf('.');
                    string restoDepoisDaVirgula = txtPrecoProduto.Text.Substring(virgulaIndice);
                    int tamanhoDepoisDaVirgula = restoDepoisDaVirgula.Length;
                    tamanhoDepoisDaVirgula--;
                    if (tamanhoDepoisDaVirgula == 2)
                    {

                        if (txtNomeProduto.TextLength < 10)
                        {
                            this.Codigodebarra = this.Codigodebarra + "0" + cmbMarcaProduto.SelectedIndex.ToString();
                            txtCodBar.Text = this.Codigodebarra;
                        }
                        else
                        {

                            this.Codigodebarra = this.Codigodebarra + cmbMarcaProduto.SelectedIndex.ToString();
                            txtCodBar.Text = this.Codigodebarra;

                        }
                        if (Convert.ToInt32(cmbTipoProduto.SelectedValue) < 10)
                        {
                            this.Codigodebarra = this.Codigodebarra + "0" + cmbTipoProduto.SelectedValue.ToString();
                            cmbMarcaProduto.Enabled = false;

                        }
                        else
                        {
                            this.Codigodebarra = this.Codigodebarra + cmbTipoProduto.SelectedValue.ToString();
                            cmbMarcaProduto.Enabled = false;

                        }
                        if (txtDescontoProduto.TextLength <= 2 && txtDescontoProduto.TextLength >= 1)
                        {
                            txtDescontoProduto.Text = "0." + txtDescontoProduto.Text;
                            if (txtDescontoProduto.TextLength == 1)
                            {
                                txtDescontoProduto.Text = txtDescontoProduto.Text + "0";
                            }

                            Produto produto = new();
                            produto.ObterPorUltimoId();
                            if (produto.Id > 0)
                            {
                                if ((produto.Id + 1) < 1000)
                                {
                                    int idProduto = produto.Id + 1;
                                    if (idProduto < 100)
                                    {

                                        if (idProduto < 10)
                                        {
                                            this.Codigodebarra = this.Codigodebarra + "000" + idProduto;
                                        }
                                        else
                                        {
                                            this.Codigodebarra = this.Codigodebarra + "00" + idProduto;
                                        }
                                    }
                                    else
                                    {

                                        this.Codigodebarra = this.Codigodebarra + "0" + idProduto;
                                    }
                                }
                                txtCodBar.Text = this.Codigodebarra;

                                produto = new(

                                    txtCodBar.Text,

                                    txtNomeProduto.Text,

                                    cmbMarcaProduto.SelectedItem.ToString(),

                                    TipoProduto.ObterPorId(Convert.ToInt32(cmbTipoProduto.SelectedValue)),

                                    cmbTipoTamanho.SelectedItem.ToString(),

                                    double.Parse(txtTamanhoProduto.Text),

                                    double.Parse(txtPrecoProduto.Text),

                                    (int)nudEstoqueMin.Value,

                                    cores,

                                    double.Parse(txtDescontoProduto.Text),

                                    txtDescricaoProduto.Text

                                    );

                                produto.Inserir();

                                if (produto.Id > 0)

                                {

                                    MessageBox.Show("Produto Inserido com sucesso," +
                                        $"com codigo de barras: {produto.CodBar} e id: {produto.Id}");
                                    txtNomeProduto.Clear();
                                    txtPrecoProduto.Clear();
                                    txtDescontoProduto.Clear();
                                    txtDescricaoProduto.Clear();
                                    txtCorProduto.Clear();
                                    txtTamanhoProduto.Clear();
                                    Cores.Items.Clear();
                                    txtTamanhoProduto.ReadOnly = true;
                                    cmbMarcaProduto.Enabled = true;
                                    cmbMarcaProduto.SelectedIndex = 0;
                                    txtCodBar.Clear();
                                    txtCodBar.Focus();

                                }
                            }
                            else
                            {
                                MessageBox.Show("falha ao pegar o id");

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Devem ter duas casas depois da virgula");
                    }
                }

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

        private bool ComboBoxSelecinado()
        {
            foreach (Control c in this.Controls)
                if (c is ComboBox)
                {
                    ComboBox combobox = c as ComboBox;
                    if (string.IsNullOrWhiteSpace(combobox.SelectedItem.ToString()))
                        return true;
                }
            return false;
        }

        private void txtCodBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeProduto.TextLength < 10)
            {
                this.Codigodebarra = "00" + txtNomeProduto.TextLength.ToString();
                txtCodBar.Text = this.Codigodebarra;
            }
            else
            {
                if (txtNomeProduto.TextLength < 100)
                {
                    this.Codigodebarra = "0" + txtNomeProduto.TextLength.ToString();
                    txtCodBar.Text = this.Codigodebarra;
                }
                else
                {
                    this.Codigodebarra = txtNomeProduto.TextLength.ToString();
                    txtCodBar.Text = this.Codigodebarra;
                }
            }



        }

        private void cmbMarcaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void cmbTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescontoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescontoProduto_TextChanged_1(object sender, EventArgs e)
        {


        }




        private void txtDescontoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    //Atribui True no Handled para cancelar o evento
                    e.Handled = true;
                }
            


        }

        private void txtPrecoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPrecoProduto.Text != string.Empty)
            {


                if (!char.IsDigit(e.KeyChar))
                {
                    //Atribui True no Handled para cancelar o evento
                    e.Handled = true;
                }


            }

            
        }

        private void txtPrecoProduto_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrecoProduto.Text = ".";
        }
    }

}
