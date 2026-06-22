/* 
Exercício 01:
    Construa um algoritmo que calcule a média aritmética de um conjunto de números pares fornecidos pelo 
    usuário. O usuário deve fornecer primeiro a quantidade de números que serão digitados, e em seguida, 
    os números considerados na média. O usuário pode digitar números ímpares, que devem ser ignorados. 
    Por exemplo, no caso abaixo, o '5' informa que serão digitados 5 números (2 7 8 6 10), e para a média 
    devem ser considerados apenas os números pares (2 8 6 10), ignorando o número 7.

    EXEMPLO:
        Entrada:    5 2 7 8 6 10
        Saída:      Média dos números pares = 6.5
*/

double soma = 0, qnt = 0;
string[] numeros;

Console.WriteLine("============================");
Console.WriteLine("   MÉDIA DE NÚMEROS PARES   ");
Console.WriteLine("============================\n");

// O primeiro valor lido é a quantidade de números que serão digitados a seguir
Console.Write("> Digite a quantidade de números e os números (separados por espaço): ");
numeros = Console.ReadLine()!.Split();
int.TryParse(numeros[0], out int contador);

while (contador > 0) { // Percorre apenas os números digitados (ignorando a quantidade na posição 0)
    double.TryParse(numeros[contador], out double numero);

    if (numero % 2 == 0) {
        soma += numero;
        qnt++;
    }
    contador--; // Diminui o contador até que todos os números tenham sido lidos
}

if (qnt == 0) { // Se nenhum número par foi digitado
    Console.WriteLine("\nNenhum número par foi digitado.");
} 
else {      
    Console.WriteLine($"\nMédia dos números pares = {soma/qnt}");
}
