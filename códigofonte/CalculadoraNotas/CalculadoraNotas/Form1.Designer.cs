namespace CalculadoraNotas
{
    partial class frmCalculadoraNota
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
            this.grpNotasSemestrais = new System.Windows.Forms.GroupBox();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtMediaFinal = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblMediaFinal = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.grpNotasSemestrais.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNotasSemestrais
            // 
            this.grpNotasSemestrais.Controls.Add(this.btnCalcularMedia);
            this.grpNotasSemestrais.Controls.Add(this.comboBox1);
            this.grpNotasSemestrais.Controls.Add(this.lblDisciplina);
            this.grpNotasSemestrais.Controls.Add(this.lblRA);
            this.grpNotasSemestrais.Controls.Add(this.textBox2);
            this.grpNotasSemestrais.Controls.Add(this.textBox1);
            this.grpNotasSemestrais.Controls.Add(this.lblNome);
            this.grpNotasSemestrais.Controls.Add(this.txtMediaFinal);
            this.grpNotasSemestrais.Controls.Add(this.txtSub);
            this.grpNotasSemestrais.Controls.Add(this.txtNota2);
            this.grpNotasSemestrais.Controls.Add(this.txtNota1);
            this.grpNotasSemestrais.Controls.Add(this.lblMediaFinal);
            this.grpNotasSemestrais.Controls.Add(this.lblSub);
            this.grpNotasSemestrais.Controls.Add(this.lblNota2);
            this.grpNotasSemestrais.Controls.Add(this.lblNota1);
            this.grpNotasSemestrais.Location = new System.Drawing.Point(12, 12);
            this.grpNotasSemestrais.Name = "grpNotasSemestrais";
            this.grpNotasSemestrais.Size = new System.Drawing.Size(321, 246);
            this.grpNotasSemestrais.TabIndex = 0;
            this.grpNotasSemestrais.TabStop = false;
            this.grpNotasSemestrais.Text = "Notas Semestrais";
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(211, 206);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(93, 23);
            this.btnCalcularMedia.TabIndex = 14;
            this.btnCalcularMedia.Text = "Calcular Média";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(6, 83);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(55, 13);
            this.lblDisciplina.TabIndex = 12;
            this.lblDisciplina.Text = "Disciplina:";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(6, 56);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(25, 13);
            this.lblRA.TabIndex = 11;
            this.lblRA.Text = "RA:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 49);
            this.textBox2.MaxLength = 8;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 23);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // txtMediaFinal
            // 
            this.txtMediaFinal.Location = new System.Drawing.Point(76, 208);
            this.txtMediaFinal.MaxLength = 3;
            this.txtMediaFinal.Name = "txtMediaFinal";
            this.txtMediaFinal.Size = new System.Drawing.Size(36, 20);
            this.txtMediaFinal.TabIndex = 7;
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(76, 176);
            this.txtSub.MaxLength = 3;
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(36, 20);
            this.txtSub.TabIndex = 6;
            this.txtSub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSub_KeyPress);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(76, 146);
            this.txtNota2.MaxLength = 3;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(36, 20);
            this.txtNota2.TabIndex = 5;
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota2_KeyPress);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(76, 119);
            this.txtNota1.MaxLength = 3;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(36, 20);
            this.txtNota1.TabIndex = 4;
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            // 
            // lblMediaFinal
            // 
            this.lblMediaFinal.AutoSize = true;
            this.lblMediaFinal.Location = new System.Drawing.Point(6, 208);
            this.lblMediaFinal.Name = "lblMediaFinal";
            this.lblMediaFinal.Size = new System.Drawing.Size(64, 13);
            this.lblMediaFinal.TabIndex = 3;
            this.lblMediaFinal.Text = "Média Final:";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(6, 176);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(29, 13);
            this.lblSub.TabIndex = 2;
            this.lblSub.Text = "Sub:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(6, 146);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(42, 13);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(6, 119);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(42, 13);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1:";
            // 
            // frmCalculadoraNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(366, 270);
            this.Controls.Add(this.grpNotasSemestrais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadoraNota";
            this.Text = "frmCalculadoraNota";
            this.grpNotasSemestrais.ResumeLayout(false);
            this.grpNotasSemestrais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNotasSemestrais;
        private System.Windows.Forms.TextBox txtMediaFinal;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblMediaFinal;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Button btnCalcularMedia;
    }
}

