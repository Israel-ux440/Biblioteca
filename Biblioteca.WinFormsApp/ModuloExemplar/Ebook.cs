using Biblioteca.WinFormsApp.Compartilhado;

public class Ebook : Exemplar
{
    public decimal Tamanho { get; set; }
    public string Formato { get; set; }
    public string Url { get; set; }

    public Ebook(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, int status, decimal tamanho, string formato, string url)
        : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)
    {
        Tamanho = tamanho;
        Formato = formato;
        Url = url;
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

        if (Tamanho <= 0)
            erros.Add("O tamanho do arquivo é obrigatório.");

        if (string.IsNullOrWhiteSpace(Formato))
            erros.Add("O formato do arquivo é obrigatório.");

        return erros;
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var novoEbook = (Ebook)novoRegistro;
        Titulo = novoEbook.Titulo;
        SubTitulo = novoEbook.SubTitulo;
        Escritor = novoEbook.Escritor;
        Editora = novoEbook.Editora;
        AnoPublicacao = novoEbook.AnoPublicacao;
        Genero = novoEbook.Genero;
        Status = novoEbook.Status;
        Tamanho = novoEbook.Tamanho;
        Formato = novoEbook.Formato;
        Url = novoEbook.Url;
    }
}
