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

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>
#include <algorithm>
#include <cstdlib>

using namespace std;

// Converte uma string para maiúsculas, facilitando a comparação
string paraMaiusculas(string texto) {
    transform(texto.begin(), texto.end(), texto.begin(), ::toupper);
    return texto;
}

// Converte qualquer forma de digitar a cidade para o nome padrão
string parametroCidade(string cidade) {
    string upper = paraMaiusculas(cidade);
    if (cidade == "0" || upper == "VIT" || upper == "VITORIA" || upper == "VITÓRIA") {
        return "Vitória";
    } 
    else if (cidade == "1" || upper == "BH" || upper == "BELO HORIZONTE") {
        return "Belo Horizonte";
    } 
    else if (cidade == "2" || upper == "RJ" || upper == "RIO DE JANEIRO") {
        return "Rio de Janeiro";
    } 
    else {
        return "São Paulo";
    }
}

// Converte o nome padrão da cidade no índice correspondente da matriz de distâncias
int indiceCidade(string cidade) {
    if (cidade == "Vitória") return 0;
    if (cidade == "Belo Horizonte") return 1;
    if (cidade == "Rio de Janeiro") return 2;
    if (cidade == "São Paulo") return 3;

    cout << "\nCidade de origem inválida. Encerrando o programa.\n" << endl;
    return -1;
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    // Matriz de distâncias (em km) entre as 4 cidades, na ordem: VIT, BH, RJ, SP
    int distancias[4][4] = {
        { 0, 524, 521, 882 },
        { 524, 0, 434, 586 },
        { 521, 434, 0, 429 },
        { 882, 586, 429, 0 }
    };

    string origem, destino;
    int distancia = 0, iOrigem = -1, iDestino = -1;

    while (true) { // Repete a consulta até o usuário informar a mesma cidade como origem e destino
        iOrigem = -1;
        iDestino = -1;

        system("cls");
        cout << "============================" << endl;
        cout << "   CONSULTA DE DISTÂNCIAS   " << endl;
        cout << "============================\n" << endl;
        cout << "Cidades disponíveis:\n" << endl;
        cout << "[0] VIT - Vitória" << endl;
        cout << "[1] BH  - Belo Horizonte" << endl;
        cout << "[2] RJ  - Rio de Janeiro" << endl;
        cout << "[3] SP  - São Paulo\n" << endl;

        cout << "> Cidade de origem: ";
        getline(cin, origem);
        origem = parametroCidade(origem);
        iOrigem = indiceCidade(origem);

        cout << "> Cidade de destino: ";
        getline(cin, destino);
        destino = parametroCidade(destino);

        if (origem == destino) {
            cout << "\nOrigem e destino são a mesma cidade. Encerrando o programa.\n" << endl;
            break;
        } 
        else {
            iDestino = indiceCidade(destino);
        }

        // Consulta a distância na matriz usando os índices das cidades
        distancia = distancias[iOrigem][iDestino];
        cout << "\nA distância entre " << origem << " e " << destino << " é de " << distancia << " km." << endl;
        cout << "\nPressione ENTER para continuar...";
        getline(cin, origem);
    }
}
