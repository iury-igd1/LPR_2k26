/* 
Exercício 07:
    Crie um algoritmo que leia duas matrizes A e B, de tamanho 3x3, e calcule A * B.

    EXEMPLO:
        Entrada:    1 2 0 3 -1 4 2 0 1
                    2 1 3 0 4 -1 1 2 0 
        Saída:      Matriz A * B =
                    2 9 1
                    10 7 10
                    5 4 6
*/

Console.WriteLine("===============================");
Console.WriteLine("   MULTIPLICAÇÃO DE MATRIZES   ");
Console.WriteLine("===============================\n");

Console.Write("> Digite os 9 elementos da primeira matriz 3x3 (separados por espaço): ");
string[] entradaA = (Console.ReadLine() ?? "").Split(' ');
int[,] matrizA = new int[3, 3];
for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        matrizA[i, j] = int.Parse(entradaA[i * 3 + j]);
    }
}

Console.Write("> Digite os 9 elementos da segunda matriz 3x3 (separados por espaço):  ");
string[] entradaB = (Console.ReadLine() ?? "").Split(' ');
int[,] matrizB = new int[3, 3];
for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        matrizB[i, j] = int.Parse(entradaB[i * 3 + j]);
    }
}

// Calcula cada elemento da matriz resultante: linha de A * coluna de B
int[,] matrizMultiplicacao = new int[3, 3];
matrizMultiplicacao[0, 0] = matrizA[0, 0] * matrizB[0, 0] + matrizA[0, 1] * matrizB[1, 0] + matrizA[0, 2] * matrizB[2, 0];
matrizMultiplicacao[0, 1] = matrizA[0, 0] * matrizB[0, 1] + matrizA[0, 1] * matrizB[1, 1] + matrizA[0, 2] * matrizB[2, 1];
matrizMultiplicacao[0, 2] = matrizA[0, 0] * matrizB[0, 2] + matrizA[0, 1] * matrizB[1, 2] + matrizA[0, 2] * matrizB[2, 2];
matrizMultiplicacao[1, 0] = matrizA[1, 0] * matrizB[0, 0] + matrizA[1, 1] * matrizB[1, 0] + matrizA[1, 2] * matrizB[2, 0];
matrizMultiplicacao[1, 1] = matrizA[1, 0] * matrizB[0, 1] + matrizA[1, 1] * matrizB[1, 1] + matrizA[1, 2] * matrizB[2, 1];
matrizMultiplicacao[1, 2] = matrizA[1, 0] * matrizB[0, 2] + matrizA[1, 1] * matrizB[1, 2] + matrizA[1, 2] * matrizB[2, 2];
matrizMultiplicacao[2, 0] = matrizA[2, 0] * matrizB[0, 0] + matrizA[2, 1] * matrizB[1, 0] + matrizA[2, 2] * matrizB[2, 0];
matrizMultiplicacao[2, 1] = matrizA[2, 0] * matrizB[0, 1] + matrizA[2, 1] * matrizB[1, 1] + matrizA[2, 2] * matrizB[2, 1];
matrizMultiplicacao[2, 2] = matrizA[2, 0] * matrizB[0, 2] + matrizA[2, 1] * matrizB[1, 2] + matrizA[2, 2] * matrizB[2, 2];

Console.WriteLine();
Console.WriteLine("Matriz A * B =");
for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        Console.Write(matrizMultiplicacao[i, j] + " ");
    }
    Console.WriteLine();
}
