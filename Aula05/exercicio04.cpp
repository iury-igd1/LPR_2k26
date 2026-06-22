/* 
Exercício 04:
    Solicite ao usuário para inserir um número e calcule a soma dos dígitos do quadrado desse número. 

    EXEMPLO:
        Entrada:    4
        Saída:      Soma dos dígitos do quadrado = 7
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int numero, soma = 0;

    cout << "==================================" << endl;
    cout << "   SOMA DOS DÍGITOS DO QUADRADO   " << endl;
    cout << "==================================\n" << endl;

    cout << "> Digite um número inteiro: ";
    cin >> numero;

    // Calcula o quadrado e converte para string para acessar cada dígito
    int quadrado = numero * numero;
    string quad = to_string(quadrado);

    for (int i = 0; i < (int)quad.length(); i++) { // Soma cada dígito do quadrado, um a um
        int digito = quad[i] - '0'; // Converte o caractere numérico da string em seu valor inteiro correspondente
        soma += digito;
    }

    cout << "\nSoma dos dígitos do quadrado = " << soma << endl;
}
