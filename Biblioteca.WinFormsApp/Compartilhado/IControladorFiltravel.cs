using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WinFormsApp.Compartilhado
{
    public interface IControladorFiltravel
    {
        string ToolTipFiltrar { get; }
        void Filtrar();
    }
}
