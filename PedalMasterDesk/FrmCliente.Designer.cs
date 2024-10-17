namespace PedalMasterDesk
{
    partial class FrmCliente
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
            dtpDatNascCliente = new DateTimePicker();
            label7 = new Label();
            rdbtnTelefone = new RadioButton();
            rdbtnCelular = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            txtEmailCliente = new TextBox();
            mskTelefoneCliente = new MaskedTextBox();
            mskCPFCliente = new MaskedTextBox();
            txtNomeCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mskCEPCliente = new MaskedTextBox();
            txtLogradouroClientes = new TextBox();
            txtNumeroClientes = new TextBox();
            txtBairroClientes = new TextBox();
            txtComplementoClientes = new TextBox();
            txtCidadeClientes = new TextBox();
            txtUFClientes = new TextBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnCadastrarClientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dtpDatNascCliente
            // 
            dtpDatNascCliente.Location = new Point(313, 95);
            dtpDatNascCliente.Name = "dtpDatNascCliente";
            dtpDatNascCliente.Size = new Size(200, 23);
            dtpDatNascCliente.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 126);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 29;
            label7.Text = "Tipo";
            // 
            // rdbtnTelefone
            // 
            rdbtnTelefone.AutoSize = true;
            rdbtnTelefone.Location = new Point(410, 159);
            rdbtnTelefone.Name = "rdbtnTelefone";
            rdbtnTelefone.Size = new Size(69, 19);
            rdbtnTelefone.TabIndex = 28;
            rdbtnTelefone.TabStop = true;
            rdbtnTelefone.Text = "Telefone";
            rdbtnTelefone.UseVisualStyleBackColor = true;
            rdbtnTelefone.CheckedChanged += rdbtnTelefone_CheckedChanged;
            // 
            // rdbtnCelular
            // 
            rdbtnCelular.AutoSize = true;
            rdbtnCelular.Location = new Point(342, 159);
            rdbtnCelular.Name = "rdbtnCelular";
            rdbtnCelular.Size = new Size(62, 19);
            rdbtnCelular.TabIndex = 27;
            rdbtnCelular.TabStop = true;
            rdbtnCelular.Text = "Celular";
            rdbtnCelular.UseVisualStyleBackColor = true;
            rdbtnCelular.CheckedChanged += rdbtnCelular_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 126);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 26;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 126);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 25;
            label5.Text = "Numero de telefone";
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(24, 158);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(191, 23);
            txtEmailCliente.TabIndex = 24;
            // 
            // mskTelefoneCliente
            // 
            mskTelefoneCliente.Location = new Point(221, 158);
            mskTelefoneCliente.Mask = "(00) 00000-0000";
            mskTelefoneCliente.Name = "mskTelefoneCliente";
            mskTelefoneCliente.Size = new Size(87, 23);
            mskTelefoneCliente.TabIndex = 23;
            // 
            // mskCPFCliente
            // 
            mskCPFCliente.Location = new Point(222, 95);
            mskCPFCliente.Mask = "000.000.000-00";
            mskCPFCliente.Name = "mskCPFCliente";
            mskCPFCliente.Size = new Size(85, 23);
            mskCPFCliente.TabIndex = 22;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(24, 95);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(192, 23);
            txtNomeCliente.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 64);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 20;
            label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 64);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 19;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 64);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 18;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 18);
            label1.Name = "label1";
            label1.Size = new Size(285, 25);
            label1.TabIndex = 17;
            label1.Text = "Pagina de Cadastro de Clientes";
            // 
            // mskCEPCliente
            // 
            mskCEPCliente.Location = new Point(24, 236);
            mskCEPCliente.Mask = "00000-999";
            mskCEPCliente.Name = "mskCEPCliente";
            mskCEPCliente.Size = new Size(62, 23);
            mskCEPCliente.TabIndex = 31;
            // 
            // txtLogradouroClientes
            // 
            txtLogradouroClientes.Location = new Point(113, 236);
            txtLogradouroClientes.Name = "txtLogradouroClientes";
            txtLogradouroClientes.Size = new Size(100, 23);
            txtLogradouroClientes.TabIndex = 32;
            // 
            // txtNumeroClientes
            // 
            txtNumeroClientes.Location = new Point(235, 236);
            txtNumeroClientes.Name = "txtNumeroClientes";
            txtNumeroClientes.Size = new Size(100, 23);
            txtNumeroClientes.TabIndex = 33;
            txtNumeroClientes.TextChanged += txtNumeroClientes_TextChanged;
            // 
            // txtBairroClientes
            // 
            txtBairroClientes.Location = new Point(359, 236);
            txtBairroClientes.Name = "txtBairroClientes";
            txtBairroClientes.Size = new Size(100, 23);
            txtBairroClientes.TabIndex = 34;
            // 
            // txtComplementoClientes
            // 
            txtComplementoClientes.Location = new Point(207, 314);
            txtComplementoClientes.Name = "txtComplementoClientes";
            txtComplementoClientes.Size = new Size(100, 23);
            txtComplementoClientes.TabIndex = 35;
            // 
            // txtCidadeClientes
            // 
            txtCidadeClientes.Location = new Point(24, 314);
            txtCidadeClientes.Name = "txtCidadeClientes";
            txtCidadeClientes.Size = new Size(100, 23);
            txtCidadeClientes.TabIndex = 36;
            // 
            // txtUFClientes
            // 
            txtUFClientes.Location = new Point(147, 314);
            txtUFClientes.Name = "txtUFClientes";
            txtUFClientes.Size = new Size(35, 23);
            txtUFClientes.TabIndex = 37;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome });
            dataGridView1.Location = new Point(538, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(250, 334);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 199);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 39;
            label8.Text = "CEP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(113, 199);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 40;
            label9.Text = "Logradouro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(235, 199);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 41;
            label10.Text = "Numero";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(359, 199);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 42;
            label11.Text = "Bairro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 277);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 43;
            label12.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(147, 277);
            label13.Name = "label13";
            label13.Size = new Size(21, 15);
            label13.TabIndex = 44;
            label13.Text = "UF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(207, 277);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 45;
            label14.Text = "Complemento";
            // 
            // btnCadastrarClientes
            // 
            btnCadastrarClientes.Location = new Point(24, 371);
            btnCadastrarClientes.Name = "btnCadastrarClientes";
            btnCadastrarClientes.Size = new Size(126, 38);
            btnCadastrarClientes.TabIndex = 46;
            btnCadastrarClientes.Text = "&Cadastrar";
            btnCadastrarClientes.UseVisualStyleBackColor = true;
            btnCadastrarClientes.Click += btnCadastrarClientes_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarClientes);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(txtUFClientes);
            Controls.Add(txtCidadeClientes);
            Controls.Add(txtComplementoClientes);
            Controls.Add(txtBairroClientes);
            Controls.Add(txtNumeroClientes);
            Controls.Add(txtLogradouroClientes);
            Controls.Add(mskCEPCliente);
            Controls.Add(dtpDatNascCliente);
            Controls.Add(label7);
            Controls.Add(rdbtnTelefone);
            Controls.Add(rdbtnCelular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmailCliente);
            Controls.Add(mskTelefoneCliente);
            Controls.Add(mskCPFCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "Cliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDatNascCliente;
        private Label label7;
        private RadioButton rdbtnTelefone;
        private RadioButton rdbtnCelular;
        private Label label6;
        private Label label5;
        private TextBox txtEmailCliente;
        private MaskedTextBox mskTelefoneCliente;
        private MaskedTextBox mskCPFCliente;
        private TextBox txtNomeCliente;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mskCEPCliente;
        private TextBox txtLogradouroClientes;
        private TextBox txtNumeroClientes;
        private TextBox txtBairroClientes;
        private TextBox txtComplementoClientes;
        private TextBox txtCidadeClientes;
        private TextBox txtUFClientes;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnCadastrarClientes;
    }
}