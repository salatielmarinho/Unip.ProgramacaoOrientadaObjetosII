namespace Presentation.ModuloUsuario
{
    partial class frmGerenciarUsuario
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
            gbGerenciarUsuario = new GroupBox();
            btnSair = new Button();
            btnExcluirUsuario = new Button();
            btnAlterarUsuario = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            dgUsuario = new DataGridView();
            btnPesquisarUsuario = new Button();
            txtFiltro = new TextBox();
            lblFiltro = new Label();
            gbGerenciarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuario).BeginInit();
            SuspendLayout();
            // 
            // gbGerenciarUsuario
            // 
            gbGerenciarUsuario.Controls.Add(btnSair);
            gbGerenciarUsuario.Controls.Add(btnExcluirUsuario);
            gbGerenciarUsuario.Controls.Add(btnAlterarUsuario);
            gbGerenciarUsuario.Controls.Add(txtNome);
            gbGerenciarUsuario.Controls.Add(lblNome);
            gbGerenciarUsuario.Controls.Add(dgUsuario);
            gbGerenciarUsuario.Controls.Add(btnPesquisarUsuario);
            gbGerenciarUsuario.Controls.Add(txtFiltro);
            gbGerenciarUsuario.Controls.Add(lblFiltro);
            gbGerenciarUsuario.Location = new Point(12, 0);
            gbGerenciarUsuario.Name = "gbGerenciarUsuario";
            gbGerenciarUsuario.Size = new Size(776, 438);
            gbGerenciarUsuario.TabIndex = 0;
            gbGerenciarUsuario.TabStop = false;
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
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(419, 326);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(122, 23);
            btnExcluirUsuario.TabIndex = 7;
            btnExcluirUsuario.Text = "Excluir Usuario";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // btnAlterarUsuario
            // 
            btnAlterarUsuario.Location = new Point(13, 326);
            btnAlterarUsuario.Name = "btnAlterarUsuario";
            btnAlterarUsuario.Size = new Size(122, 23);
            btnAlterarUsuario.TabIndex = 6;
            btnAlterarUsuario.Text = "Alterar Usuario";
            btnAlterarUsuario.UseVisualStyleBackColor = true;
            btnAlterarUsuario.Click += btnAlterarUsuario_Click;
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
            // dgUsuario
            // 
            dgUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuario.Location = new Point(13, 72);
            dgUsuario.Name = "dgUsuario";
            dgUsuario.Size = new Size(528, 184);
            dgUsuario.TabIndex = 3;
            dgUsuario.SelectionChanged += dgUsuario_SelectionChanged;
            // 
            // btnPesquisarUsuario
            // 
            btnPesquisarUsuario.Location = new Point(419, 22);
            btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            btnPesquisarUsuario.Size = new Size(122, 23);
            btnPesquisarUsuario.TabIndex = 2;
            btnPesquisarUsuario.Text = "Pesquisar Usuario";
            btnPesquisarUsuario.UseVisualStyleBackColor = true;
            btnPesquisarUsuario.Click += btnPesquisarUsuario_Click;
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
            // frmGerenciarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(gbGerenciarUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGerenciarUsuario";
            Text = "frmGerenciarUsuario";
            gbGerenciarUsuario.ResumeLayout(false);
            gbGerenciarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbGerenciarUsuario;
        private TextBox txtNome;
        private Label lblNome;
        private DataGridView dgUsuario;
        private Button btnPesquisarUsuario;
        private TextBox txtFiltro;
        private Label lblFiltro;
        private Button btnSair;
        private Button btnExcluirUsuario;
        private Button btnAlterarUsuario;
    }
}