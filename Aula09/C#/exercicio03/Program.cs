/* 
Exercício 03:
    Construa uma lista de 100 números aleatórios. Crie um algoritmo que coloque-os em ordem crescente e 
    imprima-os. A partir dessa lista ordenada, remova todos os números pares e imprima a lista novamente.
    Por fim, imprima quais números se repetem, se existe algum número repetido.
*/

using System;
using System.Collections.Generic; // Biblioteca para listas

class Program
{
    static List<int> numeros = new List<int>(); // Lista global
    static Random num = new Random();

    static void imprimirLista()
    {
        int contador = 0;
        foreach (int n in numeros) {
            Console.Write(n + " ");
            contador++;

            if (contador % 40 == 0) { // Quebra a linha a cada 40 números
                Console.WriteLine();
            }
        }
    }
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("   LISTA DE NÚMEROS ALEATÓRIOS   ");
        Console.WriteLine("=================================\n");

        for (int i = 0; i < 100; i++) { // Gera 100 números aleatórios e adiciona na lista
            int numero = num.Next(0, 101);
            numeros.Add(numero);
        }

        Console.WriteLine("Números da lista: ");
        imprimirLista();

        numeros.Sort(); // Ordena a lista em ordem crescente
        Console.WriteLine("\n\nLista em ordem crescente: ");
        imprimirLista();

        List<int> pares = new List<int>(); // Cria uma lista de números pares
        for (int i = 0; i <= 100; i += 2) {
            pares.Add(i);
        }
        for (int i = 0; i < numeros.Count; i++) { // Percorre a lista principal e remove os pares
            if (pares.Contains(numeros[i])) {
                numeros.RemoveAt(i); // Remove o elemento atual
                i--; // Volta o índice em 1, porque a lista encolheu
            }
        }
        Console.WriteLine("\n\nLista com os números ímpares: ");
        imprimirLista();

        Console.WriteLine("\n\nNúmeros repetidos encontrados na lista: ");
        List<int> listaParalela = new List<int>();
        List<int> impressos = new List<int>();
        bool repetido = false;
        
        for (int i = 0; i < numeros.Count; i++) {
            if (listaParalela.Contains(numeros[i])) { // Se o número está na listaParalela, ele é repetido
                if (impressos.Contains(numeros[i]) == false) {
                    Console.Write(numeros[i] + " ");
                    impressos.Add(numeros[i]);
                    repetido = true;
                }
                numeros.RemoveAt(i); // Remove o número da lista principal
                i--; // Volta o índice em 1, porque a lista encolheu
            }
            else { 
                listaParalela.Add(numeros[i]);
            }
        }

        if (repetido == false) {
            Console.WriteLine("Não há nenhum elemento repetido na lista.");
        }

        Console.WriteLine("\n\nLista final (sem pares e sem repetições): ");
        imprimirLista();
    }
}