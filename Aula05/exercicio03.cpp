/* 
Exercício 03:
    Elabore um algoritmo que calcule a soma de todos os números 
    ímpares múltiplos de 3 que se encontrem no conjunto dos 
    números de 50 a 500.

        Saída:      Soma dos números: 20475
*/

#include <iostream>
#include <iomanip>
#include <locale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int soma = 0;

    for (int i = 51; i <= 500; i += 3) {
        if ((i % 2 == 1)) {
            soma += i;
        }
    }

    cout << "Soma dos números: " << soma << endl;
}
