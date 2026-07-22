/* 
Exercício 04:
    Faça um programa para ler o código, o número de peças e o valor unitário de uma peça 1 e o código, o número 
    de peças e o valor unitário de uma peça 2. Calcule e mostre o valor a ser pago.
    
    EXEMPLO:
        Entrada:    12 1 5.30
                    16 2 5.10
        Saída:      Valor a pagar = R$ 15.50
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int codigo1, numero1, codigo2, numero2;
    float valor1, valor2;

    system("cls");
    cout << "==================================" << endl;
    cout << "   CALCULADORA DE VALOR A PAGAR   " << endl;
    cout << "==================================\n" << endl;
    cout << "Informe os dados das peças para calcular o valor a pagar.\n" << endl;

    // Lê código, quantidade e valor unitário da peça 1
    cout << "> Código, número de peças e valor unitário da peça 1 (separados por espaço): ";
    cin >> codigo1 >> numero1 >> valor1;
    
    // Lê código, quantidade e valor unitário da peça 2
    cout << "> Código, número de peças e valor unitário da peça 2 (separados por espaço): ";
    cin >> codigo2 >> numero2 >> valor2;

    float valor = (numero1 * valor1) + (numero2 * valor2); // Calcula o valor total a pagar pelas duas peças

    cout << "\nValor a pagar = R$ " << fixed << setprecision(2) << valor << endl;
}
