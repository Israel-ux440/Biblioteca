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
            cbTipoExemplar.SelectedIndex = 0; // Define um valor padrão para o ComboBox
            cbStatus.SelectedIndex = 0; // Define um valor padrão para o ComboBox
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
            cbStatus.SelectedItem = exemplar.Status;

            // Mostrar campos específicos conforme o tipo de Exemplar
            if (exemplar is Ebook ebook)
            {
                cbTipoExemplar.SelectedItem = "Ebook";
                txtUrl.Text = ebook.Url;
                nudTamanho.Value = ebook.Tamanho;
                txtUrl.Visible = true;
                nudTamanho.Visible = true;
            }
            else if (exemplar is Hq hq)
            {
                cbTipoExemplar.SelectedItem = "Hq";
                txtIlustrador.Text = hq.Ilustrador;
                txtIlustrador.Visible = true;
            }
            else if (exemplar is Revista revista)
            {
                cbTipoExemplar.SelectedItem = "Revista";
                nudPaginas.Value = revista.Paginas;
                nudEdicao.Value = revista.Edicao;
                nudPaginas.Visible = true;
                nudEdicao.Visible = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string subTitulo = txtSubTitulo.Text;
            string escritor = txtEscritor.Text;
            string editora = txtEditora.Text;
            int anoPublicacao = (int)nudAnoPublicacao.Value;
            string genero = txtGenero.Text;

            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione um status.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            ExemplarStatus status = (ExemplarStatus)cbStatus.SelectedItem;

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(escritor) ||
                string.IsNullOrWhiteSpace(editora) || string.IsNullOrWhiteSpace(genero))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            if (Exemplar == null)
            {
                string tipoExemplar = cbTipoExemplar.SelectedItem?.ToString();
                if (tipoExemplar == null)
                {
                    MessageBox.Show("Selecione um tipo de exemplar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    return;
                }

                switch (tipoExemplar)
                {
                    case "Ebook":
                        decimal tamanho = nudTamanho.Value;
                        string url = txtUrl.Text;
                        if (string.IsNullOrWhiteSpace(url))
                        {
                            MessageBox.Show("URL é obrigatória para Ebook.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DialogResult = DialogResult.None;
                            return;
                        }
                        Exemplar = new Ebook(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status, tamanho, "PDF", url);
                        break;
                    case "Hq":
                        string ilustrador = txtIlustrador.Text;
                        if (string.IsNullOrWhiteSpace(ilustrador))
                        {
                            MessageBox.Show("Ilustrador é obrigatório para HQ.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DialogResult = DialogResult.None;
                            return;
                        }
                        Exemplar = new Hq(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status, ilustrador);
                        break;
                    case "Revista":
                        int paginas = (int)nudPaginas.Value;
                        int edicao = (int)nudEdicao.Value;
                        Exemplar = new Revista(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status, paginas, edicao);
                        break;
                    default:
                        MessageBox.Show("Tipo de exemplar inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.None;
                        return;
                }
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

        private void cbTipoExemplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Esconder todos os campos específicos inicialmente
            txtUrl.Visible = false;
            nudTamanho.Visible = false;
            txtIlustrador.Visible = false;
            nudPaginas.Visible = false;
            nudEdicao.Visible = false;

            // Mostrar campos específicos conforme o tipo de Exemplar selecionado
            string tipoExemplar = cbTipoExemplar.SelectedItem?.ToString();
            if (tipoExemplar == null) return;

            switch (tipoExemplar)
            {
                case "Ebook":
                    txtUrl.Visible = true;
                    nudTamanho.Visible = true;
                    break;
                case "Hq":
                    txtIlustrador.Visible = true;
                    break;
                case "Revista":
                    nudPaginas.Visible = true;
                    nudEdicao.Visible = true;
                    break;
            }
        }
    }
}
