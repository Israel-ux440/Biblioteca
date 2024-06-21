using Biblioteca.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca.WinFormsApp.ModuloLeitor
{
    public partial class TabelaLeitorControl : UserControl
    {
        public TabelaLeitorControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            gridLeitores.ConfigurarGridZebrado();
            gridLeitores.ConfigurarGridSomenteLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { Name = "nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { Name = "nascimento", HeaderText = "Nascimento" },
                new DataGridViewTextBoxColumn { Name = "cpf", HeaderText = "CPF" },
                new DataGridViewTextBoxColumn { Name = "email", HeaderText = "Email" },
                new DataGridViewTextBoxColumn { Name = "telefone", HeaderText = "Telefone" }
            };

            gridLeitores.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Leitor> leitores)
        {
            gridLeitores.Rows.Clear();

            foreach (var leitor in leitores)
            {
                gridLeitores.Rows.Add(leitor.Id, leitor.Nome, leitor.Nascimento.ToShortDateString(), leitor.CPF, leitor.Email, leitor.Telefone);
            }
        }

        public int ObterIdSelecionado()
        {
            if (gridLeitores.SelectedRows.Count > 0)
                return Convert.ToInt32(gridLeitores.SelectedRows[0].Cells["id"].Value);

            return -1;
        }
    }
}
