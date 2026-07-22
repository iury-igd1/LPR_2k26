/* 
Exercício 08:
    Crie uma struct chamada Livro contendo:
        Título, Autor, Ano de publicação, Quantidade disponível

    Utilize um dicionário em que: Chave = Código do livro / Valor = Struct Livro
    Implemente as funções:
      - CadastrarLivro()
      - BuscarLivro()
      - EmprestarLivro()
      - ExibirRelatorio()

    O programa deverá:
      - Cadastrar 10 livros;
      - Permitir buscar um livro pelo código;
      - Realizar empréstimos, reduzindo a quantidade disponível;
      - Impedir empréstimos quando não houver exemplares.
      - Exibir um relatório contendo:
          > Total de livros cadastrados;
          > Livro mais antigo;
          > Livro com maior quantidade disponível.
          > Quantos livros existem por autor.
*/

using System;
using System.Collections.Generic;

class Program
{
    static int totalCadastrados = 0;
    static Dictionary<string, Livro> biblioteca = new Dictionary<string, Livro>();
    struct Livro
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
        public int Quantidade;
    }

    static void Pausar()
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }

    static void CadastrarLivro()
    {
        if (totalCadastrados >= 10) {
            Console.WriteLine("\nLimite máximo de 10 livros cadastrados atingido.");
            Pausar();
            return;
        }

        Console.Clear();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("             CADASTRO DE LIVRO             ");
        Console.WriteLine("-------------------------------------------\n");

        Console.Write("> Digite o código identificador do livro (Ex: 1A01): ");
        string codigo = Console.ReadLine() ?? "";

        if (biblioteca.ContainsKey(codigo)) {
            Console.WriteLine("\nErro: Já existe um livro cadastrado com este código.");
            Pausar();
            return;
        }

        Livro novoLivro = new Livro();
        totalCadastrados++;

        Console.Write($"> Informe o título do Livro {totalCadastrados}: ");
        novoLivro.Titulo = Console.ReadLine() ?? "";

        Console.Write($"> Informe o autor do Livro {totalCadastrados}: ");
        novoLivro.Autor = Console.ReadLine() ?? "";

        Console.Write($"> Informe o ano de publicação do Livro {totalCadastrados}: ");
        int.TryParse(Console.ReadLine(), out novoLivro.AnoPublicacao);

        Console.Write($"> Informe a quantidade disponível do Livro {totalCadastrados}: ");
        int.TryParse(Console.ReadLine(), out novoLivro.Quantidade);

        biblioteca[codigo] = novoLivro;

        Console.WriteLine($"\nLivro cadastrado com sucesso! ({totalCadastrados}/10)");
        Pausar();
    }

    static void BuscarLivro()
    {
        if (biblioteca.Count == 0) {
            Console.WriteLine("\nNenhum livro foi cadastrado.");
            Pausar();
            return;
        }

        Console.Clear();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("                BUSCAR LIVRO               ");
        Console.WriteLine("-------------------------------------------\n");

        Console.Write("> Digite o código do livro que deseja buscar: ");
        string codigo = Console.ReadLine() ?? "";

        if (biblioteca.ContainsKey(codigo)) {
            Livro livro = biblioteca[codigo];
            Console.WriteLine($"\n[Livro Encontrado]");
            Console.WriteLine($"Título: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine($"Ano de Publicação: {livro.AnoPublicacao}");
            Console.WriteLine($"Quantidade em estoque: {livro.Quantidade}");
        } 
        else {
            Console.WriteLine("\nNão existe um livro cadastrado com esse código.");
        }
        Pausar();
    }

    static void EmprestarLivro()
    {
        if (biblioteca.Count == 0) {
            Console.WriteLine("\nNenhum livro foi cadastrado.");
            Pausar();
            return;
        }

        Console.Clear();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("            EMPRÉSTIMO DE LIVRO            ");
        Console.WriteLine("-------------------------------------------\n");

        Console.Write("> Digite o código do livro para realizar o empréstimo: ");
        string codigo = Console.ReadLine() ?? "";

        if (biblioteca.ContainsKey(codigo)) {
            Livro livro = biblioteca[codigo];

            if (livro.Quantidade > 0) {
                livro.Quantidade--; // Reduz a quantidade disponível
                biblioteca[codigo] = livro; // Grava a cópia modificada de volta no dicionário
                Console.WriteLine($"\nEmpréstimo realizado com sucesso! Exemplares restantes: {livro.Quantidade}");
            } 
            else {
                Console.WriteLine("\nNão há exemplares disponíveis.");
            }
        } 
        else {
            Console.WriteLine("\nLivro não encontrado.");
        }
        Pausar();
    }

    static void ExibirRelatorio()
    {
        if (biblioteca.Count == 0) {
            Console.WriteLine("\nNenhum livro cadastrado ainda.");
            Pausar();
            return;
        }

        Console.Clear();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("          RELATÓRIO DA BIBLIOTECA          ");
        Console.WriteLine("-------------------------------------------\n");

        Console.WriteLine($"Total de livros cadastrados: {biblioteca.Count}\n");

        int anoMaisAntigo = 999999;
        string tituloMaisAntigo = "";

        int maiorQuantidade = -1;
        string tituloMaiorQtd = "";

        List<string> listaAutores = new List<string>();
        List<int> qtdLivrosPorAutor = new List<int>();

        foreach (var item in biblioteca) {
            Livro livro = item.Value;

            if (livro.AnoPublicacao < anoMaisAntigo) {
                anoMaisAntigo = livro.AnoPublicacao;
                tituloMaisAntigo = livro.Titulo;
            }
            if (livro.Quantidade > maiorQuantidade) {
                maiorQuantidade = livro.Quantidade;
                tituloMaiorQtd = livro.Titulo;
            }

            if (listaAutores.Contains(livro.Autor)) {
                int posicao = listaAutores.IndexOf(livro.Autor);
                qtdLivrosPorAutor[posicao]++;
            } 
            else {
                listaAutores.Add(livro.Autor);
                qtdLivrosPorAutor.Add(1);
            }
        }

        Console.WriteLine($"Livro mais antigo: {tituloMaisAntigo} ({anoMaisAntigo})");
        Console.WriteLine($"Livro com maior estoque disponível: {tituloMaiorQtd} ({maiorQuantidade} exemplares)\n");

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("       QUANTIDADE DE LIVROS POR AUTOR      ");
        Console.WriteLine("-------------------------------------------");
        for (int i = 0; i < listaAutores.Count; i++) {
            Console.WriteLine($"Autor: {listaAutores[i],-20} | Livros registados: {qtdLivrosPorAutor[i]}");
        }

        Pausar();
    }

    static void Menu()
    {
        int opcao = 0;
        while (opcao != 5) {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("      SISTEMA DE GESTÃO DE BIBLIOTECA      ");
            Console.WriteLine("===========================================\n");
            Console.WriteLine($"Livros cadastrados: {totalCadastrados}/10\n");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1 - Cadastrar Livro");
            Console.WriteLine("2 - Buscar Livro por Código");
            Console.WriteLine("3 - Realizar Empréstimo");
            Console.WriteLine("4 - Exibir Relatório Completo");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------------------------");

            Console.Write("> Escolha uma opção: ");
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao) {
                case 1:
                    CadastrarLivro();
                    break;
                case 2:
                    BuscarLivro();
                    break;
                case 3:
                    EmprestarLivro();
                    break;
                case 4:
                    ExibirRelatorio();
                    break;
                case 5:
                    Console.WriteLine("\nEncerrando programa.");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    Pausar();
                    break;
            }
        }
    }
    static void Main()
    {
        Menu();
    }
}