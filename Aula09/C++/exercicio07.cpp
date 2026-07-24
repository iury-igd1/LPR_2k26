/* 
Exercício 07:
    Construa um dicionário de X pares chave-valor onde as chaves são cidades e os valores são suas respectivas 
    populações. Encontre e imprima todas as cidades com população acima da média. Encontre e imprima o nome da 
    cidade mais populosa e o nome da cidade menos populosa. Remova todas as cidades com população igual a um 
    valor Y (fornecido pelo usuário) e imprima o dicionário atualizado.
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

    string nomeCidade = "", maisPopulosa = "", menosPopulosa = "";
    float populacao = 0.0f, somaPopulacoes = 0.0f, populacaoMaior = -1.0f, populacaoMenor = 999999999.0f, filtro;
    int total, qtde = 0;
    map<string, float> cidades; // Dicionário de armazenamento das cidades no formato cidade-população

    system("cls");
    cout << "=========================" << endl;
    cout << "   CADASTRO DE CIDADES   " << endl;
    cout << "=========================\n" << endl;

    cout << "> Digite o número de cidades que serão informadas: ";
    cin >> total;

    for (int i = 1; i <= total; i++) { // Cadastro das cidades informadas pelo usuário
        cout << "\n> Digite o nome da cidade " << i << ": ";
        getline(cin >> ws, nomeCidade); // 'ws' descarta espaços em branco e quebras de linha no buffer

        cout << "> Digite a população da cidade " << i << " (em milhares): ";
        cin >> populacao;
        somaPopulacoes += populacao;
        qtde += 1;

        cidades[nomeCidade] = populacao;
    }

    double media = (double)somaPopulacoes / qtde; // Calcula a média das populações cadastradas

    cout << "\nCidades com população acima da média:" << endl;
    for (auto ppl : cidades) {
        if (ppl.second > media) {
            cout << ppl.first << endl;
        }
    }

    for (auto ppl : cidades) { // Identifica a cidade mais e menos populosa
        if (ppl.second > populacaoMaior) {
            maisPopulosa = ppl.first;
            populacaoMaior = ppl.second;
        }
        if (ppl.second < populacaoMenor) {
            menosPopulosa = ppl.first;
            populacaoMenor = ppl.second;
        }
    }

    cout << "\nCidade mais populosa: "<< maisPopulosa << ", com " << populacaoMaior << " mil habitantes" << endl;
    cout << "Cidade menos populosa: "<< menosPopulosa << ", com " << populacaoMenor << " mil habitantes" << endl;

    cout << "\n> Informe um valor de população para remover do dicionário: ";
    cin >> filtro;

    // Remove todas as cidades com a população informada
    for (auto it = cidades.begin(); it != cidades.end(); ) {
        if (it->second == filtro) {
            it = cidades.erase(it);
        } 
        else {
            ++it;
        }
    }

    cout << "\nDicionário final:" << endl; // Exibe o dicionário após as remoções
    for (auto ppl : cidades) {
        cout << ppl.first << ", " << ppl.second << endl;
    }
}