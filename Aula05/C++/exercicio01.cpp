/* 
Exercício 01:
    Construa um algoritmo que calcule a média aritmética de um conjunto de números pares fornecidos pelo 
    usuário. O usuário deve fornecer primeiro a quantidade de números que serão digitados, e em seguida, 
    os números considerados na média. O usuário pode digitar números ímpares, que devem ser ignorados. 
    Por exemplo, no caso abaixo, o '5' informa que serão digitados 5 números (2 7 8 6 10), e para a média 
    devem ser considerados apenas os números pares (2 8 6 10), ignorando o número 7.

    EXEMPLO:
        Entrada:    5 2 7 8 6 10
        Saída:      Média dos números pares = 6.5
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    double soma = 0, qnt = 0;
    int contador;

    system("cls");
    cout << "============================" << endl;
    cout << "   MÉDIA DE NÚMEROS PARES   " << endl;
    cout << "============================\n" << endl;

    // Lê a quantidade de números que serão digitados
    cout << "> Digite a quantidade de números e os números (separados por espaço): ";
    cin >> contador;

    while (contador > 0) { // Percorre a quantidade de números informada pelo usuário
        int numero;
        cin >> numero; // Lê um número digitado pelo usuário

        if (numero % 2 == 0) {
            soma += numero;
            qnt++;
        }
        contador--; // Diminui o contador até que todos os números tenham sido lidos
    }

    if (qnt == 0) { // Se nenhum número par foi digitado
        cout << "\nNenhum número par foi digitado." << endl;
    } 
    else {
        cout << "\nMédia dos números pares = " << (soma / qnt) << endl;
    }
}
