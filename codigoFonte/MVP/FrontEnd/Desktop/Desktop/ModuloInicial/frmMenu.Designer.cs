namespace Desktop
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            gerenciarAlunoToolStripMenuItem = new ToolStripMenuItem();
            incluirAlunoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alunoToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerenciarAlunoToolStripMenuItem, incluirAlunoToolStripMenuItem });
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(51, 20);
            alunoToolStripMenuItem.Text = "Aluno";
            // 
            // gerenciarAlunoToolStripMenuItem
            // 
            gerenciarAlunoToolStripMenuItem.Name = "gerenciarAlunoToolStripMenuItem";
            gerenciarAlunoToolStripMenuItem.Size = new Size(159, 22);
            gerenciarAlunoToolStripMenuItem.Text = "Gerenciar Aluno";
            gerenciarAlunoToolStripMenuItem.Click += gerenciarAlunoToolStripMenuItem_Click;
            // 
            // incluirAlunoToolStripMenuItem
            // 
            incluirAlunoToolStripMenuItem.Name = "incluirAlunoToolStripMenuItem";
            incluirAlunoToolStripMenuItem.Size = new Size(159, 22);
            incluirAlunoToolStripMenuItem.Text = "Incluir Aluno";
            incluirAlunoToolStripMenuItem.Click += incluirAlunoToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "frmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem gerenciarAlunoToolStripMenuItem;
        private ToolStripMenuItem incluirAlunoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}