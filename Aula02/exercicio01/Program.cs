/* 
Exercício 01:
    Faça um programa para ler o valor do raio de um círculo, e depois mostrar o  valor da área deste círculo 
    com quatro casas decimais.
    Considerar o valor de π = 3.14159.

    EXEMPLO:
        Entrada:    2.5
        Saída:      Área = 19.6349
*/

const float pi = 3.14159f;
float area;

Console.WriteLine("====================================");
Console.WriteLine("   CALCULADORA DE ÁREA DE CÍRCULO   ");
Console.WriteLine("====================================\n");

Console.Write("> Digite o valor do raio: ");
string entrada = Console.ReadLine()!;
float.TryParse(entrada, out float raio);

area = pi * raio * raio;

Console.WriteLine($"\nÁrea = {area:F4}");
