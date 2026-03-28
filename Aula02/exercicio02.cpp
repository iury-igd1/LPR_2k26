/* 
Exercício 02:
    Faça um programa para ler quatro valores inteiros A, B, C e D. 
    A seguir, calcule e mostre a diferença do produto de A e B 
    pelo produto de C e D.
    
    EXEMPLO:
        Entrada:    5
                    6
                    7
                    8
        Saída:      Diferença = -26
*/

#include <iostream>
#include <iomanip>
#include <locale>

using namespace std;

int main()
{
     setlocale(LC_ALL, "pt_BR.UTF-8");

     int A, B, C, D;

     cout << "Valor de A: ";
     cin >> A;
     cout << "Valor de B: ";
     cin >> B;
     cout << "Valor de C: ";
     cin >> C;
     cout << "Valor de D: ";
     cin >> D;

     int conta = (A * B) - (C * D);

     cout << "Diferença = " << conta << endl;
} 
