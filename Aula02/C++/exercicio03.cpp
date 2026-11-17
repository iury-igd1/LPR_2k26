/* 
Exercício 03:
    Faça um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe 
    por hora e calcule o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com 
    duas casas decimais.
    
    EXEMPLO:
        Entrada:    1
                    200
                    20.50
        Saída:      Número = 1
                    Salário = R$ 4100.00
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");
     
    int numero, horas;
    float valorHora, salario;

    system("cls");
    cout << "===========================================" << endl;
    cout << "   CALCULADORA DE SALÁRIO DE FUNCIONÁRIO   " << endl;
    cout << "===========================================\n" << endl;
    cout << "Informe os dados do funcionário:\n" << endl;

    // Lê os dados do funcionário
    cout << "> Número: ";
    cin >> numero;

    cout << "> Horas trabalhadas: ";
    cin >> horas;
    if (horas <= 0) {
        cout << "\nQuantidade de horas não pode ser negativa ou nula!" << endl;
        return 0;
    }

    cout << "> Valor por hora: ";
    cin >> valorHora;
    if (valorHora <= 0) {
        cout << "\nValor por hora não pode ser negativo ou nulo!" << endl;
        return 0;
    }

    salario = horas * valorHora; // Calcula o salário (horas trabalhadas * valor por hora)

    cout << "\nNúmero = " << numero << endl;
    cout << "Salário = R$ " << fixed << setprecision(2) << salario << endl;
} 
