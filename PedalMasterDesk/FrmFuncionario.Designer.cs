namespace PedalMasterDesk
{
    partial class FrmFuncionario
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
            btnCadastrarClientes = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            txtUFFuncionarios = new TextBox();
            txtCidadeFuncionarios = new TextBox();
            txtComplementoFuncionarios = new TextBox();
            txtBairroFuncionarios = new TextBox();
            txtNumeroFuncionarios = new TextBox();
            txtLogradouroFuncionarios = new TextBox();
            mskCEPFuncionarios = new MaskedTextBox();
            dtpDatNascFuncionarios = new DateTimePicker();
            label7 = new Label();
            rdbtnTelefone = new RadioButton();
            rdbtnCelular = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            txtEmailFuncionarios = new TextBox();
            mskTelefoneFuncionarios = new MaskedTextBox();
            mskCPFFuncionarios = new MaskedTextBox();
            txtNomeFuncionarios = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mskRGFuncionarios = new MaskedTextBox();
            label15 = new Label();
            label16 = new Label();
            cmbCargoFuncionarios = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrarClientes
            // 
            btnCadastrarClientes.Location = new Point(327, 369);
            btnCadastrarClientes.Name = "btnCadastrarClientes";
            btnCadastrarClientes.Size = new Size(126, 38);
            btnCadastrarClientes.TabIndex = 76;
            btnCadastrarClientes.Text = "&Cadastrar";
            btnCadastrarClientes.UseVisualStyleBackColor = true;
            btnCadastrarClientes.Click += btnCadastrarClientes_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(201, 347);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 75;
            label14.Text = "Complemento";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(141, 347);
            label13.Name = "label13";
            label13.Size = new Size(21, 15);
            label13.TabIndex = 74;
            label13.Text = "UF";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 347);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 73;
            label12.Text = "Cidade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(388, 269);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 72;
            label11.Text = "Bairro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(264, 269);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 71;
            label10.Text = "Numero";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(107, 269);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 70;
            label9.Text = "Logradouro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 269);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 69;
            label8.Text = "CEP";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome });
            dataGridView1.Location = new Point(532, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(250, 334);
            dataGridView1.TabIndex = 68;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 197;
            // 
            // txtUFFuncionarios
            // 
            txtUFFuncionarios.Location = new Point(141, 384);
            txtUFFuncionarios.Name = "txtUFFuncionarios";
            txtUFFuncionarios.ReadOnly = true;
            txtUFFuncionarios.Size = new Size(35, 23);
            txtUFFuncionarios.TabIndex = 67;
            txtUFFuncionarios.TextChanged += txtUFFuncionarios_TextChanged;
            // 
            // txtCidadeFuncionarios
            // 
            txtCidadeFuncionarios.Location = new Point(18, 384);
            txtCidadeFuncionarios.Name = "txtCidadeFuncionarios";
            txtCidadeFuncionarios.ReadOnly = true;
            txtCidadeFuncionarios.Size = new Size(100, 23);
            txtCidadeFuncionarios.TabIndex = 66;
            // 
            // txtComplementoFuncionarios
            // 
            txtComplementoFuncionarios.Location = new Point(201, 384);
            txtComplementoFuncionarios.Name = "txtComplementoFuncionarios";
            txtComplementoFuncionarios.Size = new Size(100, 23);
            txtComplementoFuncionarios.TabIndex = 65;
            // 
            // txtBairroFuncionarios
            // 
            txtBairroFuncionarios.Location = new Point(388, 306);
            txtBairroFuncionarios.Name = "txtBairroFuncionarios";
            txtBairroFuncionarios.ReadOnly = true;
            txtBairroFuncionarios.Size = new Size(119, 23);
            txtBairroFuncionarios.TabIndex = 64;
            // 
            // txtNumeroFuncionarios
            // 
            txtNumeroFuncionarios.Location = new Point(264, 306);
            txtNumeroFuncionarios.Name = "txtNumeroFuncionarios";
            txtNumeroFuncionarios.Size = new Size(100, 23);
            txtNumeroFuncionarios.TabIndex = 63;
            // 
            // txtLogradouroFuncionarios
            // 
            txtLogradouroFuncionarios.Location = new Point(107, 306);
            txtLogradouroFuncionarios.Name = "txtLogradouroFuncionarios";
            txtLogradouroFuncionarios.ReadOnly = true;
            txtLogradouroFuncionarios.Size = new Size(134, 23);
            txtLogradouroFuncionarios.TabIndex = 62;
            // 
            // mskCEPFuncionarios
            // 
            mskCEPFuncionarios.Location = new Point(18, 306);
            mskCEPFuncionarios.Mask = "00000-999";
            mskCEPFuncionarios.Name = "mskCEPFuncionarios";
            mskCEPFuncionarios.Size = new Size(62, 23);
            mskCEPFuncionarios.TabIndex = 61;
            mskCEPFuncionarios.MaskInputRejected += mskCEPFuncionarios_MaskInputRejected;
            mskCEPFuncionarios.KeyPress += mskCEPFuncionarios_KeyPress;
            // 
            // dtpDatNascFuncionarios
            // 
            dtpDatNascFuncionarios.Location = new Point(307, 97);
            dtpDatNascFuncionarios.Name = "dtpDatNascFuncionarios";
            dtpDatNascFuncionarios.Size = new Size(200, 23);
            dtpDatNascFuncionarios.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 196);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 59;
            label7.Text = "Tipo";
            // 
            // rdbtnTelefone
            // 
            rdbtnTelefone.AutoSize = true;
            rdbtnTelefone.Location = new Point(404, 229);
            rdbtnTelefone.Name = "rdbtnTelefone";
            rdbtnTelefone.Size = new Size(69, 19);
            rdbtnTelefone.TabIndex = 58;
            rdbtnTelefone.TabStop = true;
            rdbtnTelefone.Text = "Telefone";
            rdbtnTelefone.UseVisualStyleBackColor = true;
            rdbtnTelefone.CheckedChanged += rdbtnTelefone_CheckedChanged_1;
            // 
            // rdbtnCelular
            // 
            rdbtnCelular.AutoSize = true;
            rdbtnCelular.Location = new Point(336, 229);
            rdbtnCelular.Name = "rdbtnCelular";
            rdbtnCelular.Size = new Size(62, 19);
            rdbtnCelular.TabIndex = 57;
            rdbtnCelular.TabStop = true;
            rdbtnCelular.Text = "Celular";
            rdbtnCelular.UseVisualStyleBackColor = true;
            rdbtnCelular.CheckedChanged += rdbtnCelular_CheckedChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 196);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 56;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 196);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 55;
            label5.Text = "Numero de telefone";
            // 
            // txtEmailFuncionarios
            // 
            txtEmailFuncionarios.Location = new Point(18, 228);
            txtEmailFuncionarios.Name = "txtEmailFuncionarios";
            txtEmailFuncionarios.Size = new Size(191, 23);
            txtEmailFuncionarios.TabIndex = 54;
            // 
            // mskTelefoneFuncionarios
            // 
            mskTelefoneFuncionarios.Location = new Point(215, 228);
            mskTelefoneFuncionarios.Mask = "(00) 00000-0000";
            mskTelefoneFuncionarios.Name = "mskTelefoneFuncionarios";
            mskTelefoneFuncionarios.Size = new Size(87, 23);
            mskTelefoneFuncionarios.TabIndex = 53;
            // 
            // mskCPFFuncionarios
            // 
            mskCPFFuncionarios.Location = new Point(216, 97);
            mskCPFFuncionarios.Mask = "000.000.000-00";
            mskCPFFuncionarios.Name = "mskCPFFuncionarios";
            mskCPFFuncionarios.Size = new Size(85, 23);
            mskCPFFuncionarios.TabIndex = 52;
            // 
            // txtNomeFuncionarios
            // 
            txtNomeFuncionarios.Location = new Point(18, 97);
            txtNomeFuncionarios.Name = "txtNomeFuncionarios";
            txtNomeFuncionarios.Size = new Size(192, 23);
            txtNomeFuncionarios.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 66);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 50;
            label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 66);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 49;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 48;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 20);
            label1.Name = "label1";
            label1.Size = new Size(331, 25);
            label1.TabIndex = 47;
            label1.Text = "Pagina de Cadastro de Funcionarios";
            label1.Click += label1_Click;
            // 
            // mskRGFuncionarios
            // 
            mskRGFuncionarios.Location = new Point(18, 159);
            mskRGFuncionarios.Mask = "00.000.000-00";
            mskRGFuncionarios.Name = "mskRGFuncionarios";
            mskRGFuncionarios.Size = new Size(85, 23);
            mskRGFuncionarios.TabIndex = 78;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 128);
            label15.Name = "label15";
            label15.Size = new Size(22, 15);
            label15.TabIndex = 77;
            label15.Text = "RG";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(120, 128);
            label16.Name = "label16";
            label16.Size = new Size(44, 15);
            label16.TabIndex = 79;
            label16.Text = "Cargos";
            // 
            // cmbCargoFuncionarios
            // 
            cmbCargoFuncionarios.FormattingEnabled = true;
            cmbCargoFuncionarios.Items.AddRange(new object[] { "Gerente", "Caixa", "Estoquista", "Vendedor" });
            cmbCargoFuncionarios.Location = new Point(120, 159);
            cmbCargoFuncionarios.Name = "cmbCargoFuncionarios";
            cmbCargoFuncionarios.Size = new Size(121, 23);
            cmbCargoFuncionarios.TabIndex = 80;
            // 
            // FrmFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCargoFuncionarios);
            Controls.Add(label16);
            Controls.Add(mskRGFuncionarios);
            Controls.Add(label15);
            Controls.Add(btnCadastrarClientes);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(txtUFFuncionarios);
            Controls.Add(txtCidadeFuncionarios);
            Controls.Add(txtComplementoFuncionarios);
            Controls.Add(txtBairroFuncionarios);
            Controls.Add(txtNumeroFuncionarios);
            Controls.Add(txtLogradouroFuncionarios);
            Controls.Add(mskCEPFuncionarios);
            Controls.Add(dtpDatNascFuncionarios);
            Controls.Add(label7);
            Controls.Add(rdbtnTelefone);
            Controls.Add(rdbtnCelular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmailFuncionarios);
            Controls.Add(mskTelefoneFuncionarios);
            Controls.Add(mskCPFFuncionarios);
            Controls.Add(txtNomeFuncionarios);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFuncionario";
            Text = "FrmFuncionario";
            Load += FrmFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarClientes;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private TextBox txtUFFuncionarios;
        private TextBox txtCidadeFuncionarios;
        private TextBox txtComplementoFuncionarios;
        private TextBox txtBairroFuncionarios;
        private TextBox txtNumeroFuncionarios;
        private TextBox txtLogradouroFuncionarios;
        private MaskedTextBox mskCEPFuncionarios;
        private DateTimePicker dtpDatNascFuncionarios;
        private Label label7;
        private RadioButton rdbtnTelefone;
        private RadioButton rdbtnCelular;
        private Label label6;
        private Label label5;
        private TextBox txtEmailFuncionarios;
        private MaskedTextBox mskTelefoneFuncionarios;
        private MaskedTextBox mskCPFFuncionarios;
        private TextBox txtNomeFuncionarios;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mskRGFuncionarios;
        private Label label15;
        private Label label16;
        private ComboBox cmbCargoFuncionarios;
    }
}