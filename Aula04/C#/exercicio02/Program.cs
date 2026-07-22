/* 
Exercício 02:
    Faça um programa que leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São 
    Múltiplos" ou "Não são Múltiplos", indicando se os valores lidos são múltiplos entre si. 
    Atenção: os números podem ser digitados em ordem crescente ou decrescente.

    EXEMPLO:
        Entrada:    36 6
        Saída:      São Múltiplos
*/

Console.Clear();
Console.WriteLine("=============================");
Console.WriteLine("   ANALISADOR DE MÚLTIPLOS   ");
Console.WriteLine("=============================\n");

// Lê os dois números informados pelo usuário
Console.Write("> Digite dois números inteiros (separados por espaço): ");
string[] entrada = (Console.ReadLine() ?? "").Split(' ');
int.TryParse(entrada[0], out int A);
int.TryParse(entrada[1], out int B);

if (A == 0 || B == 0) { // Zero não pode ser divisor
    Console.WriteLine("\nZero não é um número válido para análise de múltiplos.");
} 
else if (A % B == 0 || B % A == 0) { // Um é múltiplo do outro se a divisão entre eles tiver resto zero
    Console.WriteLine("\nSão Múltiplos");
} 
else {
    Console.WriteLine("\nNão são Múltiplos");
}
