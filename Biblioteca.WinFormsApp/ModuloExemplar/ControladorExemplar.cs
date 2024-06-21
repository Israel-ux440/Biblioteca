using Biblioteca.WinFormsApp.Compartilhado;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca.WinFormsApp.ModuloExemplar
{
    public class ControladorExemplar : ControladorBase
    {
        private IRepositorioExemplar repositorioExemplar;
        private TabelaExemplarControl tabelaExemplar;

        public ControladorExemplar(IRepositorioExemplar repositorio)
        {
            this.repositorioExemplar = repositorio;
            this.tabelaExemplar = new TabelaExemplarControl();
            InicializarExemplares();
        }

        private void InicializarExemplares()
        {
            if (repositorioExemplar.SelecionarTodos().Count == 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    var ebook = new Ebook($"Ebook {i}", $"Subtitulo {i}", $"Escritor {i}", $"Editora {i}", 2021, $"Genero {i}", ExemplarStatus.Disponivel, 1.2m, "PDF", $"url{i}.com");
                    var hq = new Hq($"HQ {i}", $"Subtitulo {i}", $"Escritor {i}", $"Editora {i}", 2021, $"Genero {i}", ExemplarStatus.Disponivel, $"Ilustrador {i}");
                    var revista = new Revista($"Revista {i}", $"Subtitulo {i}", $"Escritor {i}", $"Editora {i}", 2021, $"Genero {i}", ExemplarStatus.Disponivel, 100, i);

                    repositorioExemplar.Cadastrar(ebook);
                    repositorioExemplar.Cadastrar(hq);
                    repositorioExemplar.Cadastrar(revista);
                }
            }
        }

        public override string TipoCadastro => "Exemplares";
        public override string ToolTipAdicionar => "Adicionar novo exemplar";
        public override string ToolTipEditar => "Editar exemplar existente";
        public override string ToolTipExcluir => "Excluir exemplar existente";

        public override void Adicionar()
        {
            TelaExemplarForm tela = new TelaExemplarForm();
            if (tela.ShowDialog() == DialogResult.OK)
            {
                Exemplar novoExemplar = tela.Exemplar;
                repositorioExemplar.Cadastrar(novoExemplar);
                AtualizarTabela();
            }
        }

        public override void Editar()
        {
            int idSelecionado = tabelaExemplar.SelecionarId();
            if (idSelecionado == -1)
            {
                MessageBox.Show("Selecione um exemplar para editar.", "Edição de Exemplares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Exemplar exemplarSelecionado = repositorioExemplar.SelecionarPorId(idSelecionado);

            TelaExemplarForm tela = new TelaExemplarForm(exemplarSelecionado);
            if (tela.ShowDialog() == DialogResult.OK)
            {
                Exemplar exemplarEditado = tela.Exemplar;
                repositorioExemplar.Editar(exemplarEditado.Id, exemplarEditado);
                AtualizarTabela();
            }
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaExemplar.SelecionarId();
            if (idSelecionado == -1)
            {
                MessageBox.Show("Selecione um exemplar para excluir.", "Exclusão de Exemplares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            repositorioExemplar.Excluir(idSelecionado);
            AtualizarTabela();
        }

        public override UserControl ObterListagem()
        {
            tabelaExemplar.AtualizarRegistros(repositorioExemplar.SelecionarTodos());
            return tabelaExemplar;
        }

        private void AtualizarTabela()
        {
            tabelaExemplar.AtualizarRegistros(repositorioExemplar.SelecionarTodos());
        }
    }
}
