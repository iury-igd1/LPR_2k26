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
    static float populacao = 0.0f, somaPopulacoes = 0.0f, populacaoMaior = -1.0f, populacaoMenor = 999999999.0f;
    static int qtde = 0;
    static Dictionary<string, float> cidades = new Dictionary<string, float>();

    static void Main()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("   CADASTRO DE CIDADES   ");
        Console.WriteLine("=========================\n");

        Console.Write("> Digite o número de cidades que serão informadas: ");
        int.TryParse(Console.ReadLine(), out int total);

        for (int i = 1; i <= total; i++) {
            Console.Write($"\n> Digite o nome da cidade {i}: ");
            nomeCidade = Console.ReadLine() ?? "";

            Console.Write($"> Digite a população da cidade {i} (em milhares): ");
            float.TryParse(Console.ReadLine(), out populacao);
            somaPopulacoes += populacao;
            qtde += 1;

            cidades[nomeCidade] = populacao;
        }

        double media = somaPopulacoes / qtde;

        Console.WriteLine("\nCidades com população acima da média:");
        foreach (var ppl in cidades) {
            if (ppl.Value > media) {
                Console.Write($"{ppl.Key} ");
            }
        }

        foreach (var ppl in cidades) {
            if (ppl.Value > populacaoMaior) {
                maisPopulosa = ppl.Key;
                populacaoMaior = ppl.Value;
            }
            if (ppl.Value < populacaoMenor) {
                menosPopulosa = ppl.Key;
                populacaoMenor = ppl.Value;
            }
        }

        Console.WriteLine($"\n\nCidade mais populosa: {maisPopulosa}, com {populacaoMaior} mil habitantes");
        Console.WriteLine($"Cidade menos populosa: {menosPopulosa}, com {populacaoMenor} mil habitantes");

        Console.Write("\n> Informe um valor de população para remover do dicionário: ");
        float.TryParse(Console.ReadLine(), out float filtro);

        foreach (var ppl in cidades) {
            if (ppl.Value == filtro) {
            cidades.Remove(ppl.Key);
            }
        }

        Console.WriteLine("\nDicionário final:");
        foreach (var ppl in cidades) {
            Console.WriteLine($"{ppl.Key}, {ppl.Value}");
        }
    }
}