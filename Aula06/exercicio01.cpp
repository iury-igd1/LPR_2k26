/* 
Exercício 01:
    Construa uma função em que retorne o reverso de um número 
    inteiro.

    EXEMPLO:
        Entrada:    1234
        Saída:      O inverso desse número é: 4321
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>

using namespace std;

void inversoNumero (int numero) {
    string num = to_string(numero);
    string resultado = "";

    for (int i = num.length(); i >= 1; i--) {
        char digito = num[i-1];
        resultado += digito;
    }

    cout << "O inverso desse número é: " << resultado << endl;
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int numero_usuario;

    cout << "Digite um número inteiro: ";
    cin >> numero_usuario;

    inversoNumero(numero_usuario);
}
