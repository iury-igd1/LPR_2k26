/* 
Exercício 02:
    Construa uma lista de X nomes aleatórios. 
    A saída deve ser mostrada em uma ou mais linhas. Cada linha tem uma lista de nomes ordenados por tamanho, começando 
    com o menor. Em cada linha, só pode ser mostrado um nome de determinado tamanho, e os demais nomes com o mesmo 
    tamanho devem ser apresentados nas linhas seguintes. Siga a ordem de digitação.

    EXEMPLO:
        Entrada:    12 sergio ana maria carlos eva joaquim jo mara laura lucas ari paulo
        Saída:      jo, ana, mara, maria, sergio, joaquim
                    eva, laura, carlos
                    ari, lucas
                    paulo
*/

using System;
using System.Collections.Generic; // Biblioteca para listas

class Program
{
    static void Main()
    {
        Console.WriteLine("=====================");
        Console.WriteLine("   FILTRO DE NOMES   ");
        Console.WriteLine("=====================\n");

        Console.Write("> Digite o número de nomes e os nomes (separados por espaço): ");
        string[] entrada = (Console.ReadLine() ?? "").Split(' '); // Separa os elementos da entrada
        
        int quantidade;
        int.TryParse(entrada[0], out quantidade);
        List<string> nomes = new List<string>();

        for (int i = 1; i <= quantidade && i < entrada.Length; i++) {
            nomes.Add(entrada[i]); // Adiciona os nomes digitados à lista
        }

        Console.WriteLine("\nSaída: ");
        while (nomes.Count > 0) {
            List<string> linhaAtual = new List<string>(); // Guarda os nomes da linha a ser impressa
            List<int> tamanhosUsados = new List<int>(); // Guarda os tamanhos dos nomes da linha a ser impressa

            for (int i = 0; i < nomes.Count; i++) { // Percorre todos os nomes
                int tamanho = nomes[i].Length; // Tamanho do nome atual
                
                if (tamanhosUsados.Contains(tamanho) == false) { // Se o tamanho ainda não está na linha
                    linhaAtual.Add(nomes[i]); // Adiciona na linha de impressão
                    tamanhosUsados.Add(tamanho);
                    nomes.RemoveAt(i); // Retira o nome da lista principal
                    i--; // Volta o índice em 1, porque a lista encolheu
                }
            }

            for (int i = 0; i < linhaAtual.Count; i++) { // Ordena a lista pelo tamanho das palavras
                for (int j = i + 1; j < linhaAtual.Count; j++) {
                    if (linhaAtual[i].Length > linhaAtual[j].Length) { // Compara o tamanho da palavra com a próxima
                        string temp = linhaAtual[i];
                        linhaAtual[i] = linhaAtual[j];
                        linhaAtual[j] = temp;
                    }
                }
            }

            for (int i = 0; i < linhaAtual.Count; i++) {
                Console.Write(linhaAtual[i]);
                if (i < linhaAtual.Count - 1) {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}