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
    long long populacao = 0, somaPopulacoes = 0, populacaoMaior = -1, populacaoMenor = 999999999, filtro;
    int total;
    map<string, long long> cidades; // Dicionário de armazenamento das cidades no formato cidade-população

    system("cls");
    cout << "=========================" << endl;
    cout << "   CADASTRO DE CIDADES   " << endl;
    cout << "=========================\n" << endl;

    cout << "> Digite o número de cidades que serão informadas: ";
    cin >> total;

    if (total <= 0) {
        cout << "\nValor informado inválido." << endl;
        return 0;
    }

    for (int i = 1; i <= total; i++) { // Cadastro das cidades informadas pelo usuário
        cout << "\n> Digite o nome da cidade " << i << ": ";
        getline(cin >> ws, nomeCidade); // 'ws' descarta espaços em branco e quebras de linha no buffer

        cout << "> Digite a população da cidade " << i << ": ";
        cin >> populacao;

        cidades[nomeCidade] = populacao;
    }

    for (auto ppl : cidades) { // Soma as populações e identifica as cidades mais e menos populosas
        somaPopulacoes += ppl.second;

        if (ppl.second > populacaoMaior) {
            maisPopulosa = ppl.first;
            populacaoMaior = ppl.second;
        }
        if (ppl.second < populacaoMenor) {
            menosPopulosa = ppl.first;
            populacaoMenor = ppl.second;
        }
    }
    
    double media = (double)somaPopulacoes / cidades.size(); // Calcula a média das populações cadastradas

    cout << fixed << setprecision(2);
    cout << "\nMédia das populações: " << media << " habitantes" << endl;
    cout << "\nCidades com população acima da média:" << endl;
    for (auto ppl : cidades) { // Exibe somente as cidades cuja população é maior que a média calculada
        if (ppl.second > media) {
            cout << "- " << ppl.first << endl;
        }
    }

    cout << "\nCidade mais populosa: " << maisPopulosa << ", com " << populacaoMaior << " habitantes" << endl;
    cout << "Cidade menos populosa: " << menosPopulosa << ", com " << populacaoMenor << " habitantes" << endl;

    cout << "\n> Informe um valor de população para remover do dicionário: ";
    cin >> filtro;

    // Remove todas as cidades com a população informada
    for (auto it = cidades.begin(); it != cidades.end(); ) {
        if (it->second == filtro) {
            it = cidades.erase(it); // A remoção devolve o próximo iterador válido, permitindo continuar o percurso
        } 
        else {
            ++it;
        }
    }

    cout << "\nDicionário final:" << endl; // Exibe o dicionário após as remoções
    if (cidades.empty()) {
        cout << "(Vazio)" << endl;
    } 
    else {
        for (auto ppl : cidades) {
            cout << ppl.first << ", " << ppl.second << endl;
        }
    }
}
