/* 
Exercício 07:
    Construa um dicionário de X pares chave-valor onde as chaves são cidades e os valores são suas respectivas populações.
    Encontre e imprima todas as cidades com população acima da média.
    Encontre e imprima o nome da cidade mais populosa e o nome da cidade menos populosa.
    Remova todas as cidades com população igual a um valor Y (fornecido pelo usuário) e imprima o dicionário atualizado.
*/

using System;
using System.Collections.Generic;

class Program
{
    static string nomeCidade = "", maisPopulosa = "", menosPopulosa = "";
    static int populacao = 0, somaPopulacoes = 0, qtde = 0, populacaoMenor = -1, populacaoMaior = 999999999;
    static Dictionary<string, float> pessoas = new Dictionary<string, float>();

    static void Main()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("   CADASTRO DE CIDADES   ");
        Console.WriteLine("=========================\n");

        Console.Write("> Digite o número de cidades que serão informadas: ");
        int.TryParse(Console.ReadLine(), out int total);

        for (int i = 0; i < total; i++) {
            Console.Write($"\n> Digite o nome da cidade {i + 1}: ");
            nomeCidade = Console.ReadLine() ?? "";

            Console.Write($"> Digite a população da cidade {i + 1} (em milhares): ");
            float.TryParse(Console.ReadLine(), out idadePessoa);
            somaIdades += idadePessoa;
            qtde += 1;

            pessoas[nomePessoa] = idadePessoa;
        }

        double media = somaIdades / qtde;

        Console.WriteLine("\nPessoas com idade acima da média:");
        foreach (var idd in pessoas) {
            if (idd.Value > media) {
                Console.Write($"{idd.Key} ");
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

        Console.WriteLine($"\n\nPessoa mais velha: {maisVelho}, com {iddMaisVelho} anos");
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