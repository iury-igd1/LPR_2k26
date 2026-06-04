/* 
Exercício 01:
    Construa uma função que retorne o reverso de um número inteiro.

    EXEMPLO:
        Entrada:    1234
        Saída:      O inverso desse número é: 4321
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>

using namespace std;

string inversoNumero (int numero) {
    string num = to_string(numero);
    string resultado = "";

    for (int i = num.length(); i >= 1; i--) {
        char digito = num[i-1];
        resultado += digito;
    }

    return resultado;
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int numero_usuario;

    cout << "=========================" << endl;
    cout << "   INVERSOR DE NÚMEROS   " << endl;
    cout << "=========================\n" << endl;

    cout << "> Digite um número inteiro: ";
    cin >> numero_usuario;

    string resultado = inversoNumero(numero_usuario);
    cout << "\nO inverso desse número é: " << resultado << endl;
}
