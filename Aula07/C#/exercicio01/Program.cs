/* 
Exercício 01:
    Construa um algoritmo que leia 5 números inteiros e os armazene em um vetor. Ao final, o programa deve 
    exibir todos os números digitados, o maior valor armazenado e a posição em que esse valor se encontra.

    EXEMPLO:
        Entrada:    8 3 12 7 5
        Saída:      Vetor = 8 3 12 7 5
                    Maior valor = 12
                    Posição = 3
*/

int[] numeros = new int[5];

Console.Clear();
Console.WriteLine("======================");
Console.WriteLine("   ANÁLISE DE VETOR   ");
Console.WriteLine("======================\n");

Console.Write("> Digite 5 números inteiros (separados por espaço): ");
string[] entrada = (Console.ReadLine() ?? "").Split(' ');
// Lê os 5 números informados e armazena no vetor
for (int i = 0; i < 5; i++) {
    numeros[i] = int.Parse(entrada[i]);
}

int maior = numeros[0], posicao = 0;

for (int i = 1; i < 5; i++) { // Percorre o vetor para encontrar o maior valor e sua posição
    if (numeros[i] > maior) {
        maior = numeros[i];
        posicao = i + 1;
    }
}

Console.Write("\nVetor = ");
for (int i = 0; i < 5; i++) {
    Console.Write($"{numeros[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Maior valor = {maior}");
Console.WriteLine($"Posição = {posicao}");
