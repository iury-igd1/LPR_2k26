/* 
Exercício 01:
    Faça um programa para ler um número inteiro, e depois dizer se este número é par ou não.

    EXEMPLO:
        Entrada:    10
        Saída:      O número informado é PAR
*/

#include <iostream>
#include <iomanip>
#include <locale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int num;

    cout << "============================" << endl;
    cout << "   ANALISADOR DE PARIDADE   " << endl;
    cout << "============================\n" << endl;

    // Lê o número informado pelo usuário
    cout << "> Digite um número inteiro: ";
    cin >> num;

    if (num % 2 == 0) { // Um número é par quando o resto da divisão por 2 é zero
        cout << "\nO número informado é PAR" << endl;
    } 
    else {
        cout << "\nO número informado é ÍMPAR" << endl;
    }
}
