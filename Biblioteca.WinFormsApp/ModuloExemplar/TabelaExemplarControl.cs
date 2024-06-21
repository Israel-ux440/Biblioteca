using Biblioteca.WinFormsApp.Compartilhado;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca.WinFormsApp.ModuloExemplar
{
    public partial class TabelaExemplarControl : UserControl
    {
        public TabelaExemplarControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            gridExemplar.ConfigurarGridZebrado();
            gridExemplar.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Exemplar> exemplares)
        {
            gridExemplar.DataSource = null;
            gridExemplar.DataSource = exemplares;
        }

        public int SelecionarId()
        {
            if (gridExemplar.SelectedRows.Count == 0)
                return -1;

            return (int)gridExemplar.SelectedRows[0].Cells[0].Value;
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { Name = "titulo", HeaderText = "Título" },
                new DataGridViewTextBoxColumn { Name = "subTitulo", HeaderText = "Subtítulo" },
                new DataGridViewTextBoxColumn { Name = "escritor", HeaderText = "Escritor" },
                new DataGridViewTextBoxColumn { Name = "editora", HeaderText = "Editora" },
                new DataGridViewTextBoxColumn { Name = "anoPublicacao", HeaderText = "Ano de Publicação" },
                new DataGridViewTextBoxColumn { Name = "genero", HeaderText = "Gênero" },
                new DataGridViewTextBoxColumn { Name = "status", HeaderText = "Status" }
            };

            gridExemplar.Columns.AddRange(colunas);
        }
    }
}
