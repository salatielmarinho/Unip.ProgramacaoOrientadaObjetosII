namespace Presentation.ModuloPerfil
{
    partial class frmIncluirPerfil
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
            lblNomePerfil = new Label();
            gbIncluirCliente = new GroupBox();
            txtNomePerfil = new TextBox();
            btnIncluirPerfil = new Button();
            btnSair = new Button();
            gbIncluirCliente.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomePerfil
            // 
            lblNomePerfil.AutoSize = true;
            lblNomePerfil.Location = new Point(13, 31);
            lblNomePerfil.Name = "lblNomePerfil";
            lblNomePerfil.Size = new Size(73, 15);
            lblNomePerfil.TabIndex = 0;
            lblNomePerfil.Text = "Nome Perfil:";
            // 
            // gbIncluirCliente
            // 
            gbIncluirCliente.Controls.Add(txtNomePerfil);
            gbIncluirCliente.Controls.Add(lblNomePerfil);
            gbIncluirCliente.Location = new Point(25, 12);
            gbIncluirCliente.Name = "gbIncluirCliente";
            gbIncluirCliente.Size = new Size(631, 74);
            gbIncluirCliente.TabIndex = 1;
            gbIncluirCliente.TabStop = false;
            // 
            // txtNomePerfil
            // 
            txtNomePerfil.Location = new Point(102, 28);
            txtNomePerfil.MaxLength = 100;
            txtNomePerfil.Name = "txtNomePerfil";
            txtNomePerfil.Size = new Size(326, 23);
            txtNomePerfil.TabIndex = 1;
            // 
            // btnIncluirPerfil
            // 
            btnIncluirPerfil.Location = new Point(25, 109);
            btnIncluirPerfil.Name = "btnIncluirPerfil";
            btnIncluirPerfil.Size = new Size(111, 23);
            btnIncluirPerfil.TabIndex = 5;
            btnIncluirPerfil.Text = "Incluir Perfil";
            btnIncluirPerfil.UseVisualStyleBackColor = true;
            btnIncluirPerfil.Click += btnIncluirPerfil_Click;
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
            // frmIncluirPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 231);
            ControlBox = false;
            Controls.Add(btnSair);
            Controls.Add(btnIncluirPerfil);
            Controls.Add(gbIncluirCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmIncluirPerfil";
            Text = "frmIncluirPerfil";
            gbIncluirCliente.ResumeLayout(false);
            gbIncluirCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNomePerfil;
        private GroupBox gbIncluirCliente;
        private Button btnIncluirPerfil;
        private Button btnSair;
        private TextBox txtNomePerfil;
    }
}
