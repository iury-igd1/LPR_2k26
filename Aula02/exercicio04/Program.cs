/* 
Exercício 04:
     Faça um programa para ler o código de uma peça 1, o número 
     de peças 1, o valor unitário de cada peça 1, o código de 
     uma peça 2, o número de peças 2 e o valor unitário de cada 
     peça 2. Calcule e mostre o valor a ser pago.
    
    EXEMPLO:
        Entrada:    12 1 5.30
                    16 2 5.10
        Saída:      Valor a pagar: R$ 15.50
*/

Console.Write("Código, número de peças e valor unitário da peça 1: ");
string[] entrada1 = Console.ReadLine()!.Split(' ');
Console.Write("Código, número de peças e valor unitário da peça 2: ");
string[] entrada2 = Console.ReadLine()!.Split(' ');

int.TryParse(entrada1[1], out int numero1);
float.TryParse(entrada1[2], out float valor1);
int.TryParse(entrada2[1], out int numero2);
float.TryParse(entrada2[2], out float valor2);

float valor = (numero1 * valor1) + (numero2 * valor2);

Console.WriteLine($"Valor a pagar: R$ {valor:F2}");
