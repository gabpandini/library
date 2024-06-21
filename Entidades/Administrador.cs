namespace Biblioteca.Entidades
{
  public class Administrador : Funcionario
  {
    private int AdministradorId { get; set; }

    public Administrador(string nome, int membroID, int funcionarioID, int administradorID) : base(nome, membroId, funcionarioId)
    {
      AdministradorId = administradorId;
    }

    internal void GerenciarBiblioteca()
    {
      Console.WriteLine($"Biblioteca gerenciada pelo administrador {Nome}");
    }

    protected string ObterInformacoesDetalhadasAdministrador()
    {
      return $"Nome: {Nome}, ID do Administrador: {AdministradorId}";
    }
  }
}