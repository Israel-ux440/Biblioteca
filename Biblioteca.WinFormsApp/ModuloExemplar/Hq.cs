using Biblioteca.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;

public class Hq : Exemplar
{
    public string Ilustrador { get; set; }

    public Hq(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, ExemplarStatus status, string ilustrador)
        : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)
    {
        if (string.IsNullOrWhiteSpace(ilustrador))
            throw new ArgumentException("O ilustrador é obrigatório.", nameof(ilustrador));

        Ilustrador = ilustrador;
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

        if (string.IsNullOrWhiteSpace(Ilustrador))
            erros.Add("O ilustrador é obrigatório.");

        return erros;
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var novaHq = (Hq)novoRegistro;
        Titulo = novaHq.Titulo;
        SubTitulo = novaHq.SubTitulo;
        Escritor = novaHq.Escritor;
        Editora = novaHq.Editora;
        AnoPublicacao = novaHq.AnoPublicacao;
        Genero = novaHq.Genero;
        Status = novaHq.Status;
        Ilustrador = novaHq.Ilustrador;
    }
}
