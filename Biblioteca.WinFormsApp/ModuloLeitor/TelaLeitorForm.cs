using System;
using System.Windows.Forms;

namespace Biblioteca.WinFormsApp.ModuloLeitor
{
    public partial class TelaLeitorForm : Form
    {
        public Leitor Leitor { get; set; }

        public TelaLeitorForm()
        {
            InitializeComponent();
        }

        public TelaLeitorForm(Leitor leitor) : this()
        {
            this.Leitor = leitor;
            txtNome.Text = leitor.Nome;
            dtpDataNascimento.Value = leitor.Nascimento;
            txtCPF.Text = leitor.CPF;
            txtEmail.Text = leitor.Email;
            txtTelefone.Text = leitor.Telefone;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            DateTime dataNascimento = dtpDataNascimento.Value;
            string cpf = txtCPF.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;


            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }


            if (Leitor == null)
            {
                Leitor = new Leitor("Leitor", nome, dataNascimento, cpf, email, telefone);
            }
            else
            {
                Leitor.Nome = nome;
                Leitor.Nascimento = dataNascimento;
                Leitor.CPF = cpf;
                Leitor.Email = email;
                Leitor.Telefone = telefone;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
