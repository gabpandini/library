namespace Biblioteca.Entidades
{
  public class MembroDaBiblioteca
  {
    public string Nome { get; set; }
    private int MembroId { get; set; }

    public MembroDaBiblioteca(string nome, int membroId)
    {
      Nome = nome;
      MembroId = membroId;
    }

    internal void PegarLivroEmprestado(Livro livro)
    {
      Console.WriteLine($"{Nome} pegou emprestado o livro {livro.Titulo}");
    }

    protected string ObterInformacoesDetalhadas()
    {
      return $"Nome: {Nome}, ID: {MembroId}";
    }
  }
}
