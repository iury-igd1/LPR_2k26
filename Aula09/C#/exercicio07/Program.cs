/* 
Exercício 07:
    Construa um dicionário de X pares chave-valor onde as chaves são cidades e os valores são suas respectivas 
    populações. Encontre e imprima todas as cidades com população acima da média. Encontre e imprima o nome da 
    cidade mais populosa e o nome da cidade menos populosa. Remova todas as cidades com população igual a um 
    valor Y (fornecido pelo usuário) e imprima o dicionário atualizado.
*/

using System;
using System.Collections.Generic;

class Program
{
    static string nomeCidade = "", maisPopulosa = "", menosPopulosa = "";
    static long populacao = 0, somaPopulacoes = 0, populacaoMaior = -1, populacaoMenor = 999999999;
    // Dicionário de armazenamento das cidades no formato cidade-população
    static Dictionary<string, long> cidades = new Dictionary<string, long>();

    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=========================");
        Console.WriteLine("   CADASTRO DE CIDADES   ");
        Console.WriteLine("=========================\n");

        Console.Write("> Digite o número de cidades que serão informadas: ");
        int.TryParse(Console.ReadLine(), out int total);

        if (total <= 0) {
            Console.WriteLine("\nValor informado inválido.");
            return;
        }

        for (int i = 1; i <= total; i++) { // Cadastro das cidades informadas pelo usuário
            Console.Write($"\n> Digite o nome da cidade {i}: ");
            nomeCidade = Console.ReadLine() ?? "";

            Console.Write($"> Digite a população da cidade {i}: ");
            long.TryParse(Console.ReadLine(), out populacao);

            cidades[nomeCidade] = populacao;
        }

        foreach (var ppl in cidades) { // Soma as populações e identifica as cidades mais e menos populosas
            somaPopulacoes += ppl.Value;

            if (ppl.Value > populacaoMaior) {
                maisPopulosa = ppl.Key;
                populacaoMaior = ppl.Value;
            }
            if (ppl.Value < populacaoMenor) {
                menosPopulosa = ppl.Key;
                populacaoMenor = ppl.Value;
            }
        }

        double media = (double)somaPopulacoes / cidades.Count; // Calcula a média das populações cadastradas

        Console.WriteLine($"\nMédia das populações: {media:N2} habitantes");
        Console.WriteLine("\nCidades com população acima da média:");
        foreach (var ppl in cidades) { // Exibe somente as cidades cuja população é maior que a média calculada
            if (ppl.Value > media) {
                Console.Write($"- {ppl.Key} ");
            }
        }

        Console.WriteLine($"\n\nCidade mais populosa: {maisPopulosa}, com {populacaoMaior} habitantes");
        Console.WriteLine($"Cidade menos populosa: {menosPopulosa}, com {populacaoMenor} habitantes");

        Console.Write("\n> Informe um valor de população para remover do dicionário: ");
        long.TryParse(Console.ReadLine(), out long filtro);

        // Armazena as chaves das cidades com a população informada
        // Separa a busca das remoções para não alterar o dicionário durante sua enumeração
        List<string> chavesParaRemover = new List<string>();
        foreach (var ppl in cidades) {
            if (ppl.Value == filtro) {
                chavesParaRemover.Add(ppl.Key);
            }
        }

        // Remove do dicionário todas as cidades com a população informada
        foreach (var chave in chavesParaRemover) {
            cidades.Remove(chave);
        }

        Console.WriteLine("\nDicionário final:"); // Exibe o dicionário após as remoções
        if (cidades.Count == 0) {
            Console.WriteLine("(Vazio)");
        }
        else {
            foreach (var ppl in cidades) {
                Console.WriteLine($"{ppl.Key}, {ppl.Value}");
            }
        }
    }
}
