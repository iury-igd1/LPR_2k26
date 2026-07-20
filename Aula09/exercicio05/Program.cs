/* 
Exercício 05:
    Crie um programa que utilize um dicionário para armazenar jogos e seus respectivos gêneros. Cadastre pelo menos cinco 
    jogos informados pelo usuário e, depois, solicite o nome de um jogo e exiba seu gênero.
    Caso o jogo não esteja cadastrado, exiba uma mensagem informando isso.
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dicionário de armazenamento dos jogos no formato jogo-gênero
        Dictionary<string, string> jogos = new Dictionary<string, string>();
        string nomeJogo, generoJogo, nomeBusca;

        Console.WriteLine("=======================");
        Console.WriteLine("   CADASTRO DE JOGOS   ");
        Console.WriteLine("=======================");

        for (int i = 1; i <= 5; i++) {
            Console.Write($"\n> Digite o nome do jogo {i}: ");
            nomeJogo = Console.ReadLine() ?? "";

            Console.Write($"> Digite o gênero do jogo {i}: ");
            generoJogo = Console.ReadLine() ?? "";

            jogos[nomeJogo] = generoJogo;
        }

        Console.Write($"\n> Digite o nome do jogo que deseja buscar: ");
        nomeBusca = Console.ReadLine() ?? "";

        if (jogos.ContainsKey(nomeBusca)) { // Verifica se a chave existe
            Console.WriteLine($"O gênero do jogo '{nomeBusca}' é: {jogos[nomeBusca]}.");
        } 
        else {
            Console.WriteLine($"O jogo '{nomeBusca}' não foi cadastrado.");
        }
    }
}