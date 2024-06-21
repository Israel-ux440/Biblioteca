using Biblioteca.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;

public class Revista : Exemplar
{
    public int Paginas { get; set; }
    public int Edicao { get; set; }

    public Revista(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, ExemplarStatus status, int paginas, int edicao)
        : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)
    {
        if (paginas <= 0)
            throw new ArgumentException("O número de páginas é obrigatório e deve ser maior que zero.", nameof(paginas));

        if (edicao <= 0)
            throw new ArgumentException("A edição é obrigatória e deve ser maior que zero.", nameof(edicao));

        Paginas = paginas;
        Edicao = edicao;
    }

    public override List<string> Validar()
    {
        var erros = new List<string>();

        if (string.IsNullOrWhiteSpace(Titulo))
            erros.Add("O título é obrigatório.");

        if (string.IsNullOrWhiteSpace(Escritor))
            erros.Add("O escritor é obrigatório.");

        if (string.IsNullOrWhiteSpace(Editora))
            erros.Add("A editora é obrigatória.");

        if (AnoPublicacao <= 0)
            erros.Add("O ano de publicação é obrigatório.");

        if (string.IsNullOrWhiteSpace(Genero))
            erros.Add("O gênero é obrigatório.");

        if (Paginas <= 0)
            erros.Add("O número de páginas é obrigatório e deve ser maior que zero.");

        if (Edicao <= 0)
            erros.Add("A edição é obrigatória e deve ser maior que zero.");

        return erros;
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var novaRevista = (Revista)novoRegistro;
        Titulo = novaRevista.Titulo;
        SubTitulo = novaRevista.SubTitulo;
        Escritor = novaRevista.Escritor;
        Editora = novaRevista.Editora;
        AnoPublicacao = novaRevista.AnoPublicacao;
        Genero = novaRevista.Genero;
        Status = novaRevista.Status;
        Paginas = novaRevista.Paginas;
        Edicao = novaRevista.Edicao;
    }
}
