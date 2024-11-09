namespace PrjBancoConta
{
    partial class frmPrincipal
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
            menuPrincipal = new MenuStrip();
            contaToolStripMenuItem = new ToolStripMenuItem();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            fecharContaToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Items.AddRange(new ToolStripItem[] { contaToolStripMenuItem, operaçõesToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(800, 24);
            menuPrincipal.TabIndex = 1;
            menuPrincipal.Text = "menuStrip1";
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarContaToolStripMenuItem, fecharContaToolStripMenuItem });
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(51, 20);
            contaToolStripMenuItem.Text = "Conta";
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(180, 22);
            criarContaToolStripMenuItem.Text = "Criar Conta";
            criarContaToolStripMenuItem.Click += criarContaToolStripMenuItem_Click;
            // 
            // fecharContaToolStripMenuItem
            // 
            fecharContaToolStripMenuItem.Name = "fecharContaToolStripMenuItem";
            fecharContaToolStripMenuItem.Size = new Size(180, 22);
            fecharContaToolStripMenuItem.Text = "Fechar Conta";
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(75, 20);
            operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipal;
            Name = "frmPrincipal";
            Text = "Gestão de Contas";
            Load += frmPrincipal_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private MenuStrip menuPrincipal;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private ToolStripMenuItem fecharContaToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
    }
}