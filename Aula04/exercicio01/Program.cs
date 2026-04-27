/* 
Exercício 01:
    Faça um programa para ler um número inteiro, e depois dizer se este número 
    é par ou não.

    EXEMPLO:
        Entrada:    10
        Saída:      Este número é PAR
*/

Console.Write("Digite um número inteiro: ");
string entrada = Console.ReadLine()!;
int.TryParse(entrada, out int num);

if (num % 2 == 0) {
    Console.WriteLine("Este número é PAR");
} else {
    Console.WriteLine("Este número é ÍMPAR");
}
