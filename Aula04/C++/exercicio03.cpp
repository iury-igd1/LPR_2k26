/* 
Exercício 03:
    Suponha que você está desenvolvendo um jogo de RPG. Você é responsável por implementar a mecânica de 
    habilidades especiais para diferentes classes de personagens. Cada classe tem suas próprias habilidades 
    especiais. Crie um programa que permita ao jogador escolher uma classe de personagem e, em seguida, exiba 
    suas habilidades especiais correspondentes. 

    EXEMPLO:
        Entrada:    2
        Saída:      Suas habilidades: Bola de fogo e Escudo de gelo.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    int classe;

    system("cls");
    cout << "============================" << endl;
    cout << "   SISTEMA DE CLASSES RPG   " << endl;
    cout << "============================\n" << endl;

    cout << "1 - Guerreira\n2 - Mago\n3 - Arqueira\n" << endl;
    // Lê a classe escolhida pelo jogador
    cout << "> Escolha sua Classe: ";
    cin >> classe;

    switch (classe) { // Cada classe possui um conjunto fixo de duas habilidades especiais
        case 1:
            cout << "\nSuas habilidades: Ataque pesado e Defesa total." << endl;
            break;
        case 2:
            cout << "\nSuas habilidades: Bola de fogo e Escudo de gelo." << endl;
            break;
        case 3:
            cout << "\nSuas habilidades: Flecha precisa e Disparo triplo." << endl;
            break;
        default:
            cout << "\nClasse inválida." << endl;
            break;
    }
}
