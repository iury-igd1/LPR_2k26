/* 
Exercício 01:
    Construa um algoritmo que calcule a média aritmética de um 
    conjunto de números pares fornecidos pelo usuário. O usuário 
    deve fornecer primeiro a quantidade de números que serão 
    digitados, e em seguida, os números considerados na média. O 
    usuário pode digitar números ímpares, que devem ser ignorados. 
    Por exemplo, no caso abaixo, o '5' informa que serão digitados 
    5 números (2 7 8 6 10), e para a média devem ser considerados 
    apenas os números pares (2 8 6 10), ignorando o número 7.

    EXEMPLO:
        Entrada:    5 2 7 8 6 10
        Saída:      Média dos números: 6.5
*/

using System.Diagnostics;

double soma = 0, qnt = 0;
string[] numeros;

Console.Write("Digite a quantidade de números e os números: ");
numeros = Console.ReadLine()!.Split();
int contador = Convert.ToInt32(numeros[0]);

while (contador > 0) {
    double numero = Convert.ToDouble(numeros[contador]);

    if (numero % 2 == 0) {
        soma += numero;
        qnt++;
    }
    contador--;
}

Console.WriteLine($"Média dos números: {soma/qnt}");
