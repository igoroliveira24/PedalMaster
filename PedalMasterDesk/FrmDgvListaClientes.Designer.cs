namespace PedalMasterDesk
{
    partial class FrmDgvListaClientes
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
            lblNomeClientes = new Label();
            lblIdClientes = new Label();
            label3 = new Label();
            txtIdTelefone = new TextBox();
            label2 = new Label();
            txtIdEmail = new TextBox();
            label1 = new Label();
            txtIdEndereco = new TextBox();
            btnLimparTelefone = new Button();
            btnLimparEndereco = new Button();
            btnLimparEmail = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            label7 = new Label();
            rdbtnTelefone = new RadioButton();
            rdbtnCelular = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            txtEmailClientes = new TextBox();
            mskTelefoneClientes = new MaskedTextBox();
            label11 = new Label();
            txtBairroClientes = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtUFClientes = new TextBox();
            txtCidadeClientes = new TextBox();
            txtComplementoClientes = new TextBox();
            txtNumeroClientes = new TextBox();
            txtLogradouroClientes = new TextBox();
            mskCEPClientes = new MaskedTextBox();
            btnAdd = new Button();
            btnArquivar = new Button();
            btnEditar = new Button();
            dgvTelefone = new DataGridView();
            idtelefone = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            TipoTelefone = new DataGridViewTextBoxColumn();
            idFuncionariosTelefone = new DataGridViewTextBoxColumn();
            dgvEndereco = new DataGridView();
            idendereco = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Complemento = new DataGridViewTextBoxColumn();
            idFuncionariosEndereco = new DataGridViewTextBoxColumn();
            dgvEmail = new DataGridView();
            idemail = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            idFuncionarioEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTelefone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmail).BeginInit();
            SuspendLayout();
            // 
            // lblNomeClientes
            // 
            lblNomeClientes.AutoSize = true;
            lblNomeClientes.Location = new Point(289, 3);
            lblNomeClientes.Name = "lblNomeClientes";
            lblNomeClientes.Size = new Size(44, 15);
            lblNomeClientes.TabIndex = 156;
            lblNomeClientes.Text = "label15";
            // 
            // lblIdClientes
            // 
            lblIdClientes.AutoSize = true;
            lblIdClientes.Location = new Point(229, 3);
            lblIdClientes.Name = "lblIdClientes";
            lblIdClientes.Size = new Size(38, 15);
            lblIdClientes.TabIndex = 155;
            lblIdClientes.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 223);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 154;
            label3.Text = "ID";
            // 
            // txtIdTelefone
            // 
            txtIdTelefone.Location = new Point(197, 251);
            txtIdTelefone.Name = "txtIdTelefone";
            txtIdTelefone.ReadOnly = true;
            txtIdTelefone.Size = new Size(70, 23);
            txtIdTelefone.TabIndex = 153;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 223);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 152;
            label2.Text = "ID";
            // 
            // txtIdEmail
            // 
            txtIdEmail.Location = new Point(8, 251);
            txtIdEmail.Name = "txtIdEmail";
            txtIdEmail.ReadOnly = true;
            txtIdEmail.Size = new Size(70, 23);
            txtIdEmail.TabIndex = 151;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 223);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 150;
            label1.Text = "ID";
            // 
            // txtIdEndereco
            // 
            txtIdEndereco.Location = new Point(430, 251);
            txtIdEndereco.Name = "txtIdEndereco";
            txtIdEndereco.ReadOnly = true;
            txtIdEndereco.Size = new Size(70, 23);
            txtIdEndereco.TabIndex = 149;
            // 
            // btnLimparTelefone
            // 
            btnLimparTelefone.Location = new Point(197, 352);
            btnLimparTelefone.Name = "btnLimparTelefone";
            btnLimparTelefone.Size = new Size(75, 23);
            btnLimparTelefone.TabIndex = 148;
            btnLimparTelefone.Text = "Limpar";
            btnLimparTelefone.UseVisualStyleBackColor = true;
            btnLimparTelefone.Click += btnLimparTelefone_Click;
            // 
            // btnLimparEndereco
            // 
            btnLimparEndereco.Location = new Point(679, 396);
            btnLimparEndereco.Name = "btnLimparEndereco";
            btnLimparEndereco.Size = new Size(75, 23);
            btnLimparEndereco.TabIndex = 147;
            btnLimparEndereco.Text = "Limpar";
            btnLimparEndereco.UseVisualStyleBackColor = true;
            btnLimparEndereco.Click += btnLimparEndereco_Click;
            // 
            // btnLimparEmail
            // 
            btnLimparEmail.Location = new Point(6, 351);
            btnLimparEmail.Name = "btnLimparEmail";
            btnLimparEmail.Size = new Size(75, 23);
            btnLimparEmail.TabIndex = 146;
            btnLimparEmail.Text = "Limpar";
            btnLimparEmail.UseVisualStyleBackColor = true;
            btnLimparEmail.Click += btnLimparEmail_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(679, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 23);
            btnCancelar.TabIndex = 145;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(7, 6);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(99, 23);
            btnSalvar.TabIndex = 144;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(328, 294);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 143;
            label7.Text = "Tipo";
            // 
            // rdbtnTelefone
            // 
            rdbtnTelefone.AutoSize = true;
            rdbtnTelefone.Enabled = false;
            rdbtnTelefone.Location = new Point(328, 352);
            rdbtnTelefone.Name = "rdbtnTelefone";
            rdbtnTelefone.Size = new Size(69, 19);
            rdbtnTelefone.TabIndex = 142;
            rdbtnTelefone.TabStop = true;
            rdbtnTelefone.Text = "Telefone";
            rdbtnTelefone.UseVisualStyleBackColor = true;
            rdbtnTelefone.CheckedChanged += rdbtnTelefone_CheckedChanged;
            // 
            // rdbtnCelular
            // 
            rdbtnCelular.AutoSize = true;
            rdbtnCelular.Enabled = false;
            rdbtnCelular.Location = new Point(328, 322);
            rdbtnCelular.Name = "rdbtnCelular";
            rdbtnCelular.Size = new Size(62, 19);
            rdbtnCelular.TabIndex = 141;
            rdbtnCelular.TabStop = true;
            rdbtnCelular.Text = "Celular";
            rdbtnCelular.UseVisualStyleBackColor = true;
            rdbtnCelular.CheckedChanged += rdbtnCelular_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 290);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 140;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 290);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 139;
            label5.Text = "Numero de telefone";
            // 
            // txtEmailClientes
            // 
            txtEmailClientes.Location = new Point(7, 321);
            txtEmailClientes.Name = "txtEmailClientes";
            txtEmailClientes.ReadOnly = true;
            txtEmailClientes.Size = new Size(167, 23);
            txtEmailClientes.TabIndex = 138;
            // 
            // mskTelefoneClientes
            // 
            mskTelefoneClientes.Location = new Point(197, 322);
            mskTelefoneClientes.Mask = "(00) 00000-0000";
            mskTelefoneClientes.Name = "mskTelefoneClientes";
            mskTelefoneClientes.ReadOnly = true;
            mskTelefoneClientes.Size = new Size(87, 23);
            mskTelefoneClientes.TabIndex = 137;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(552, 293);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 136;
            label11.Text = "Bairro";
            // 
            // txtBairroClientes
            // 
            txtBairroClientes.Location = new Point(552, 322);
            txtBairroClientes.Name = "txtBairroClientes";
            txtBairroClientes.ReadOnly = true;
            txtBairroClientes.Size = new Size(119, 23);
            txtBairroClientes.TabIndex = 135;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(552, 369);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 134;
            label14.Text = "Complemento";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(695, 293);
            label13.Name = "label13";
            label13.Size = new Size(21, 15);
            label13.TabIndex = 133;
            label13.Text = "UF";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(430, 369);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 132;
            label12.Text = "Cidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(430, 293);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 131;
            label10.Text = "Numero";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(620, 223);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 130;
            label9.Text = "Logradouro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(531, 223);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 129;
            label8.Text = "CEP";
            // 
            // txtUFClientes
            // 
            txtUFClientes.Location = new Point(695, 322);
            txtUFClientes.Name = "txtUFClientes";
            txtUFClientes.ReadOnly = true;
            txtUFClientes.Size = new Size(35, 23);
            txtUFClientes.TabIndex = 128;
            // 
            // txtCidadeClientes
            // 
            txtCidadeClientes.Location = new Point(430, 396);
            txtCidadeClientes.Name = "txtCidadeClientes";
            txtCidadeClientes.ReadOnly = true;
            txtCidadeClientes.Size = new Size(100, 23);
            txtCidadeClientes.TabIndex = 127;
            // 
            // txtComplementoClientes
            // 
            txtComplementoClientes.Location = new Point(552, 396);
            txtComplementoClientes.Name = "txtComplementoClientes";
            txtComplementoClientes.ReadOnly = true;
            txtComplementoClientes.Size = new Size(100, 23);
            txtComplementoClientes.TabIndex = 126;
            // 
            // txtNumeroClientes
            // 
            txtNumeroClientes.Location = new Point(430, 322);
            txtNumeroClientes.Name = "txtNumeroClientes";
            txtNumeroClientes.ReadOnly = true;
            txtNumeroClientes.Size = new Size(100, 23);
            txtNumeroClientes.TabIndex = 125;
            // 
            // txtLogradouroClientes
            // 
            txtLogradouroClientes.Location = new Point(620, 251);
            txtLogradouroClientes.Name = "txtLogradouroClientes";
            txtLogradouroClientes.ReadOnly = true;
            txtLogradouroClientes.Size = new Size(134, 23);
            txtLogradouroClientes.TabIndex = 124;
            // 
            // mskCEPClientes
            // 
            mskCEPClientes.Location = new Point(531, 251);
            mskCEPClientes.Mask = "00000-999";
            mskCEPClientes.Name = "mskCEPClientes";
            mskCEPClientes.ReadOnly = true;
            mskCEPClientes.Size = new Size(62, 23);
            mskCEPClientes.TabIndex = 123;
            mskCEPClientes.KeyPress += mskCEPFuncionarios_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(240, 452);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 27);
            btnAdd.TabIndex = 122;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnArquivar
            // 
            btnArquivar.Location = new Point(125, 451);
            btnArquivar.Name = "btnArquivar";
            btnArquivar.Size = new Size(99, 27);
            btnArquivar.TabIndex = 121;
            btnArquivar.Text = "Arquivar";
            btnArquivar.UseVisualStyleBackColor = true;
            btnArquivar.Click += btnArquivar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 451);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 27);
            btnEditar.TabIndex = 120;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvTelefone
            // 
            dgvTelefone.AllowUserToAddRows = false;
            dgvTelefone.AllowUserToDeleteRows = false;
            dgvTelefone.AllowUserToResizeRows = false;
            dgvTelefone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelefone.Columns.AddRange(new DataGridViewColumn[] { idtelefone, dataGridViewTextBoxColumn5, TipoTelefone, idFuncionariosTelefone });
            dgvTelefone.Location = new Point(194, 38);
            dgvTelefone.Name = "dgvTelefone";
            dgvTelefone.RowHeadersVisible = false;
            dgvTelefone.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTelefone.Size = new Size(203, 175);
            dgvTelefone.TabIndex = 119;
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
            // dgvEndereco
            // 
            dgvEndereco.AllowUserToAddRows = false;
            dgvEndereco.AllowUserToDeleteRows = false;
            dgvEndereco.AllowUserToResizeRows = false;
            dgvEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEndereco.Columns.AddRange(new DataGridViewColumn[] { idendereco, CEP, Numero, Complemento, idFuncionariosEndereco });
            dgvEndereco.Location = new Point(430, 38);
            dgvEndereco.Name = "dgvEndereco";
            dgvEndereco.RowHeadersVisible = false;
            dgvEndereco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEndereco.Size = new Size(353, 175);
            dgvEndereco.TabIndex = 118;
            dgvEndereco.CellClick += dgvEndereco_CellClick;
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
            // dgvEmail
            // 
            dgvEmail.AllowUserToAddRows = false;
            dgvEmail.AllowUserToDeleteRows = false;
            dgvEmail.AllowUserToResizeColumns = false;
            dgvEmail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmail.Columns.AddRange(new DataGridViewColumn[] { idemail, mail, idFuncionarioEmail });
            dgvEmail.Location = new Point(8, 38);
            dgvEmail.Name = "dgvEmail";
            dgvEmail.RowHeadersVisible = false;
            dgvEmail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmail.Size = new Size(153, 175);
            dgvEmail.TabIndex = 117;
            dgvEmail.CellClick += dgvEmail_CellClick;
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
            // FrmDgvListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(lblNomeClientes);
            Controls.Add(lblIdClientes);
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
            Controls.Add(txtEmailClientes);
            Controls.Add(mskTelefoneClientes);
            Controls.Add(label11);
            Controls.Add(txtBairroClientes);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtUFClientes);
            Controls.Add(txtCidadeClientes);
            Controls.Add(txtComplementoClientes);
            Controls.Add(txtNumeroClientes);
            Controls.Add(txtLogradouroClientes);
            Controls.Add(mskCEPClientes);
            Controls.Add(btnAdd);
            Controls.Add(btnArquivar);
            Controls.Add(btnEditar);
            Controls.Add(dgvTelefone);
            Controls.Add(dgvEndereco);
            Controls.Add(dgvEmail);
            Name = "FrmDgvListaClientes";
            Text = "FrmDgvListaClientes";
            Load += FrmDgvListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTelefone).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeClientes;
        private Label lblIdClientes;
        private Label label3;
        private TextBox txtIdTelefone;
        private Label label2;
        private TextBox txtIdEmail;
        private Label label1;
        private TextBox txtIdEndereco;
        private Button btnLimparTelefone;
        private Button btnLimparEndereco;
        private Button btnLimparEmail;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label label7;
        private RadioButton rdbtnTelefone;
        private RadioButton rdbtnCelular;
        private Label label6;
        private Label label5;
        private TextBox txtEmailClientes;
        private MaskedTextBox mskTelefoneClientes;
        private Label label11;
        private TextBox txtBairroClientes;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtUFClientes;
        private TextBox txtCidadeClientes;
        private TextBox txtComplementoClientes;
        private TextBox txtNumeroClientes;
        private TextBox txtLogradouroClientes;
        private MaskedTextBox mskCEPClientes;
        private Button btnAdd;
        private Button btnArquivar;
        private Button btnEditar;
        private DataGridView dgvTelefone;
        private DataGridViewTextBoxColumn idtelefone;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn TipoTelefone;
        private DataGridViewTextBoxColumn idFuncionariosTelefone;
        private DataGridView dgvEndereco;
        private DataGridViewTextBoxColumn idendereco;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn idFuncionariosEndereco;
        private DataGridView dgvEmail;
        private DataGridViewTextBoxColumn idemail;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn idFuncionarioEmail;
    }
}