/* 
Exercício 02:
    Faça um programa que leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "São 
    Múltiplos" ou "Não são Múltiplos", indicando se os valores lidos são múltiplos entre si. 
    Atenção: os números podem ser digitados em ordem crescente ou decrescente.

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

    cout << "=============================" << endl;
    cout << "   ANALISADOR DE MÚLTIPLOS   " << endl;
    cout << "=============================\n" << endl;

    cout << "> Digite dois números inteiros (separados por espaço): ";

    cin >> A >> B;

    if (A == 0 || B == 0) {
        cout << "\nZero não é um número válido para análise de múltiplos." << endl;
    } 
    else if (A % B == 0 || B % A == 0) {
        cout << "\nSão Múltiplos" << endl;
    } 
    else {
        cout << "\nNão são Múltiplos" << endl;
    }
}
