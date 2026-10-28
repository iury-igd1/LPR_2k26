/* 
Exercício 02:
    Faça um programa para ler os dados de um funcionário (nome, salário bruto e imposto). 
    A classe funcionário deve conter os seguintes métodos:
      - Mostrar os dados do funcionário (nome e salário líquido);
      - Aumentar o salário do funcionário com base em uma porcentagem dada.
    Tabela de Imposto:
      - 10% para salários de até 2000;
      - 15% para salários de até 3000;
      - 20% para salários superiores a 3000.

    EXEMPLO:
        Entrada:    Iury
                    2500
        Saída:      Nome do funcionário: Iury
                    Salário líquido: R$ 2125,00
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