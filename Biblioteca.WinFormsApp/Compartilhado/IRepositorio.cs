using System.Collections.Generic;

namespace Biblioteca.WinFormsApp.Compartilhado
{
    public interface IRepositorio<T>
    {
        void Cadastrar(T entidade);
        bool Editar(int id, T entidade);
        bool Excluir(int id);
        T SelecionarPorId(int id);
        List<T> SelecionarTodos();
    }
}
