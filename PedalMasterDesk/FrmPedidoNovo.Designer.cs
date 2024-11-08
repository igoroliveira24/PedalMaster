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
            precoTot = new DataGridViewTextBoxColumn();
            Remover = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadePedido).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, buttonmenos, Column4, buttonmais, ValorUnit, precoTot, Remover });
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(779, 649);
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
            Remover.Width = 75;
            // 
            // btnInserir
            // 
            btnInserir.BackgroundImageLayout = ImageLayout.None;
            btnInserir.Location = new Point(716, 243);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtCodBarPedido
            // 
            txtCodBarPedido.Location = new Point(11, 244);
            txtCodBarPedido.Name = "txtCodBarPedido";
            txtCodBarPedido.Size = new Size(153, 23);
            txtCodBarPedido.TabIndex = 4;
            // 
            // txtValorUnitPedido
            // 
            txtValorUnitPedido.Location = new Point(250, 243);
            txtValorUnitPedido.Name = "txtValorUnitPedido";
            txtValorUnitPedido.ReadOnly = true;
            txtValorUnitPedido.Size = new Size(100, 23);
            txtValorUnitPedido.TabIndex = 5;
            // 
            // txtValorTotPedido
            // 
            txtValorTotPedido.Location = new Point(371, 243);
            txtValorTotPedido.Name = "txtValorTotPedido";
            txtValorTotPedido.ReadOnly = true;
            txtValorTotPedido.Size = new Size(100, 23);
            txtValorTotPedido.TabIndex = 6;
            // 
            // nudQuantidadePedido
            // 
            nudQuantidadePedido.Location = new Point(498, 244);
            nudQuantidadePedido.Name = "nudQuantidadePedido";
            nudQuantidadePedido.Size = new Size(78, 23);
            nudQuantidadePedido.TabIndex = 7;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(594, 243);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(100, 23);
            txtDescontoPedido.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 216);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 9;
            label1.Text = "Codigo de Barra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 215);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 10;
            label2.Text = "Valor Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 215);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 11;
            label3.Text = "Valor Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 215);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(594, 215);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Desconto";
            // 
            // btnBuscarCodbar
            // 
            btnBuscarCodbar.Location = new Point(160, 244);
            btnBuscarCodbar.Name = "btnBuscarCodbar";
            btnBuscarCodbar.Size = new Size(74, 23);
            btnBuscarCodbar.TabIndex = 14;
            btnBuscarCodbar.Text = "Buscar";
            btnBuscarCodbar.UseVisualStyleBackColor = true;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 949);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn buttonmenos;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn buttonmais;
        private DataGridViewTextBoxColumn ValorUnit;
        private DataGridViewTextBoxColumn precoTot;
        private DataGridViewTextBoxColumn Remover;
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
    }
}