using System;
using System.Windows.Forms;
using Biblioteca.WinFormsApp.ModuloLeitor;
using Biblioteca.WinFormsApp.ModuloExemplar;
using Biblioteca.WinFormsApp.Compartilhado;

namespace Biblioteca.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private static TelaPrincipalForm instance;

        public static TelaPrincipalForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new TelaPrincipalForm();
                return instance;
            }
        }

        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void leitoresMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorLeitor(new RepositorioLeitor());
            ConfigurarTelaPrincipal();
        }

        private void exemplaresMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorExemplar(new RepositorioExemplar());
            ConfigurarTelaPrincipal();
        }

        private void ConfigurarTelaPrincipal()
        {
            lblTipoCadastro.Text = controlador.TipoCadastro;
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            AtualizarRodape("");

            AtualizarListagem();
        }

        private void AtualizarListagem()
        {
            UserControl listagem = controlador.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();

            pnlRegistros.Controls.Add(listagem);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
            AtualizarListagem();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
            AtualizarListagem();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
            AtualizarListagem();
        }

        private void AtualizarRodape(string mensagem)
        {
            statusLabelPrincipal.Text = mensagem;
        }
    }
}
