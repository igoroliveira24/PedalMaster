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
    //VOLTAR PARA FAZER ALTERAÇÕES  
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            rdbtnCelular.Checked = true;
            CarregaGrid();
            mskCEPCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskCPFCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefoneCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtUFClientes.MaxLength = 2;

        }

        private void rdbtnTelefone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnTelefone.Checked)
            {
                mskTelefoneCliente.Mask = "(00)0000-0000";
            }

        }

        private void rdbtnCelular_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnCelular.Checked)
            {
                mskTelefoneCliente.Mask = "(00)00000-0000";
            }

        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                                txtNomeCliente.Text,
                                mskCPFCliente.Text,
                                dtpDatNascCliente.Value
                                );


            if (textBoxVazias() && MaskedTextBoxVazias())
            {
                MessageBox.Show("Preencha todas as informações");
            }
            else
            {
                if (mskCEPCliente.TextLength != 9 && mskCPFCliente.TextLength != 14)
                {
                    MessageBox.Show("Preencha as informações com valores validos");
                }
                else
                {
                    if (rdbtnCelular.Checked)
                    {
                        if (mskTelefoneCliente.TextLength != 14)
                        {
                            MessageBox.Show("Preencha as informações com valores validos");
                        }
                        else
                        {
                            if (VerificacaoEmails(txtEmailCliente.Text))
                            {
                                if (VerificacaoCPF(mskCPFCliente.Text))
                                {

                                    if (ValidaCpf.Validar(mskCPFCliente.Text))
                                    {
                                        cliente.Inserir();



                                        Telefone telefone = new(
                                            mskTelefoneCliente.Text,
                                            "Celular",
                                            Cliente.ObterId(Convert.ToInt32(cliente.Id))
                                            );

                                        Email email = new(
                                            txtEmailCliente.Text,
                                            Cliente.ObterId(Convert.ToInt32(cliente.Id))
                                            );

                                        Endereco endereco = new(
                                            txtLogradouroClientes.Text,
                                            txtNumeroClientes.Text,
                                            txtBairroClientes.Text,
                                            txtCidadeClientes.Text,
                                            txtUFClientes.Text,
                                            txtComplementoClientes.Text,
                                            mskCEPCliente.Text,
                                            Cliente.ObterId(cliente.Id)
                                            );

                                        email.InserirEmailClientes();
                                        telefone.InserirTelefoneClientes();
                                        endereco.InserirEnderecosEmClientes();

                                        MessageBox.Show("Cliente Cadastrado com SUCESSO!!!");
                                        Apagatudo();

                                    }
                                    else
                                    {
                                        MessageBox.Show("O Cpf digitado é invalido ou inexistente");
                                        mskCPFCliente.Clear();
                                        mskCPFCliente.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("O Cpf ja está sendo utilizado por outro cliente");
                                    mskCPFCliente.Clear();
                                    mskCPFCliente.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("O Email ja está sendo utilizado por outro cliente");
                                txtEmailCliente.Clear();
                                txtEmailCliente.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (mskTelefoneCliente.TextLength != 13)
                        {
                            MessageBox.Show("Preencha as informações com valores validos");
                        }
                        else
                        {
                            if (VerificacaoEmails(txtEmailCliente.Text))
                            {
                                if (VerificacaoCPF(mskCPFCliente.Text))
                                {

                                    if (ValidaCpf.Validar(mskCPFCliente.Text))
                                    {
                                        cliente.Inserir();

                                        var id = cliente.Id;

                                        Telefone telefone = new(
                                            mskTelefoneCliente.Text,
                                            "Celular",
                                            Cliente.ObterId(id)
                                            );

                                        Email email = new(
                                            txtEmailCliente.Text,
                                            Cliente.ObterId(id)
                                            );

                                        Endereco endereco = new(
                                            txtLogradouroClientes.Text,
                                            txtNumeroClientes.Text,
                                            txtBairroClientes.Text,
                                            txtCidadeClientes.Text,
                                            txtUFClientes.Text,
                                            txtComplementoClientes.Text,
                                            mskCEPCliente.Text,
                                            Cliente.ObterId(id)
                                            );

                                        email.InserirEmailClientes();
                                        telefone.InserirTelefoneClientes();
                                        endereco.InserirEnderecosEmClientes();

                                        MessageBox.Show("Cliente Cadastrado com SUCESSO!!!");
                                        Apagatudo();
                                    }
                                    else
                                    {
                                        MessageBox.Show("O Cpf digitado é invalido ou inexistente");
                                        mskCPFCliente.Clear();
                                        mskCPFCliente.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("O Cpf ja está sendo utilizado por outro cliente");
                                    mskCPFCliente.Clear();
                                    mskCPFCliente.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("O Email ja está sendo utilizado por outro cliente");
                                txtEmailCliente.Clear();
                                txtEmailCliente.Focus();
                            }
                        }
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

        private bool MaskedTextBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is MaskedTextBox)
                {
                    MaskedTextBox msktextBox = c as MaskedTextBox;
                    if (string.IsNullOrWhiteSpace(msktextBox.Text))
                        return true;
                }
            return false;
        }

        private void txtNumeroClientes_TextChanged(object sender, EventArgs e)
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
                dataGridView1.Rows[cont].Cells[0].Value = cliente.Id;//linhas do datagrid usuarios com linha varivael cont e coluna 0 vale usuario id
                dataGridView1.Rows[cont].Cells[1].Value = cliente.Nome;//linhas do datagrid usuarios com linha varivael cont e coluna 2 vale usuario Email               


                cont++;//{cont esta em loop para listar os usuarios}
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mskCEPCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebCEP webcep = new(mskCEPCliente.Text);
                txtBairroClientes.Text = webcep.Bairro;
                txtCidadeClientes.Text = webcep.Cidade;
                txtLogradouroClientes.Text = webcep.Lagradouro;
                txtUFClientes.Text = webcep.UF;
            }
        }

        private bool VerificacaoEmails(string emailescrito)
        {
            Email email = new();
            email.ObterPorEmail(emailescrito);

            if (email.Id > 0)
            {
                return false;
            }
            return true;





        }

        private bool VerificacaoCPF(string CPF)
        {
            Cliente cliente = new();
            cliente.ObrterPorCPF(CPF);
            if (cliente.Id > 0)
            {
                return false;
            }

            return true;




        }

        public void Apagatudo()
        {
            txtBairroClientes.Clear();
            txtCidadeClientes.Clear();
            txtComplementoClientes.Clear();
            txtEmailCliente.Clear();
            txtLogradouroClientes.Clear();
            txtNomeCliente.Clear();
            txtNumeroClientes.Clear();
            txtUFClientes.Clear();
            mskCEPCliente.Clear();
            mskCPFCliente.Clear();
            mskTelefoneCliente.Clear();
        }
    }
}
