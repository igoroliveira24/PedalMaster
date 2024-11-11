namespace PedalMasterDesk
{
    partial class FrmBuscarCodBar
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
            CodBarBuscar = new DataGridViewTextBoxColumn();
            NomeProdutoBuscar = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CodBarBuscar, NomeProdutoBuscar });
            dataGridView1.Location = new Point(185, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(403, 321);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CodBarBuscar
            // 
            CodBarBuscar.HeaderText = "Codigo de Barras";
            CodBarBuscar.Name = "CodBarBuscar";
            CodBarBuscar.Width = 200;
            // 
            // NomeProdutoBuscar
            // 
            NomeProdutoBuscar.HeaderText = "Nome Produto";
            NomeProdutoBuscar.Name = "NomeProdutoBuscar";
            NomeProdutoBuscar.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 23);
            textBox1.TabIndex = 1;
            // 
            // FrmBuscarCodBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "FrmBuscarCodBar";
            Text = "FrmBuscarCodBar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CodBarBuscar;
        private DataGridViewTextBoxColumn NomeProdutoBuscar;
        private TextBox textBox1;
    }
}