/* 
Exercício 03:
    Construa um algoritmo que leia 10 números inteiros. Depois solicite para o usuário um número que ele 
    gostaria de pesquisar no vetor. Caso o número exista no vetor, mostre em qual posição (ou quais) ele 
    aparece e quantas ocorrências foram detectadas. 

    EXEMPLO:
        Entrada:    5 8 7 9 6 4 10 8 10 9
                    8 
        Saída:      O número 8 aparece na(s) posição(ões): 2, 8 
                    Total de ocorrências = 2
*/

int[] numeros = new int[10];
int[] posicoes = new int[10];

Console.Clear();
Console.WriteLine("===============================");
Console.WriteLine("   ENCONTRAR NÚMERO NO VETOR   ");
Console.WriteLine("===============================\n");

Console.Write("> Digite 10 números inteiros (separados por espaço): ");
string[] entrada = (Console.ReadLine() ?? "").Split(' ');
// Lê os 10 números informados pelo usuário
for (int i = 0; i < 10; i++) {
    numeros[i] = int.Parse(entrada[i]);
}

// Lê o número a ser pesquisado no vetor
Console.Write("> Digite o número que deseja pesquisar: ");
int.TryParse(Console.ReadLine(), out int numeroPesquisa);

// Percorre o vetor guardando a posição de cada ocorrência encontrada
int ocorrencias = 0;
for (int i = 0; i < 10; i++) {
    if (numeros[i] == numeroPesquisa) {
        posicoes[ocorrencias] = i;
        ocorrencias++;
    }
}

if (ocorrencias == 0) {
    Console.WriteLine($"\nO número {numeroPesquisa} não existe no vetor.");
}
else {
    Console.Write($"\nO número {numeroPesquisa} aparece na(s) posição(ões): ");
    for (int i = 0; i < ocorrencias; i++) {
        Console.Write(posicoes[i] + 1);
        if (i < ocorrencias - 1) {
            Console.Write(", ");
        }
    }
    Console.WriteLine($"\nTotal de ocorrências = {ocorrencias}");
}
