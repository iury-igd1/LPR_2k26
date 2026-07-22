/* 
Exercício 03:
    Elabore um algoritmo que calcule a soma de todos os números ímpares múltiplos de 3 que se encontrem no 
    conjunto dos números de 50 a 500.

        Saída:      Soma dos números = 20475
*/

int soma = 0;

// Começa em 51 (primeiro múltiplo de 3 ímpar acima de 50) e avança de 3 em 3 filtrando apenas os ímpares
for (int i = 51; i <= 500; i += 3) {
    if (i % 2 == 1) {
        soma += i;
    }
}

Console.Clear();
Console.WriteLine("=============================");
Console.WriteLine("   SOMA DOS MÚLTIPLOS DE 3   ");
Console.WriteLine("=============================\n");

Console.WriteLine($"Soma dos números = {soma}");
