namespace Desktop.ModuloUsuario
{
    partial class frmIncluirUsuario
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            cbPerfil = new ComboBox();
            gbDadosUsuario = new GroupBox();
            btnIncluirUsuario = new Button();
            btnSair = new Button();
            lblNome = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblPerfil = new Label();
            gbDadosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(67, 22);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(471, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 65);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(471, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(66, 109);
            txtSenha.MaxLength = 8;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(142, 23);
            txtSenha.TabIndex = 2;
            // 
            // cbPerfil
            // 
            cbPerfil.FormattingEnabled = true;
            cbPerfil.Location = new Point(66, 156);
            cbPerfil.Name = "cbPerfil";
            cbPerfil.Size = new Size(167, 23);
            cbPerfil.TabIndex = 3;
            // 
            // gbDadosUsuario
            // 
            gbDadosUsuario.Controls.Add(lblPerfil);
            gbDadosUsuario.Controls.Add(lblSenha);
            gbDadosUsuario.Controls.Add(lblEmail);
            gbDadosUsuario.Controls.Add(lblNome);
            gbDadosUsuario.Controls.Add(btnSair);
            gbDadosUsuario.Controls.Add(btnIncluirUsuario);
            gbDadosUsuario.Controls.Add(txtNome);
            gbDadosUsuario.Controls.Add(cbPerfil);
            gbDadosUsuario.Controls.Add(txtEmail);
            gbDadosUsuario.Controls.Add(txtSenha);
            gbDadosUsuario.Location = new Point(12, 12);
            gbDadosUsuario.Name = "gbDadosUsuario";
            gbDadosUsuario.Size = new Size(544, 398);
            gbDadosUsuario.TabIndex = 4;
            gbDadosUsuario.TabStop = false;
            // 
            // btnIncluirUsuario
            // 
            btnIncluirUsuario.Location = new Point(18, 215);
            btnIncluirUsuario.Name = "btnIncluirUsuario";
            btnIncluirUsuario.Size = new Size(149, 23);
            btnIncluirUsuario.TabIndex = 4;
            btnIncluirUsuario.Text = "Incluir Usuário";
            btnIncluirUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(389, 369);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(149, 23);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(18, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 73);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(18, 117);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha:";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(18, 164);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(37, 15);
            lblPerfil.TabIndex = 8;
            lblPerfil.Text = "Perfil:";
            // 
            // frmIncluirUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 419);
            ControlBox = false;
            Controls.Add(gbDadosUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmIncluirUsuario";
            Text = "frmIncluirUsuario";
            gbDadosUsuario.ResumeLayout(false);
            gbDadosUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private ComboBox cbPerfil;
        private GroupBox gbDadosUsuario;
        private Label lblPerfil;
        private Label lblSenha;
        private Label lblEmail;
        private Label lblNome;
        private Button btnSair;
        private Button btnIncluirUsuario;
    }
}