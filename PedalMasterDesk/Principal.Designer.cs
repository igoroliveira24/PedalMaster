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
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(164, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
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
            lisToolStripMenuItem.Size = new Size(180, 22);
            lisToolStripMenuItem.Text = "Lista";
            // 
            // inserirToolStripMenuItem
            // 
            inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            inserirToolStripMenuItem.Size = new Size(180, 22);
            inserirToolStripMenuItem.Text = "Inserir";
            inserirToolStripMenuItem.Click += inserirToolStripMenuItem_Click;
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
    }
}
