namespace Presentation.ModuloPerfil
{
    partial class frmGerenciarPerfil
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
            gbGerenciarPerfil = new GroupBox();
            btnSair = new Button();
            btnExcluirPerfil = new Button();
            btnAlterarPerfil = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            dgPerfil = new DataGridView();
            btnPesquisarPerfil = new Button();
            txtFiltro = new TextBox();
            lblFiltro = new Label();
            gbGerenciarPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPerfil).BeginInit();
            SuspendLayout();
            // 
            // gbGerenciarPerfil
            // 
            gbGerenciarPerfil.Controls.Add(btnSair);
            gbGerenciarPerfil.Controls.Add(btnExcluirPerfil);
            gbGerenciarPerfil.Controls.Add(btnAlterarPerfil);
            gbGerenciarPerfil.Controls.Add(txtNome);
            gbGerenciarPerfil.Controls.Add(lblNome);
            gbGerenciarPerfil.Controls.Add(dgPerfil);
            gbGerenciarPerfil.Controls.Add(btnPesquisarPerfil);
            gbGerenciarPerfil.Controls.Add(txtFiltro);
            gbGerenciarPerfil.Controls.Add(lblFiltro);
            gbGerenciarPerfil.Location = new Point(12, 0);
            gbGerenciarPerfil.Name = "gbGerenciarPerfil";
            gbGerenciarPerfil.Size = new Size(776, 438);
            gbGerenciarPerfil.TabIndex = 0;
            gbGerenciarPerfil.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(648, 409);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(122, 23);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnExcluirPerfil
            // 
            btnExcluirPerfil.Location = new Point(419, 326);
            btnExcluirPerfil.Name = "btnExcluirPerfil";
            btnExcluirPerfil.Size = new Size(122, 23);
            btnExcluirPerfil.TabIndex = 7;
            btnExcluirPerfil.Text = "Excluir Perfil";
            btnExcluirPerfil.UseVisualStyleBackColor = true;
            btnExcluirPerfil.Click += btnExcluirPerfil_Click;
            // 
            // btnAlterarPerfil
            // 
            btnAlterarPerfil.Location = new Point(13, 326);
            btnAlterarPerfil.Name = "btnAlterarPerfil";
            btnAlterarPerfil.Size = new Size(122, 23);
            btnAlterarPerfil.TabIndex = 6;
            btnAlterarPerfil.Text = "Alterar Perfil";
            btnAlterarPerfil.UseVisualStyleBackColor = true;
            btnAlterarPerfil.Click += btnAlterarPerfil_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(56, 274);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(330, 23);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(13, 282);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // dgPerfil
            // 
            dgPerfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPerfil.Location = new Point(13, 72);
            dgPerfil.Name = "dgPerfil";
            dgPerfil.Size = new Size(528, 184);
            dgPerfil.TabIndex = 3;
            dgPerfil.SelectionChanged += dgPerfil_SelectionChanged;
            // 
            // btnPesquisarPerfil
            // 
            btnPesquisarPerfil.Location = new Point(419, 22);
            btnPesquisarPerfil.Name = "btnPesquisarPerfil";
            btnPesquisarPerfil.Size = new Size(122, 23);
            btnPesquisarPerfil.TabIndex = 2;
            btnPesquisarPerfil.Text = "Pesquisar Perfil";
            btnPesquisarPerfil.UseVisualStyleBackColor = true;
            btnPesquisarPerfil.Click += btnPesquisarPerfil_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(56, 22);
            txtFiltro.MaxLength = 50;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(330, 23);
            txtFiltro.TabIndex = 1;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(13, 30);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(37, 15);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Filtro:";
            // 
            // frmGerenciarPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(gbGerenciarPerfil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGerenciarPerfil";
            Text = "frmGerenciarPerfil";
            gbGerenciarPerfil.ResumeLayout(false);
            gbGerenciarPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbGerenciarPerfil;
        private TextBox txtNome;
        private Label lblNome;
        private DataGridView dgPerfil;
        private Button btnPesquisarPerfil;
        private TextBox txtFiltro;
        private Label lblFiltro;
        private Button btnSair;
        private Button btnExcluirPerfil;
        private Button btnAlterarPerfil;
    }
}