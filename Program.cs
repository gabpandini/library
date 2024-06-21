using System;
using Biblioteca.Entidades;

namespace Biblioteca
{
  public class Program
  {
    public static void Main()
    {

      Administrador administrador = new Administrador("Gabriela", 3, 102, 201);

      administrador.GerenciarBiblioteca();


      Funcionario funcionario = Funcionario.RegistrarNovoFuncionario("Maria", 2, 101);

      Livro livro = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", "1234567890");

      funcionario.AdicionarLivro(livro);


      MembroDaBiblioteca membro = new MembroDaBiblioteca("Ana", 1);

      membro.PegarLivroEmprestado(livro);
    }
  }
}
