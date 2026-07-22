/* 
Exercício 03:
    Construa uma lista de 100 números aleatórios. Crie um algoritmo que coloque-os em ordem crescente e 
    imprima-os. A partir dessa lista ordenada, remova todos os números pares e imprima a lista novamente.
    Por fim, imprima quais números se repetem, se existe algum número repetido.
*/

#include <iostream>
#include <locale>
#include <cstdlib>
#include <algorithm> 
#include <list> // Biblioteca para listas
#include <ctime>

using namespace std;

list<int> numeros;

void imprimirLista() {
    int contador = 0;
    for (int n : numeros) {
        cout << n << " ";
        contador++;

        if (contador % 40 == 0) { // Quebra a linha a cada 40 números
            cout << endl;
        }
    }
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");
    srand(time(NULL));

    system("cls");
    cout << "=================================" << endl;
    cout << "   LISTA DE NÚMEROS ALEATÓRIOS   " << endl;
    cout << "=================================\n" << endl;

    for (int i = 0; i < 100; i++) { // Gera 100 números aleatórios e adiciona na lista
        int numero = rand() % 101;
        numeros.push_back(numero);
    }

    cout << "Números da lista: " << endl;
    imprimirLista();

    numeros.sort(); // Ordena a lista em ordem crescente
    cout << "\n\nLista em ordem crescente: " << endl;
    imprimirLista();

    list<int> pares; // Cria uma lista de números pares
    for (int i = 0; i <= 100; i += 2) {
        pares.push_back(i);
    }
    for (auto it = numeros.begin(); it != numeros.end(); ) {
        // Verifica se o valor *it existe na lista pares
        if (find(pares.begin(), pares.end(), *it) != pares.end()) {
            it = numeros.erase(it); // Remove o elemento atual
        }
        else {
            it++;
        }
    }

    cout << "\n\nLista com os números ímpares: " << endl;
    imprimirLista();

    cout << "\n\nNúmeros repetidos encontrados na lista: " << endl;
    list<int> listaParalela;
    list<int> impressos;
    bool repetido = false;

    for (auto it = numeros.begin(); it != numeros.end(); ) {
        // Se o número está na listaParalela, ele é repetido
        if (find(listaParalela.begin(), listaParalela.end(), *it) != listaParalela.end()) {
            if (find(impressos.begin(), impressos.end(), *it) == impressos.end()) {
                cout << *it << " ";
                impressos.push_back(*it);
                repetido = true;
            }
            it = numeros.erase(it); // Remove o número repetido da lista principal
        }
        else {
            listaParalela.push_back(*it);
            it++;
        }
    }
    if (repetido == false) {
        cout << "Não há nenhum elemento repetido na lista." << endl;
    }

    cout << "\n\nLista final (sem pares e sem repetições): " << endl;
    imprimirLista();
}