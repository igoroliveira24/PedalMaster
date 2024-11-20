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
            idItempedido = new DataGridViewTextBoxColumn();
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
            txtDescontoTotal = new TextBox();
            label10 = new Label();
            lblDescontoVarejo = new Label();
            lblDescontoAtacado = new Label();
            txtSubTotaPedido = new TextBox();
            txtDescontoProdutos = new TextBox();
            txtValorTotalPedido = new TextBox();
            btnFinalizarPedido = new Button();
            btnManterAberto = new Button();
            btnCancelarPed = new Button();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtDescontoEscritoPedido = new TextBox();
            label13 = new Label();
            btnFecharCaixa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadePedido).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, buttonmenos, Column4, buttonmais, ValorUnit, DescontoitemProduto, precoTot, Remover, idItempedido });
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
            // idItempedido
            // 
            idItempedido.HeaderText = "idItemPedido";
            idItempedido.Name = "idItempedido";
            idItempedido.Visible = false;
            // 
            // btnInserir
            // 
            btnInserir.BackgroundImageLayout = ImageLayout.None;
            btnInserir.Enabled = false;
            btnInserir.Location = new Point(643, 290);
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
            txtValorUnitPedido.Location = new Point(182, 289);
            txtValorUnitPedido.Name = "txtValorUnitPedido";
            txtValorUnitPedido.ReadOnly = true;
            txtValorUnitPedido.Size = new Size(100, 23);
            txtValorUnitPedido.TabIndex = 5;
            // 
            // txtValorTotPedido
            // 
            txtValorTotPedido.Enabled = false;
            txtValorTotPedido.Location = new Point(303, 289);
            txtValorTotPedido.Name = "txtValorTotPedido";
            txtValorTotPedido.ReadOnly = true;
            txtValorTotPedido.Size = new Size(100, 23);
            txtValorTotPedido.TabIndex = 6;
            // 
            // nudQuantidadePedido
            // 
            nudQuantidadePedido.Enabled = false;
            nudQuantidadePedido.Location = new Point(430, 290);
            nudQuantidadePedido.Name = "nudQuantidadePedido";
            nudQuantidadePedido.Size = new Size(78, 23);
            nudQuantidadePedido.TabIndex = 7;
            nudQuantidadePedido.ValueChanged += nudQuantidadePedido_ValueChanged;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Enabled = false;
            txtDescontoPedido.Location = new Point(526, 289);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(100, 23);
            txtDescontoPedido.TabIndex = 8;
            txtDescontoPedido.Text = "0";
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
            label2.Location = new Point(182, 261);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 10;
            label2.Text = "Valor Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 261);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 11;
            label3.Text = "Valor Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 261);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 271);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Desconto";
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
            // txtDescontoTotal
            // 
            txtDescontoTotal.Location = new Point(526, 245);
            txtDescontoTotal.Name = "txtDescontoTotal";
            txtDescontoTotal.ReadOnly = true;
            txtDescontoTotal.Size = new Size(100, 23);
            txtDescontoTotal.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(526, 225);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 29;
            label10.Text = "Desconto Total";
            // 
            // lblDescontoVarejo
            // 
            lblDescontoVarejo.AutoSize = true;
            lblDescontoVarejo.ForeColor = Color.Red;
            lblDescontoVarejo.Location = new Point(632, 248);
            lblDescontoVarejo.Name = "lblDescontoVarejo";
            lblDescontoVarejo.Size = new Size(0, 15);
            lblDescontoVarejo.TabIndex = 30;
            // 
            // lblDescontoAtacado
            // 
            lblDescontoAtacado.AutoSize = true;
            lblDescontoAtacado.ForeColor = Color.Red;
            lblDescontoAtacado.Location = new Point(643, 248);
            lblDescontoAtacado.Name = "lblDescontoAtacado";
            lblDescontoAtacado.Size = new Size(0, 15);
            lblDescontoAtacado.TabIndex = 31;
            // 
            // txtSubTotaPedido
            // 
            txtSubTotaPedido.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubTotaPedido.Location = new Point(985, 29);
            txtSubTotaPedido.Name = "txtSubTotaPedido";
            txtSubTotaPedido.ReadOnly = true;
            txtSubTotaPedido.Size = new Size(323, 50);
            txtSubTotaPedido.TabIndex = 32;
            txtSubTotaPedido.Text = "0";
            // 
            // txtDescontoProdutos
            // 
            txtDescontoProdutos.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescontoProdutos.Location = new Point(985, 130);
            txtDescontoProdutos.Name = "txtDescontoProdutos";
            txtDescontoProdutos.ReadOnly = true;
            txtDescontoProdutos.Size = new Size(323, 50);
            txtDescontoProdutos.TabIndex = 33;
            txtDescontoProdutos.Text = "0";
            // 
            // txtValorTotalPedido
            // 
            txtValorTotalPedido.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorTotalPedido.Location = new Point(985, 329);
            txtValorTotalPedido.Name = "txtValorTotalPedido";
            txtValorTotalPedido.ReadOnly = true;
            txtValorTotalPedido.Size = new Size(323, 50);
            txtValorTotalPedido.TabIndex = 34;
            txtValorTotalPedido.Text = "0";
            txtValorTotalPedido.TextChanged += txtValorTotalPedido_TextChanged;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.BackColor = Color.GreenYellow;
            btnFinalizarPedido.Enabled = false;
            btnFinalizarPedido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinalizarPedido.Location = new Point(985, 403);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.Size = new Size(323, 50);
            btnFinalizarPedido.TabIndex = 35;
            btnFinalizarPedido.Text = "Finalizar Pedido";
            btnFinalizarPedido.UseVisualStyleBackColor = false;
            btnFinalizarPedido.Click += btnFinalizarPedido_Click;
            // 
            // btnManterAberto
            // 
            btnManterAberto.BackColor = Color.OrangeRed;
            btnManterAberto.Enabled = false;
            btnManterAberto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManterAberto.Location = new Point(985, 475);
            btnManterAberto.Name = "btnManterAberto";
            btnManterAberto.Size = new Size(323, 50);
            btnManterAberto.TabIndex = 36;
            btnManterAberto.Text = "Manter Pedido Aberto";
            btnManterAberto.UseVisualStyleBackColor = false;
            btnManterAberto.Click += btnManterAberto_Click;
            // 
            // btnCancelarPed
            // 
            btnCancelarPed.BackColor = Color.Red;
            btnCancelarPed.Enabled = false;
            btnCancelarPed.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarPed.ForeColor = Color.White;
            btnCancelarPed.Location = new Point(985, 549);
            btnCancelarPed.Name = "btnCancelarPed";
            btnCancelarPed.Size = new Size(323, 50);
            btnCancelarPed.TabIndex = 37;
            btnCancelarPed.Text = "Cancelar Pedido";
            btnCancelarPed.UseVisualStyleBackColor = false;
            btnCancelarPed.Click += btnCancelarPed_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(985, 5);
            label9.Name = "label9";
            label9.Size = new Size(128, 30);
            label9.TabIndex = 38;
            label9.Text = "Valor Pedido";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(985, 108);
            label11.Name = "label11";
            label11.Size = new Size(294, 30);
            label11.TabIndex = 39;
            label11.Text = "Desconto dos Produtos em R$";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(985, 309);
            label12.Name = "label12";
            label12.Size = new Size(109, 30);
            label12.TabIndex = 40;
            label12.Text = "Valor Total";
            // 
            // txtDescontoEscritoPedido
            // 
            txtDescontoEscritoPedido.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescontoEscritoPedido.Location = new Point(985, 224);
            txtDescontoEscritoPedido.Name = "txtDescontoEscritoPedido";
            txtDescontoEscritoPedido.Size = new Size(323, 50);
            txtDescontoEscritoPedido.TabIndex = 41;
            txtDescontoEscritoPedido.Text = "0";
            txtDescontoEscritoPedido.TextChanged += textBox1_TextChanged_2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(985, 200);
            label13.Name = "label13";
            label13.Size = new Size(265, 30);
            label13.TabIndex = 42;
            label13.Text = "Desconto do Pedido em R$";
            // 
            // btnFecharCaixa
            // 
            btnFecharCaixa.BackColor = Color.Transparent;
            btnFecharCaixa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFecharCaixa.ForeColor = Color.Black;
            btnFecharCaixa.Location = new Point(985, 625);
            btnFecharCaixa.Name = "btnFecharCaixa";
            btnFecharCaixa.Size = new Size(323, 50);
            btnFecharCaixa.TabIndex = 43;
            btnFecharCaixa.Text = "Fechar Caixa";
            btnFecharCaixa.UseVisualStyleBackColor = false;
            btnFecharCaixa.Click += btnFecharCaixa_Click;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            ControlBox = false;
            Controls.Add(btnFecharCaixa);
            Controls.Add(label13);
            Controls.Add(txtDescontoEscritoPedido);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(btnCancelarPed);
            Controls.Add(btnManterAberto);
            Controls.Add(btnFinalizarPedido);
            Controls.Add(txtValorTotalPedido);
            Controls.Add(txtDescontoProdutos);
            Controls.Add(txtSubTotaPedido);
            Controls.Add(lblDescontoAtacado);
            Controls.Add(lblDescontoVarejo);
            Controls.Add(label10);
            Controls.Add(txtDescontoTotal);
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
        private TextBox txtDescontoTotal;
        private Label label10;
        private Label lblDescontoVarejo;
        private DataGridViewTextBoxColumn idItempedido;
        private Label lblDescontoAtacado;
        private TextBox txtSubTotaPedido;
        private TextBox txtDescontoProdutos;
        private TextBox txtValorTotalPedido;
        private Button btnFinalizarPedido;
        private Button btnManterAberto;
        private Button btnCancelarPed;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox txtDescontoEscritoPedido;
        private Label label13;
        private Button btnFecharCaixa;
    }
}