/* 
Exercício 03:
    A tabela a seguir mostra a distância de quatro cidades entre si.

         |  VIT  |  BH  |  RJ  |  SP
    VIT  |   -   |  524 |  521 |  882
    BH   |  524  |  -   |  434 |  586
    RJ   |  521  |  434 |  -   |  429
    SP   |  882  |  586 |  429 |  - 

    Crie um programa que leia essa matriz e informe ao usuário a distância 
    entre duas cidades por ele fornecidas. O programa deve ficar repetindo 
    até que o usuário informe a mesma cidade como origem e destino.

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
    Console.Write("Digite a cidade de origem (VIT, BH, RJ, SP): ");
    origem = Console.ReadLine() ?? "";

    Console.Write("Digite a cidade de destino (VIT, BH, RJ, SP): ");
    destino = Console.ReadLine() ?? "";

    if (origem == destino) {
        Console.WriteLine("\nOrigem e destino são a mesma cidade. Encerrando o programa.\n");
        break;
    } 
    else
    {
        switch (origem)
        {
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
                Console.WriteLine("Cidade inválida.");
                return;
        }

        switch (destino)
        {
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
                Console.WriteLine("Cidade inválida.");
                return;
        }

        distancia = distancias[iOrigem, iDestino];
        Console.WriteLine($"\nA distância entre {origem} e {destino} é de {distancia} km.\n");
    }
}