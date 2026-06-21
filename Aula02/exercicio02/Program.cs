/* 
Exercício 02:
    Faça um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do 
    produto de A e B pelo produto de C e D.
    
    EXEMPLO:
        Entrada:    5
                    6
                    7
                    8
        Saída:      Diferença = -26 
*/

Console.WriteLine("==========================================");
Console.WriteLine("   CALCULADORA DE DIFERENÇA DE PRODUTOS   ");
Console.WriteLine("==========================================\n");
Console.WriteLine("Diferença = (A * B) - (C * D)\n");
Console.WriteLine("Informe os valores:\n");

// Lê os quatro valores informados pelo usuário
Console.Write("> Valor de A: ");
int.TryParse(Console.ReadLine(), out int A);
Console.Write("> Valor de B: ");
int.TryParse(Console.ReadLine(), out int B);
Console.Write("> Valor de C: ");
int.TryParse(Console.ReadLine(), out int C);
Console.Write("> Valor de D: ");
int.TryParse(Console.ReadLine(), out int D);

int diferenca = (A * B) - (C * D); // Calcula a diferença entre os dois produtos

Console.WriteLine($"\nDiferença = {diferenca}");
