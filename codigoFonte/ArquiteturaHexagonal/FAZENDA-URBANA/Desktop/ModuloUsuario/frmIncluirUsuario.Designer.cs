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
            lblCep = new Label();
            mskCep = new MaskedTextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            gbIncluirUsuario = new GroupBox();
            btnSair = new Button();
            btnIncluirUsuario = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUF = new TextBox();
            lblUf = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            cbxPerfil = new ComboBox();
            lblPerfil = new Label();
            gbIncluirUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(32, 68);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 0;
            lblCep.Text = "Cep:";
            // 
            // mskCep
            // 
            mskCep.Location = new Point(125, 60);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(65, 23);
            mskCep.TabIndex = 2;
            mskCep.Leave += mskCep_Leave;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(32, 112);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(65, 15);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Enedereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(125, 104);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(398, 23);
            txtEndereco.TabIndex = 3;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(125, 156);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(249, 23);
            txtComplemento.TabIndex = 4;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(32, 164);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(87, 15);
            lblComplemento.TabIndex = 4;
            lblComplemento.Text = "Complemento:";
            // 
            // gbIncluirUsuario
            // 
            gbIncluirUsuario.Controls.Add(lblPerfil);
            gbIncluirUsuario.Controls.Add(cbxPerfil);
            gbIncluirUsuario.Controls.Add(btnSair);
            gbIncluirUsuario.Controls.Add(btnIncluirUsuario);
            gbIncluirUsuario.Controls.Add(txtSenha);
            gbIncluirUsuario.Controls.Add(lblSenha);
            gbIncluirUsuario.Controls.Add(txtEmail);
            gbIncluirUsuario.Controls.Add(lblEmail);
            gbIncluirUsuario.Controls.Add(txtUF);
            gbIncluirUsuario.Controls.Add(lblUf);
            gbIncluirUsuario.Controls.Add(txtBairro);
            gbIncluirUsuario.Controls.Add(lblBairro);
            gbIncluirUsuario.Controls.Add(txtNumero);
            gbIncluirUsuario.Controls.Add(lblNumero);
            gbIncluirUsuario.Controls.Add(txtNome);
            gbIncluirUsuario.Controls.Add(lblNome);
            gbIncluirUsuario.Controls.Add(txtComplemento);
            gbIncluirUsuario.Controls.Add(lblCep);
            gbIncluirUsuario.Controls.Add(lblComplemento);
            gbIncluirUsuario.Controls.Add(mskCep);
            gbIncluirUsuario.Controls.Add(txtEndereco);
            gbIncluirUsuario.Controls.Add(lblEndereco);
            gbIncluirUsuario.Location = new Point(12, 12);
            gbIncluirUsuario.Name = "gbIncluirUsuario";
            gbIncluirUsuario.Size = new Size(910, 601);
            gbIncluirUsuario.TabIndex = 6;
            gbIncluirUsuario.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(795, 563);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 23);
            btnSair.TabIndex = 17;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnIncluirUsuario
            // 
            btnIncluirUsuario.Location = new Point(32, 516);
            btnIncluirUsuario.Name = "btnIncluirUsuario";
            btnIncluirUsuario.Size = new Size(100, 23);
            btnIncluirUsuario.TabIndex = 16;
            btnIncluirUsuario.Text = "Incluir Usuário";
            btnIncluirUsuario.UseVisualStyleBackColor = true;
            btnIncluirUsuario.Click += btnIncluirUsuario_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(125, 408);
            txtSenha.MaxLength = 8;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(249, 23);
            txtSenha.TabIndex = 9;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(32, 416);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 15;
            lblSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 363);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(32, 371);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(125, 314);
            txtUF.MaxLength = 2;
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(52, 23);
            txtUF.TabIndex = 7;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(32, 322);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(24, 15);
            lblUf.TabIndex = 11;
            lblUf.Text = "UF:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(125, 263);
            txtBairro.MaxLength = 50;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(249, 23);
            txtBairro.TabIndex = 6;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(32, 271);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 9;
            lblBairro.Text = "Bairro:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(125, 212);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(52, 23);
            txtNumero.TabIndex = 5;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(32, 220);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 7;
            lblNumero.Text = "Número:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(125, 19);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(398, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(32, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome:";
            // 
            // cbxPerfil
            // 
            cbxPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Location = new Point(125, 454);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(249, 23);
            cbxPerfil.TabIndex = 18;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(32, 462);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 19;
            lblPerfil.Text = "Perfil";
            // 
            // frmIncluirUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 641);
            ControlBox = false;
            Controls.Add(gbIncluirUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmIncluirUsuario";
            Text = "frmIncluirUsuario";
            gbIncluirUsuario.ResumeLayout(false);
            gbIncluirUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCep;
        private MaskedTextBox mskCep;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private GroupBox gbIncluirUsuario;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtNumero;
        private Label lblNumero;
        private Button btnSair;
        private Button btnIncluirUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtUF;
        private Label lblUf;
        private Label lblPerfil;
        private ComboBox cbxPerfil;
    }
}