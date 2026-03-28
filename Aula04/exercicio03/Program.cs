/* 
Exercício 03:
    Suponha que você está desenvolvendo um jogo de RPG. Você é 
    responsável por implementar a mecânica de habilidades 
    especiais para diferentes classes de personagens. Cada classe 
    tem suas próprias habilidades especiais. Crie um programa que 
    permita ao jogador escolher uma classe de personagem e, em 
    seguida, exiba suas habilidades especiais correspondentes. 

    EXEMPLO:
        Entrada:    2
        Saída:      Suas habilidades: Bola de fogo e Escudo de gelo.
*/

using System.Diagnostics;

string classe;

Console.WriteLine("Classes disponíveis: \n1. Guerreira\n2. Mago\n3. Arqueira\n");
Console.Write("Escolha sua Classe: ");
classe = Console.ReadLine()!;

switch (classe) {
    case "1":
        Console.WriteLine("Suas habilidades: Ataque pesado e Defesa total.");
        break;
    case "2":
        Console.WriteLine("Suas habilidades: Bola de fogo e Escudo de gelo.");
        break;
    case "3":
        Console.WriteLine("Suas habilidades: Flecha precisa e Disparo triplo.");
        break;
    default:
        Console.WriteLine("Classe inválida.");
        break;
}
