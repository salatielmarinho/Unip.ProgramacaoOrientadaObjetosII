namespace Desktop
{
    partial class frmIncluirAluno
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
            lblCep = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            btnIncluirAluno = new Button();
            mskCEP = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(12, 171);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 0;
            lblCep.Text = "CEP:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(74, 209);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(224, 23);
            txtEndereco.TabIndex = 3;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(12, 212);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereco";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(74, 252);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(224, 23);
            txtBairro.TabIndex = 5;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(12, 255);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 4;
            lblBairro.Text = "Bairro";
            // 
            // btnIncluirAluno
            // 
            btnIncluirAluno.Location = new Point(566, 394);
            btnIncluirAluno.Name = "btnIncluirAluno";
            btnIncluirAluno.Size = new Size(166, 23);
            btnIncluirAluno.TabIndex = 6;
            btnIncluirAluno.Text = "Incluir Aluno";
            btnIncluirAluno.UseVisualStyleBackColor = true;
            btnIncluirAluno.Click += btnIncluirAluno_Click;
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(74, 171);
            mskCEP.Mask = "00000-000";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(55, 23);
            mskCEP.TabIndex = 7;
            mskCEP.Leave += mskCEP_Leave;
            // 
            // frmIncluirAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mskCEP);
            Controls.Add(btnIncluirAluno);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(lblCep);
            Name = "frmIncluirAluno";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCep;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtBairro;
        private Label lblBairro;
        private Button btnIncluirAluno;
        private MaskedTextBox mskCEP;
    }
}
