/* 
Exercício 07:
    Crie um algoritmo que leia duas matrizes A e B, de tamanho 3x3, e calcule A * B.

    EXEMPLO:
        Entrada:    1 2 0 3 -1 4 2 0 1
                    2 1 3 0 4 -1 1 2 0 
        Saída:      Matriz A * B =
                    2 9 1
                    10 7 10
                    5 4 6
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>
#include <vector>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int a, b, c, d, e, f, g, h, i;

    cout << "===============================" << endl;
    cout << "   MULTIPLICAÇÃO DE MATRIZES   " << endl;
    cout << "===============================\n" << endl;

    // Lê os 9 elementos da primeira matriz
    cout << "> Digite os 9 elementos da primeira matriz 3x3 (separados por espaço): ";
    cin >> a >> b >> c >> d >> e >> f >> g >> h >> i;
    int matrizA[3][3] = {{a, b, c}, {d, e, f}, {g, h, i}};

    // Lê os 9 elementos da segunda matriz
    cout << "> Digite os 9 elementos da segunda matriz 3x3 (separados por espaço):  ";
    cin >> a >> b >> c >> d >> e >> f >> g >> h >> i;
    int matrizB[3][3] = {{a, b, c}, {d, e, f}, {g, h, i}};

    // Calcula cada elemento da matriz resultante: linha de A * coluna de B
    int matrizMultiplicacao[3][3];
    matrizMultiplicacao[0][0] = matrizA[0][0] * matrizB[0][0] + matrizA[0][1] * matrizB[1][0] + matrizA[0][2] * matrizB[2][0];
    matrizMultiplicacao[0][1] = matrizA[0][0] * matrizB[0][1] + matrizA[0][1] * matrizB[1][1] + matrizA[0][2] * matrizB[2][1];
    matrizMultiplicacao[0][2] = matrizA[0][0] * matrizB[0][2] + matrizA[0][1] * matrizB[1][2] + matrizA[0][2] * matrizB[2][2];
    matrizMultiplicacao[1][0] = matrizA[1][0] * matrizB[0][0] + matrizA[1][1] * matrizB[1][0] + matrizA[1][2] * matrizB[2][0];
    matrizMultiplicacao[1][1] = matrizA[1][0] * matrizB[0][1] + matrizA[1][1] * matrizB[1][1] + matrizA[1][2] * matrizB[2][1];
    matrizMultiplicacao[1][2] = matrizA[1][0] * matrizB[0][2] + matrizA[1][1] * matrizB[1][2] + matrizA[1][2] * matrizB[2][2];
    matrizMultiplicacao[2][0] = matrizA[2][0] * matrizB[0][0] + matrizA[2][1] * matrizB[1][0] + matrizA[2][2] * matrizB[2][0];
    matrizMultiplicacao[2][1] = matrizA[2][0] * matrizB[0][1] + matrizA[2][1] * matrizB[1][1] + matrizA[2][2] * matrizB[2][1];
    matrizMultiplicacao[2][2] = matrizA[2][0] * matrizB[0][2] + matrizA[2][1] * matrizB[1][2] + matrizA[2][2] * matrizB[2][2];
   
    cout << endl;
    cout << "Matriz A * B =" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << matrizMultiplicacao[i][j] << " ";
        }
        cout << endl;
    }
}
