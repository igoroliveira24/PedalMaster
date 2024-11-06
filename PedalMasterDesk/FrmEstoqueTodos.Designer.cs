namespace PedalMasterDesk
{
    partial class FrmEstoque
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
            dtgEstoque = new DataGridView();
            idEstoque = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            CodProduto = new DataGridViewTextBoxColumn();
            emEstoque = new DataGridViewTextBoxColumn();
            EstoqueMin = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // dtgEstoque
            // 
            dtgEstoque.AllowUserToAddRows = false;
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Columns.AddRange(new DataGridViewColumn[] { idEstoque, NomeProduto, CodProduto, emEstoque, EstoqueMin });
            dtgEstoque.Location = new Point(104, 29);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.RowHeadersVisible = false;
            dtgEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEstoque.Size = new Size(603, 310);
            dtgEstoque.TabIndex = 0;
            dtgEstoque.CellContentClick += dtgEstoque_CellContentClick;
            dtgEstoque.CellDoubleClick += dtgEstoque_CellDoubleClick;
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
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgEstoque);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            Load += FrmEstoqueTodos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgEstoque;
        private DataGridViewTextBoxColumn idEstoque;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn CodProduto;
        private DataGridViewTextBoxColumn emEstoque;
        private DataGridViewTextBoxColumn EstoqueMin;
    }
}