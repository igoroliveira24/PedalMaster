using PedalMasterLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;

namespace PedalMasterDesk
{
    public partial class FrmFuncionario : Form
    {


        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUFFuncionarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            var cargo = Cargos.ObterLista();
            cmbCargoFuncionarios.DataSource = cargo;
            cmbCargoFuncionarios.DisplayMember = "Cargo";
            cmbCargoFuncionarios.ValueMember = "Id";

            rdbtnCelular.Checked = true;
            CarregaGrid();
            mskCEPFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskCPFFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskTelefoneFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskRGFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtUFFuncionarios.MaxLength = 2;


        }

        private void rdbtnTelefone_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rdbtnCelular_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new(
                                txtNomeFuncionarios.Text,
                                mskCPFFuncionarios.Text,
                                mskRGFuncionarios.Text,
                                dtpDatNascFuncionarios.Value,
                                Cargos.ObterPorId(Convert.ToInt32(cmbCargoFuncionarios.SelectedValue))
                                );

            Telefone celular = new(
                                mskTelefoneFuncionarios.Text,
                                "Celular",
                                Funcionarios.ObrterPorID(Convert.ToInt32(funcionarios.Id))
                                );

            Email email = new(
                txtEmailFuncionarios.Text,
                Funcionarios.ObrterPorID(Convert.ToInt32(funcionarios.Id))
                );

            Endereco endereco = new(
                txtLogradouroFuncionarios.Text,
                txtNumeroFuncionarios.Text,
                txtBairroFuncionarios.Text,
                txtCidadeFuncionarios.Text,
                txtUFFuncionarios.Text,
                txtComplementoFuncionarios.Text,
                mskCEPFuncionarios.Text,
                Funcionarios.ObrterPorID(funcionarios.Id)
                );


            if (textBoxVazias() && MaskedTextBoxVazias())
            {
                MessageBox.Show("Preencha todas as informações");
            }
            else
            {
                if (mskCEPFuncionarios.TextLength != 9 && txtUFFuncionarios.TextLength != 2)
                {
                    MessageBox.Show("Preencha as informações com valores validos");
                }
                else
                {
                    if (rdbtnCelular.Checked)
                    {
                        if (mskTelefoneFuncionarios.TextLength != 14)
                        {
                            MessageBox.Show("Preencha as informações com valores validos");
                        }
                        else
                        {
                            if (VerificacaoEmails(txtEmailFuncionarios.Text))
                            {
                                if (VerificacaoCPF(mskCPFFuncionarios.Text))
                                {

                                    if (ValidaCpf.Validar(mskCPFFuncionarios.Text))
                                    {


                                        funcionarios.Inserir();

                                        if (funcionarios.Id > 0)
                                        {



                                            email.IdFuncionarios.Id = funcionarios.Id;
                                            endereco.IdFuncionarios.Id = funcionarios.Id;
                                            celular.IdFuncionarios.Id = funcionarios.Id;

                                            email.InserirEmailFuncionarios();
                                            celular.InserirTelefoneFuncionarios();
                                            endereco.InserirEnderecosEmFuncionarios();
                                            if (email.Id > 0 && celular.Id > 0 && endereco.Id > 0)
                                            {
                                                MessageBox.Show($"O Funcionarios {funcionarios.Nome}, " +
                                                $"foi inserido com sucesso , com o ID {funcionarios.Id}");
                                                txtNomeFuncionarios.Clear();
                                                mskCPFFuncionarios.Clear();
                                                mskRGFuncionarios.Clear();
                                                txtEmailFuncionarios.Clear();
                                                mskTelefoneFuncionarios.Clear();
                                                mskCEPFuncionarios.Clear();
                                                txtLogradouroFuncionarios.Clear();
                                                txtNumeroFuncionarios.Clear();
                                                txtBairroFuncionarios.Clear();
                                                txtCidadeFuncionarios.Clear();
                                                txtUFFuncionarios.Clear();
                                                txtComplementoFuncionarios.Clear();
                                                txtNomeFuncionarios.Focus();
                                                FrmFuncionario_Load(sender, e);
                                            }
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("O número é um CPF Inválido !");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Este CPF ja pertence a outro cadastro");

                                }
                            }
                            else
                            {
                                MessageBox.Show("Este email ja pertence a outro cadastro");
                            }

                        }
                    }
                    else
                    {
                        if (mskTelefoneFuncionarios.TextLength != 13)
                        {
                            MessageBox.Show("Preencha as informações com valores validos");
                        }
                        else
                        {
                            if (VerificacaoEmails(txtEmailFuncionarios.Text))
                            {
                                if (VerificacaoCPF(mskCPFFuncionarios.Text))
                                {

                                    if (ValidaCpf.Validar(mskCPFFuncionarios.Text))
                                    {
                                        funcionarios.Inserir();
                                        if (funcionarios.Id > 0)
                                        {

                                            Telefone telefone = new(
                                                mskTelefoneFuncionarios.Text,
                                                "Telefone",
                                                Funcionarios.ObrterPorID(Convert.ToInt32(funcionarios.Id))
                                                );



                                            email.InserirEmailFuncionarios();
                                            telefone.InserirTelefoneFuncionarios();
                                            endereco.InserirEnderecosEmFuncionarios();
                                            if (funcionarios.Id > 0 && email.Id > 0
                                                && telefone.Id > 0 && endereco.Id > 0)
                                            {
                                                MessageBox.Show($"O Funcionarios {funcionarios.Nome}, " +
                                                $"foi inserido com sucesso , com o ID {funcionarios.Id}");
                                                txtNomeFuncionarios.Clear();
                                                mskCPFFuncionarios.Clear();
                                                mskRGFuncionarios.Clear();
                                                txtEmailFuncionarios.Clear();
                                                mskTelefoneFuncionarios.Clear();
                                                mskCEPFuncionarios.Clear();
                                                txtLogradouroFuncionarios.Clear();
                                                txtNumeroFuncionarios.Clear();
                                                txtBairroFuncionarios.Clear();
                                                txtCidadeFuncionarios.Clear();
                                                txtUFFuncionarios.Clear();
                                                txtComplementoFuncionarios.Clear();
                                                txtNomeFuncionarios.Focus();
                                                FrmFuncionario_Load(sender, e);

                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("O número é um CPF Inválido !");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Este CPF ja pertence a outro cadastro");

                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Este email ja pertence a outro cadastro");
                                }
                            }
                        }
                    }
                }

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
            Funcionarios funcionarios = new();
            funcionarios.ObrterPorCPF(CPF);
            if (funcionarios.Id > 0)
            {
                return false;
            }

            return true;




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
        private void CarregaGrid()
        {
            var lista = Funcionarios.ObrterLista();
            dataGridView1.Rows.Clear();
            int cont = 0;


            foreach (var funcionarios in lista)// para cada usuario na lista
            {
                dataGridView1.Rows.Add();//linhas do datagrid usuarios adiciona
                dataGridView1.Rows[cont].Cells[0].Value = funcionarios.Id;//linhas do datagrid usuarios com linha varivael cont e coluna 0 vale usuario id
                dataGridView1.Rows[cont].Cells[1].Value = funcionarios.Nome;//linhas do datagrid usuarios com linha varivael cont e coluna 2 vale usuario Email               


                cont++;//{cont esta em loop para listar os usuarios}
            }



        }

        private void rdbtnCelular_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbtnCelular.Checked)
            {
                mskTelefoneFuncionarios.Mask = "(00)00000-0000";
                mskTelefoneFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
        }

        private void rdbtnTelefone_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbtnTelefone.Checked)
            {
                mskTelefoneFuncionarios.Mask = "(00)0000-0000";
                mskTelefoneFuncionarios.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
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

        private void mskCEPFuncionarios_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}

