/* 
Exercício 02:
    Construa um algoritmo de adivinhação de números. O seu trabalho é elaborar um algoritmo em que o usuário 
    possa digitar números no console até acertar o número inteiro aleatório valorInteiro, de 1 a 100. A cada 
    chute, o programa deve responder com “Chutou alto”, “Chutou baixo” ou “Acertou”. Após acertar, deve ser 
    mostrado quantas tentativas foram usadas para descobrir o número.

    EXEMPLO:
        Entrada:    50 
                    75 
                    63 
                    68
        Saída:      Acertou em 4 tentativas!
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    // Sorteia um número secreto entre 1 e 100
    srand(static_cast<unsigned int>(time(0)));
    int valorInteiro = rand() % 100 + 1;
    int tentativas = 0, palpite;

    cout << "=========================" << endl;
    cout << "   JOGO DE ADIVINHAÇÃO   " << endl;
    cout << "=========================\n" << endl;
    cout << "Tente descobrir o número secreto!" << endl;

    do { // Repete até o jogador acertar o número sorteado
        cout << "\n> Digite um número entre 1 e 100: ";
        cin >> palpite;
        tentativas++;

        if (palpite < valorInteiro) {
            cout << "Chutou baixo!" << endl;
        } 
        else if (palpite > valorInteiro) {
            cout << "Chutou Alto!" << endl;
        } 
        else {
            cout << "Acertou em " << tentativas << " tentativas!" << endl;
        }
    } while (palpite != valorInteiro);
}
