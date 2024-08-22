using System;
using System.Windows.Forms;

namespace CalculadoraNotas
{
    public partial class frmCalculadoraNota : Form
    {
        public frmCalculadoraNota()
        {
            InitializeComponent();
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtSub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
