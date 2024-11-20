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
            tsddbCadastros = new ToolStripDropDownButton();
            clientestsmi = new ToolStripMenuItem();
            lisToolStripMenuItem = new ToolStripMenuItem();
            inserirToolStripMenuItem = new ToolStripMenuItem();
            funcionariostsmi = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            produtostsmi = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            tsddbCaixaEstoque = new ToolStripDropDownButton();
            produtosToolStripMenuItem2 = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            emEstoqueToolStripMenuItem2 = new ToolStripMenuItem();
            emFaltaToolStripMenuItem1 = new ToolStripMenuItem();
            tsddbCaixa = new ToolStripDropDownButton();
            pedidoToolStripMenuItem1 = new ToolStripMenuItem();
            listaToolStripMenuItem2 = new ToolStripMenuItem();
            todosToolStripMenuItem1 = new ToolStripMenuItem();
            finalizadosToolStripMenuItem = new ToolStripMenuItem();
            emAbertoToolStripMenuItem = new ToolStripMenuItem();
            canceladosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsddbCadastros, tsddbCaixaEstoque, tsddbCaixa });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsddbCadastros
            // 
            tsddbCadastros.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddbCadastros.DropDownItems.AddRange(new ToolStripItem[] { clientestsmi, funcionariostsmi, produtostsmi });
            tsddbCadastros.Image = (Image)resources.GetObject("tsddbCadastros.Image");
            tsddbCadastros.ImageTransparentColor = Color.Magenta;
            tsddbCadastros.Name = "tsddbCadastros";
            tsddbCadastros.Size = new Size(72, 22);
            tsddbCadastros.Text = "Cadastros";
            // 
            // clientestsmi
            // 
            clientestsmi.DropDownItems.AddRange(new ToolStripItem[] { lisToolStripMenuItem, inserirToolStripMenuItem });
            clientestsmi.Name = "clientestsmi";
            clientestsmi.Size = new Size(142, 22);
            clientestsmi.Text = "Clientes";
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
            // funcionariostsmi
            // 
            funcionariostsmi.DropDownItems.AddRange(new ToolStripItem[] { listaToolStripMenuItem, cadastrarToolStripMenuItem });
            funcionariostsmi.Name = "funcionariostsmi";
            funcionariostsmi.Size = new Size(142, 22);
            funcionariostsmi.Text = "Funcionarios";
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
            // produtostsmi
            // 
            produtostsmi.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem1 });
            produtostsmi.Name = "produtostsmi";
            produtostsmi.Size = new Size(142, 22);
            produtostsmi.Text = "Produtos";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(124, 22);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem1_Click;
            // 
            // tsddbCaixaEstoque
            // 
            tsddbCaixaEstoque.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddbCaixaEstoque.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem2 });
            tsddbCaixaEstoque.Image = (Image)resources.GetObject("tsddbCaixaEstoque.Image");
            tsddbCaixaEstoque.ImageTransparentColor = Color.Magenta;
            tsddbCaixaEstoque.Name = "tsddbCaixaEstoque";
            tsddbCaixaEstoque.Size = new Size(62, 22);
            tsddbCaixaEstoque.Text = "Estoque";
            tsddbCaixaEstoque.Click += toolStripDropDownButton2_Click;
            // 
            // produtosToolStripMenuItem2
            // 
            produtosToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem, emEstoqueToolStripMenuItem2, emFaltaToolStripMenuItem1 });
            produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            produtosToolStripMenuItem2.Size = new Size(122, 22);
            produtosToolStripMenuItem2.Text = "Produtos";
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(136, 22);
            todosToolStripMenuItem.Text = "Todos";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // emEstoqueToolStripMenuItem2
            // 
            emEstoqueToolStripMenuItem2.Name = "emEstoqueToolStripMenuItem2";
            emEstoqueToolStripMenuItem2.Size = new Size(136, 22);
            emEstoqueToolStripMenuItem2.Text = "Em Estoque";
            emEstoqueToolStripMenuItem2.Click += emEstoqueToolStripMenuItem2_Click;
            // 
            // emFaltaToolStripMenuItem1
            // 
            emFaltaToolStripMenuItem1.Name = "emFaltaToolStripMenuItem1";
            emFaltaToolStripMenuItem1.Size = new Size(136, 22);
            emFaltaToolStripMenuItem1.Text = "Em Falta";
            emFaltaToolStripMenuItem1.Click += emFaltaToolStripMenuItem1_Click;
            // 
            // tsddbCaixa
            // 
            tsddbCaixa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsddbCaixa.DropDownItems.AddRange(new ToolStripItem[] { pedidoToolStripMenuItem1 });
            tsddbCaixa.Image = (Image)resources.GetObject("tsddbCaixa.Image");
            tsddbCaixa.ImageTransparentColor = Color.Magenta;
            tsddbCaixa.Name = "tsddbCaixa";
            tsddbCaixa.Size = new Size(49, 22);
            tsddbCaixa.Text = "Caixa";
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
            listaToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem1, finalizadosToolStripMenuItem, emAbertoToolStripMenuItem, canceladosToolStripMenuItem });
            listaToolStripMenuItem2.Name = "listaToolStripMenuItem2";
            listaToolStripMenuItem2.Size = new Size(180, 22);
            listaToolStripMenuItem2.Text = "Lista";
            // 
            // todosToolStripMenuItem1
            // 
            todosToolStripMenuItem1.Name = "todosToolStripMenuItem1";
            todosToolStripMenuItem1.Size = new Size(180, 22);
            todosToolStripMenuItem1.Text = "Todos";
            todosToolStripMenuItem1.Click += todosToolStripMenuItem1_Click;
            // 
            // finalizadosToolStripMenuItem
            // 
            finalizadosToolStripMenuItem.Name = "finalizadosToolStripMenuItem";
            finalizadosToolStripMenuItem.Size = new Size(180, 22);
            finalizadosToolStripMenuItem.Text = "Finalizados";
            finalizadosToolStripMenuItem.Click += finalizadosToolStripMenuItem_Click;
            // 
            // emAbertoToolStripMenuItem
            // 
            emAbertoToolStripMenuItem.Name = "emAbertoToolStripMenuItem";
            emAbertoToolStripMenuItem.Size = new Size(180, 22);
            emAbertoToolStripMenuItem.Text = "Em Aberto";
            emAbertoToolStripMenuItem.Click += emAbertoToolStripMenuItem_Click;
            // 
            // canceladosToolStripMenuItem
            // 
            canceladosToolStripMenuItem.Name = "canceladosToolStripMenuItem";
            canceladosToolStripMenuItem.Size = new Size(180, 22);
            canceladosToolStripMenuItem.Text = "Cancelados";
            canceladosToolStripMenuItem.Click += canceladosToolStripMenuItem_Click;
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(180, 22);
            novoToolStripMenuItem1.Text = "Novo";
            novoToolStripMenuItem1.Click += novoToolStripMenuItem1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Principal";
            Text = "Pagina Inicial";
            WindowState = FormWindowState.Maximized;
            Load += Principal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tsddbCadastros;
        private ToolStripMenuItem clientestsmi;
        private ToolStripMenuItem lisToolStripMenuItem;
        private ToolStripMenuItem inserirToolStripMenuItem;
        private ToolStripMenuItem funcionariostsmi;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem produtostsmi;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripDropDownButton tsddbCaixaEstoque;
        private ToolStripMenuItem produtosToolStripMenuItem2;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem emEstoqueToolStripMenuItem2;
        private ToolStripMenuItem emFaltaToolStripMenuItem1;
        private ToolStripDropDownButton tsddbCaixa;
        private ToolStripMenuItem pedidoToolStripMenuItem1;
        private ToolStripMenuItem listaToolStripMenuItem2;
        private ToolStripMenuItem novoToolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem todosToolStripMenuItem1;
        private ToolStripMenuItem finalizadosToolStripMenuItem;
        private ToolStripMenuItem emAbertoToolStripMenuItem;
        private ToolStripMenuItem canceladosToolStripMenuItem;
    }
}
