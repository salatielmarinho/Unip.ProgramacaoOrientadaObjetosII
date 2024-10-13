namespace Desktop
{
    partial class frmLogin
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
            btnLogin = new Button();
            lblLogin = new Label();
            lblSenha = new Label();
            grpDadosLogin = new GroupBox();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            btnSair = new Button();
            grpDadosLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(14, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(35, 48);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(35, 88);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // grpDadosLogin
            // 
            grpDadosLogin.Controls.Add(txtSenha);
            grpDadosLogin.Controls.Add(txtLogin);
            grpDadosLogin.Controls.Add(lblLogin);
            grpDadosLogin.Controls.Add(lblSenha);
            grpDadosLogin.Location = new Point(12, 12);
            grpDadosLogin.Name = "grpDadosLogin";
            grpDadosLogin.Size = new Size(361, 244);
            grpDadosLogin.TabIndex = 3;
            grpDadosLogin.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(94, 85);
            txtSenha.MaxLength = 8;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(94, 49);
            txtLogin.MaxLength = 30;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(244, 23);
            txtLogin.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(298, 301);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 336);
            ControlBox = false;
            Controls.Add(btnSair);
            Controls.Add(grpDadosLogin);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmLogin";
            Text = "frmLogin";
            grpDadosLogin.ResumeLayout(false);
            grpDadosLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Label lblLogin;
        private Label lblSenha;
        private GroupBox grpDadosLogin;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Button btnSair;
    }
}