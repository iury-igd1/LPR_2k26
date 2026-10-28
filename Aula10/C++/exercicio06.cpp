/* 
Exercício 06:
    Implemente um sistema onde uma Reserva está associada a um Cliente, e um Cliente pode ter várias Reservas.
      - Crie as classes Cliente e Reserva;
      - Um Cliente pode ter várias Reservas, mas cada Reserva pertence a apenas um Cliente;
      - Em Cliente, implemente um método para adicionar uma Reserva à lista de reservas do cliente;
      - Em Reserva, adicione um atributo para referenciar o cliente que fez a reserva;
      - Crie um método em Cliente que liste todas as reservas existentes para um determinado cliente.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");
}