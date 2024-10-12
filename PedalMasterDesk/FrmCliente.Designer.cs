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
            txtEmail = new TextBox();
            mskTelefone = new MaskedTextBox();
            mskCPFCliente = new MaskedTextBox();
            txtNomeCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
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
            label7.Location = new Point(345, 126);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 29;
            label7.Text = "Tipo";
            // 
            // rdbtnTelefone
            // 
            rdbtnTelefone.AutoSize = true;
            rdbtnTelefone.Location = new Point(413, 158);
            rdbtnTelefone.Name = "rdbtnTelefone";
            rdbtnTelefone.Size = new Size(69, 19);
            rdbtnTelefone.TabIndex = 28;
            rdbtnTelefone.TabStop = true;
            rdbtnTelefone.Text = "Telefone";
            rdbtnTelefone.UseVisualStyleBackColor = true;
            // 
            // rdbtnCelular
            // 
            rdbtnCelular.AutoSize = true;
            rdbtnCelular.Location = new Point(345, 158);
            rdbtnCelular.Name = "rdbtnCelular";
            rdbtnCelular.Size = new Size(62, 19);
            rdbtnCelular.TabIndex = 27;
            rdbtnCelular.TabStop = true;
            rdbtnCelular.Text = "Celular";
            rdbtnCelular.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 126);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 26;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 126);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 25;
            label5.Text = "Numero de telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 24;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(224, 157);
            mskTelefone.Mask = "(99) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(87, 23);
            mskTelefone.TabIndex = 23;
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(27, 256);
            maskedTextBox1.Mask = "00000-999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(62, 23);
            maskedTextBox1.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(238, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(362, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(275, 311);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 35;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(27, 311);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 36;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(150, 311);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 37;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(dtpDatNascCliente);
            Controls.Add(label7);
            Controls.Add(rdbtnTelefone);
            Controls.Add(rdbtnCelular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(mskTelefone);
            Controls.Add(mskCPFCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "Cliente";
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
        private TextBox txtEmail;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskCPFCliente;
        private TextBox txtNomeCliente;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}