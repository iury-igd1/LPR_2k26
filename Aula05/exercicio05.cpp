#include <iostream>
#include <locale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    double horas;
    double dias;
    double semanas;
    double meses;

    cout << "Digite o número de horas de treinamento por dia: ";
    cin >> horas;
    
    dias = 1000 / horas;
    semanas = dias / 5;
    meses = semanas / 4.5;

    cout << "Número de dias para atingir 1000 horas: " << dias << endl;
    cout << "Número de semanas para atingir 1000 horas: " << semanas << endl;
    cout << "Número de meses para atingir 1000 horas: " << meses << endl;
}