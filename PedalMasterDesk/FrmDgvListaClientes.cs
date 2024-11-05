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
    public partial class FrmDgvListaClientes : Form
    {
        public FrmDgvListaClientes()
        {
            InitializeComponent();
        }

        private void CarregaGridEmail()
        {

            var lista = Email.ObterListaPorIdCliente(Program.frmDgvCliente.Id);
            int cont = 0;
            dgvEmail.Rows.Clear();

            foreach (var email in lista)// para cada usuario na lista
            {
                this.dgvEmail.DataSource = null;
                dgvEmail.Rows.Add();//linhas do datagrid usuarios adiciona
                dgvEmail.Rows[cont].Cells[0].Value = email.Id;
                dgvEmail.Rows[cont].Cells[1].Value = email.Emails;

                cont++;//{cont esta em loop para listar os usuarios}
            }



        }

        private void CarregaGridTelefone()
        {

            var lista = Telefone.ObterListaPorIdCliente(Program.frmDgvCliente.Id);
            int cont = 0;
            dgvTelefone.Rows.Clear();

            foreach (var telefone in lista)// para cada usuario na lista
            {

                dgvTelefone.Rows.Add();//linhas do datagrid usuarios adiciona
                dgvTelefone.Rows[cont].Cells[0].Value = telefone.Id;
                dgvTelefone.Rows[cont].Cells[1].Value = telefone.Telefones;
                dgvTelefone.Rows[cont].Cells[2].Value = telefone.Tipo;

                cont++;//{cont esta em loop para listar os usuarios}
            }



        }

        private void CarregaGridEndereco()
        {


            var lista = Endereco.ObterListaPorIdCliente(Program.frmDgvCliente.Id);
            int cont = 0;
            dgvEndereco.Rows.Clear();

            foreach (var endereco in lista)// para cada usuario na lista
            {

                dgvEndereco.Rows.Add();//linhas do datagrid usuarios adiciona
                dgvEndereco.Rows[cont].Cells[0].Value = endereco.Id;
                dgvEndereco.Rows[cont].Cells[1].Value = endereco.Cep;
                dgvEndereco.Rows[cont].Cells[2].Value = endereco.Numero;
                dgvEndereco.Rows[cont].Cells[3].Value = endereco.Complemento;

                cont++;//{cont esta em loop para listar os usuarios}
            }



        }


        private void FrmDgvListaClientes_Load(object sender, EventArgs e)
        {
            lblIdClientes.Text = Program.frmDgvCliente.Id.ToString();
            lblNomeClientes.Text = Program.frmDgvCliente.Nome;
            CarregaGridEmail();
            CarregaGridTelefone();
            CarregaGridEndereco();
            mskCEPClientes.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefoneClientes.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void dgvEmail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dgvEmail.CurrentRow.Index;

            txtIdEmail.Text = dgvEmail.Rows[PosicaoLinha].Cells[0].Value.ToString();
            txtEmailClientes.Text = dgvEmail.Rows[PosicaoLinha].Cells[1].Value.ToString();
        }

        private void dgvTelefone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dgvTelefone.CurrentRow.Index;
            txtIdTelefone.Text = dgvTelefone.Rows[PosicaoLinha].Cells[0].Value.ToString();
            mskTelefoneClientes.Text = dgvTelefone.Rows[PosicaoLinha].Cells[1].Value.ToString();
            if (dgvTelefone.Rows[PosicaoLinha].Cells[2].Value.ToString() == "Celular")
            {
                rdbtnCelular.Checked = true;
            }
            else
            {
                if (dgvTelefone.Rows[PosicaoLinha].Cells[2].Value.ToString() == "Telefone")
                {
                    rdbtnTelefone.Checked = true;
                }
            }
        }

        private void dgvEndereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dgvEndereco.CurrentRow.Index;

            Endereco endereco = Endereco.ObterPorId(Convert.ToInt32(dgvEndereco.Rows[PosicaoLinha].Cells[0].Value));


            txtIdEndereco.Text = endereco.Id.ToString();
            mskCEPClientes.Text = endereco.Cep;
            txtLogradouroClientes.Text = endereco.Logradouro;
            txtCidadeClientes.Text = endereco.Cidade;
            txtBairroClientes.Text = endereco.Bairro;
            txtComplementoClientes.Text = endereco.Complemento;
            txtNumeroClientes.Text = endereco.Numero;
            txtUFClientes.Text = endereco.Uf;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnArquivar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtEmailClientes.ReadOnly = false;
            mskTelefoneClientes.ReadOnly = false;
            rdbtnCelular.Enabled = true;
            rdbtnTelefone.Enabled = true;
            mskCEPClientes.ReadOnly = false;
            txtNumeroClientes.ReadOnly = false;
            txtComplementoClientes.ReadOnly = false;
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

        private void mskCEPFuncionarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebCEP webcep = new(mskCEPClientes.Text);
                txtBairroClientes.Text = webcep.Bairro;
                txtCidadeClientes.Text = webcep.Cidade;
                txtLogradouroClientes.Text = webcep.Lagradouro;
                txtUFClientes.Text = webcep.UF;
            }
        }

        private void rdbtnCelular_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnCelular.Checked)
            {
                mskTelefoneClientes.Mask = "(00)00000-0000";
                mskTelefoneClientes.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
        }

        private void rdbtnTelefone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnTelefone.Checked)
            {
                mskTelefoneClientes.Mask = "(00)0000-0000";
                mskTelefoneClientes.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Enabled)
            {

                if (txtEmailClientes.Text != string.Empty)
                {
                    if (VerificacaoEmails(txtEmailClientes.Text))
                    {


                        Email email = new(
                            int.Parse(txtIdEmail.Text),
                            txtEmailClientes.Text
                            );
                        email.Atualizar();

                        if (mskTelefoneClientes.Text != string.Empty)
                        {
                            if (rdbtnCelular.Checked)
                            {
                                Telefone telefone = new(
                                int.Parse(txtIdTelefone.Text),
                                mskTelefoneClientes.Text,
                                "Celular"
                                );
                                telefone.Atualizar();
                            }
                            if (rdbtnTelefone.Checked)
                            {
                                Telefone telefone = new(
                                int.Parse(txtIdTelefone.Text),
                                mskTelefoneClientes.Text,
                                "Telefone"

                                );
                                telefone.Atualizar();
                            }

                            if (mskCEPClientes.Text != string.Empty)
                            {
                                Endereco endereco = new(
                                int.Parse(txtIdEndereco.Text),
                                txtLogradouroClientes.Text,
                                    txtNumeroClientes.Text,
                                    txtBairroClientes.Text,
                                    txtCidadeClientes.Text,
                                    txtUFClientes.Text,
                                    txtComplementoClientes.Text,
                                    mskCEPClientes.Text
                                );
                                endereco.Atualizar();
                            }
                        }
                        else
                        {
                            if (mskCEPClientes.Text != string.Empty)
                            {
                                Endereco endereco = new(
                                int.Parse(txtIdEndereco.Text),
                                txtLogradouroClientes.Text,
                                    txtNumeroClientes.Text,
                                    txtBairroClientes.Text,
                                    txtCidadeClientes.Text,
                                    txtUFClientes.Text,
                                    txtComplementoClientes.Text,
                                    mskCEPClientes.Text
                                );
                                endereco.Atualizar();

                            }
                        }
                        if (email.Emails == txtEmailClientes.Text)
                        {
                            MessageBox.Show("Alterações concluidas com sucesso");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Já Existe um usuario com esse Email");
                    }
                }
                else
                {
                    if (mskTelefoneClientes.Text != string.Empty)
                    {
                        if (rdbtnCelular.Checked)
                        {
                            Telefone telefone = new(
                            int.Parse(txtIdTelefone.Text),
                            mskTelefoneClientes.Text,
                            "Celular"
                            );
                            telefone.Atualizar();
                        }
                        else
                        {
                            if (rdbtnTelefone.Checked)
                            {
                                Telefone telefone = new(
                                int.Parse(txtIdTelefone.Text),
                                mskTelefoneClientes.Text,
                                "Telefone"

                                );
                                telefone.Atualizar();
                            }
                        }


                        if (mskCEPClientes.Text != string.Empty)
                        {
                            Endereco endereco = new(
                                int.Parse(txtIdEndereco.Text),
                                txtLogradouroClientes.Text,
                                    txtNumeroClientes.Text,
                                    txtBairroClientes.Text,
                                    txtCidadeClientes.Text,
                                    txtUFClientes.Text,
                                    txtComplementoClientes.Text,
                                    mskCEPClientes.Text
                                );
                            endereco.Atualizar();
                        }
                        MessageBox.Show("Alterações concluidas com sucesso");
                    }
                    else
                    {
                        if (mskCEPClientes.Text != string.Empty)
                        {
                            Endereco endereco = new(
                                int.Parse(txtIdEndereco.Text),
                                txtLogradouroClientes.Text,
                                    txtNumeroClientes.Text,
                                    txtBairroClientes.Text,
                                    txtCidadeClientes.Text,
                                    txtUFClientes.Text,
                                    txtComplementoClientes.Text,
                                    mskCEPClientes.Text
                                );
                            endereco.Atualizar();

                            MessageBox.Show("Alterações concluidas com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Suas Alterações não foram salvas, " +
                                "verifique se o campo que deseja alterar está vazio");
                        }

                    }
                }
            }
            if (btnAdd.Enabled)
            {
                if (txtEmailClientes.Text != string.Empty)
                {
                    if (VerificacaoEmails(txtEmailClientes.Text))
                    {

                        Email email = new(
                            txtEmailClientes.Text,
                            Cliente.ObterId(Program.frmDgvCliente.Id)
                            );

                        email.InserirEmailClientes();

                        if (mskTelefoneClientes.Text != string.Empty)
                        {
                            if (rdbtnCelular.Checked)
                            {
                                Telefone telefone = new(
                                mskTelefoneClientes.Text,
                                "Celular",
                                Cliente.ObterId(Program.frmDgvCliente.Id)
                                );
                                telefone.InserirTelefoneClientes();
                            }
                            if (rdbtnTelefone.Checked)
                            {
                                Telefone telefone = new(
                                mskTelefoneClientes.Text,
                                "Telefone",
                                Cliente.ObterId(Program.frmDgvCliente.Id)
                                );
                                telefone.InserirTelefoneClientes();
                            }

                            if (mskCEPClientes.Text != string.Empty)
                            {
                                Endereco endereco = new(
                                    txtLogradouroClientes.Text,
                                    txtNumeroClientes.Text,
                                    txtBairroClientes.Text,
                                    txtCidadeClientes.Text,
                                    txtUFClientes.Text,
                                    txtComplementoClientes.Text,
                                    mskCEPClientes.Text,
                                    Cliente.ObterId(Program.frmDgvCliente.Id)
                                    );
                                //endereco.IdFuncionarios.Id = int.Parse(lblIdFuncionarios.Text);
                                endereco.InserirEnderecosEmClientes();
                            }
                        }
                        else
                        {
                            if (mskCEPClientes.Text != string.Empty)
                            {
                                Endereco endereco = new(
                                    txtLogradouroClientes.Text,
                                    txtNumeroClientes.Text,
                                    txtBairroClientes.Text,
                                    txtCidadeClientes.Text,
                                    txtUFClientes.Text,
                                    txtComplementoClientes.Text,
                                    mskCEPClientes.Text,
                                    Cliente.ObterId(Program.frmDgvCliente.Id)
                                    );
                                //endereco.IdFuncionarios.Id = int.Parse(lblIdFuncionarios.Text);
                                endereco.InserirEnderecosEmClientes();
                            }
                        }
                        //MessageBox.Show("Alterações concluidas com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Já Existe um usuario com esse Email");
                    }
                }
                else
                {
                    if (mskTelefoneClientes.Text != string.Empty)
                    {

                        if (rdbtnCelular.Checked)
                        {
                            Telefone telefone = new(
                            mskTelefoneClientes.Text,
                            "Celular",
                            Cliente.ObterId(Program.frmDgvCliente.Id)
                            );
                            telefone.InserirTelefoneClientes();
                        }
                        if (rdbtnTelefone.Checked)
                        {
                            Telefone telefone = new(
                            mskTelefoneClientes.Text,
                            "Telefone",
                            Cliente.ObterId(Program.frmDgvCliente.Id)
                            );
                            telefone.InserirTelefoneClientes();
                        }



                        if (mskCEPClientes.Text != string.Empty)
                        {
                            Endereco endereco = new(
                                txtLogradouroClientes.Text,
                                txtNumeroClientes.Text,
                                txtBairroClientes.Text,
                                txtCidadeClientes.Text,
                                txtUFClientes.Text,
                                txtComplementoClientes.Text,
                                mskCEPClientes.Text,
                                Cliente.ObterId(Program.frmDgvCliente.Id)
                                );
                            //endereco.IdFuncionarios.Id = int.Parse(lblIdFuncionarios.Text);
                            endereco.InserirEnderecosEmClientes();
                        }
                        MessageBox.Show("Alterações concluidas com sucesso");
                    }
                    else
                    {
                        if (mskCEPClientes.Text != string.Empty)
                        {
                            Endereco endereco = new(
                                txtLogradouroClientes.Text,
                                txtNumeroClientes.Text,
                                txtBairroClientes.Text,
                                txtCidadeClientes.Text,
                                txtUFClientes.Text,
                                txtComplementoClientes.Text,
                                mskCEPClientes.Text,
                                Cliente.ObterId(Program.frmDgvCliente.Id)
                                );
                            //endereco.IdFuncionarios.Id = int.Parse(lblIdFuncionarios.Text);
                            endereco.InserirEnderecosEmClientes();
                            if (endereco.Id > 0)
                            {
                                MessageBox.Show("Alterações concluidas com sucesso");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Suas Alterações não foram salvas, " +
                                "verifique se o campo que deseja alterar está vazio");
                        }

                    }
                }
            }
            if (btnArquivar.Enabled)
            {
                if (txtEmailClientes.Text != string.Empty)
                {

                    Email email = new();
                    email.Arquivar(int.Parse(txtIdEmail.Text));

                    if (mskTelefoneClientes.Text != string.Empty)
                    {
                        Telefone telefone = new();
                        telefone.Arquivar(int.Parse(txtIdTelefone.Text));

                        if (mskCEPClientes.Text != string.Empty)
                        {
                            Endereco endereco = new();
                            endereco.Arquivar(int.Parse(txtIdEndereco.Text));
                        }
                    }
                    else
                    {
                        if (mskCEPClientes.Text != string.Empty)
                        {
                            Endereco endereco = new();
                            endereco.Arquivar(int.Parse(txtIdEndereco.Text));
                        }
                    }
                    MessageBox.Show("Alterações concluidas com sucesso");


                }
                else
                {
                    if (mskTelefoneClientes.Text != string.Empty)
                    {
                        Telefone telefone = new();
                        telefone.Arquivar(int.Parse(txtIdTelefone.Text));

                        if (mskCEPClientes.Text != string.Empty)
                        {
                            Endereco endereco = new();
                            endereco.Arquivar(int.Parse(txtIdEndereco.Text));
                        }
                        MessageBox.Show("Alterações concluidas com sucesso");
                    }
                    else
                    {
                        if (mskCEPClientes.Text != string.Empty)
                        {
                            Endereco endereco = new();
                            endereco.Arquivar(int.Parse(txtIdEndereco.Text));

                            MessageBox.Show("Alterações concluidas com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Suas Alterações não foram salvas, " +
                                "verifique se o campo que deseja alterar está vazio");
                        }

                    }
                }
            }
            btnAdd.Enabled = true;
            btnArquivar.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            txtEmailClientes.ReadOnly = true;
            mskTelefoneClientes.ReadOnly = true;
            rdbtnCelular.Enabled = false;
            rdbtnTelefone.Enabled = false;
            mskCEPClientes.ReadOnly = true;
            txtNumeroClientes.ReadOnly = true;
            txtComplementoClientes.ReadOnly = true;
            FrmDgvListaClientes_Load(sender, e);

        }

        private void btnLimparEmail_Click(object sender, EventArgs e)
        {
            txtIdEmail.Clear();
            txtEmailClientes.Clear();
        }

        private void btnLimparTelefone_Click(object sender, EventArgs e)
        {
            txtIdTelefone.Clear();
            mskTelefoneClientes.Clear();
        }

        private void btnLimparEndereco_Click(object sender, EventArgs e)
        {
            txtIdEndereco.Clear();
            mskCEPClientes.Clear();
            txtNumeroClientes.Clear();
            txtComplementoClientes.Clear();
            txtBairroClientes.Clear();
            txtCidadeClientes.Clear();
            txtLogradouroClientes.Clear();
            txtUFClientes.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja realmente cancelar as Alterações", "Tem certeza?", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                btnAdd.Enabled = true;
                btnArquivar.Enabled = true;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnArquivar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtEmailClientes.ReadOnly = false;
            mskTelefoneClientes.ReadOnly = false;
            rdbtnCelular.Enabled = true;
            rdbtnTelefone.Enabled = true;
            mskCEPClientes.ReadOnly = false;
            txtNumeroClientes.ReadOnly = false;
            txtComplementoClientes.ReadOnly = false;
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnAdd.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtEmailClientes.ReadOnly = false;
            mskTelefoneClientes.ReadOnly = false;
            rdbtnCelular.Enabled = true;
            rdbtnTelefone.Enabled = true;
            mskCEPClientes.ReadOnly = false;
            txtNumeroClientes.ReadOnly = false;
            txtComplementoClientes.ReadOnly = false;
        }
    }
}
