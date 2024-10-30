using PedalMasterLib;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PedalMasterDesk
{
    public partial class FrmDgvFuncionariosListagem : Form
    {
        public FrmDgvFuncionariosListagem()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregaGridEmail()
        {

            var lista = Email.ObterListaPorIdFuncionarios(Program.frmDgvFuncionario.Id);
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

            var lista = Telefone.ObterListaPorIdFuncionarios(Program.frmDgvFuncionario.Id);
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

            
            var lista = Endereco.ObterListaPorIdFuncionarios(Program.frmDgvFuncionario.Id);
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

        private void FrmDgvFuncionariosListagem_Load(object sender, EventArgs e)
        {
            lblIdFuncionarios.Text = Program.frmDgvFuncionario.Id.ToString();
            lblNomeFuncionarios.Text = Program.frmDgvFuncionario.Nome;
            CarregaGridEmail();
            CarregaGridTelefone();
            CarregaGridEndereco();
            mskCEPFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefoneFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void dgvEmail_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmail_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {


        }

        private void dgvEmail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dgvEmail.CurrentRow.Index;

            txtIdEmail.Text = dgvEmail.Rows[PosicaoLinha].Cells[0].Value.ToString();
            txtEmailFuncionarios.Text = dgvEmail.Rows[PosicaoLinha].Cells[1].Value.ToString();

        }

        private void dgvTelefone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dgvTelefone.CurrentRow.Index;
            txtIdTelefone.Text = dgvTelefone.Rows[PosicaoLinha].Cells[0].Value.ToString();
            mskTelefoneFuncionarios.Text = dgvTelefone.Rows[PosicaoLinha].Cells[1].Value.ToString();
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

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int PosicaoLinha = dgvEndereco.CurrentRow.Index;

            Endereco endereco = Endereco.ObterPorId(Convert.ToInt32(dgvEndereco.Rows[PosicaoLinha].Cells[0].Value));


            txtIdEndereco.Text = endereco.Id.ToString();
            mskCEPFuncionarios.Text = endereco.Cep;
            txtLogradouroFuncionarios.Text = endereco.Logradouro;
            txtCidadeFuncionarios.Text = endereco.Cidade;
            txtBairroFuncionarios.Text = endereco.Bairro;
            txtComplementoFuncionarios.Text = endereco.Complemento;
            txtNumeroFuncionarios.Text = endereco.Numero;
            txtUFFuncionarios.Text = endereco.Uf;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnArquivar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtEmailFuncionarios.ReadOnly = false;
            mskTelefoneFuncionarios.ReadOnly = false;
            rdbtnCelular.Enabled = true;
            rdbtnTelefone.Enabled = true;
            mskCEPFuncionarios.ReadOnly = false;
            txtNumeroFuncionarios.ReadOnly = false;
            txtComplementoFuncionarios.ReadOnly = false;


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
                WebCEP webcep = new(mskCEPFuncionarios.Text);
                txtBairroFuncionarios.Text = webcep.Bairro;
                txtCidadeFuncionarios.Text = webcep.Cidade;
                txtLogradouroFuncionarios.Text = webcep.Lagradouro;
                txtUFFuncionarios.Text = webcep.UF;
            }
        }

        private void rdbtnCelular_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnCelular.Checked)
            {
                mskTelefoneFuncionarios.Mask = "(00)00000-0000";
                mskTelefoneFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
        }

        private void rdbtnTelefone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnTelefone.Checked)
            {
                mskTelefoneFuncionarios.Mask = "(00)0000-0000";
                mskTelefoneFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Enabled)
            {

                if (txtEmailFuncionarios.Text != string.Empty)
                {
                    if (VerificacaoEmails(txtEmailFuncionarios.Text))
                    {


                        Email email = new(
                            int.Parse(txtIdEmail.Text),
                            txtEmailFuncionarios.Text
                            );
                        email.Atualizar();

                        if (mskTelefoneFuncionarios.Text != string.Empty)
                        {
                            if (rdbtnCelular.Checked)
                            {
                                Telefone telefone = new(
                                int.Parse(txtIdTelefone.Text),
                                mskTelefoneFuncionarios.Text,
                                "Celular"
                                );
                                telefone.Atualizar();
                            }
                            if (rdbtnTelefone.Checked)
                            {
                                Telefone telefone = new(
                                int.Parse(txtIdTelefone.Text),
                                mskTelefoneFuncionarios.Text,
                                "Telefone"

                                );
                                telefone.Atualizar();
                            }

                            if (mskCEPFuncionarios.Text != string.Empty)
                            {
                                Endereco endereco = new(
                                int.Parse(txtIdEndereco.Text),
                                txtLogradouroFuncionarios.Text,
                                    txtNumeroFuncionarios.Text,
                                    txtBairroFuncionarios.Text,
                                    txtCidadeFuncionarios.Text,
                                    txtUFFuncionarios.Text,
                                    txtComplementoFuncionarios.Text,
                                    mskCEPFuncionarios.Text
                                );
                                endereco.Atualizar();
                            }
                        }
                        else
                        {
                            if (mskCEPFuncionarios.Text != string.Empty)
                            {
                                Endereco endereco = new(
                                int.Parse(txtIdEndereco.Text),
                                txtLogradouroFuncionarios.Text,
                                    txtNumeroFuncionarios.Text,
                                    txtBairroFuncionarios.Text,
                                    txtCidadeFuncionarios.Text,
                                    txtUFFuncionarios.Text,
                                    txtComplementoFuncionarios.Text,
                                    mskCEPFuncionarios.Text
                                );
                                endereco.Atualizar();
                                
                            }
                        }
                        if(email.Emails == txtEmailFuncionarios.Text)
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
                    if (mskTelefoneFuncionarios.Text != string.Empty)
                    {
                        if (rdbtnCelular.Checked)
                        {
                            Telefone telefone = new(
                            int.Parse(txtIdTelefone.Text),
                            mskTelefoneFuncionarios.Text,
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
                                mskTelefoneFuncionarios.Text,
                                "Telefone"

                                );
                                telefone.Atualizar();
                            }
                        }
                        

                        if (mskCEPFuncionarios.Text != string.Empty)
                        {
                            Endereco endereco = new(
                                int.Parse(txtIdEndereco.Text),
                                txtLogradouroFuncionarios.Text,
                                    txtNumeroFuncionarios.Text,
                                    txtBairroFuncionarios.Text,
                                    txtCidadeFuncionarios.Text,
                                    txtUFFuncionarios.Text,
                                    txtComplementoFuncionarios.Text,
                                    mskCEPFuncionarios.Text
                                );
                            endereco.Atualizar();
                        }
                        MessageBox.Show("Alterações concluidas com sucesso");
                    }
                    else
                    {
                        if (mskCEPFuncionarios.Text != string.Empty)
                        {
                            Endereco endereco = new(
                                int.Parse(txtIdEndereco.Text),
                                txtLogradouroFuncionarios.Text,
                                    txtNumeroFuncionarios.Text,
                                    txtBairroFuncionarios.Text,
                                    txtCidadeFuncionarios.Text,
                                    txtUFFuncionarios.Text,
                                    txtComplementoFuncionarios.Text,
                                    mskCEPFuncionarios.Text
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
                if (txtEmailFuncionarios.Text != string.Empty)
                {
                    if (VerificacaoEmails(txtEmailFuncionarios.Text))
                    {

                        Email email = new(
                            txtEmailFuncionarios.Text,
                            Funcionarios.ObrterPorID(Program.frmDgvFuncionario.Id)
                            );
                        
                        email.InserirEmailFuncionarios();

                        if (mskTelefoneFuncionarios.Text != string.Empty)
                        {
                            if (rdbtnCelular.Checked)
                            {
                                Telefone telefone = new(
                                mskTelefoneFuncionarios.Text,
                                "Celular",
                                Funcionarios.ObrterPorID(Program.frmDgvFuncionario.Id)
                                );
                                telefone.InserirTelefoneFuncionarios();
                            }
                            if (rdbtnTelefone.Checked)
                            {
                                Telefone telefone = new(
                                mskTelefoneFuncionarios.Text,
                                "Telefone",
                                Funcionarios.ObrterPorID(Program.frmDgvFuncionario.Id)
                                );
                                telefone.InserirTelefoneFuncionarios();
                            }

                            if (mskCEPFuncionarios.Text != string.Empty)
                            {
                                Endereco endereco = new(
                                    txtLogradouroFuncionarios.Text,
                                    txtNumeroFuncionarios.Text,
                                    txtBairroFuncionarios.Text,
                                    txtCidadeFuncionarios.Text,
                                    txtUFFuncionarios.Text,
                                    txtComplementoFuncionarios.Text,
                                    mskCEPFuncionarios.Text,
                                    Funcionarios.ObrterPorID(Program.frmDgvFuncionario.Id)
                                    );
                                //endereco.IdFuncionarios.Id = int.Parse(lblIdFuncionarios.Text);
                                endereco.InserirEnderecosEmFuncionarios();
                            }
                        }
                        else
                        {
                            if (mskCEPFuncionarios.Text != string.Empty)
                            {
                                Endereco endereco = new(
                                    txtLogradouroFuncionarios.Text,
                                    txtNumeroFuncionarios.Text,
                                    txtBairroFuncionarios.Text,
                                    txtCidadeFuncionarios.Text,
                                    txtUFFuncionarios.Text,
                                    txtComplementoFuncionarios.Text,
                                    mskCEPFuncionarios.Text,
                                    Funcionarios.ObrterPorID(Program.frmDgvFuncionario.Id)
                                    );
                                //endereco.IdFuncionarios.Id = int.Parse(lblIdFuncionarios.Text);
                                endereco.InserirEnderecosEmFuncionarios();
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
                    if (mskTelefoneFuncionarios.Text != string.Empty)
                    {
                        
                        if (rdbtnCelular.Checked)
                        {
                            Telefone telefone = new(
                            mskTelefoneFuncionarios.Text,
                            "Celular",
                            Funcionarios.ObrterPorID(Program.frmDgvFuncionario.Id)
                            );
                            telefone.InserirTelefoneFuncionarios();
                        }
                        if (rdbtnTelefone.Checked)
                        {
                            Telefone telefone = new(
                            mskTelefoneFuncionarios.Text,
                            "Telefone",
                            Funcionarios.ObrterPorID(Program.frmDgvFuncionario.Id)
                            );
                            telefone.InserirTelefoneFuncionarios();
                        }

                        

                        if (mskCEPFuncionarios.Text != string.Empty)
                        {
                            Endereco endereco = new(
                                txtLogradouroFuncionarios.Text,
                                txtNumeroFuncionarios.Text,
                                txtBairroFuncionarios.Text,
                                txtCidadeFuncionarios.Text,
                                txtUFFuncionarios.Text,
                                txtComplementoFuncionarios.Text,
                                mskCEPFuncionarios.Text,
                                Funcionarios.ObrterPorID(Program.frmDgvFuncionario.Id)
                                );
                            //endereco.IdFuncionarios.Id = int.Parse(lblIdFuncionarios.Text);
                            endereco.InserirEnderecosEmFuncionarios();
                        }
                        MessageBox.Show("Alterações concluidas com sucesso");
                    }
                    else
                    {
                        if (mskCEPFuncionarios.Text != string.Empty)
                        {
                            Endereco endereco = new(
                                txtLogradouroFuncionarios.Text,
                                txtNumeroFuncionarios.Text,
                                txtBairroFuncionarios.Text,
                                txtCidadeFuncionarios.Text,
                                txtUFFuncionarios.Text,
                                txtComplementoFuncionarios.Text,
                                mskCEPFuncionarios.Text,
                                Funcionarios.ObrterPorID(Program.frmDgvFuncionario.Id)
                                );
                            //endereco.IdFuncionarios.Id = int.Parse(lblIdFuncionarios.Text);
                            endereco.InserirEnderecosEmFuncionarios();
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
                if (txtEmailFuncionarios.Text != string.Empty)
                {

                    Email email = new();
                    email.Arquivar(int.Parse(txtIdEmail.Text));

                    if (mskTelefoneFuncionarios.Text != string.Empty)
                    {
                        Telefone telefone = new();
                        telefone.Arquivar(int.Parse(txtIdTelefone.Text));

                        if (mskCEPFuncionarios.Text != string.Empty)
                        {
                            Endereco endereco = new();
                            endereco.Arquivar(int.Parse(txtIdEndereco.Text));
                        }
                    }
                    else
                    {
                        if (mskCEPFuncionarios.Text != string.Empty)
                        {
                            Endereco endereco = new();
                            endereco.Arquivar(int.Parse(txtIdEndereco.Text));
                        }
                    }
                    MessageBox.Show("Alterações concluidas com sucesso");


                }
                else
                {
                    if (mskTelefoneFuncionarios.Text != string.Empty)
                    {
                        Telefone telefone = new();
                        telefone.Arquivar(int.Parse(txtIdTelefone.Text));

                        if (mskCEPFuncionarios.Text != string.Empty)
                        {
                            Endereco endereco = new();
                            endereco.Arquivar(int.Parse(txtIdEndereco.Text));
                        }
                        MessageBox.Show("Alterações concluidas com sucesso");
                    }
                    else
                    {
                        if (mskCEPFuncionarios.Text != string.Empty)
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
            txtEmailFuncionarios.ReadOnly = true;
            mskTelefoneFuncionarios.ReadOnly = true;
            rdbtnCelular.Enabled = false;
            rdbtnTelefone.Enabled = false;
            mskCEPFuncionarios.ReadOnly = true;
            txtNumeroFuncionarios.ReadOnly = true;
            txtComplementoFuncionarios.ReadOnly = true;
            FrmDgvFuncionariosListagem_Load(sender, e);

        }

        private void btnLimparEmail_Click(object sender, EventArgs e)
        {
            txtIdEmail.Clear();
            txtEmailFuncionarios.Clear();
        }

        private void btnLimparTelefone_Click(object sender, EventArgs e)
        {
            txtIdTelefone.Clear();
            mskTelefoneFuncionarios.Clear();
        }

        private void btnLimparEndereco_Click(object sender, EventArgs e)
        {
            txtIdEndereco.Clear();
            mskCEPFuncionarios.Clear();
            txtNumeroFuncionarios.Clear();
            txtComplementoFuncionarios.Clear();
            txtBairroFuncionarios.Clear();
            txtCidadeFuncionarios.Clear();
            txtLogradouroFuncionarios.Clear();
            txtUFFuncionarios.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

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
            txtEmailFuncionarios.ReadOnly = false;
            mskTelefoneFuncionarios.ReadOnly = false;
            rdbtnCelular.Enabled = true;
            rdbtnTelefone.Enabled = true;
            mskCEPFuncionarios.ReadOnly = false;
            txtNumeroFuncionarios.ReadOnly = false;
            txtComplementoFuncionarios.ReadOnly = false;
        }

        private void btnArquivar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnAdd.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtEmailFuncionarios.ReadOnly = false;
            mskTelefoneFuncionarios.ReadOnly = false;
            rdbtnCelular.Enabled = true;
            rdbtnTelefone.Enabled = true;
            mskCEPFuncionarios.ReadOnly = false;
            txtNumeroFuncionarios.ReadOnly = false;
            txtComplementoFuncionarios.ReadOnly = false;
        }
    }
}
