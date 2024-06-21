namespace Biblioteca.Entidades
{
  public class Livro
  {
    public string Titulo { get; set; }
    protected string Autor { get; set; }
    internal string ISBN { get; set; }

    public Livro(string titulo, string autor, string isbn)
    {
      Titulo = titulo;
      Autor = autor;
      ISBN = isbn;
    }

    public string ObterResumo()
    {
      return $"Livro: {Titulo}, Autor: {Autor}, ISBN: {ISBN}";
    }
  }
}
