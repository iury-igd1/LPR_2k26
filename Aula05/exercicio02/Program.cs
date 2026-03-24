using System.Diagnostics;

int tentativas = 0;
int palpite;

Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);

do {
    Console.Write("Digite um número entre 1 e 100: ");
    palpite = Convert.ToInt32(Console.ReadLine());
    tentativas++;

    if (palpite < valorInteiro) {
        Console.WriteLine("Chutou baixo!");
    } 
    else if (palpite > valorInteiro) {
        Console.WriteLine("Chutou Alto!");
    } 
    else {
        Console.WriteLine($"Acertou em {tentativas} tentativas!");
    }
} while (palpite != valorInteiro);