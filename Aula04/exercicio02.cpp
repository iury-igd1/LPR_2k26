/* 
Exercício 02:
    Faça um programa que leia 2 valores inteiros (A e B). Após, 
    o programa deve mostrar uma mensagem "São Múltiplos" ou "Não 
    são Múltiplos", indicando se os valores lidos são múltiplos 
    entre si. 
    Atenção: os números podem ser digitados em ordem crescente 
    ou decrescente.

    EXEMPLO:
        Entrada:    36 6
        Saída:      São Múltiplos
*/

#include <iostream>
#include <iomanip>
#include <locale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int A, B;

    cout << "Digite dois números inteiros: ";

    cin >> A >> B;

    if (A % B == 0 || B % A == 0) {
        cout << "São Múltiplos" << endl;
    } else {
        cout << "Não são Múltiplos" << endl;
    }
}
