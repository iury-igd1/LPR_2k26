/* 
Exercício 01:
    Construa uma função que retorne o reverso de um número inteiro.

    EXEMPLO:
        Entrada:    1234
        Saída:      O inverso desse número é: 4321
*/

#include <iostream>
#include <locale>
#include <cstdlib>
#include <string>

using namespace std;

long long inversoNumero(long long numero) { // Inverte a ordem dos dígitos, preservando o sinal do número
    string num = to_string(numero);
    string resultado = "";

    if (num[0] == '-') {
        resultado += "-";
        // Percorre a string do número de trás para frente, juntando cada dígito em uma string
        for (int i = num.length(); i > 1; i--) {
            char digito = num[i - 1];
            resultado += digito;
        }
    }
    else {
        // Percorre a string do número de trás para frente, juntando cada dígito em uma string
        for (int i = num.length(); i >= 1; i--) {
            char digito = num[i - 1];
            resultado += digito;
        }
    }

    return stoll(resultado); // Converte o texto invertido para número, eliminando zeros à esquerda
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    long long numeroUsuario;

    system("cls");
    cout << "=========================" << endl;
    cout << "   INVERSOR DE NÚMEROS   " << endl;
    cout << "=========================\n" << endl;

    // Lê o número informado pelo usuário
    cout << "> Digite um número inteiro: ";
    cin >> numeroUsuario;

    long long resultado = inversoNumero(numeroUsuario);
    cout << "\nO inverso desse número é: " << resultado << endl;
}
