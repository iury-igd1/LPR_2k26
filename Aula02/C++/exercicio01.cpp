/* 
Exercício 01:
    Faça um programa para ler o valor do raio de um círculo, e depois mostrar o  valor da área deste círculo 
    com quatro casas decimais. Considerar o valor de π = 3.14159.

    EXEMPLO:
        Entrada:    2.5
        Saída:      Área = 19.6349 u.a.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    const float pi = 3.14159f;
    float raio, area;

    system("cls");
    cout << "====================================" << endl;
    cout << "   CALCULADORA DE ÁREA DE CÍRCULO   " << endl;
    cout << "====================================\n" << endl;

    cout << "> Digite o valor do raio: ";
    cin >> raio; // Lê o raio informado pelo usuário

    if (raio < 0) {
        cout << "\nO raio não pode ser negativo!" << endl;
    }
    else if (raio == 0) {
        cout << "\nO raio não pode ser nulo!" << endl;
    }
    else {
        area = pi * raio * raio; // Calcula a área do círculo (área = π * raio²)
        cout << "\nÁrea = " << fixed << setprecision(4) << area << " u.a." << endl; // Exibe o resultado com 4 casas decimais
    }
}
