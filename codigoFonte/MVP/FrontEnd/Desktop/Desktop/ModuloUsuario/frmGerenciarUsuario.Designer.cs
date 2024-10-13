namespace Desktop.ModuloUsuario
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
            btnSair = new Button();
            gbGerenciarUsuario = new GroupBox();
            rbEmail = new RadioButton();
            rbNome = new RadioButton();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnPesquisar = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            dgUsuario = new DataGridView();
            txtFiltro = new TextBox();
            lblFiltro = new Label();
            gbGerenciarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(713, 415);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // gbGerenciarUsuario
            // 
            gbGerenciarUsuario.Controls.Add(rbEmail);
            gbGerenciarUsuario.Controls.Add(rbNome);
            gbGerenciarUsuario.Controls.Add(btnExcluir);
            gbGerenciarUsuario.Controls.Add(btnAlterar);
            gbGerenciarUsuario.Controls.Add(btnPesquisar);
            gbGerenciarUsuario.Controls.Add(txtEmail);
            gbGerenciarUsuario.Controls.Add(lblEmail);
            gbGerenciarUsuario.Controls.Add(txtNome);
            gbGerenciarUsuario.Controls.Add(lblNome);
            gbGerenciarUsuario.Controls.Add(dgUsuario);
            gbGerenciarUsuario.Controls.Add(txtFiltro);
            gbGerenciarUsuario.Controls.Add(lblFiltro);
            gbGerenciarUsuario.Location = new Point(12, 12);
            gbGerenciarUsuario.Name = "gbGerenciarUsuario";
            gbGerenciarUsuario.Size = new Size(776, 397);
            gbGerenciarUsuario.TabIndex = 9;
            gbGerenciarUsuario.TabStop = false;
            // 
            // rbEmail
            // 
            rbEmail.AutoSize = true;
            rbEmail.Location = new Point(488, 31);
            rbEmail.Name = "rbEmail";
            rbEmail.Size = new Size(75, 19);
            rbEmail.TabIndex = 15;
            rbEmail.TabStop = true;
            rbEmail.Text = "Por Email";
            rbEmail.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            rbNome.AutoSize = true;
            rbNome.Location = new Point(393, 32);
            rbNome.Name = "rbNome";
            rbNome.Size = new Size(79, 19);
            rbNome.TabIndex = 10;
            rbNome.TabStop = true;
            rbNome.Text = "Por Nome";
            rbNome.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(488, 355);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(13, 355);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(595, 30);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(83, 310);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(480, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 318);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(83, 267);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(480, 23);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(13, 275);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome:";
            // 
            // dgUsuario
            // 
            dgUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuario.Location = new Point(13, 59);
            dgUsuario.Name = "dgUsuario";
            dgUsuario.Size = new Size(657, 191);
            dgUsuario.TabIndex = 10;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(62, 27);
            txtFiltro.MaxLength = 100;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(325, 23);
            txtFiltro.TabIndex = 1;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(13, 30);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(37, 15);
            lblFiltro.TabIndex = 8;
            lblFiltro.Text = "Filtro:";
            // 
            // frmGerenciarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            ControlBox = false;
            Controls.Add(gbGerenciarUsuario);
            Controls.Add(btnSair);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGerenciarUsuario";
            Text = "frmGerenciarUsuario";
            gbGerenciarUsuario.ResumeLayout(false);
            gbGerenciarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
        private GroupBox gbGerenciarUsuario;
        private Button btnPesquisar;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtNome;
        private Label lblNome;
        private DataGridView dgUsuario;
        private TextBox txtFiltro;
        private Label lblFiltro;
        private Button btnAlterar;
        private Button btnExcluir;
        private RadioButton rbEmail;
        private RadioButton rbNome;
    }
}