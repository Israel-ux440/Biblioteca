using Biblioteca.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca.WinFormsApp.ModuloLeitor
{
    public class ControladorLeitor : ControladorBase
    {
        private IRepositorioLeitor repositorioLeitor;
        private TabelaLeitorControl tabelaLeitor;

        public ControladorLeitor(IRepositorioLeitor repositorio)
        {
            this.repositorioLeitor = repositorio;
            this.tabelaLeitor = new TabelaLeitorControl();
        }

        public override string TipoCadastro => "Leitores";
        public override string ToolTipAdicionar => "Adicionar novo leitor";
        public override string ToolTipEditar => "Editar leitor existente";
        public override string ToolTipExcluir => "Excluir leitor existente";

        public override void Adicionar()
        {
            TelaLeitorForm tela = new TelaLeitorForm();
            if (tela.ShowDialog() == DialogResult.OK)
            {
                Leitor novoLeitor = tela.Leitor;
                repositorioLeitor.Cadastrar(novoLeitor);
                AtualizarTabela(); // Atualizar a tabela após adicionar
            }
        }

        public override void Editar()
        {
            int idSelecionado = tabelaLeitor.ObterIdSelecionado();
            if (idSelecionado == -1)
            {
                MessageBox.Show("Selecione um leitor para editar.", "Edição de Leitores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Leitor leitorSelecionado = repositorioLeitor.SelecionarPorId(idSelecionado);

            TelaLeitorForm tela = new TelaLeitorForm(leitorSelecionado);
            if (tela.ShowDialog() == DialogResult.OK)
            {
                Leitor leitorEditado = tela.Leitor;
                repositorioLeitor.Editar(leitorEditado.Id, leitorEditado);
                AtualizarTabela(); // Atualizar a tabela após editar
            }
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaLeitor.ObterIdSelecionado();
            if (idSelecionado == -1)
            {
                MessageBox.Show("Selecione um leitor para excluir.", "Exclusão de Leitores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            repositorioLeitor.Excluir(idSelecionado);
            AtualizarTabela(); // Atualizar a tabela após excluir
        }

        public override UserControl ObterListagem()
        {
            tabelaLeitor.AtualizarRegistros(repositorioLeitor.SelecionarTodos());
            return tabelaLeitor;
        }

        private void AtualizarTabela()
        {
            tabelaLeitor.AtualizarRegistros(repositorioLeitor.SelecionarTodos());
        }
    }
}
