/* 
Exercício 01:
    Faça um programa para ler um número inteiro e depois dizer se este número é par ou não.

    EXEMPLO:
        Entrada:    10
        Saída:      O número informado é PAR
    EXEMPLO:
        Entrada:    11
        Saída:      O número informado é ÍMPAR
*/

Console.Clear();
Console.WriteLine("============================");
Console.WriteLine("   ANALISADOR DE PARIDADE   ");
Console.WriteLine("============================\n");

// Lê o número informado pelo usuário
Console.Write("> Digite um número inteiro: ");
string entrada = Console.ReadLine()!;
int.TryParse(entrada, out int num);

if (num % 2 == 0) { // Um número é par quando o resto da divisão por 2 é zero
    Console.WriteLine("\nO número informado é PAR");
} 
else {
    Console.WriteLine("\nO número informado é ÍMPAR");
}
