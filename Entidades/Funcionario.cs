namespace Biblioteca.Entidades
{
  public class Funcionario : MembroDaBiblioteca
  {
    protected internal int FuncionarioId { get; set; }

    public Funcionario(string nome, int membroId, int funcionarioId) : base(nome, membroId)
    {
      FuncionarioId = funcionarioId;
    }

    protected void AdicionarLivro(Livro livro)
    {
      Console.WriteLine($"Livro {livro.Titulo} adicionado à biblioteca por {Nome}");
    }

    private protected void RemoverLivro(Livro livro)
    {
      Console.WriteLine($"Livro {livro.Titulo} removido da biblioteca por {Nome}");
    }

    public static Funcionario RegistrarNovoFuncionario(string nome, int membroID, int funcionarioID)
    {
      return new Funcionario(nome, membroId, funcionarioId);
    }
  }
}
