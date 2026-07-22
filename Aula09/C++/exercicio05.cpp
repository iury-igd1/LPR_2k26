/* 
Exercício 05:
    Crie um programa que utilize um dicionário para armazenar jogos e seus respectivos gêneros. Cadastre pelo 
    menos cinco jogos informados pelo usuário e, depois, solicite o nome de um jogo e exiba seu gênero. Caso o 
    jogo não esteja cadastrado, exiba uma mensagem informando isso.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>
#include <map>

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    // Dicionário de armazenamento dos jogos no formato jogo-gênero
    map<string, string> jogos;
    string nomeJogo, generoJogo, nomeBusca;

    system("cls");
    cout << "=======================" << endl;
    cout << "   CADASTRO DE JOGOS   " << endl;
    cout << "=======================" << endl;

    for (int i = 1; i <= 5; i++) {
        cout << "\n> Digite o nome do jogo " << i << ": ";
        getline(cin >> ws, nomeJogo); // 'ws' descarta espaços em branco e quebras de linha no buffer

        cout << "> Digite o gênero do jogo " << i << ": ";
        getline(cin >> ws, generoJogo);

        jogos[nomeJogo] = generoJogo;
    }

    cout << "\n> Digite o nome do jogo que deseja buscar: ";
    getline(cin >> ws, nomeBusca);

    if (jogos.find(nomeBusca) != jogos.end()) { // Verifica se a chave existe
        cout << "O gênero do jogo '" << nomeBusca << "' é: " << jogos[nomeBusca] << "." << endl;
    }
    else {
        cout << "O jogo '" << nomeBusca << "' não foi cadastrado." << endl;
    }
}