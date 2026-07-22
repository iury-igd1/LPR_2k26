/* 
Exercício 03:
    Suponha que você está desenvolvendo um jogo de RPG. Você é responsável por implementar a mecânica de 
    habilidades especiais para diferentes classes de personagens. Cada classe tem suas próprias habilidades 
    especiais. Crie um programa que permita ao jogador escolher uma classe de personagem e, em seguida, exiba 
    suas habilidades especiais correspondentes. 

    EXEMPLO:
        Entrada:    2
        Saída:      Suas habilidades: Bola de fogo e Escudo de gelo.
*/

string classe;

Console.Clear();
Console.WriteLine("============================");
Console.WriteLine("   SISTEMA DE CLASSES RPG   ");
Console.WriteLine("============================\n");

Console.WriteLine("1 - Guerreira\n2 - Mago\n3 - Arqueira\n");
// Lê a classe escolhida pelo jogador
Console.Write("> Escolha sua Classe: "); 
classe = Console.ReadLine() ?? "";

switch (classe) { // Cada classe possui um conjunto fixo de duas habilidades especiais
    case "1":
        Console.WriteLine("\nSuas habilidades: Ataque pesado e Defesa total.");
        break;
    case "2":
        Console.WriteLine("\nSuas habilidades: Bola de fogo e Escudo de gelo.");
        break;
    case "3":
        Console.WriteLine("\nSuas habilidades: Flecha precisa e Disparo triplo.");
        break;
    default:
        Console.WriteLine("\nClasse inválida.");
        break;
}
