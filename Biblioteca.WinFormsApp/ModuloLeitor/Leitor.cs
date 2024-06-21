using Biblioteca.WinFormsApp.ModuloExemplar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WinFormsApp.ModuloLeitor
{
    public class Leitor : Pessoa
    {
        public List<Exemplar> ExemplaresLeitor { get; set; }
       // public List<Emprestimo> EmprestimosLeitor { get; set; }
        public string Tipo { get; set; }

        public Leitor(string tipo, string nome, DateTime nascimento, string cpf, string email, string telefone)
            : base(nome, nascimento, cpf, email, telefone)
        {
            Tipo = tipo;
            ExemplaresLeitor = new List<Exemplar>();
           // EmprestimosLeitor = new List<Emprestimo>();
        }

        public bool EmprestaItem(Exemplar exemplar, Leitor leitorDestino) { return true; }
        public bool DevolveItem(Exemplar exemplar, Leitor leitorDestino) { return true; }
        public bool DoaExemplar(Exemplar exemplar, Leitor leitorDestino) { return true; }
        public bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem) { return true; }

        public void ListaLeitor() { }
        public void EditaLeitor(Leitor leitor) { }
        public void AdicionaExemplarLeitor(Exemplar exemplar) { }
        public void RemoveExemplarLeitor(Exemplar exemplar) { }
        public void EditaExemplarLeitor(Exemplar exemplar) { }
        public void ListaExemplarLeitor(Exemplar exemplar) { }
    }
}
