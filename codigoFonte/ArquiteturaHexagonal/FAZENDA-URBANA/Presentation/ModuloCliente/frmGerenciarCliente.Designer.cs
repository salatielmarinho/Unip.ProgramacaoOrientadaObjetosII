namespace Presentation.ModuloCliente
{
    partial class frmGerenciarCliente
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
            gbGerenciarCliente = new GroupBox();
            btnSair = new Button();
            btnExcluirCliente = new Button();
            btnAlterarCliente = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            dgCliente = new DataGridView();
            btnPesquisarCliente = new Button();
            txtFiltro = new TextBox();
            lblFiltro = new Label();
            gbGerenciarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCliente).BeginInit();
            SuspendLayout();
            // 
            // gbGerenciarCliente
            // 
            gbGerenciarCliente.Controls.Add(btnSair);
            gbGerenciarCliente.Controls.Add(btnExcluirCliente);
            gbGerenciarCliente.Controls.Add(btnAlterarCliente);
            gbGerenciarCliente.Controls.Add(txtNome);
            gbGerenciarCliente.Controls.Add(lblNome);
            gbGerenciarCliente.Controls.Add(dgCliente);
            gbGerenciarCliente.Controls.Add(btnPesquisarCliente);
            gbGerenciarCliente.Controls.Add(txtFiltro);
            gbGerenciarCliente.Controls.Add(lblFiltro);
            gbGerenciarCliente.Location = new Point(12, 0);
            gbGerenciarCliente.Name = "gbGerenciarCliente";
            gbGerenciarCliente.Size = new Size(776, 438);
            gbGerenciarCliente.TabIndex = 0;
            gbGerenciarCliente.TabStop = false;
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
            // btnExcluirCliente
            // 
            btnExcluirCliente.Location = new Point(419, 326);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(122, 23);
            btnExcluirCliente.TabIndex = 7;
            btnExcluirCliente.Text = "Excluir Cliente";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.Location = new Point(13, 326);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(122, 23);
            btnAlterarCliente.TabIndex = 6;
            btnAlterarCliente.Text = "Alterar Cliente";
            btnAlterarCliente.UseVisualStyleBackColor = true;
            btnAlterarCliente.Click += btnAlterarCliente_Click;
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
            // dgCliente
            // 
            dgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCliente.Location = new Point(13, 72);
            dgCliente.Name = "dgCliente";
            dgCliente.Size = new Size(528, 184);
            dgCliente.TabIndex = 3;
            dgCliente.SelectionChanged += dgCliente_SelectionChanged;
            // 
            // btnPesquisarCliente
            // 
            btnPesquisarCliente.Location = new Point(419, 22);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.Size = new Size(122, 23);
            btnPesquisarCliente.TabIndex = 2;
            btnPesquisarCliente.Text = "Pesquisar Cliente";
            btnPesquisarCliente.UseVisualStyleBackColor = true;
            btnPesquisarCliente.Click += btnPesquisarCliente_Click;
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
            // frmGerenciarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(gbGerenciarCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGerenciarCliente";
            Text = "frmGerenciarCliente";
            gbGerenciarCliente.ResumeLayout(false);
            gbGerenciarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbGerenciarCliente;
        private TextBox txtNome;
        private Label lblNome;
        private DataGridView dgCliente;
        private Button btnPesquisarCliente;
        private TextBox txtFiltro;
        private Label lblFiltro;
        private Button btnSair;
        private Button btnExcluirCliente;
        private Button btnAlterarCliente;
    }
}