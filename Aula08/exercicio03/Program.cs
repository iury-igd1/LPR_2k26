/* 
Exercício 03:
    Defina uma struct chamada Livro com os seguintes campos: 
        Titulo, Autor, AnoPublicacao, NumeroPaginas e Preco.

    Crie um programa que permita ao usuário inserir dados de 3 livros e, em seguida, calcule e exiba o 
    preço total dos livros cadastrados e a média de páginas dos livros.
*/

using System;

class Program
{
    struct Livro
    {
    public string Titulo;
    public string Autor;
    public int AnoPublicacao;
    public int NumeroPaginas;
    public double Preco;
    }

    static void Main()
    {
        Livro[] listaLivros = new Livro[3];
        double somaPaginas = 0;
        double somaPrecos = 0;

        Console.WriteLine("========================");
        Console.WriteLine("   CADASTRO DE LIVROS   ");
        Console.WriteLine("========================\n");

        for (int i = 0; i < 3; i++) { // Lê os dados de cada um dos 3 livros, somando páginas e preços ao longo da leitura
            Console.Write($"> Informe o título do Livro {i + 1}: ");
            listaLivros[i].Titulo = Console.ReadLine() ?? "";

            Console.Write($"> Informe o nome do autor do Livro {i + 1}: ");
            listaLivros[i].Autor = Console.ReadLine() ?? "";

            Console.Write($"> Informe o ano de publicação do Livro {i + 1}: ");
            listaLivros[i].AnoPublicacao = int.Parse(Console.ReadLine() ?? "0");

            Console.Write($"> Informe o número de páginas do Livro {i + 1}: ");
            listaLivros[i].NumeroPaginas = int.Parse(Console.ReadLine() ?? "0");
            somaPaginas += listaLivros[i].NumeroPaginas;

            Console.Write($"> Informe o preço do Livro {i + 1}: ");
            listaLivros[i].Preco = double.Parse(Console.ReadLine() ?? "0");
            somaPrecos += listaLivros[i].Preco;

            Console.WriteLine();
        }

        Console.WriteLine("Livros cadastrados:");
        Console.WriteLine("[1] " + listaLivros[0].Titulo);
        Console.WriteLine("[2] " + listaLivros[1].Titulo);
        Console.WriteLine("[3] " + listaLivros[2].Titulo);
        Console.WriteLine();

        Console.WriteLine("Preço total dos livros cadastrados = R$ " + somaPrecos.ToString("F2"));
        Console.WriteLine("Média de páginas dos livros = " + (somaPaginas / 3).ToString("F2"));
    }
}