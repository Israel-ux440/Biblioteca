using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.WinFormsApp.Compartilhado
{
    public abstract class RepositorioBase<T> : IRepositorio<T> where T : EntidadeBase
    {
        protected List<T> registros = new List<T>();
        protected int contadorId = 1;

        public void Cadastrar(T entidade)
        {
            entidade.Id = contadorId++;
            registros.Add(entidade);
        }

        public bool Editar(int id, T entidade)
        {
            T registro = SelecionarPorId(id);
            if (registro != null)
            {
                registro.AtualizarRegistro(entidade);
                return true;
            }
            return false;
        }

        public bool Excluir(int id)
        {
            T registro = SelecionarPorId(id);
            if (registro != null)
            {
                registros.Remove(registro);
                return true;
            }
            return false;
        }

        public T SelecionarPorId(int id)
        {
            return registros.FirstOrDefault(r => r.Id == id);
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }
    }
}
