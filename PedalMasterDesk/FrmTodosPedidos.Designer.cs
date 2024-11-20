namespace PedalMasterDesk
{
    partial class FrmTodosPedidos
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
            dtgPedido = new DataGridView();
            idPed = new DataGridViewTextBoxColumn();
            Est = new DataGridViewTextBoxColumn();
            Desc = new DataGridViewTextBoxColumn();
            DataPed = new DataGridViewTextBoxColumn();
            Func = new DataGridViewTextBoxColumn();
            nomeCliente = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgPedido).BeginInit();
            SuspendLayout();
            // 
            // dtgPedido
            // 
            dtgPedido.AllowUserToAddRows = false;
            dtgPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPedido.Columns.AddRange(new DataGridViewColumn[] { idPed, Est, Desc, DataPed, Func, nomeCliente });
            dtgPedido.Location = new Point(125, 67);
            dtgPedido.Name = "dtgPedido";
            dtgPedido.RowHeadersVisible = false;
            dtgPedido.Size = new Size(603, 275);
            dtgPedido.TabIndex = 0;
            dtgPedido.CellDoubleClick += dtgPedido_CellDoubleClick;
            // 
            // idPed
            // 
            idPed.HeaderText = "ID";
            idPed.Name = "idPed";
            // 
            // Est
            // 
            Est.HeaderText = "Estatus";
            Est.Name = "Est";
            // 
            // Desc
            // 
            Desc.HeaderText = "Desconto";
            Desc.Name = "Desc";
            // 
            // DataPed
            // 
            DataPed.HeaderText = "Data do Pedido";
            DataPed.Name = "DataPed";
            // 
            // Func
            // 
            Func.HeaderText = "Funcionario";
            Func.Name = "Func";
            // 
            // nomeCliente
            // 
            nomeCliente.HeaderText = "Cliente";
            nomeCliente.Name = "nomeCliente";
            // 
            // FrmTodosPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgPedido);
            Name = "FrmTodosPedidos";
            Text = "FrmTodosPedidos";
            Load += FrmTodosPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgPedido;
        private DataGridViewTextBoxColumn idPed;
        private DataGridViewTextBoxColumn Est;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn DataPed;
        private DataGridViewTextBoxColumn Func;
        private DataGridViewTextBoxColumn nomeCliente;
    }
}