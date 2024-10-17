namespace Desktop
{
    partial class frmIncluirCliente
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
            lblNomeCliente = new Label();
            gbIncluirCliente = new GroupBox();
            mskCpf = new MaskedTextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtNomeCliente = new TextBox();
            lblSenha = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            btnIncluirCliente = new Button();
            btnSair = new Button();
            gbIncluirCliente.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(13, 31);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(83, 15);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "Nome Cliente:";
            // 
            // gbIncluirCliente
            // 
            gbIncluirCliente.Controls.Add(mskCpf);
            gbIncluirCliente.Controls.Add(txtSenha);
            gbIncluirCliente.Controls.Add(txtEmail);
            gbIncluirCliente.Controls.Add(txtNomeCliente);
            gbIncluirCliente.Controls.Add(lblSenha);
            gbIncluirCliente.Controls.Add(lblEmail);
            gbIncluirCliente.Controls.Add(lblCpf);
            gbIncluirCliente.Controls.Add(lblNomeCliente);
            gbIncluirCliente.Location = new Point(25, 12);
            gbIncluirCliente.Name = "gbIncluirCliente";
            gbIncluirCliente.Size = new Size(631, 178);
            gbIncluirCliente.TabIndex = 1;
            gbIncluirCliente.TabStop = false;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(102, 64);
            mskCpf.Mask = "000.000.000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(80, 23);
            mskCpf.TabIndex = 2;
            mskCpf.MaskInputRejected += mskCpf_MaskInputRejected;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(102, 126);
            txtSenha.MaxLength = 4;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(80, 23);
            txtSenha.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(102, 97);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(102, 28);
            txtNomeCliente.MaxLength = 100;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(326, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(13, 133);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(13, 64);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(29, 15);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "Cpf:";
            // 
            // btnIncluirCliente
            // 
            btnIncluirCliente.Location = new Point(25, 196);
            btnIncluirCliente.Name = "btnIncluirCliente";
            btnIncluirCliente.Size = new Size(111, 23);
            btnIncluirCliente.TabIndex = 5;
            btnIncluirCliente.Text = "Incluir Cliente";
            btnIncluirCliente.UseVisualStyleBackColor = true;
            btnIncluirCliente.Click += btnIncluirCliente_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(545, 196);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(111, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // frmIncluirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 231);
            ControlBox = false;
            Controls.Add(btnSair);
            Controls.Add(btnIncluirCliente);
            Controls.Add(gbIncluirCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmIncluirCliente";
            Text = "frmIncluirCliente";
            gbIncluirCliente.ResumeLayout(false);
            gbIncluirCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNomeCliente;
        private GroupBox gbIncluirCliente;
        private Label lblSenha;
        private Label lblEmail;
        private Label lblCpf;
        private Button btnIncluirCliente;
        private Button btnSair;
        private MaskedTextBox mskCpf;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtNomeCliente;
    }
}
