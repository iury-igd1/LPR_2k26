/* 
Exercício 02:
    Faça um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do 
    produto de A e B pelo produto de C e D.
    
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

    cout << "==========================================" << endl;
    cout << "   CALCULADORA DE DIFERENÇA DE PRODUTOS   " << endl;
    cout << "==========================================\n" << endl;
    cout << "Diferença = (A * B) - (C * D)\n" << endl;
    cout << "Informe os valores:\n" << endl;

    // Lê os quatro valores informados pelo usuário
    cout << "> Valor de A: ";
    cin >> A;
    cout << "> Valor de B: ";
    cin >> B;
    cout << "> Valor de C: ";
    cin >> C;
    cout << "> Valor de D: ";
    cin >> D;

    int diferenca = (A * B) - (C * D); // Calcula a diferença entre os dois produtos

    cout << "\nDiferença = " << diferenca << endl;
} 
