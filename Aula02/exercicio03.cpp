#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
     int numero, horas;
     float valor_hora, salario;

     cin >> numero;
     cin >> horas;
     cin >> valor_hora;

     salario = horas * valor_hora;

     cout << "NUMBER = " << numero << endl;
     cout << "SALARY = U$ " << fixed << setprecision(2) << salario << endl;
} 
