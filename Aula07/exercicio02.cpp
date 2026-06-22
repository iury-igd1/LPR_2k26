/* 
Exercício 02:
    Construa um algoritmo que leia 10 números inteiros e armazene-os em um vetor (use o for para fazer a 
    leitura). Depois, crie automaticamente dois vetores, um contendo apenas os números pares e outro os 
    números ímpares digitados. 

    EXEMPLO:
        Entrada:    5 8 7 9 6 4 10 8 10 9 
        Saída:      Números pares   = 8 6 4 10 8 10
                    Números ímpares = 5 7 9 9
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <vector>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    vector<int> numeros(10);
    int contPares = 0, contImpares = 0;

    cout << "==========================" << endl;
    cout << "   SEPARADOR DE NÚMEROS   " << endl;
    cout << "==========================\n" << endl;

    // Lê os 10 números e já conta quantos são pares e quantos são ímpares
    cout << "> Digite 10 números inteiros (separados por espaço): ";
    for (int i = 0; i < 10; i++) {
        cin >> numeros[i];

        if (numeros[i] % 2 == 0) {
            contPares++;
        } 
        else {
            contImpares++;
        }
    }

    // Cria os vetores de pares e ímpares já com o tamanho exato necessário
    vector<int> pares(contPares);
    vector<int> impares(contImpares);

    int iPares = 0, iImpares = 0;

    for (int i = 0; i < (int)numeros.size(); i++) { // Distribui cada número lido no vetor de pares ou de ímpares
        if (numeros[i] % 2 == 0) {
            pares[iPares] = numeros[i];
            iPares++;
        } 
        else {
            impares[iImpares] = numeros[i];
            iImpares++;
        }
    }

    cout << "\nNúmeros pares   = ";
    for (int par : pares) {
        cout << par << " ";
    }

    cout << "\nNúmeros ímpares = ";
    for (int impar : impares) {
        cout << impar << " ";
    }
    cout << endl;
}
