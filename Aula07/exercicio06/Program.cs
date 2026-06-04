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

int[,] distancias = new int[4, 4]
{
    { 0, 524, 521, 882 },
    { 524, 0, 434, 586 },
    { 521, 434, 0, 429 },
    { 882, 586, 429, 0 }
};

string origem, destino;
int distancia = 0, iOrigem = -1, iDestino = -1;

while (true)
{
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
    if (origem.ToUpper() == "0" || origem.ToUpper() == "vit" || origem.ToUpper() == "VIT" || origem.ToUpper() == "vitoria" || origem.ToUpper() == "vitória" || origem.ToUpper() == "Vitória" || origem.ToUpper() == "Vitoria" || origem.ToUpper() == "VITORIA" || origem.ToUpper() == "VITÓRIA") {
        origem = "VIT";
    } 
    else if (origem.ToUpper() == "1" || origem.ToUpper() == "bh" || origem.ToUpper() == "BH" || origem.ToUpper() == "belo horizonte" || origem.ToUpper() == "Belo Horizonte") {
        origem = "BH";
    } 
    else if (origem.ToUpper() == "2" || origem.ToUpper() == "rj" || origem.ToUpper() == "RJ" || origem.ToUpper() == "rio de janeiro" || origem.ToUpper() == "Rio de Janeiro") {
        origem = "RJ";
    } 
    else if (origem.ToUpper() == "3" || origem.ToUpper() == "sp" || origem.ToUpper() == "SP" || origem.ToUpper() == "são paulo" || origem.ToUpper() == "São Paulo" || origem.ToUpper() == "sao paulo" || origem.ToUpper() == "Sao Paulo") {
        origem = "SP";
    }

    switch (origem) {
        case "VIT": 
            iOrigem = 0; 
            break;
        case "BH": 
            iOrigem = 1; 
            break;
        case "RJ": 
            iOrigem = 2; 
            break;
        case "SP": 
            iOrigem = 3; 
            break;
        default:
            Console.WriteLine("\nCidade de origem inválida. Encerrando o programa.\n");
            return;
    }

    Console.Write("> Cidade de destino: ");
    destino = Console.ReadLine() ?? "";
    if (destino.ToUpper() == "0" || destino.ToUpper() == "vit" || destino.ToUpper() == "VIT" || destino.ToUpper() == "vitoria" || destino.ToUpper() == "vitória" || destino.ToUpper() == "Vitória" || destino.ToUpper() == "Vitoria" || destino.ToUpper() == "VITORIA" || destino.ToUpper() == "VITÓRIA") {
        destino = "VIT";
    } 
    else if (destino.ToUpper() == "1" || destino.ToUpper() == "bh" || destino.ToUpper() == "BH" || destino.ToUpper() == "belo horizonte" || destino.ToUpper() == "Belo Horizonte") {
        destino = "BH";
    } 
    else if (destino.ToUpper() == "2" || destino.ToUpper() == "rj" || destino.ToUpper() == "RJ" || destino.ToUpper() == "rio de janeiro" || destino.ToUpper() == "Rio de Janeiro") {
        destino = "RJ";
    } 
    else if (destino.ToUpper() == "3" || destino.ToUpper() == "sp" || destino.ToUpper() == "SP" || destino.ToUpper() == "são paulo" || destino.ToUpper() == "São Paulo" || destino.ToUpper() == "sao paulo" || destino.ToUpper() == "Sao Paulo") {
        destino = "SP";
    }

    if (origem.ToUpper() == destino.ToUpper()) {
        Console.WriteLine("\nOrigem e destino são a mesma cidade. Encerrando o programa.\n");
        break;
    } 
    else {
        switch (destino.ToUpper()) {
            case "VIT": 
                iDestino = 0; 
                break;
            case "BH": 
                iDestino = 1; 
                break;
            case "RJ": 
                iDestino = 2; 
                break;
            case "SP": 
                iDestino = 3; 
                break;
            default:
                Console.WriteLine("\nCidade de destino inválida. Encerrando o programa.\n");
                return;
        }

        distancia = distancias[iOrigem, iDestino];
        Console.WriteLine($"\nA distância entre {origem.ToUpper()} e {destino.ToUpper()} é de {distancia} km.");
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
}
