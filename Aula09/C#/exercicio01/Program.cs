/* 
Exercício 01:
    Crie um programa que permita ao usuário cadastrar notas de alunos em uma lista. 
    
    O programa deve:
      - Solicitar ao usuário 5 notas.
      - Armazenar as notas em uma lista.
      - Exibir:
          > Todas as notas cadastradas;
          > A maior nota;
          > A menor nota;
          > A média das notas.
*/

using System;
using System.Collections.Generic; // Biblioteca para listas

class Program
{
    static void Main()
    {
        List<int> notas = new List<int>();
        int nota, soma = 0;

        Console.Clear();
        Console.WriteLine("=======================");
        Console.WriteLine("   CADASTRO DE NOTAS   ");
        Console.WriteLine("=======================\n");

        for (int i = 1; i <= 5; i++) { // Lê os valores das 5 notas
            Console.Write($"> Insira a {i}ª nota (0 a 100): ");
            int.TryParse(Console.ReadLine(), out nota);
            notas.Add(nota); // Adiciona ao final da lista
            soma += nota;
        }
        
        int maior = notas[0];
        int menor = notas[0];

        for (int i = 0; i < 5; i++) { // Percorre todos os valores da lista para verificar o maior e o menor
            if (notas[i] > maior) {
                maior = notas[i];
            }
            if (notas[i] < menor) {
                menor = notas[i];
            }
        }

        Console.Write("\nNotas cadastradas: ");
        foreach (int elemento in notas) { // Percorre todos os elementos da lista
            Console.Write(elemento + " ");
        }
        Console.WriteLine($"\nMaior nota: {maior}");
        Console.WriteLine($"Menor nota: {menor}");
        Console.WriteLine($"Média das notas: {soma / 5.0}");        
    }
}