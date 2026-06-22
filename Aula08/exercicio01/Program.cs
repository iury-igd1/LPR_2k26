/* 
Exercício 01:
    Defina uma struct chamada Filme contendo os seguintes campos:
        Titulo, Diretor, AnoLancamento, DuracaoMinutos

    Crie um programa que:
      - Solicite os dados de 3 filmes.
      - Armazene-os em um vetor de structs.
      - Exiba todos os filmes cadastrados.
      - Informe qual é o filme mais antigo.
*/

using System;

class Program
{
    struct Filme
    {
        public string Titulo;
        public string Diretor;
        public int AnoLancamento;
        public int DuracaoMinutos;
    }

    static void Main()
    {
        Filme[] listaFilmes = new Filme[3];

        Console.WriteLine("========================");
        Console.WriteLine("   CADASTRO DE FILMES   ");
        Console.WriteLine("========================\n");

        for (int i = 0; i < 3; i++) { // Lê os dados de cada um dos 3 filmes
            Console.Write($"> Informe o título do Filme {i + 1}: ");
            listaFilmes[i].Titulo = Console.ReadLine() ?? "";

            Console.Write($"> Informe o nome do diretor do Filme {i + 1}: ");
            listaFilmes[i].Diretor = Console.ReadLine() ?? "";

            Console.Write($"> Informe o ano de lançamento do Filme {i + 1}: ");
            listaFilmes[i].AnoLancamento = int.Parse(Console.ReadLine() ?? "0");

            Console.Write($"> Informe a duração (em minutos) do Filme {i + 1}: ");
            listaFilmes[i].DuracaoMinutos = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine();
        }

        Console.WriteLine("Filmes cadastrados:");
        Console.WriteLine($"[1] {listaFilmes[0].Titulo}");
        Console.WriteLine($"[2] {listaFilmes[1].Titulo}");
        Console.WriteLine($"[3] {listaFilmes[2].Titulo}");
        Console.WriteLine();

        // Compara o ano de lançamento dos 3 filmes para descobrir o mais antigo
        int a1 = listaFilmes[0].AnoLancamento;
        int a2 = listaFilmes[1].AnoLancamento;
        int a3 = listaFilmes[2].AnoLancamento;

        if (a1 <= a2 && a1 <= a3) {
            Console.WriteLine($"O filme mais antigo é: '{listaFilmes[0].Titulo}'.");
        }
        else if (a2 <= a1 && a2 <= a3) {
            Console.WriteLine($"O filme mais antigo é: '{listaFilmes[1].Titulo}'.");
        }
        else {
            Console.WriteLine($"O filme mais antigo é: '{listaFilmes[2].Titulo}'.");
        }
    }
}