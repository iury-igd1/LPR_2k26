/* 
Exercício 02:
    Construa um algoritmo que agrupe em funções os exercícios 1, 3 e 4 da tarefa 
    de estruturas de repetições (Aula 5). Cada exercício deve estar contido em 
    uma função separada. Defina os parâmetros de modo eficiente e generalista. 
    Construa um menu na função main. 

    EXEMPLO:
        Entrada:    0
        Saída:      Encerrando programa.
    EXEMPLO:
        Entrada:    1
                    5 2 7 8 6 10
        Saída:      Média dos números: 6.50
    EXEMPLO:
        Entrada:    2
        Saída:      Opção inválida.
    EXEMPLO:
        Entrada:    3
        Saída:      Soma dos números: 20475
    EXEMPLO:
        Entrada:    4
                    123
        Saída:      Soma dos dígitos: 18
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>

using namespace std;

void exercicio01() {
    int n, soma = 0, qtd = 0;

    cout << "> Digite a quantidade de números e os números (separados por espaço): ";
    cin >> n;

    for (int i = 0; i < n; i++) {
        int valor;
        cin >> valor;

        if (valor % 2 == 0) {
            soma += valor;
            qtd++;
        }
    }

    cout << "Média dos números: " << fixed << setprecision(2) << (double)soma / qtd << endl;
}

void exercicio03() {
    int soma = 0;
    
    for (int i = 51; i <= 500; i += 3) {
        if ((i % 2 == 1)) {
            soma += i;
        }
    }

    cout << "Soma dos números: " << soma << endl;
}

void exercicio04() {
    int numero, soma = 0;
    cout << "> Digite um número inteiro: ";
    cin >> numero;

    int quadrado = numero * numero;
    string quad = to_string(quadrado);

    for (int i = 0; i < (int)quad.length(); i++) {
        int digito = quad[i] - '0'; // Converte para inteiro
        soma += digito;
    }

    cout << "Soma dos dígitos: " << soma << endl;
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    cout << "--- Menu de opções ---" << endl;
    cout << "1. Ex1: Média de números pares" << endl;
    cout << "3. Ex3: Soma dos ímpares múltiplos de 3 de 50 a 500" << endl;
    cout << "4. Ex4: Soma dos dígitos do quadrado" << endl;
    cout << "0. Sair" << endl;
    
    int opcao;
    cout << "\n> Digite a opção desejada: ";
    cin >> opcao;
    
    switch (opcao) {
        case 1:
            exercicio01();
            break;
        case 3:
            exercicio03();
            break;
        case 4:
            exercicio04();
            break;
        case 0:
            cout << "Encerrando programa." << endl;
            break;
        default:
            cout << "Opção inválida." << endl;
    }
}
