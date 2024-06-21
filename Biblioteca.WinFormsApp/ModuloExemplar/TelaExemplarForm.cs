using Biblioteca.WinFormsApp.Compartilhado;
using System;
using System.Windows.Forms;

namespace Biblioteca.WinFormsApp.ModuloExemplar
{
    public partial class TelaExemplarForm : Form
    {
        public Exemplar Exemplar { get; set; }

        public TelaExemplarForm()
        {
            InitializeComponent();
        }

        public TelaExemplarForm(Exemplar exemplar) : this()
        {
            this.Exemplar = exemplar;
            txtTitulo.Text = exemplar.Titulo;
            txtSubTitulo.Text = exemplar.SubTitulo;
            txtEscritor.Text = exemplar.Escritor;
            txtEditora.Text = exemplar.Editora;
            nudAnoPublicacao.Value = exemplar.AnoPublicacao;
            txtGenero.Text = exemplar.Genero;
            cbStatus.SelectedItem = (EnumExemplarStatus)exemplar.Status;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string subTitulo = txtSubTitulo.Text;
            string escritor = txtEscritor.Text;
            string editora = txtEditora.Text;
            int anoPublicacao = (int)nudAnoPublicacao.Value;
            string genero = txtGenero.Text;
            int status = (int)Enum.Parse(typeof(EnumExemplarStatus), cbStatus.SelectedItem.ToString());

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(escritor) ||
                string.IsNullOrWhiteSpace(editora) || string.IsNullOrWhiteSpace(genero))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            if (Exemplar == null)
            {
                Exemplar = new Ebook(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status, 0, "", "");
            }
            else
            {
                Exemplar.Titulo = titulo;
                Exemplar.SubTitulo = subTitulo;
                Exemplar.Escritor = escritor;
                Exemplar.Editora = editora;
                Exemplar.AnoPublicacao = anoPublicacao;
                Exemplar.Genero = genero;
                Exemplar.Status = status;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
