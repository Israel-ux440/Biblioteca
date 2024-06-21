using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WinFormsApp.Compartilhado
{
    using System.ComponentModel;

    public enum EnumExemplarStatus
    {
        [Description("Pendente")]
        Pendente = 1,
        [Description("Lido")]
        Lido = 2,
        [Description("Emprestado")]
        Emprestado = 3,
        [Description("Devolvido")]
        Devolvido = 4,
        [Description("Perdido")]
        Perdido = 5,
    }

    public enum EnumEbookFormato
    {
        [Description("PDF")]
        PDF = 1,
        [Description("EPUB")]
        EPUB = 2,
        [Description("MOBI")]
        MOBI = 3,
        [Description("AZW")]
        AZW = 4,
        [Description("Outro")]
        Outro = 5,
    }

    public enum EnumFuncionarioCargo
    {
        [Description("Gerente")]
        Gerente = 1,
        [Description("Atendente")]
        Atendente = 2,
        [Description("Caixa")]
        Caixa = 3,
        [Description("Estagiário")]
        Estagiário = 4,
    }

    public enum EnumTipoLeitor
    {
        [Description("Leitor Casual")]
        LeitorCasual = 1,
        [Description("Leitor Ávido")]
        LeitorAvido = 2,
        [Description("Leitor de Ficção")]
        LeitorFiccao = 3,
        [Description("Leitor Crítico")]
        LeitorCritico = 4,
        [Description("Leitor de Clássicos")]
        LeitorClassicos = 5,
        [Description("Leitor Acadêmico")]
        LeitorAcademico = 6,
    }


}
