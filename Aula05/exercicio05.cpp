/* 
Exercício 05:
    Crie um programa que simula o treinamento de um Jedi. O usuário deve inserir o número de horas de 
    treinamento por dia. O programa deve calcular o total de horas de treinamento em uma semana, 
    desconsiderando sábados e domingos, e informar quantos dias, semanas e meses seriam necessários para 
    alcançar o total de 1000 horas de treinamento. 
    Considerar 1 mês = 4,5 semanas.

    EXEMPLO:
        Entrada:    8 
        Saída:      Horas treinadas por semana: 40h
                    Serão necessários 5 meses, 2 semana(s) e 3 dia(s) para alcançar 1000h de treinamento.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cmath> // Para arredondamentos

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    double horas, diasTotal, diasRestantes;
    int semanas, meses;

    cout << "==================================" << endl;
    cout << "   SIMULADOR DE TREINAMENTO JEDI  " << endl;
    cout << "==================================\n" << endl;
    cout << "Meta: 1000 horas\n" << endl;

    cout << "> Digite o número de horas de treinamento por dia: ";
    cin >> horas;
    
    if (horas <= 0) {
        cout << "Valor de horas inválido." << endl;
    } else {
        diasTotal = 1000 / horas;

        // 5 * 4.5 = 22.5 dias úteis por mês
        meses = static_cast<int>(diasTotal / 22.5); // Armazena somente a parte inteira
        diasRestantes = diasTotal - meses * 22.5;

        semanas = static_cast<int>(diasRestantes / 5); // Armazena somente a parte inteira
        diasRestantes -= semanas * 5;

        int diasFinal = ceil(diasRestantes); // Arredonda para cima

        if (diasFinal == 5) {
            semanas += 1;
            diasFinal = 0;
        }

        cout << "\nHoras treinadas por semana: " << horas * 5 << "h" << endl;
        cout << "Serão necessários " << meses << " meses, " << semanas << " semana(s) e " << diasFinal << " dia(s) para alcançar 1000h de treinamento." << endl;
    }
}
