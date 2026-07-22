/* 
Exercício 05:
    Construa um algoritmo que leia uma matriz 3x3 de números inteiros. Ao final, o programa deverá mostrar a 
    matriz digitada e calcular a soma de todos os elementos da matriz.

    EXEMPLO:
        Entrada:    1 2 3 4 5 6 7 8 9
        Saída:      Matriz informda:
                    1 2 3
                    4 5 6
                    7 8 9
                    Soma dos elementos = 45
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "===========================" << endl;
    cout << "   LEITURA DE MATRIZ 3X3   " << endl;
    cout << "===========================\n" << endl;

    int matriz[3][3];

    // Lê os 9 elementos da matriz 3x3
    cout << "> Digite os elementos da matriz 3x3 (9 números inteiros separados por espaço): ";
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cin >> matriz[i][j];
        }
    }

    int soma = 0;

    // Exibe a matriz e soma todos os elementos ao mesmo tempo
    cout << "\nMatriz informada:" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << matriz[i][j] << " ";
            soma += matriz[i][j];
        }
        cout << endl;
    }

    cout << "\nSoma dos elementos = " << soma << endl;
}
