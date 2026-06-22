/* 
Exercício 02:
    Construa um algoritmo que agrupe em funções os exercícios 1, 3 e 4 da Aula 05. Cada exercício deve estar 
    contido em uma função separada. Defina os parâmetros de modo eficiente e generalista. 
    Construa um menu na função main. 

    EXEMPLO:
        Entrada:    1
                    5 2 7 8 6 10
        Saída:      Média dos números = 6.50
    EXEMPLO:
        Entrada:    3
        Saída:      Soma dos números = 20475
    EXEMPLO:
        Entrada:    4
        Saída:      Soma dos dígitos do quadrado = 7
*/

void Exercicio01() { // Média dos números pares informados
    int soma = 0, qtd = 0;

    Console.Write("\n> Digite a quantidade de números e os números (separados por espaço): ");
    string[] entrada = Console.ReadLine()!.Split();

    int n = int.Parse(entrada[0]);

    for (int i = 1; i <= n; i++) {
        int valor = int.Parse(entrada[i]);

        if (valor % 2 == 0) {
            soma += valor;
            qtd++;
        }
    }

    Console.WriteLine($"\nMédia dos números = {(double)soma / qtd:F2}");
}

void Exercicio03() { // Soma dos ímpares múltiplos de 3 entre 50 e 500
    int soma = 0;

    for (int i = 51; i <= 500; i += 3) {
        if (i % 2 == 1) {
            soma += i;
        }
    }

    Console.WriteLine($"\nSoma dos números = {soma}");
}

void Exercicio04() { // Soma dos dígitos do quadrado de um número
    int soma = 0;

    Console.Write("\n> Digite um número inteiro: ");
    int numero = int.Parse(Console.ReadLine()!);

    int quadrado = numero * numero;
    string quad = quadrado.ToString();

    for (int i = 0; i < quad.Length; i++)
    {
        int digito = quad[i] - '0'; // Converte o caractere numérico em inteiro
        soma += digito;
    }

    Console.WriteLine($"\nSoma dos dígitos do quadrado = {soma}");
}

Console.WriteLine("===========================");
Console.WriteLine("   CENTRAL DE EXERCÍCIOS   ");
Console.WriteLine("===========================\n");
Console.WriteLine("1 - Média de números pares");
Console.WriteLine("3 - Soma dos ímpares múltiplos de 3 entre 50 a 500");
Console.WriteLine("4 - Soma dos dígitos do quadrado");
Console.WriteLine("0 - Sair");

Console.Write("\n> Digite a opção desejada: ");
int opcao = int.Parse(Console.ReadLine()!);

switch (opcao) { // Encaminha para a função correspondente à opção escolhida
    case 1:
        Exercicio01();
        break;
    case 3:
        Exercicio03();
        break;
    case 4:
        Exercicio04();
        break;
    case 0:
        Console.WriteLine("\nEncerrando programa.");
        break;
    default:
        Console.WriteLine("\nOpção inválida.");
        break;
}