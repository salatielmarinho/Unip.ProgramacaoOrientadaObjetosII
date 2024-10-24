﻿using Applications.Configuration;
using Domain.Enums;
using Presentation.ModuloCliente;
using Presentation.ModuloPerfil;
using Presentation.ModuloUsuario;

namespace Presentation.ModuloInicial
{
    public partial class frmMenu : Form
    {
        #region Propriedades
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmMenu(ServiceConfiguration configuration, int fkPerfil)
        {
            InitializeComponent();
            _configuration = configuration;
            VisualizarMenu(fkPerfil);
        }
        #endregion

        #region Eventos
        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarCliente frmGerenciarCliente = new frmGerenciarCliente(_configuration);
                frmGerenciarCliente.MdiParent = this;
                frmGerenciarCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirCliente frmIncluirCliente = new frmIncluirCliente(_configuration);
                frmIncluirCliente.MdiParent = this;
                frmIncluirCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void incluirToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirUsuario frmIncluirUsuario = new frmIncluirUsuario(_configuration);
                frmIncluirUsuario.MdiParent = this;
                frmIncluirUsuario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void incluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirPerfil frmIncluirPerfil = new frmIncluirPerfil(_configuration);
                frmIncluirPerfil.MdiParent = this;
                frmIncluirPerfil.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void gerenciarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarPerfil frmGerenciarPerfil = new frmGerenciarPerfil(_configuration);
                frmGerenciarPerfil.MdiParent = this;
                frmGerenciarPerfil.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        #endregion

        #region Métodos
        private void VisualizarMenu(int fkPerfil)
        {
            try
            {
                switch (fkPerfil)
                {
                    case (int)PerfilTipo.Usuario:
                        usuarioToolStripMenuItem.Visible = false;
                        perfilToolStripMenuItem.Visible = false;
                        break;
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}