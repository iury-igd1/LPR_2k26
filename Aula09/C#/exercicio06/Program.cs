/* 
Exercício 06:
    Construa um dicionário de X pares chave-valor em que as chaves são nomes e os valores são respectivas idades. 
    Encontre e imprima todos os nomes de pessoas com idade acima da média. Encontre e imprima o nome da pessoa 
    mais velha e o nome da pessoa mais nova. Remova todas as pessoas com idade igual a um valor Y (fornecido 
    pelo usuário) e imprima o dicionário atualizado.
*/

using System;
using System.Collections.Generic;

class Program
{
    static string nomePessoa = "", maisVelho = "", maisNovo = "";
    static int idadePessoa = 0, somaIdades = 0, iddMaisVelho = -1, iddMaisNovo = 999999999;
    // Dicionário de armazenamento das pessoas no formato nome-idade
    static Dictionary<string, int> pessoas = new Dictionary<string, int>();

    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=========================");
        Console.WriteLine("   CADASTRO DE PESSOAS   ");
        Console.WriteLine("=========================\n");

        Console.Write("> Digite o número de pessoas que serão informadas: ");
        int.TryParse(Console.ReadLine(), out int total);

        if (total <= 0) {
            Console.WriteLine("\nValor informado inválido.");
            return;
        }

        for (int i = 1; i <= total; i++) { // Cadastro das pessoas informadas pelo usuário
            Console.Write($"\n> Digite o nome da pessoa {i}: ");
            nomePessoa = Console.ReadLine() ?? "";

            Console.Write($"> Digite a idade da pessoa {i}: ");
            int.TryParse(Console.ReadLine(), out idadePessoa);

            pessoas[nomePessoa] = idadePessoa;
        }

        foreach (var idd in pessoas) { // Soma as idades e identifica as pessoas mais velha e mais nova
            somaIdades += idd.Value;

            if (idd.Value > iddMaisVelho) {
                maisVelho = idd.Key;
                iddMaisVelho = idd.Value;
            }
            if (idd.Value < iddMaisNovo) {
                maisNovo = idd.Key;
                iddMaisNovo = idd.Value;
            }
        }

        double media = (double)somaIdades / pessoas.Count; // Calcula a média das idades cadastradas

        Console.WriteLine($"\nMédia das idades: {media:F2}");
        Console.WriteLine("\nPessoas com idade acima da média:");
        foreach (var idd in pessoas) { // Exibe somente as pessoas cuja idade é maior que a média calculada
            if (idd.Value > media) {
                Console.WriteLine($"- {idd.Key}");
            }
        }

        Console.WriteLine($"\nPessoa mais velha: {maisVelho}, com {iddMaisVelho} anos");
        Console.WriteLine($"Pessoa mais nova: {maisNovo}, com {iddMaisNovo} anos");

        Console.Write("\n> Informe um valor de idade para remover do dicionário: ");
        int.TryParse(Console.ReadLine(), out int filtro);

        // Armazena as chaves das pessoas que possuem a idade informada
        // Separa a busca das remoções para não alterar o dicionário durante sua enumeração
        List<string> chavesParaRemover = new List<string>();
        foreach (var idd in pessoas) {
            if (idd.Value == filtro) {
                chavesParaRemover.Add(idd.Key);
            }
        }
        
        // Remove do dicionário todas as pessoas com a idade informada
        foreach (var chave in chavesParaRemover) { 
            pessoas.Remove(chave);
        }

        Console.WriteLine("\nDicionário final:"); // Exibe o dicionário após as remoções
        if (pessoas.Count == 0) {
            Console.WriteLine("(Vazio)");
        }
        else {
            foreach (var idd in pessoas) {
                Console.WriteLine($"{idd.Key}, {idd.Value}");
            }
        }
    }
}
