/* 
Exercício 03:
     Faça um programa que leia o número de um funcionário, seu 
     número de horas trabalhadas, o valor que recebe por hora e 
     calcule o salário desse funcionário. A seguir, mostre o 
     número e o salário do funcionário, com duas casas decimais.
    
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

using namespace std;

int main()
{
     setlocale(LC_ALL, "pt_BR.UTF-8");
     
     int numero, horas;
     float valor_hora, salario;

     cout << "Número do funcionário: ";
     cin >> numero;
     cout << "Horas trabalhadas: ";
     cin >> horas;
     cout << "Valor por hora: ";
     cin >> valor_hora;

     salario = horas * valor_hora;

     cout << "Número = " << numero << endl;
     cout << "Salário = R$ " << fixed << setprecision(2) << salario << endl;
} 
