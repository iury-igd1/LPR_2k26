/* 
Exercício 02:
    Construa um algoritmo de adivinhação de números. O seu 
    trabalho é elaborar um algoritmo em que o usuário possa
    digitar números no console até acertar o número inteiro 
    aleatório valorInteiro, de 1 a 100. A cada chute, o programa 
    deve responder com “Chutou alto”, “Chutou baixo” ou “Acertou”. 
    Após acertar, deve ser mostrado quantas tentativas foram 
    usadas para descobrir o número.

    EXEMPLO:
        Entrada:    50 
                    75 
                    63 
                    67
        Saída:      Acertou em 4 tentativas!
*/

using System.Diagnostics;

int tentativas = 0, palpite;

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
