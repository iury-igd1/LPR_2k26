/* 
Exercício 03:
    Faça um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe 
    por hora e calcule o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com 
    duas casas decimais.
    
    EXEMPLO:
        Entrada:    1
                    200
                    20.50
        Saída:      Número = 1
                    Salário = R$ 4100.00
*/

Console.Clear();
Console.WriteLine("===========================================");
Console.WriteLine("   CALCULADORA DE SALÁRIO DE FUNCIONÁRIO   ");
Console.WriteLine("===========================================\n");
Console.WriteLine("Informe os dados do funcionário:\n");

// Lê os dados do funcionário
Console.Write("> Número: ");
int.TryParse(Console.ReadLine(), out int numero);

Console.Write("> Horas trabalhadas: ");
int.TryParse(Console.ReadLine(), out int horas);
if (horas <= 0) {
    Console.WriteLine("\nQuantidade de horas não pode ser negativa ou nula!");
    return;
}

Console.Write("> Valor por hora: ");
decimal.TryParse(Console.ReadLine(), out decimal valorHora);
if (valorHora <= 0) {
    Console.WriteLine("\nValor por hora não pode ser negativo ou nulo!");
    return;
}

decimal salario = horas * valorHora; // Calcula o salário (horas trabalhadas * valor por hora)

Console.WriteLine($"\nNúmero = {numero}");
Console.WriteLine($"Salário = R$ {salario:F2}");
