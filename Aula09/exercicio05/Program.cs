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
        Dictionary<string, string> jogos = new Dictionary<string, string>();
        string nomeJogo, generoJogo, nomeBusca;

        Console.WriteLine("=======================");
        Console.WriteLine("   CADASTRO DE JOGOS   ");
        Console.WriteLine("=======================");

        for (int i = 0; i < 5; i++) {
            Console.Write($"\n> Digite o nome do jogo {i + 1}: ");
            nomeJogo = Console.ReadLine() ?? "";

            Console.Write($"> Digite o gênero do jogo {i + 1}: ");
            generoJogo = Console.ReadLine() ?? "";

            jogos[nomeJogo] = generoJogo;
        }

        Console.Write($"\n> Digite o nome do jogo que deseja buscar: ");
        nomeBusca = Console.ReadLine() ?? "";

        if (jogos.ContainsKey(nomeBusca)) {
            Console.WriteLine($"O gênero do jogo '{nomeBusca}' é: {jogos[nomeBusca]}.");
        } 
        else {
            Console.WriteLine($"O jogo '{nomeBusca}' não foi cadastrado.");
        }
    }
}