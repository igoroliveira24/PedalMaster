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
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, buttonmenos, Column4, buttonmais });
            dataGridView1.Location = new Point(239, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(500, 390);
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
            buttonmenos.HeaderText = "-";
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
            buttonmais.HeaderText = "+";
            buttonmais.Name = "buttonmais";
            buttonmais.Width = 50;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 23);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(171, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 661);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            WindowState = FormWindowState.Maximized;
            Load += FrmPedidoNovo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn buttonmenos;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn buttonmais;
        private Button button1;
    }
}