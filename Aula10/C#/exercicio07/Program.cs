/* 
Exercício 07:
    Crie as classes Livro, com os atributos Titulo, Autor e AnoPublicacao, e Biblioteca, com uma lista de 
    objetos da classe Livro. Use métodos construtores, getters e setters quando necessário.
    Na classe Biblioteca, crie os métodos AdicionarLivro e ListarLivros.
*/

using System;
using System.Collections.Generic;

class Livro {
    // As propriedades permitem consultar e alterar os dados do livro por meio de get e set
    public string titulo { get; set; }
    public string autor { get; set; }
    public int anoPublicacao { get; set; }

	// Inicializa o livro com título, autor e ano de publicação
    public Livro(string titulo, string autor, int anoPublicacao) {
        this.titulo = titulo;
        this.autor = autor;
        this.anoPublicacao = anoPublicacao;
    }
}

class Biblioteca {
    public List<Livro> livros = new List<Livro>();

    // Adiciona o livro à coleção da biblioteca
    public void adicionarLivro(Livro livro) {
        livros.Add(livro);
    }

    // Percorre a coleção e exibe os dados de cada livro cadastrado
    public void listarLivros() {
        foreach (Livro livro in livros) {
            Console.WriteLine($"{livro.titulo} | {livro.autor} | {livro.anoPublicacao}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("===========================");
        Console.WriteLine("   SISTEMA DE BIBLIOTECA   ");
        Console.WriteLine("===========================\n");

        Biblioteca biblioteca = new Biblioteca();

        Livro primeiro = new Livro("Diário de um Banana", "Jeff Kinney", 2007);
        Livro segundo = new Livro("Turma da Mônica - Nº 1", "Maurício de Sousa", 1959);

        biblioteca.adicionarLivro(primeiro);
        biblioteca.adicionarLivro(segundo);
        biblioteca.listarLivros();
    } 
}
