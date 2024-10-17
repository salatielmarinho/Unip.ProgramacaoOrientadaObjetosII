namespace Desktop
{
    partial class frmGerenciarAluno
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
            dtAluno = new DataGridView();
            lblAluno = new Label();
            txtNomeAluno = new TextBox();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtAluno).BeginInit();
            SuspendLayout();
            // 
            // dtAluno
            // 
            dtAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtAluno.Location = new Point(50, 96);
            dtAluno.Name = "dtAluno";
            dtAluno.Size = new Size(470, 176);
            dtAluno.TabIndex = 0;
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Location = new Point(52, 23);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(92, 15);
            lblAluno.TabIndex = 1;
            lblAluno.Text = "Nome Aluno(a):";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(150, 23);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(370, 23);
            txtNomeAluno.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(657, 415);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(131, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // frmGerenciarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPesquisar);
            Controls.Add(txtNomeAluno);
            Controls.Add(lblAluno);
            Controls.Add(dtAluno);
            Name = "frmGerenciarAluno";
            Text = "frmGerenciarAluno";
            ((System.ComponentModel.ISupportInitialize)dtAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtAluno;
        private Label lblAluno;
        private TextBox txtNomeAluno;
        private Button btnPesquisar;
    }
}