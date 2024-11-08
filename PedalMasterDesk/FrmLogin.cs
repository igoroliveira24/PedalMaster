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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Deseja realmente cancelar o login?", "Cancelar", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                Email email = new();

                email.ObterPorEmail(txtEmail.Text);

                var funcionarios = Funcionarios.EfetuarLogin(email.Id, txtSenha.Text);


                if (funcionarios.IdLogin > 0)
                {
                    funcionarios = Funcionarios.ObrterPorID(funcionarios.Id);
                    email = Email.ObterPorId(email.Id);
                    if (funcionarios.Ativo)
                    {
                        Program.UsuarioLogado = funcionarios;
                        Program.EmailUsuarioLogado = email;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu usuario está inativo. \nProcure a gerência.");
                        Application.Exit();
                    }
                    
                    
                    
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha invalidos ou inexistentes. \nProcure a gerência");
                    txtEmail.Focus();
                }

            }
            else
            {
                MessageBox.Show("Você deve preencher email e senha.");
                txtEmail.Focus();
            }
        }
    }
}
