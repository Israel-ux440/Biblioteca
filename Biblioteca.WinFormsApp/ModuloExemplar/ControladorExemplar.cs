using Biblioteca.WinFormsApp.Compartilhado;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.WinFormsApp.ModuloExemplar
{
    public class ControladorExemplar : ControladorBase
    {
        private IRepositorioExemplar repositorioExemplar;

        public ControladorExemplar(IRepositorioExemplar repositorio)
        {
            this.repositorioExemplar = repositorio;
            InicializarExemplares();
        }

        private void InicializarExemplares()
        {
            if (repositorioExemplar.SelecionarTodos().Count == 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    var ebook = new Ebook($"Ebook {i}", $"Subtitulo {i}", $"Escritor {i}", $"Editora {i}", 2021, $"Genero {i}", (int)EnumExemplarStatus.Pendente, 1.2m, "PDF", $"url{i}.com");
                    var hq = new Hq($"HQ {i}", $"Subtitulo {i}", $"Escritor {i}", $"Editora {i}", 2021, $"Genero {i}", (int)EnumExemplarStatus.Pendente, $"Ilustrador {i}");
                    var revista = new Revista($"Revista {i}", $"Subtitulo {i}", $"Escritor {i}", $"Editora {i}", 2021, $"Genero {i}", (int)EnumExemplarStatus.Pendente, 100, i);

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
            }
        }

        public override void Editar()
        {
            TabelaExemplarControl tabelaExemplar = new TabelaExemplarControl();
            int idSelecionado = tabelaExemplar.SelecionarId();
            if (idSelecionado == -1)
            {
                MessageBox.Show("Selecione um exemplar para editar.", "Edição de Exemplares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Exemplar exemplarSelecionado = repositorioExemplar.SelecionarPorId(idSelecionado);

            TelaExemplarForm tela = new TelaExemplarForm();
            tela.Exemplar = exemplarSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                Exemplar exemplarEditado = tela.Exemplar;
                repositorioExemplar.Editar(exemplarEditado.Id, exemplarEditado);
            }
        }

        public override void Excluir()
        {
            TabelaExemplarControl tabelaExemplar = new TabelaExemplarControl();
            int idSelecionado = tabelaExemplar.SelecionarId();
            if (idSelecionado == -1)
            {
                MessageBox.Show("Selecione um exemplar para excluir.", "Exclusão de Exemplares", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            repositorioExemplar.Excluir(idSelecionado);
        }

        public override UserControl ObterListagem()
        {
            return new TabelaExemplarControl();
        }
    }
}
