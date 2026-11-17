/* 
Exercício 01:
    Faça um programa para ler o valor do raio de um círculo, e depois mostrar o  valor da área deste círculo 
    com quatro casas decimais. Considerar o valor de π = 3.14159.

    EXEMPLO:
        Entrada:    2.5
        Saída:      Área = 19.6349 u.a.
*/

const float pi = 3.14159f;

Console.Clear();
Console.WriteLine("====================================");
Console.WriteLine("   CALCULADORA DE ÁREA DE CÍRCULO   ");
Console.WriteLine("====================================\n");

Console.Write("> Digite o valor do raio: ");
string entrada = Console.ReadLine() ?? "0"; // Lê o raio informado pelo usuário
float.TryParse(entrada, out float raio);

if (raio < 0) {
    Console.WriteLine("\nO raio não pode ser negativo!");
}
else if (raio == 0) {
    Console.WriteLine("\nO raio não pode ser nulo!");
}
else {
    float area = pi * raio * raio; // Calcula a área do círculo (área = π * raio²)
    Console.WriteLine($"\nÁrea = {area:F4} u.a."); // Exibe o resultado com 4 casas decimais
}
