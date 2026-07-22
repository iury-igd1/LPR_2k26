/* 
Exercício 05:
    Construa um algoritmo que leia uma matriz 3x3 de números inteiros. Ao final, o programa deverá mostrar a 
    matriz digitada e calcular a soma de todos os elementos da matriz.

    EXEMPLO:
        Entrada:    1 2 3 4 5 6 7 8 9
        Saída:      Matriz informda:
                    1 2 3
                    4 5 6
                    7 8 9
                    Soma dos elementos = 45
*/

Console.Clear();
Console.WriteLine("===========================");
Console.WriteLine("   LEITURA DE MATRIZ 3X3   ");
Console.WriteLine("===========================\n");

// Lê os 9 elementos da matriz 3x3
Console.Write("> Digite os elementos da matriz 3x3 (9 números inteiros separados por espaço): ");
string[] entrada = (Console.ReadLine() ?? "").Split(' ');

int[,] matriz = new int[3, 3];
for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        matriz[i, j] = int.Parse(entrada[i * 3 + j]);
    }
}

int soma = 0;

// Exibe a matriz e soma todos os elementos ao mesmo tempo
Console.WriteLine("\nMatriz informada:");
for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        Console.Write(matriz[i, j] + " ");
        soma += matriz[i, j];
    }
    Console.WriteLine();
}

Console.WriteLine($"\nSoma dos elementos = {soma}");
