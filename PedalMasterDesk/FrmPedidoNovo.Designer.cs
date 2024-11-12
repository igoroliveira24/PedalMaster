namespace PedalMasterDesk
{
    partial class FrmPedidoNovo
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            buttonmenos = new DataGridViewButtonColumn();
            Column4 = new DataGridViewTextBoxColumn();
            buttonmais = new DataGridViewButtonColumn();
            ValorUnit = new DataGridViewTextBoxColumn();
            DescontoitemProduto = new DataGridViewTextBoxColumn();
            precoTot = new DataGridViewTextBoxColumn();
            Remover = new DataGridViewButtonColumn();
            btnInserir = new Button();
            txtCodBarPedido = new TextBox();
            txtValorUnitPedido = new TextBox();
            txtValorTotPedido = new TextBox();
            nudQuantidadePedido = new NumericUpDown();
            txtDescontoPedido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnBuscarCodbar = new Button();
            txtFuncionarioPedido = new TextBox();
            txtNomeClientes = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnBuscarCliente = new Button();
            txtIdCliente = new TextBox();
            txtCpfCliente = new TextBox();
            btnAdicionaPedido = new Button();
            txtIdPedido = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            txtDescontoTotal = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadePedido).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, buttonmenos, Column4, buttonmais, ValorUnit, DescontoitemProduto, precoTot, Remover });
            dataGridView1.Location = new Point(12, 331);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(878, 606);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nº";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Codigo de Barras";
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // buttonmenos
            // 
            buttonmenos.HeaderText = "Menos";
            buttonmenos.Name = "buttonmenos";
            buttonmenos.Text = "";
            buttonmenos.UseColumnTextForButtonValue = true;
            buttonmenos.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantidade";
            Column4.Name = "Column4";
            // 
            // buttonmais
            // 
            buttonmais.HeaderText = "Mais";
            buttonmais.Name = "buttonmais";
            buttonmais.Width = 50;
            // 
            // ValorUnit
            // 
            ValorUnit.HeaderText = "Valor Unitario";
            ValorUnit.Name = "ValorUnit";
            ValorUnit.Width = 150;
            // 
            // DescontoitemProduto
            // 
            DescontoitemProduto.HeaderText = "Desconto(%)";
            DescontoitemProduto.Name = "DescontoitemProduto";
            // 
            // precoTot
            // 
            precoTot.HeaderText = "ValorTotal";
            precoTot.Name = "precoTot";
            precoTot.Width = 150;
            // 
            // Remover
            // 
            Remover.HeaderText = "Remover";
            Remover.Name = "Remover";
            Remover.Resizable = DataGridViewTriState.True;
            Remover.SortMode = DataGridViewColumnSortMode.Automatic;
            Remover.Width = 75;
            // 
            // btnInserir
            // 
            btnInserir.BackgroundImageLayout = ImageLayout.None;
            btnInserir.Enabled = false;
            btnInserir.Location = new Point(712, 291);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtCodBarPedido
            // 
            txtCodBarPedido.Enabled = false;
            txtCodBarPedido.Location = new Point(12, 291);
            txtCodBarPedido.Name = "txtCodBarPedido";
            txtCodBarPedido.Size = new Size(153, 23);
            txtCodBarPedido.TabIndex = 4;
            txtCodBarPedido.TextChanged += txtCodBarPedido_TextChanged;
            txtCodBarPedido.KeyPress += txtCodBarPedido_KeyPress;
            // 
            // txtValorUnitPedido
            // 
            txtValorUnitPedido.Enabled = false;
            txtValorUnitPedido.Location = new Point(251, 290);
            txtValorUnitPedido.Name = "txtValorUnitPedido";
            txtValorUnitPedido.ReadOnly = true;
            txtValorUnitPedido.Size = new Size(100, 23);
            txtValorUnitPedido.TabIndex = 5;
            // 
            // txtValorTotPedido
            // 
            txtValorTotPedido.Enabled = false;
            txtValorTotPedido.Location = new Point(372, 290);
            txtValorTotPedido.Name = "txtValorTotPedido";
            txtValorTotPedido.ReadOnly = true;
            txtValorTotPedido.Size = new Size(100, 23);
            txtValorTotPedido.TabIndex = 6;
            // 
            // nudQuantidadePedido
            // 
            nudQuantidadePedido.Enabled = false;
            nudQuantidadePedido.Location = new Point(499, 291);
            nudQuantidadePedido.Name = "nudQuantidadePedido";
            nudQuantidadePedido.Size = new Size(78, 23);
            nudQuantidadePedido.TabIndex = 7;
            nudQuantidadePedido.ValueChanged += nudQuantidadePedido_ValueChanged;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Enabled = false;
            txtDescontoPedido.Location = new Point(595, 290);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(100, 23);
            txtDescontoPedido.TabIndex = 8;
            txtDescontoPedido.TextChanged += txtDescontoPedido_TextChanged;
            txtDescontoPedido.KeyPress += txtDescontoPedido_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 263);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 9;
            label1.Text = "Codigo de Barra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 262);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 10;
            label2.Text = "Valor Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 262);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 11;
            label3.Text = "Valor Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 262);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(595, 272);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Desconto";
            // 
            // btnBuscarCodbar
            // 
            btnBuscarCodbar.Enabled = false;
            btnBuscarCodbar.Location = new Point(161, 291);
            btnBuscarCodbar.Name = "btnBuscarCodbar";
            btnBuscarCodbar.Size = new Size(74, 23);
            btnBuscarCodbar.TabIndex = 14;
            btnBuscarCodbar.Text = "Buscar";
            btnBuscarCodbar.UseVisualStyleBackColor = true;
            btnBuscarCodbar.Click += btnBuscarCodbar_Click;
            // 
            // txtFuncionarioPedido
            // 
            txtFuncionarioPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuncionarioPedido.Location = new Point(13, 65);
            txtFuncionarioPedido.Name = "txtFuncionarioPedido";
            txtFuncionarioPedido.ReadOnly = true;
            txtFuncionarioPedido.Size = new Size(263, 29);
            txtFuncionarioPedido.TabIndex = 15;
            txtFuncionarioPedido.TextChanged += textBox1_TextChanged_1;
            // 
            // txtNomeClientes
            // 
            txtNomeClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeClientes.Location = new Point(236, 152);
            txtNomeClientes.Name = "txtNomeClientes";
            txtNomeClientes.ReadOnly = true;
            txtNomeClientes.Size = new Size(263, 29);
            txtNomeClientes.TabIndex = 16;
            txtNomeClientes.TextChanged += txtClientePedido_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 47);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 17;
            label6.Text = "Funcionario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 134);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 18;
            label7.Text = "Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(505, 152);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(74, 29);
            btnBuscarCliente.TabIndex = 19;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += button1_Click_1;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(13, 152);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(52, 29);
            txtIdCliente.TabIndex = 20;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            // 
            // txtCpfCliente
            // 
            txtCpfCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCpfCliente.Location = new Point(71, 152);
            txtCpfCliente.Name = "txtCpfCliente";
            txtCpfCliente.ReadOnly = true;
            txtCpfCliente.Size = new Size(159, 29);
            txtCpfCliente.TabIndex = 21;
            // 
            // btnAdicionaPedido
            // 
            btnAdicionaPedido.BackColor = Color.Red;
            btnAdicionaPedido.Enabled = false;
            btnAdicionaPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionaPedido.ForeColor = SystemColors.ControlLightLight;
            btnAdicionaPedido.Location = new Point(12, 201);
            btnAdicionaPedido.Name = "btnAdicionaPedido";
            btnAdicionaPedido.Size = new Size(153, 40);
            btnAdicionaPedido.TabIndex = 22;
            btnAdicionaPedido.Text = "Adicionar Pedido";
            btnAdicionaPedido.UseVisualStyleBackColor = false;
            btnAdicionaPedido.Click += button2_Click;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.ForeColor = Color.Red;
            txtIdPedido.Location = new Point(1702, 44);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.ReadOnly = true;
            txtIdPedido.Size = new Size(83, 50);
            txtIdPedido.TabIndex = 24;
            txtIdPedido.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1700, 9);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 25;
            label8.Text = "ID Pedido";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 26;
            // 
            // txtDescontoTotal
            // 
            txtDescontoTotal.Location = new Point(595, 246);
            txtDescontoTotal.Name = "txtDescontoTotal";
            txtDescontoTotal.ReadOnly = true;
            txtDescontoTotal.Size = new Size(100, 23);
            txtDescontoTotal.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(595, 226);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 29;
            label10.Text = "Desconto Total";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(label10);
            Controls.Add(txtDescontoTotal);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(txtIdPedido);
            Controls.Add(btnAdicionaPedido);
            Controls.Add(txtCpfCliente);
            Controls.Add(txtIdCliente);
            Controls.Add(btnBuscarCliente);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtNomeClientes);
            Controls.Add(txtFuncionarioPedido);
            Controls.Add(btnBuscarCodbar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescontoPedido);
            Controls.Add(nudQuantidadePedido);
            Controls.Add(txtValorTotPedido);
            Controls.Add(txtValorUnitPedido);
            Controls.Add(txtCodBarPedido);
            Controls.Add(btnInserir);
            Controls.Add(dataGridView1);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            WindowState = FormWindowState.Maximized;
            Load += FrmPedidoNovo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadePedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnInserir;
        private TextBox txtCodBarPedido;
        private TextBox txtValorUnitPedido;
        private TextBox txtValorTotPedido;
        private NumericUpDown nudQuantidadePedido;
        private TextBox txtDescontoPedido;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnBuscarCodbar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn buttonmenos;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn buttonmais;
        private DataGridViewTextBoxColumn ValorUnit;
        private DataGridViewTextBoxColumn DescontoitemProduto;
        private DataGridViewTextBoxColumn precoTot;
        private DataGridViewButtonColumn Remover;
        private TextBox txtFuncionarioPedido;
        private TextBox txtNomeClientes;
        private Label label6;
        private Label label7;
        private Button btnBuscarCliente;
        private TextBox txtIdCliente;
        private TextBox txtCpfCliente;
        private Button btnAdicionaPedido;
        private TextBox txtIdPedido;
        private Label label8;
        private TextBox textBox1;
        private TextBox txtDescontoTotal;
        private Label label10;
    }
}