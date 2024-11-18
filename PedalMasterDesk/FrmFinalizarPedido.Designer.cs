namespace PedalMasterDesk
{
    partial class FrmFinalizarPedido
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
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbFrmPag = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtAberto = new TextBox();
            txtRecebido = new TextBox();
            dataGridView1 = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            Pagamento = new DataGridViewTextBoxColumn();
            Val = new DataGridViewTextBoxColumn();
            Parce = new DataGridViewTextBoxColumn();
            btnProsseguir = new Button();
            cmbparcelas = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(41, 50);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(196, 23);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 32);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 197);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 3;
            label2.Text = "Forma de Pagamento";
            // 
            // cmbFrmPag
            // 
            cmbFrmPag.FormattingEnabled = true;
            cmbFrmPag.Items.AddRange(new object[] { "DINHEIRO", "C. CRÉDITO", "C. DÉBITO", "PIX", "BOLETO" });
            cmbFrmPag.Location = new Point(41, 215);
            cmbFrmPag.Name = "cmbFrmPag";
            cmbFrmPag.Size = new Size(196, 23);
            cmbFrmPag.TabIndex = 4;
            cmbFrmPag.SelectedIndexChanged += cmbFrmPag_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 86);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor em Aberto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 141);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Recebido:";
            // 
            // txtAberto
            // 
            txtAberto.Location = new Point(41, 104);
            txtAberto.Name = "txtAberto";
            txtAberto.ReadOnly = true;
            txtAberto.Size = new Size(196, 23);
            txtAberto.TabIndex = 7;
            // 
            // txtRecebido
            // 
            txtRecebido.Location = new Point(41, 159);
            txtRecebido.Name = "txtRecebido";
            txtRecebido.Size = new Size(196, 23);
            txtRecebido.TabIndex = 8;
            txtRecebido.Text = "0";
            txtRecebido.TextChanged += txtRecebido_TextChanged;
            txtRecebido.KeyPress += txtRecebido_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Numero, Pagamento, Val, Parce });
            dataGridView1.Location = new Point(278, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(403, 188);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Numero
            // 
            Numero.HeaderText = "Nº";
            Numero.Name = "Numero";
            Numero.Width = 50;
            // 
            // Pagamento
            // 
            Pagamento.HeaderText = "Pagamento";
            Pagamento.Name = "Pagamento";
            Pagamento.Width = 125;
            // 
            // Val
            // 
            Val.HeaderText = "Valor";
            Val.Name = "Val";
            Val.Width = 125;
            // 
            // Parce
            // 
            Parce.HeaderText = "Parcelas";
            Parce.Name = "Parce";
            // 
            // btnProsseguir
            // 
            btnProsseguir.Enabled = false;
            btnProsseguir.Location = new Point(41, 266);
            btnProsseguir.Name = "btnProsseguir";
            btnProsseguir.Size = new Size(82, 23);
            btnProsseguir.TabIndex = 10;
            btnProsseguir.Text = "Prosseguir";
            btnProsseguir.UseVisualStyleBackColor = true;
            btnProsseguir.Click += btnProsseguir_Click;
            // 
            // cmbparcelas
            // 
            cmbparcelas.Enabled = false;
            cmbparcelas.FormattingEnabled = true;
            cmbparcelas.Location = new Point(131, 266);
            cmbparcelas.Name = "cmbparcelas";
            cmbparcelas.Size = new Size(106, 23);
            cmbparcelas.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(131, 248);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 12;
            label5.Text = "Parcelas";
            // 
            // FrmFinalizarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 367);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(cmbparcelas);
            Controls.Add(btnProsseguir);
            Controls.Add(dataGridView1);
            Controls.Add(txtRecebido);
            Controls.Add(txtAberto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbFrmPag);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Name = "FrmFinalizarPedido";
            Load += FrmFinalizarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Label label1;
        private Label label2;
        private ComboBox cmbFrmPag;
        private Label label3;
        private Label label4;
        private TextBox txtAberto;
        private TextBox txtRecebido;
        private DataGridView dataGridView1;
        private Button btnProsseguir;
        private ComboBox cmbparcelas;
        private Label label5;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Pagamento;
        private DataGridViewTextBoxColumn Val;
        private DataGridViewTextBoxColumn Parce;
    }
}