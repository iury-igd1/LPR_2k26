/* 
Exercício 01:
    Construa um algoritmo que leia 5 números inteiros e os armazene em um vetor. Ao final, o programa deve 
    exibir todos os números digitados, o maior valor armazenado e a posição em que esse valor se encontra.

    EXEMPLO:
        Entrada:    8 3 12 7 5
        Saída:      Vetor = 8 3 12 7 5
                    Maior valor = 12
                    Posição = 3
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>
#include <vector>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    vector<int> numeros(5);

    system("cls");
    cout << "======================" << endl;
    cout << "   ANÁLISE DE VETOR   " << endl;
    cout << "======================\n" << endl;

    // Lê os 5 números informados pelo usuário e armazena no vetor
    cout << "> Digite 5 números inteiros (separados por espaço): ";
    for (int i = 0; i < 5; i++) {
        cin >> numeros[i];
    }

    int maior = numeros[0], posicao = 0;
    for (int i = 1; i < 5; i++) { // Percorre o vetor para encontrar o maior valor e sua posição
        if (numeros[i] > maior) {
            maior = numeros[i];
            posicao = i + 1;
        }
    }

    cout << "\nVetor = ";
    for (int i = 0; i < 5; i++) {
        cout << numeros[i] << " ";
    }
    cout << endl;
    cout << "Maior valor = " << maior << endl;
    cout << "Posição = " << posicao << endl;
}
