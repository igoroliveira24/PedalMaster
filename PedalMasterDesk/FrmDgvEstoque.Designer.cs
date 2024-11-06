namespace PedalMasterDesk
{
    partial class FrmDgvEstoque
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
            btnAdicionar = new Button();
            btnEditar = new Button();
            cmbCorEstoque = new ComboBox();
            nudQuantidadeEstoque = new NumericUpDown();
            dtgEstoque = new DataGridView();
            idEstoque = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            CodProduto = new DataGridViewTextBoxColumn();
            emEstoque = new DataGridViewTextBoxColumn();
            EstoqueMin = new DataGridViewTextBoxColumn();
            CorEstoque = new DataGridViewTextBoxColumn();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(89, 324);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(158, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar estoque de cor";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(89, 363);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar Estoque";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // cmbCorEstoque
            // 
            cmbCorEstoque.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCorEstoque.Enabled = false;
            cmbCorEstoque.Location = new Point(244, 261);
            cmbCorEstoque.Name = "cmbCorEstoque";
            cmbCorEstoque.Size = new Size(121, 23);
            cmbCorEstoque.TabIndex = 2;
            cmbCorEstoque.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // nudQuantidadeEstoque
            // 
            nudQuantidadeEstoque.Enabled = false;
            nudQuantidadeEstoque.Location = new Point(89, 261);
            nudQuantidadeEstoque.Name = "nudQuantidadeEstoque";
            nudQuantidadeEstoque.ReadOnly = true;
            nudQuantidadeEstoque.Size = new Size(120, 23);
            nudQuantidadeEstoque.TabIndex = 3;
            // 
            // dtgEstoque
            // 
            dtgEstoque.AllowUserToAddRows = false;
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Columns.AddRange(new DataGridViewColumn[] { idEstoque, NomeProduto, CodProduto, emEstoque, EstoqueMin, CorEstoque });
            dtgEstoque.Location = new Point(50, 59);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.RowHeadersVisible = false;
            dtgEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEstoque.Size = new Size(704, 152);
            dtgEstoque.TabIndex = 4;
            dtgEstoque.CellContentClick += dtgEstoque_CellContentClick;
            dtgEstoque.CellContentDoubleClick += dtgEstoque_CellContentDoubleClick;
            // 
            // idEstoque
            // 
            idEstoque.Frozen = true;
            idEstoque.HeaderText = "Id";
            idEstoque.Name = "idEstoque";
            idEstoque.ReadOnly = true;
            // 
            // NomeProduto
            // 
            NomeProduto.HeaderText = "Nome";
            NomeProduto.Name = "NomeProduto";
            NomeProduto.ReadOnly = true;
            NomeProduto.Width = 150;
            // 
            // CodProduto
            // 
            CodProduto.HeaderText = "Codigo de barras";
            CodProduto.Name = "CodProduto";
            CodProduto.ReadOnly = true;
            CodProduto.Width = 150;
            // 
            // emEstoque
            // 
            emEstoque.HeaderText = "Em Estoque";
            emEstoque.Name = "emEstoque";
            emEstoque.ReadOnly = true;
            // 
            // EstoqueMin
            // 
            EstoqueMin.HeaderText = "Estoque minimo";
            EstoqueMin.Name = "EstoqueMin";
            EstoqueMin.ReadOnly = true;
            // 
            // CorEstoque
            // 
            CorEstoque.HeaderText = "Cor";
            CorEstoque.Name = "CorEstoque";
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(50, 12);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(679, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmDgvEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(dtgEstoque);
            Controls.Add(nudQuantidadeEstoque);
            Controls.Add(cmbCorEstoque);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Name = "FrmDgvEstoque";
            Text = "FrmDgvEstoque";
            Load += FrmDgvEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdicionar;
        private Button btnEditar;
        private ComboBox cmbCorEstoque;
        private NumericUpDown nudQuantidadeEstoque;
        private DataGridView dtgEstoque;
        private DataGridViewTextBoxColumn idEstoque;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn CodProduto;
        private DataGridViewTextBoxColumn emEstoque;
        private DataGridViewTextBoxColumn EstoqueMin;
        private DataGridViewTextBoxColumn CorEstoque;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}