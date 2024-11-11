namespace PedalMasterDesk
{
    partial class FrmGdvBuscarCliente
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
            idCliente = new DataGridViewTextBoxColumn();
            NomeCliente = new DataGridViewTextBoxColumn();
            CPFCLIENTE = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idCliente, NomeCliente, CPFCLIENTE });
            dataGridView1.Location = new Point(67, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(354, 348);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idCliente
            // 
            idCliente.HeaderText = "ID";
            idCliente.Name = "idCliente";
            idCliente.Width = 50;
            // 
            // NomeCliente
            // 
            NomeCliente.HeaderText = "Nome";
            NomeCliente.Name = "NomeCliente";
            NomeCliente.Width = 150;
            // 
            // CPFCLIENTE
            // 
            CPFCLIENTE.HeaderText = "CPF";
            CPFCLIENTE.Name = "CPFCLIENTE";
            CPFCLIENTE.Width = 150;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(67, 21);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(354, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // FrmGdvBuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            Name = "FrmGdvBuscarCliente";
            Text = "FrmGdvBuscarCliente";
            Load += FrmGdvBuscarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn idCliente;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn CPFCLIENTE;
    }
}