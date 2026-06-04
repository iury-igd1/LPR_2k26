/* 
Exercício 03:
    Construa um algoritmo que leia 10 números inteiros. Depois solicite para o usuário um número que ele 
    gostaria de pesquisar no vetor. Caso o número exista no vetor, mostre em qual posição (ou quais) ele 
    aparece e quantas ocorrências foram detectadas. 

    EXEMPLO:
        Entrada:    5 8 7 9 6 4 10 8 10 9 
                    8 
        Saída:      O número 8 aparece nas posições: 2, 8 
                    Total de ocorrências = 2
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

    vector<int> numeros(10);
    vector<int> posicoes(10);
    
    cout << "===============================" << endl;
    cout << "   ENCONTRAR NÚMERO NO VETOR   " << endl;
    cout << "===============================\n" << endl;

    cout << "> Digite 10 números inteiros (separados por espaço): ";
    for (int i = 0; i < 10; i++) {
        cin >> numeros[i];
    }

    cout << "> Digite o número que deseja pesquisar: ";
    int numeroPesquisa;
    cin >> numeroPesquisa;

    int ocorrencias = 0;
    for (int i = 0; i < 10; i++) {
        if (numeros[i] == numeroPesquisa) {
            posicoes[ocorrencias] = i;
            ocorrencias++;
        }
    }

    if (ocorrencias == 0) {
        cout << "\nO número " << numeroPesquisa << " não existe no vetor." << endl;
    }
    else {
        cout << "\nO número " << numeroPesquisa << " aparece na(s) posição(ões): ";
        for (int i = 0; i < ocorrencias; i++) {
            cout << posicoes[i] + 1;
            if (i < ocorrencias - 1) {
                cout << ", ";
            }
        }
        cout << "\nTotal de ocorrências = " << ocorrencias << endl;
    }
}
