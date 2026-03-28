/* 
Exercício 01:
    Faça um programa para ler o valor do raio de um círculo, e 
    depois mostrar o valor da área deste círculo com quatro 
    casas decimais.
    Considerar o valor de π = 3.14159.

    EXEMPLO:
        Entrada:    2.00
        Saída:      Área = 12.5664
*/

using System.Diagnostics;

const float pi = 3.14159f;
float raio, area;

Console.Write("Digite o valor do raio do círculo: ");
string entrada = Console.ReadLine()!;
float.TryParse(entrada, out raio);

area = pi * raio * raio;

Console.WriteLine($"Área = {area:F4}");
