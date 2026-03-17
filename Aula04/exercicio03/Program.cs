using System.Diagnostics;

string classe;

Console.Write("Escolha sua Classe (Guerreira, Mago ou Arqueira): ");
classe = Console.ReadLine();

switch (classe) {
    case "Guerreira":
        Console.WriteLine("Suas habilidades são: Ataque pesado e Defesa total.");
        break;
    case "Mago":
        Console.WriteLine("Suas habilidades são: Bola de fogo e Escudo de gelo.");
        break;
    case "Arqueira":
        Console.WriteLine("Suas habilidades são: Flecha precisa e Disparo triplo.");
        break;
    default:
        Console.WriteLine("Classe inválida.");
        break;
}