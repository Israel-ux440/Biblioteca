using Biblioteca.WinFormsApp.Compartilhado;

public class Revista : Exemplar
{
    public int Paginas { get; set; }
    public int Edicao { get; set; }

    public Revista(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int paginas, int edicao)
        : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)
    {
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
            erros.Add("O número de páginas é obrigatório.");

        if (Edicao <= 0)
            erros.Add("A edição é obrigatória.");

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
