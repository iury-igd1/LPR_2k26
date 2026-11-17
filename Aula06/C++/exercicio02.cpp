/* 
Exercício 02:
    Construa um algoritmo que agrupe em funções os exercícios 1, 3 e 4 da Aula 05. Cada exercício deve estar 
    contido em uma função separada. Defina os parâmetros de modo eficiente e generalista. 
    Construa um menu na função main. 

    EXEMPLO:
        Entrada:    1
                    5 2 7 8 6 10
        Saída:      Média dos números = 6.50
    EXEMPLO:
        Entrada:    3
        Saída:      Soma dos números = 20475
    EXEMPLO:
        Entrada:    4
                    5
        Saída:      Soma dos dígitos do quadrado = 7
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>

using namespace std;

void exercicio01(int n) { // Média dos números pares informados
    int soma = 0, qtd = 0;

    for (int i = 0; i < n; i++) { // Percorre os valores informados e acumula a soma e a quantidade dos pares
        int valor;
        cin >> valor;

        if (valor % 2 == 0) {
            soma += valor;
            qtd++;
        }
    }

    if (qtd == 0) { // Se nenhum número par foi digitado
        cout << "\nNenhum número par foi digitado." << endl;
    } 
    else {
        cout << "\nMédia dos números = " << fixed << setprecision(2) << (double)soma / qtd << endl;
    }
}

void exercicio03() { // Soma dos ímpares múltiplos de 3 entre 50 e 500
    int soma = 0;
    
    for (int i = 51; i <= 500; i += 3) { // Percorre os múltiplos de 3 a partir de 51 e soma somente os ímpares
        if (i % 2 == 1) {
            soma += i;
        }
    }

    cout << "\nSoma dos números = " << soma << endl;
}

void exercicio04(long long numero) { // Soma dos dígitos do quadrado de um número
    int soma = 0;

    // Calcula o quadrado e o converte para texto para percorrer seus dígitos
    long long quadrado = numero * numero;
    string quad = to_string(quadrado);

    for (int i = 0; i < (int)quad.length(); i++) {
        int digito = quad[i] - '0'; // Converte para inteiro
        soma += digito;
    }

    cout << "\nSoma dos dígitos do quadrado = " << soma << endl;
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "===========================" << endl;
    cout << "   CENTRAL DE EXERCÍCIOS   " << endl;
    cout << "===========================\n" << endl;
    cout << "1 - Média de números pares" << endl;
    cout << "3 - Soma dos ímpares múltiplos de 3 entre 50 a 500" << endl;
    cout << "4 - Soma dos dígitos do quadrado" << endl;
    cout << "0 - Sair" << endl;
    
    int opcao;
    cout << "\n> Digite a opção desejada: ";
    cin >> opcao;
    
    switch (opcao) { // Encaminha para a função correspondente à opção escolhida
        case 1:
            int n;
            cout << "\n> Digite a quantidade de números e os números (separados por espaço): ";
            cin >> n;
            exercicio01(n);
            break;
        case 3:
            exercicio03();
            break;
        case 4:
            long long numero;
            cout << "\n> Digite um número inteiro: ";
            cin >> numero;
            exercicio04(numero);
            break;
        case 0:
            cout << "\nEncerrando programa." << endl;
            break;
        default:
            cout << "\nOpção inválida." << endl;
    }
}
