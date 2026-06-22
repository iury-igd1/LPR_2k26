/* 
Exercício 06:
    A tabela a seguir mostra a distância de quatro cidades entre si.

         |  VIT  |  BH  |  RJ  |  SP
    VIT  |   -   |  524 |  521 |  882
    BH   |  524  |  -   |  434 |  586
    RJ   |  521  |  434 |  -   |  429
    SP   |  882  |  586 |  429 |  - 

    Crie um programa que leia essa matriz e informe ao usuário a distância entre duas cidades por ele 
    fornecidas. O programa deve ficar repetindo até que o usuário informe a mesma cidade como origem e destino.

    EXEMPLO:
        Entrada:    RJ
                    SP
        Saída:      A distância entre RJ e SP é de 429 km.
*/

// Converte qualquer forma de digitar a cidade para o nome padrão
string parametroCidade (string cidade) {
    if (cidade == "0" || cidade.ToUpper() == "VIT" || cidade.ToUpper() == "VITORIA" || cidade.ToUpper() == "VITÓRIA") {
        return "Vitória";
    } 
    else if (cidade == "1" || cidade.ToUpper() == "BH" || cidade.ToUpper() == "BELO HORIZONTE") {
        return "Belo Horizonte";
    } 
    else if (cidade == "2" || cidade.ToUpper() == "RJ" || cidade.ToUpper() == "RIO DE JANEIRO") {
        return "Rio de Janeiro";
    } 
    else {
        return "São Paulo";
    }
}

// Converte o nome padrão da cidade no índice correspondente da matriz de distâncias
int indiceCidade (string cidade) {
    switch (cidade) {
        case "Vitória": 
            return 0; 
        case "Belo Horizonte": 
            return 1; 
        case "Rio de Janeiro": 
            return 2; 
        case "São Paulo": 
            return 3; 
        default:
            Console.WriteLine("\nCidade de origem inválida. Encerrando o programa.\n");
            return -1;
    }
}

// Matriz de distâncias (em km) entre as 4 cidades, na ordem: VIT, BH, RJ, SP
int[,] distancias = new int[4, 4] {
    { 0, 524, 521, 882 },
    { 524, 0, 434, 586 },
    { 521, 434, 0, 429 },
    { 882, 586, 429, 0 }
};

string origem, destino;
int distancia, iOrigem, iDestino;

while (true) { // Repete a consulta até o usuário informar a mesma cidade como origem e destino
    iOrigem = -1;
    iDestino = -1;

    Console.WriteLine("============================");
    Console.WriteLine("   CONSULTA DE DISTÂNCIAS   ");
    Console.WriteLine("============================\n");
    Console.WriteLine("Cidades disponíveis:\n");
    Console.WriteLine("[0] VIT - Vitória");
    Console.WriteLine("[1] BH  - Belo Horizonte");
    Console.WriteLine("[2] RJ  - Rio de Janeiro");
    Console.WriteLine("[3] SP  - São Paulo\n");

    Console.Write("> Cidade de origem: ");
    origem = Console.ReadLine() ?? "";
    origem = parametroCidade(origem);
    iOrigem = indiceCidade(origem);

    Console.Write("> Cidade de destino: ");
    destino = Console.ReadLine() ?? "";
    destino = parametroCidade(destino);

    if (origem == destino) {
        Console.WriteLine("\nOrigem e destino são a mesma cidade. Encerrando o programa.\n");
        break;
    } 
    else {
        iDestino = indiceCidade(destino);
    }

    // Consulta a distância na matriz usando os índices das cidades
    distancia = distancias[iOrigem, iDestino];
    Console.WriteLine($"\nA distância entre {origem} e {destino} é de {distancia} km.");
    Console.WriteLine("\nPressione ENTER para continuar...");
    Console.ReadLine();
}
