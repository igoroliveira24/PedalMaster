namespace PedalMasterDesk
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            lisToolStripMenuItem = new ToolStripMenuItem();
            inserirToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            produtosToolStripMenuItem2 = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            emEstoqueToolStripMenuItem2 = new ToolStripMenuItem();
            emFaltaToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            pedidoToolStripMenuItem1 = new ToolStripMenuItem();
            listaToolStripMenuItem2 = new ToolStripMenuItem();
            novoToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2, toolStripDropDownButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, funcionariosToolStripMenuItem, produtosToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(72, 22);
            toolStripDropDownButton1.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lisToolStripMenuItem, inserirToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // lisToolStripMenuItem
            // 
            lisToolStripMenuItem.Name = "lisToolStripMenuItem";
            lisToolStripMenuItem.Size = new Size(106, 22);
            lisToolStripMenuItem.Text = "Lista";
            lisToolStripMenuItem.Click += lisToolStripMenuItem_Click;
            // 
            // inserirToolStripMenuItem
            // 
            inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            inserirToolStripMenuItem.Size = new Size(106, 22);
            inserirToolStripMenuItem.Text = "Inserir";
            inserirToolStripMenuItem.Click += inserirToolStripMenuItem_Click;
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaToolStripMenuItem, cadastrarToolStripMenuItem });
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new Size(180, 22);
            funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(106, 22);
            listaToolStripMenuItem.Text = "Lista";
            listaToolStripMenuItem.Click += listaToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(106, 22);
            cadastrarToolStripMenuItem.Text = "Inserir";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem1 });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(124, 22);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem1_Click;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem2 });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(62, 22);
            toolStripDropDownButton2.Text = "Estoque";
            toolStripDropDownButton2.Click += toolStripDropDownButton2_Click;
            // 
            // produtosToolStripMenuItem2
            // 
            produtosToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem, emEstoqueToolStripMenuItem2, emFaltaToolStripMenuItem1 });
            produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            produtosToolStripMenuItem2.Size = new Size(180, 22);
            produtosToolStripMenuItem2.Text = "Produtos";
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(180, 22);
            todosToolStripMenuItem.Text = "Todos";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // emEstoqueToolStripMenuItem2
            // 
            emEstoqueToolStripMenuItem2.Name = "emEstoqueToolStripMenuItem2";
            emEstoqueToolStripMenuItem2.Size = new Size(180, 22);
            emEstoqueToolStripMenuItem2.Text = "Em Estoque";
            emEstoqueToolStripMenuItem2.Click += emEstoqueToolStripMenuItem2_Click;
            // 
            // emFaltaToolStripMenuItem1
            // 
            emFaltaToolStripMenuItem1.Name = "emFaltaToolStripMenuItem1";
            emFaltaToolStripMenuItem1.Size = new Size(180, 22);
            emFaltaToolStripMenuItem1.Text = "Em Falta";
            emFaltaToolStripMenuItem1.Click += emFaltaToolStripMenuItem1_Click;
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { pedidoToolStripMenuItem1 });
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(49, 22);
            toolStripDropDownButton3.Text = "Caixa";
            // 
            // pedidoToolStripMenuItem1
            // 
            pedidoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { listaToolStripMenuItem2, novoToolStripMenuItem1 });
            pedidoToolStripMenuItem1.Name = "pedidoToolStripMenuItem1";
            pedidoToolStripMenuItem1.Size = new Size(180, 22);
            pedidoToolStripMenuItem1.Text = "Pedido";
            // 
            // listaToolStripMenuItem2
            // 
            listaToolStripMenuItem2.Name = "listaToolStripMenuItem2";
            listaToolStripMenuItem2.Size = new Size(180, 22);
            listaToolStripMenuItem2.Text = "Lista";
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(180, 22);
            novoToolStripMenuItem1.Text = "Novo";
            novoToolStripMenuItem1.Click += novoToolStripMenuItem1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Principal";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Principal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem lisToolStripMenuItem;
        private ToolStripMenuItem inserirToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem produtosToolStripMenuItem2;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem emEstoqueToolStripMenuItem2;
        private ToolStripMenuItem emFaltaToolStripMenuItem1;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem pedidoToolStripMenuItem1;
        private ToolStripMenuItem listaToolStripMenuItem2;
        private ToolStripMenuItem novoToolStripMenuItem1;
    }
}
