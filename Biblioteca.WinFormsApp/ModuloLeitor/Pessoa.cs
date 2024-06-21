using Biblioteca.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WinFormsApp.ModuloLeitor
{
    public abstract class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        protected Pessoa(string nome, DateTime nascimento, string cpf, string email, string telefone)
        {
            Nome = nome;
            Nascimento = nascimento;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Pessoa novaPessoa = (Pessoa)novoRegistro;
            Nome = novaPessoa.Nome;
            Nascimento = novaPessoa.Nascimento;
            CPF = novaPessoa.CPF;
            Email = novaPessoa.Email;
            Telefone = novaPessoa.Telefone;
        }

        public override List<string> Validar()
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O nome é obrigatório.");

            if (string.IsNullOrEmpty(CPF))
                erros.Add("O CPF é obrigatório.");

            if (string.IsNullOrEmpty(Email))
                erros.Add("O email é obrigatório.");

            return erros;
        }
    }
}
