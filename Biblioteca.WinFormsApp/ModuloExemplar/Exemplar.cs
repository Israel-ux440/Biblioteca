using Biblioteca.WinFormsApp.Compartilhado;

public abstract class Exemplar : EntidadeBase
{
    public string Titulo { get; set; }
    public string SubTitulo { get; set; }
    public string Escritor { get; set; }
    public string Editora { get; set; }
    public int AnoPublicacao { get; set; }
    public string Genero { get; set; }
    public int Status { get; set; }

    protected Exemplar(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, int status)
    {
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
