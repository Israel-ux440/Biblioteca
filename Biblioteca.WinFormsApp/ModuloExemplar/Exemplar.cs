using Biblioteca.WinFormsApp.Compartilhado;
using System;

public abstract class Exemplar : EntidadeBase
{
    public string Titulo { get; set; }
    public string SubTitulo { get; set; }
    public string Escritor { get; set; }
    public string Editora { get; set; }
    public int AnoPublicacao { get; set; }
    public string Genero { get; set; }
    public ExemplarStatus Status { get; set; }

    protected Exemplar(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, ExemplarStatus status)
    {
        if (string.IsNullOrEmpty(titulo))
            throw new ArgumentException("Título é obrigatório.", nameof(titulo));

        if (string.IsNullOrEmpty(escritor))
            throw new ArgumentException("Escritor é obrigatório.", nameof(escritor));

        if (anoPublicacao < 0 || anoPublicacao > DateTime.Now.Year)
            throw new ArgumentOutOfRangeException(nameof(anoPublicacao), "Ano de publicação inválido.");

        Titulo = titulo;
        SubTitulo = subTitulo;
        Escritor = escritor;
        Editora = editora;
        AnoPublicacao = anoPublicacao;
        Genero = genero;
        Status = status;
    }

    public abstract override void AtualizarRegistro(EntidadeBase novoRegistro);
}

public enum ExemplarStatus
{
    Disponivel,
    Emprestado,
    Reservado,
    Indisponivel
}
