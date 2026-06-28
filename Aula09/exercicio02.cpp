/* 
Exercício 02:
    Construa uma lista de X nomes aleatórios. 
    A saída deve ser mostrada em uma ou mais linhas. Cada linha tem uma lista de nomes ordenados por tamanho, começando 
    com o menor. Em cada linha, só pode ser mostrado um nome de determinado tamanho, e os demais nomes com o mesmo 
    tamanho devem ser apresentados nas linhas seguintes. Siga a ordem de digitação.

    EXEMPLO:
        Entrada:    12 sergio ana maria carlos eva joaquim jo mara laura lucas ari paulo
        Saída:      jo, ana, mara, maria, sergio, joaquim
                    eva, laura, carlos
                    ari, lucas
                    paulo
*/

#include <iostream>
#include <locale>
#include <string>
#include <algorithm>
#include <list> // Biblioteca para listas

using namespace std;

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    cout << "=====================" << endl;
    cout << "   FILTRO DE NOMES   " << endl;
    cout << "=====================\n" << endl;

    int quantidade;
    cout << "> Digite o número de nomes e os nomes (separados por espaço): ";
    cin >> quantidade; // Lê apenas o primeiro número digitado

    list<string> nomes;
    for (int i = 0; i < quantidade; i++) {
        string nome;
        cin >> nome;
        nomes.push_back(nome); // Adiciona os nomes digitados à lista
    }

    cout << "\nSaída: " << endl;

    while (nomes.empty() == false) {
        list<string> linhaAtual; // Guarda os nomes da linha a ser impressa
        list<int> tamanhosUsados; // Guarda os tamanhos dos nomes da linha a ser impressa

        for (auto it = nomes.begin(); it != nomes.end(); ) { // Percorre todos os nomes
            int tamanho = it -> length(); // Tamanho do nome atual

            // Se o tamanho ainda não está na linha
            if (find(tamanhosUsados.begin(), tamanhosUsados.end(), tamanho) == tamanhosUsados.end()) {
                linhaAtual.push_back(*it); // Adiciona na linha de impressão
                tamanhosUsados.push_back(tamanho);
                it = nomes.erase(it); // Retira o nome da lista principal
            }
            else {
                it++;
            }
        }

        // Ordena a lista pelo tamanho das palavras
        for (auto itI = linhaAtual.begin(); itI != linhaAtual.end(); itI++) { 
            auto itJ = itI;
            itJ++;
            for (; itJ != linhaAtual.end(); itJ++) {
                if (itI -> length() > itJ -> length()) { // Compara o tamanho da palavra com a próxima
                    string temporario = *itI;
                    *itI = *itJ;
                    *itJ = temporario;
                }
            }
        }

        auto itPrint = linhaAtual.begin();
        while (itPrint != linhaAtual.end()) {
            cout << *itPrint;
            auto proximo = itPrint;
            proximo++;

            if (proximo != linhaAtual.end()) {
                cout << ", ";
            }
            itPrint++;
        }
        cout << endl;
    }
}