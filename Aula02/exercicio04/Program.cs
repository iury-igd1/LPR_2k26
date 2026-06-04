/* 
Exercício 04:
    Faça um programa para ler o código, o número de peças e o valor unitário de uma peça 1 e o código, o 
    número de peças e o valor unitário de uma peça 2. Calcule e mostre o valor a ser pago.
    
    EXEMPLO:
        Entrada:    12 1 5.30
                    16 2 5.10
        Saída:      Valor a pagar = R$ 15.50
*/

Console.WriteLine("==================================");
Console.WriteLine("   CALCULADORA DE VALOR A PAGAR   ");
Console.WriteLine("==================================\n");
Console.WriteLine("Informe os dados das peças para calcular o valor a pagar.\n");   

Console.Write("> Código, número de peças e valor unitário da peça 1 (separados por espaço): ");
string[] entrada1 = Console.ReadLine()!.Split(' ');
Console.Write("> Código, número de peças e valor unitário da peça 2 (separados por espaço): ");
string[] entrada2 = Console.ReadLine()!.Split(' ');

int.TryParse(entrada1[1], out int numero1);
float.TryParse(entrada1[2], out float valor1);
int.TryParse(entrada2[1], out int numero2);
float.TryParse(entrada2[2], out float valor2);

float valor = (numero1 * valor1) + (numero2 * valor2);

Console.WriteLine($"\nValor a pagar = R$ {valor:F2}");
