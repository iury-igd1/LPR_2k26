/* 
Exercício 01:
    Crie um programa que permita ao usuário cadastrar notas de alunos em uma lista. 
    
    O programa deve:
      - Solicitar ao usuário 5 notas.
      - Armazenar as notas em uma lista.
      - Exibir:
          > Todas as notas cadastradas;
          > A maior nota;
          > A menor nota;
          > A média das notas.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <list> // Biblioteca para listas

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    list<int> notas;
    int nota, soma = 0;

    system("cls");
    cout << "=======================" << endl;
    cout << "   CADASTRO DE NOTAS   " << endl;
    cout << "=======================\n" << endl;

    for (int i = 1; i <= 5; i++) { // Lê os valores das 5 notas
        cout << "> Insira a " << i << "ª nota (0 a 100): ";
        cin >> nota;
        notas.push_back(nota); // Adiciona ao final da lista
        soma += nota;
    }

    auto itInicial = notas.begin(); // Aponta para o primeiro elemento da lista
    int maior = *itInicial; // O * acessa o valor apontado pelo iterador
    int menor = *itInicial;
    
    for (int i = 0; i < 5; i++) { // Percorre todos os valores da lista para verificar o maior e o menor
        auto it = notas.begin(); // Aponta para o primeiro elemento da lista
        advance(it, i); // Avança o iterador para o índice i
        if (*it > maior) {
            maior = *it;
        }
        if (*it < menor) {
            menor = *it;
        }
    }

    cout << "\nNotas cadastradas: ";
    for (int elemento : notas) { // Percorre todos os elementos da lista
        cout << elemento << " ";
    }
    cout << "\nMaior nota: " << maior << endl;
    cout << "Menor nota: " << menor << endl;
    cout << "Média das notas: " << (soma / 5.0) << endl;
}