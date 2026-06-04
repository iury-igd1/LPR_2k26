/* 
Exercício 02:
    Construa um algoritmo que leia 10 números inteiros e armazene-os em um vetor (use o for para fazer a 
    leitura). Depois, crie automaticamente dois vetores, um contendo apenas os números pares e outro os 
    números ímpares digitados. 

    EXEMPLO:
        Entrada:    5 8 7 9 6 4 10 8 10 9 
        Saída:      Números pares   = 8 6 4 10 8 10
                    Números ímpares = 5 7 9 9
*/

int[] numeros = new int[10];
int contPares = 0;
int contImpares = 0;

Console.WriteLine("==========================");
Console.WriteLine("   SEPARADOR DE NÚMEROS   ");
Console.WriteLine("==========================\n");

Console.Write("> Digite 10 números inteiros (separados por espaço): ");
string[] entrada = (Console.ReadLine() ?? "").Split(' ');

for (int i = 0; i < 10; i++) {
    numeros[i] = int.Parse(entrada[i]);

    if (numeros[i] % 2 == 0) {
        contPares++;
    } 
    else {
        contImpares++;
    }
}

int[] pares = new int[contPares];
int[] impares = new int[contImpares];

int iPares = 0;
int iImpares = 0;

for (int i = 0; i < numeros.Length; i++) {
    if (numeros[i] % 2 == 0) {
        pares[iPares] = numeros[i];
        iPares++;
    } 
    else {
        impares[iImpares] = numeros[i];
        iImpares++;
    }
}

Console.Write($"\nNúmeros pares   = ");
foreach (int par in pares) {
    Console.Write($"{par} ");
}

Console.Write($"\nNúmeros ímpares = ");
foreach (int impar in impares) {
    Console.Write($"{impar} ");
}
