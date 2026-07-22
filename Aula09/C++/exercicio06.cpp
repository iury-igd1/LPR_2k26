/* 
Exercício 06:
    Construa um dicionário de X pares chave-valor em que as chaves são nomes e os valores são respectivas idades. 
    Encontre e imprima todos os nomes de pessoas com idade acima da média. Encontre e imprima o nome da pessoa 
    mais velha e o nome da pessoa mais nova. Remova todas as pessoas com idade igual a um valor Y (fornecido 
    pelo usuário) e imprima o dicionário atualizado.
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

    string nomePessoa = "", maisVelho = "", maisNovo = "";
    int idadePessoa = 0, somaIdades = 0, qtde = 0, iddMaisVelho = -1, iddMaisNovo = 999999999;
    int total, filtro;
    map<string, int> pessoas;

    system("cls");
    cout << "=========================" << endl;
    cout << "   CADASTRO DE PESSOAS   " << endl;
    cout << "=========================\n" << endl;

    cout << "> Digite o número de pessoas que serão informadas: ";
    cin >> total;

    for (int i = 1; i <= total; i++) {
        cout << "\n> Digite o nome da pessoa " << i << ": ";
        getline(cin >> ws, nomePessoa); // 'ws' descarta espaços em branco e quebras de linha no buffer

        cout << "> Digite a idade da pessoa " << i << ": ";
        cin >> idadePessoa;
        somaIdades += idadePessoa;
        qtde += 1;

        pessoas[nomePessoa] = idadePessoa;
    }

    double media = (double)somaIdades / qtde;

    cout << "\nPessoas com idade acima da média:" << endl;
    for (auto idd : pessoas) {
        if (idd.second > media) {
            cout << idd.first << endl;
        }
    }

    for (auto idd : pessoas) {
        if (idd.second > iddMaisVelho) {
            maisVelho = idd.first;
            iddMaisVelho = idd.second;
        }
        if (idd.second < iddMaisNovo) {
            maisNovo = idd.first;
            iddMaisNovo = idd.second;
        }
    }

    cout << "\nPessoa mais velha: "<< maisVelho << ", com " << iddMaisVelho << " anos" << endl;
    cout << "Pessoa mais nova: "<< maisNovo << ", com " << iddMaisNovo << " anos" << endl;

    cout << "\n> Informe um valor de idade para remover do dicionário: ";
    cin >> filtro;

    for (auto it = pessoas.begin(); it != pessoas.end(); ) {
        if (it->second == filtro) {
            it = pessoas.erase(it);
        } 
        else {
            ++it;
        }
    }

    cout << "\nDicionário final:" << endl;
    for (auto idd : pessoas) {
        cout << idd.first << ", " << idd.second << endl;
    }
}