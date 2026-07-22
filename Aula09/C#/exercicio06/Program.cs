/* 
Exercício 06:
    Construa um dicionário de X pares chave-valor em que as chaves são nomes e os valores são respectivas idades. 
    Encontre e imprima todos os nomes de pessoas com idade acima da média.
    Encontre e imprima o nome da pessoa mais velha e o nome da pessoa mais nova.
    Remova todas as pessoas com idade igual a um valor Y (fornecido pelo usuário) e imprima o dicionário atualizado.
*/

using System;
using System.Collections.Generic;

class Program
{
    static string nomePessoa = "", maisVelho = "", maisNovo = "";
    static int idadePessoa = 0, somaIdades = 0, qtde = 0, iddMaisVelho = -1, iddMaisNovo = 999999999;
    static Dictionary<string, int> pessoas = new Dictionary<string, int>();

    static void Main()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("   CADASTRO DE PESSOAS   ");
        Console.WriteLine("=========================\n");

        Console.Write("> Digite o número de pessoas que serão informadas: ");
        int.TryParse(Console.ReadLine(), out int total);

        for (int i = 1; i <= total; i++) {
            Console.Write($"\n> Digite o nome da pessoa {i}: ");
            nomePessoa = Console.ReadLine() ?? "";

            Console.Write($"> Digite a idade da pessoa {i}: ");
            int.TryParse(Console.ReadLine(), out idadePessoa);
            somaIdades += idadePessoa;
            qtde += 1;

            pessoas[nomePessoa] = idadePessoa;
        }

        double media = (double)somaIdades / qtde;

        Console.WriteLine("\nPessoas com idade acima da média:");
        foreach (var idd in pessoas) {
            if (idd.Value > media) {
                Console.WriteLine($"{idd.Key}");
            }
        }

        foreach (var idd in pessoas) {
            if (idd.Value > iddMaisVelho) {
                maisVelho = idd.Key;
                iddMaisVelho = idd.Value;
            }
            if (idd.Value < iddMaisNovo) {
                maisNovo = idd.Key;
                iddMaisNovo = idd.Value;
            }
        }

        Console.WriteLine($"\nPessoa mais velha: {maisVelho}, com {iddMaisVelho} anos");
        Console.WriteLine($"Pessoa mais nova: {maisNovo}, com {iddMaisNovo} anos");

        Console.Write("\n> Informe um valor de idade para remover do dicionário: ");
        int.TryParse(Console.ReadLine(), out int filtro);

        foreach (var idd in pessoas) {
            if (idd.Value == filtro) {
                pessoas.Remove(idd.Key);
            }
        }

        Console.WriteLine("\nDicionário final:");
        foreach (var idd in pessoas) {
            Console.WriteLine($"{idd.Key}, {idd.Value}");
        }
    }
}