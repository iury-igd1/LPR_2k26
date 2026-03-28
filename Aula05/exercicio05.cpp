/* 
Exercício 05:
    Crie um programa que simula o treinamento de um Jedi. O 
    usuário deve inserir o número de horas de treinamento por dia. 
    O programa deve calcular o total de horas de treinamento em 
    uma semana, desconsiderando sábados e domingos, e informar 
    quantos dias, semanas e meses seriam necessários para alcançar 
    o total de 1000 horas de treinamento. 
    Considerar 1 mês = 4,5 semanas.

    EXEMPLO:
        Entrada:    8 
        Saída:      Número de dias necessários: 125.00
                    Número de semanas necessárias: 25.00
                    Número de meses necessários: 5.56
*/

#include <iostream>
#include <iomanip>
#include <locale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    double horas, dias, semanas, meses;

    cout << "Digite o número de horas de treinamento por dia (meta de 1000h): ";
    cin >> horas;
    
    if (horas <= 0) {
        cout << "Valor de horas inválido." << endl;
    } else {
        dias = 1000 / horas;
        semanas = dias / 5;
        meses = semanas / 4.5;

        cout << "Número de dias necessários: " << fixed << setprecision(2) << dias << endl;
        cout << "Número de semanas necessárias: " << fixed << setprecision(2) << semanas << endl;
        cout << "Número de meses necessários: " << fixed << setprecision(2) << meses << endl;
    }
}
