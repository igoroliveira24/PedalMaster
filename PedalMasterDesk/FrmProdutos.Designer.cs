namespace PedalMasterDesk
{
    partial class FrmProdutos
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
            label1 = new Label();
            txtCodBar = new TextBox();
            txtNomeProduto = new TextBox();
            txtTamanhoProduto = new TextBox();
            txtDescricaoProduto = new TextBox();
            txtPrecoProduto = new TextBox();
            txtCorProduto = new TextBox();
            cmbMarcaProduto = new ComboBox();
            cmbTipoProduto = new ComboBox();
            cmbTipoTamanho = new ComboBox();
            nudEstoqueMin = new NumericUpDown();
            Cores = new ListBox();
            btnLimparCor = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnCadastrarProdutos = new Button();
            label13 = new Label();
            txtDescontoProduto = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 21);
            label1.Name = "label1";
            label1.Size = new Size(299, 25);
            label1.TabIndex = 48;
            label1.Text = "Pagina de Cadastro de Produtos";
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(43, 106);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.ReadOnly = true;
            txtCodBar.Size = new Size(133, 23);
            txtCodBar.TabIndex = 49;
            txtCodBar.TextChanged += txtCodBar_TextChanged;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(193, 106);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(155, 23);
            txtNomeProduto.TabIndex = 50;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // txtTamanhoProduto
            // 
            txtTamanhoProduto.Location = new Point(119, 154);
            txtTamanhoProduto.Name = "txtTamanhoProduto";
            txtTamanhoProduto.ReadOnly = true;
            txtTamanhoProduto.Size = new Size(100, 23);
            txtTamanhoProduto.TabIndex = 51;
            // 
            // txtDescricaoProduto
            // 
            txtDescricaoProduto.Location = new Point(43, 245);
            txtDescricaoProduto.Name = "txtDescricaoProduto";
            txtDescricaoProduto.Size = new Size(556, 23);
            txtDescricaoProduto.TabIndex = 52;
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.Location = new Point(237, 154);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(100, 23);
            txtPrecoProduto.TabIndex = 53;
            txtPrecoProduto.Text = ".";
            txtPrecoProduto.TextChanged += txtPrecoProduto_TextChanged;
            txtPrecoProduto.KeyDown += txtPrecoProduto_KeyDown;
            txtPrecoProduto.KeyPress += txtPrecoProduto_KeyPress;
            // 
            // txtCorProduto
            // 
            txtCorProduto.Location = new Point(499, 153);
            txtCorProduto.Name = "txtCorProduto";
            txtCorProduto.Size = new Size(100, 23);
            txtCorProduto.TabIndex = 56;
            txtCorProduto.KeyPress += txtCoresProduto_KeyPress;
            // 
            // cmbMarcaProduto
            // 
            cmbMarcaProduto.FormattingEnabled = true;
            cmbMarcaProduto.Items.AddRange(new object[] { "CALOI", "SENSE", "OGGI", "GTS ", "KSW", "TSW", "AUDAX", "MORMAII", "MORMAK", "TREK", "OUTRAS" });
            cmbMarcaProduto.Location = new Point(363, 106);
            cmbMarcaProduto.Name = "cmbMarcaProduto";
            cmbMarcaProduto.Size = new Size(100, 23);
            cmbMarcaProduto.TabIndex = 57;
            cmbMarcaProduto.SelectedIndexChanged += cmbMarcaProduto_SelectedIndexChanged;
            // 
            // cmbTipoProduto
            // 
            cmbTipoProduto.FormattingEnabled = true;
            cmbTipoProduto.Location = new Point(478, 106);
            cmbTipoProduto.Name = "cmbTipoProduto";
            cmbTipoProduto.Size = new Size(121, 23);
            cmbTipoProduto.TabIndex = 58;
            cmbTipoProduto.SelectedIndexChanged += cmbTipoProduto_SelectedIndexChanged;
            // 
            // cmbTipoTamanho
            // 
            cmbTipoTamanho.FormattingEnabled = true;
            cmbTipoTamanho.Items.AddRange(new object[] { "M", "Cm", "Mm" });
            cmbTipoTamanho.Location = new Point(43, 154);
            cmbTipoTamanho.Name = "cmbTipoTamanho";
            cmbTipoTamanho.Size = new Size(61, 23);
            cmbTipoTamanho.TabIndex = 59;
            cmbTipoTamanho.SelectedIndexChanged += cmbTipoTamanho_SelectedIndexChanged;
            // 
            // nudEstoqueMin
            // 
            nudEstoqueMin.Location = new Point(354, 154);
            nudEstoqueMin.Name = "nudEstoqueMin";
            nudEstoqueMin.Size = new Size(120, 23);
            nudEstoqueMin.TabIndex = 60;
            // 
            // Cores
            // 
            Cores.FormattingEnabled = true;
            Cores.ItemHeight = 15;
            Cores.Location = new Point(617, 153);
            Cores.Name = "Cores";
            Cores.Size = new Size(120, 94);
            Cores.TabIndex = 61;
            // 
            // btnLimparCor
            // 
            btnLimparCor.Location = new Point(617, 253);
            btnLimparCor.Name = "btnLimparCor";
            btnLimparCor.Size = new Size(120, 23);
            btnLimparCor.TabIndex = 62;
            btnLimparCor.Text = "Limpar Selecionado";
            btnLimparCor.UseVisualStyleBackColor = true;
            btnLimparCor.Click += btnLimparCor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 88);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 63;
            label2.Text = "Codigo de Barras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 88);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 64;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 88);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 65;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(478, 88);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 66;
            label5.Text = "Tipo de Produto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 136);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 67;
            label6.Text = "Metrica";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 136);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 68;
            label7.Text = "Tamanho";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(237, 136);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 69;
            label8.Text = "Preço";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 136);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 70;
            label9.Text = "Estoque Minimo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(499, 136);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 71;
            label10.Text = "Cores";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(617, 136);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 72;
            label11.Text = "Lista de Cores";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 227);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 73;
            label12.Text = "Descricao";
            // 
            // btnCadastrarProdutos
            // 
            btnCadastrarProdutos.Location = new Point(43, 293);
            btnCadastrarProdutos.Name = "btnCadastrarProdutos";
            btnCadastrarProdutos.Size = new Size(109, 35);
            btnCadastrarProdutos.TabIndex = 74;
            btnCadastrarProdutos.Text = "Cadastrar";
            btnCadastrarProdutos.UseVisualStyleBackColor = true;
            btnCadastrarProdutos.Click += btnCadastrarProdutos_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(43, 184);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 76;
            label13.Text = "Desconto";
            // 
            // txtDescontoProduto
            // 
            txtDescontoProduto.Location = new Point(43, 201);
            txtDescontoProduto.Name = "txtDescontoProduto";
            txtDescontoProduto.Size = new Size(100, 23);
            txtDescontoProduto.TabIndex = 75;
            txtDescontoProduto.TextChanged += txtDescontoProduto_TextChanged_1;
            txtDescontoProduto.KeyPress += txtDescontoProduto_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(237, 184);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 77;
            button1.Text = "Limpar Preço";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(txtDescontoProduto);
            Controls.Add(btnCadastrarProdutos);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLimparCor);
            Controls.Add(Cores);
            Controls.Add(nudEstoqueMin);
            Controls.Add(cmbTipoTamanho);
            Controls.Add(cmbTipoProduto);
            Controls.Add(cmbMarcaProduto);
            Controls.Add(txtCorProduto);
            Controls.Add(txtPrecoProduto);
            Controls.Add(txtDescricaoProduto);
            Controls.Add(txtTamanhoProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtCodBar);
            Controls.Add(label1);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodBar;
        private TextBox txtNomeProduto;
        private TextBox txtTamanhoProduto;
        private TextBox txtDescricaoProduto;
        private TextBox txtPrecoProduto;
        private TextBox txtCorProduto;
        private ComboBox cmbMarcaProduto;
        private ComboBox cmbTipoProduto;
        private ComboBox cmbTipoTamanho;
        private NumericUpDown nudEstoqueMin;
        private ListBox Cores;
        private Button btnLimparCor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnCadastrarProdutos;
        private Label label13;
        private TextBox txtDescontoProduto;
        private Button button1;
    }
}