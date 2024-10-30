namespace PedalMasterDesk
{
    partial class FrmDgvFuncionariosListagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmail = new DataGridView();
            idemail = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            idFuncionarioEmail = new DataGridViewTextBoxColumn();
            dgvTelefone = new DataGridView();
            idtelefone = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            TipoTelefone = new DataGridViewTextBoxColumn();
            idFuncionariosTelefone = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            btnArquivar = new Button();
            btnAdd = new Button();
            dgvEndereco = new DataGridView();
            idendereco = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Complemento = new DataGridViewTextBoxColumn();
            idFuncionariosEndereco = new DataGridViewTextBoxColumn();
            mskCEPFuncionarios = new MaskedTextBox();
            txtLogradouroFuncionarios = new TextBox();
            txtNumeroFuncionarios = new TextBox();
            txtComplementoFuncionarios = new TextBox();
            txtCidadeFuncionarios = new TextBox();
            txtUFFuncionarios = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtBairroFuncionarios = new TextBox();
            label11 = new Label();
            label7 = new Label();
            rdbtnTelefone = new RadioButton();
            rdbtnCelular = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            txtEmailFuncionarios = new TextBox();
            mskTelefoneFuncionarios = new MaskedTextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnLimparEmail = new Button();
            btnLimparEndereco = new Button();
            btnLimparTelefone = new Button();
            label1 = new Label();
            txtIdEndereco = new TextBox();
            label2 = new Label();
            txtIdEmail = new TextBox();
            label3 = new Label();
            txtIdTelefone = new TextBox();
            lblIdFuncionarios = new Label();
            lblNomeFuncionarios = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTelefone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).BeginInit();
            SuspendLayout();
            // 
            // dgvEmail
            // 
            dgvEmail.AllowUserToAddRows = false;
            dgvEmail.AllowUserToDeleteRows = false;
            dgvEmail.AllowUserToResizeColumns = false;
            dgvEmail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmail.Columns.AddRange(new DataGridViewColumn[] { idemail, mail, idFuncionarioEmail });
            dgvEmail.Location = new Point(13, 44);
            dgvEmail.Name = "dgvEmail";
            dgvEmail.RowHeadersVisible = false;
            dgvEmail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmail.Size = new Size(153, 175);
            dgvEmail.TabIndex = 70;
            dgvEmail.AllowUserToDeleteRowsChanged += dgvEmail_AllowUserToDeleteRowsChanged;
            dgvEmail.CellClick += dgvEmail_CellClick;
            dgvEmail.CellContentClick += dataGridView1_CellContentClick;
            dgvEmail.UserDeletingRow += dgvEmail_UserDeletingRow;
            // 
            // idemail
            // 
            idemail.HeaderText = "id";
            idemail.Name = "idemail";
            idemail.ReadOnly = true;
            idemail.Visible = false;
            // 
            // mail
            // 
            mail.HeaderText = "Email";
            mail.Name = "mail";
            mail.ReadOnly = true;
            mail.Width = 150;
            // 
            // idFuncionarioEmail
            // 
            idFuncionarioEmail.HeaderText = "idFuncionarios";
            idFuncionarioEmail.Name = "idFuncionarioEmail";
            idFuncionarioEmail.Visible = false;
            // 
            // dgvTelefone
            // 
            dgvTelefone.AllowUserToAddRows = false;
            dgvTelefone.AllowUserToDeleteRows = false;
            dgvTelefone.AllowUserToResizeRows = false;
            dgvTelefone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelefone.Columns.AddRange(new DataGridViewColumn[] { idtelefone, dataGridViewTextBoxColumn5, TipoTelefone, idFuncionariosTelefone });
            dgvTelefone.Location = new Point(199, 44);
            dgvTelefone.Name = "dgvTelefone";
            dgvTelefone.RowHeadersVisible = false;
            dgvTelefone.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTelefone.Size = new Size(203, 175);
            dgvTelefone.TabIndex = 72;
            dgvTelefone.CellClick += dgvTelefone_CellClick;
            // 
            // idtelefone
            // 
            idtelefone.HeaderText = "id";
            idtelefone.Name = "idtelefone";
            idtelefone.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // TipoTelefone
            // 
            TipoTelefone.HeaderText = "Tipo";
            TipoTelefone.Name = "TipoTelefone";
            TipoTelefone.ReadOnly = true;
            // 
            // idFuncionariosTelefone
            // 
            idFuncionariosTelefone.HeaderText = "idFuncionarios";
            idFuncionariosTelefone.Name = "idFuncionariosTelefone";
            idFuncionariosTelefone.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(17, 457);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 27);
            btnEditar.TabIndex = 73;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnArquivar
            // 
            btnArquivar.Location = new Point(130, 457);
            btnArquivar.Name = "btnArquivar";
            btnArquivar.Size = new Size(99, 27);
            btnArquivar.TabIndex = 74;
            btnArquivar.Text = "Arquivar";
            btnArquivar.UseVisualStyleBackColor = true;
            btnArquivar.Click += btnArquivar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(245, 458);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 27);
            btnAdd.TabIndex = 75;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvEndereco
            // 
            dgvEndereco.AllowUserToAddRows = false;
            dgvEndereco.AllowUserToDeleteRows = false;
            dgvEndereco.AllowUserToResizeRows = false;
            dgvEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEndereco.Columns.AddRange(new DataGridViewColumn[] { idendereco, CEP, Numero, Complemento, idFuncionariosEndereco });
            dgvEndereco.Location = new Point(435, 44);
            dgvEndereco.Name = "dgvEndereco";
            dgvEndereco.RowHeadersVisible = false;
            dgvEndereco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEndereco.Size = new Size(353, 175);
            dgvEndereco.TabIndex = 71;
            dgvEndereco.CellContentClick += dgvEndereco_CellContentClick;
            // 
            // idendereco
            // 
            idendereco.HeaderText = "id";
            idendereco.Name = "idendereco";
            idendereco.Visible = false;
            // 
            // CEP
            // 
            CEP.HeaderText = "CEP";
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            // 
            // Numero
            // 
            Numero.HeaderText = "Numero";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            // 
            // Complemento
            // 
            Complemento.HeaderText = "Complemento";
            Complemento.Name = "Complemento";
            Complemento.ReadOnly = true;
            Complemento.Width = 150;
            // 
            // idFuncionariosEndereco
            // 
            idFuncionariosEndereco.HeaderText = "idFuncionarios";
            idFuncionariosEndereco.Name = "idFuncionariosEndereco";
            idFuncionariosEndereco.Visible = false;
            // 
            // mskCEPFuncionarios
            // 
            mskCEPFuncionarios.Location = new Point(536, 257);
            mskCEPFuncionarios.Mask = "00000-999";
            mskCEPFuncionarios.Name = "mskCEPFuncionarios";
            mskCEPFuncionarios.ReadOnly = true;
            mskCEPFuncionarios.Size = new Size(62, 23);
            mskCEPFuncionarios.TabIndex = 83;
            mskCEPFuncionarios.KeyPress += mskCEPFuncionarios_KeyPress;
            // 
            // txtLogradouroFuncionarios
            // 
            txtLogradouroFuncionarios.Location = new Point(625, 257);
            txtLogradouroFuncionarios.Name = "txtLogradouroFuncionarios";
            txtLogradouroFuncionarios.ReadOnly = true;
            txtLogradouroFuncionarios.Size = new Size(134, 23);
            txtLogradouroFuncionarios.TabIndex = 84;
            // 
            // txtNumeroFuncionarios
            // 
            txtNumeroFuncionarios.Location = new Point(435, 328);
            txtNumeroFuncionarios.Name = "txtNumeroFuncionarios";
            txtNumeroFuncionarios.ReadOnly = true;
            txtNumeroFuncionarios.Size = new Size(100, 23);
            txtNumeroFuncionarios.TabIndex = 85;
            // 
            // txtComplementoFuncionarios
            // 
            txtComplementoFuncionarios.Location = new Point(557, 402);
            txtComplementoFuncionarios.Name = "txtComplementoFuncionarios";
            txtComplementoFuncionarios.ReadOnly = true;
            txtComplementoFuncionarios.Size = new Size(100, 23);
            txtComplementoFuncionarios.TabIndex = 86;
            // 
            // txtCidadeFuncionarios
            // 
            txtCidadeFuncionarios.Location = new Point(435, 402);
            txtCidadeFuncionarios.Name = "txtCidadeFuncionarios";
            txtCidadeFuncionarios.ReadOnly = true;
            txtCidadeFuncionarios.Size = new Size(100, 23);
            txtCidadeFuncionarios.TabIndex = 87;
            // 
            // txtUFFuncionarios
            // 
            txtUFFuncionarios.Location = new Point(700, 328);
            txtUFFuncionarios.Name = "txtUFFuncionarios";
            txtUFFuncionarios.ReadOnly = true;
            txtUFFuncionarios.Size = new Size(35, 23);
            txtUFFuncionarios.TabIndex = 88;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(536, 229);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 89;
            label8.Text = "CEP";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(625, 229);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 90;
            label9.Text = "Logradouro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(435, 299);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 91;
            label10.Text = "Numero";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(435, 375);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 92;
            label12.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(700, 299);
            label13.Name = "label13";
            label13.Size = new Size(21, 15);
            label13.TabIndex = 93;
            label13.Text = "UF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(557, 375);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 94;
            label14.Text = "Complemento";
            // 
            // txtBairroFuncionarios
            // 
            txtBairroFuncionarios.Location = new Point(557, 328);
            txtBairroFuncionarios.Name = "txtBairroFuncionarios";
            txtBairroFuncionarios.ReadOnly = true;
            txtBairroFuncionarios.Size = new Size(119, 23);
            txtBairroFuncionarios.TabIndex = 95;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(557, 299);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 96;
            label11.Text = "Bairro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 300);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 103;
            label7.Text = "Tipo";
            // 
            // rdbtnTelefone
            // 
            rdbtnTelefone.AutoSize = true;
            rdbtnTelefone.Enabled = false;
            rdbtnTelefone.Location = new Point(333, 358);
            rdbtnTelefone.Name = "rdbtnTelefone";
            rdbtnTelefone.Size = new Size(69, 19);
            rdbtnTelefone.TabIndex = 102;
            rdbtnTelefone.TabStop = true;
            rdbtnTelefone.Text = "Telefone";
            rdbtnTelefone.UseVisualStyleBackColor = true;
            rdbtnTelefone.CheckedChanged += rdbtnTelefone_CheckedChanged;
            // 
            // rdbtnCelular
            // 
            rdbtnCelular.AutoSize = true;
            rdbtnCelular.Enabled = false;
            rdbtnCelular.Location = new Point(333, 328);
            rdbtnCelular.Name = "rdbtnCelular";
            rdbtnCelular.Size = new Size(62, 19);
            rdbtnCelular.TabIndex = 101;
            rdbtnCelular.TabStop = true;
            rdbtnCelular.Text = "Celular";
            rdbtnCelular.UseVisualStyleBackColor = true;
            rdbtnCelular.CheckedChanged += rdbtnCelular_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 295);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 100;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 296);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 99;
            label5.Text = "Numero de telefone";
            // 
            // txtEmailFuncionarios
            // 
            txtEmailFuncionarios.Location = new Point(12, 327);
            txtEmailFuncionarios.Name = "txtEmailFuncionarios";
            txtEmailFuncionarios.ReadOnly = true;
            txtEmailFuncionarios.Size = new Size(167, 23);
            txtEmailFuncionarios.TabIndex = 98;
            // 
            // mskTelefoneFuncionarios
            // 
            mskTelefoneFuncionarios.Location = new Point(202, 328);
            mskTelefoneFuncionarios.Mask = "(00) 00000-0000";
            mskTelefoneFuncionarios.Name = "mskTelefoneFuncionarios";
            mskTelefoneFuncionarios.ReadOnly = true;
            mskTelefoneFuncionarios.Size = new Size(87, 23);
            mskTelefoneFuncionarios.TabIndex = 97;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(12, 12);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(99, 23);
            btnSalvar.TabIndex = 104;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(684, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 23);
            btnCancelar.TabIndex = 105;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimparEmail
            // 
            btnLimparEmail.Location = new Point(11, 357);
            btnLimparEmail.Name = "btnLimparEmail";
            btnLimparEmail.Size = new Size(75, 23);
            btnLimparEmail.TabIndex = 106;
            btnLimparEmail.Text = "Limpar";
            btnLimparEmail.UseVisualStyleBackColor = true;
            btnLimparEmail.Click += btnLimparEmail_Click;
            // 
            // btnLimparEndereco
            // 
            btnLimparEndereco.Location = new Point(684, 402);
            btnLimparEndereco.Name = "btnLimparEndereco";
            btnLimparEndereco.Size = new Size(75, 23);
            btnLimparEndereco.TabIndex = 107;
            btnLimparEndereco.Text = "Limpar";
            btnLimparEndereco.UseVisualStyleBackColor = true;
            btnLimparEndereco.Click += btnLimparEndereco_Click;
            // 
            // btnLimparTelefone
            // 
            btnLimparTelefone.Location = new Point(202, 358);
            btnLimparTelefone.Name = "btnLimparTelefone";
            btnLimparTelefone.Size = new Size(75, 23);
            btnLimparTelefone.TabIndex = 108;
            btnLimparTelefone.Text = "Limpar";
            btnLimparTelefone.UseVisualStyleBackColor = true;
            btnLimparTelefone.Click += btnLimparTelefone_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 229);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 110;
            label1.Text = "ID";
            // 
            // txtIdEndereco
            // 
            txtIdEndereco.Location = new Point(435, 257);
            txtIdEndereco.Name = "txtIdEndereco";
            txtIdEndereco.ReadOnly = true;
            txtIdEndereco.Size = new Size(70, 23);
            txtIdEndereco.TabIndex = 109;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 229);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 112;
            label2.Text = "ID";
            // 
            // txtIdEmail
            // 
            txtIdEmail.Location = new Point(13, 257);
            txtIdEmail.Name = "txtIdEmail";
            txtIdEmail.ReadOnly = true;
            txtIdEmail.Size = new Size(70, 23);
            txtIdEmail.TabIndex = 111;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 229);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 114;
            label3.Text = "ID";
            // 
            // txtIdTelefone
            // 
            txtIdTelefone.Location = new Point(202, 257);
            txtIdTelefone.Name = "txtIdTelefone";
            txtIdTelefone.ReadOnly = true;
            txtIdTelefone.Size = new Size(70, 23);
            txtIdTelefone.TabIndex = 113;
            // 
            // lblIdFuncionarios
            // 
            lblIdFuncionarios.AutoSize = true;
            lblIdFuncionarios.Location = new Point(234, 9);
            lblIdFuncionarios.Name = "lblIdFuncionarios";
            lblIdFuncionarios.Size = new Size(38, 15);
            lblIdFuncionarios.TabIndex = 115;
            lblIdFuncionarios.Text = "label4";
            // 
            // lblNomeFuncionarios
            // 
            lblNomeFuncionarios.AutoSize = true;
            lblNomeFuncionarios.Location = new Point(294, 9);
            lblNomeFuncionarios.Name = "lblNomeFuncionarios";
            lblNomeFuncionarios.Size = new Size(44, 15);
            lblNomeFuncionarios.TabIndex = 116;
            lblNomeFuncionarios.Text = "label15";
            // 
            // FrmDgvFuncionariosListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(lblNomeFuncionarios);
            Controls.Add(lblIdFuncionarios);
            Controls.Add(label3);
            Controls.Add(txtIdTelefone);
            Controls.Add(label2);
            Controls.Add(txtIdEmail);
            Controls.Add(label1);
            Controls.Add(txtIdEndereco);
            Controls.Add(btnLimparTelefone);
            Controls.Add(btnLimparEndereco);
            Controls.Add(btnLimparEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label7);
            Controls.Add(rdbtnTelefone);
            Controls.Add(rdbtnCelular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmailFuncionarios);
            Controls.Add(mskTelefoneFuncionarios);
            Controls.Add(label11);
            Controls.Add(txtBairroFuncionarios);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtUFFuncionarios);
            Controls.Add(txtCidadeFuncionarios);
            Controls.Add(txtComplementoFuncionarios);
            Controls.Add(txtNumeroFuncionarios);
            Controls.Add(txtLogradouroFuncionarios);
            Controls.Add(mskCEPFuncionarios);
            Controls.Add(btnAdd);
            Controls.Add(btnArquivar);
            Controls.Add(btnEditar);
            Controls.Add(dgvTelefone);
            Controls.Add(dgvEndereco);
            Controls.Add(dgvEmail);
            Name = "FrmDgvFuncionariosListagem";
            Text = "FrmDgvFuncionariosListagem";
            Load += FrmDgvFuncionariosListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTelefone).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmail;
        private DataGridView dgvTelefone;
        private Button btnEditar;
        private Button btnArquivar;
        private Button btnAdd;
        private DataGridView dgvEndereco;
        private MaskedTextBox mskCEPFuncionarios;
        private TextBox txtLogradouroFuncionarios;
        private TextBox txtNumeroFuncionarios;
        private TextBox txtComplementoFuncionarios;
        private TextBox txtCidadeFuncionarios;
        private TextBox txtUFFuncionarios;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtBairroFuncionarios;
        private Label label11;
        private Label label7;
        private RadioButton rdbtnTelefone;
        private RadioButton rdbtnCelular;
        private Label label6;
        private Label label5;
        private TextBox txtEmailFuncionarios;
        private MaskedTextBox mskTelefoneFuncionarios;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnLimparEmail;
        private Button btnLimparEndereco;
        private Button btnLimparTelefone;
        private Label label1;
        private TextBox txtIdEndereco;
        private Label label2;
        private TextBox txtIdEmail;
        private Label label3;
        private TextBox txtIdTelefone;
        private DataGridViewTextBoxColumn idemail;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn idFuncionarioEmail;
        private DataGridViewTextBoxColumn idtelefone;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn TipoTelefone;
        private DataGridViewTextBoxColumn idFuncionariosTelefone;
        private DataGridViewTextBoxColumn idendereco;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn idFuncionariosEndereco;
        private Label lblIdFuncionarios;
        private Label lblNomeFuncionarios;
    }
}