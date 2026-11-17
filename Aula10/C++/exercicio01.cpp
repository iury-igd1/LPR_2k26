/* 
Exercício 01:
    Faça um programa para ler os valores da largura e altura de um retângulo e em seguida, mostrar na tela o 
    valor de sua área e perímetro.

    EXEMPLO:
        Entrada:    10
                    5
        Saída:      Área = 50.00 u.a.                                                                                          
                    Perímetro = 30.00 u.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>

using namespace std;

class Retangulo {
    public:
    double altura;
    double largura;

    // Calcula a área multiplicando a altura pela largura
    double calcArea() {
        return altura * largura;
    }

    // Calcula o perímetro somando os quatro lados do retângulo
    double calcPerimetro() {
        return 2 * (altura + largura);
    }
};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "==========================" << endl;
    cout << "   CÁLCULO DE RETÂNGULO   " << endl;
    cout << "==========================\n" << endl;

    Retangulo retangulo; // Cria o retângulo que receberá as dimensões informadas pelo usuário

    cout << "> Insira a altura do retângulo: ";
    cin >> retangulo.altura;

    cout << "> Insira a largura do retângulo: ";
    cin >> retangulo.largura;

    cout << fixed << setprecision(2);
    cout << "\nÁrea = " << retangulo.calcArea() << " u.a." << endl;
    cout << "Perímetro = " << retangulo.calcPerimetro() << " u." << endl;
}
