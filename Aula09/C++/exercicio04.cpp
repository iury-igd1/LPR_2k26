/* 
Exercício 04:
    Crie uma struct chamada Piloto contendo:
        Nome, Equipe, Pontuação
    O programa deverá utilizar uma lista para armazenar os competidores.
    Implemente as seguintes funções:
      - CadastrarPiloto()
      - ExibirRanking()
      - CalcularPontuacaoMedia()
      - ExibirMelhorEquipe()
*/

#include <iostream>
#include <iomanip>
#include <string>
#include <locale>
#include <algorithm>
#include <cstdlib> 
#include <list> // Biblioteca para listas

using namespace std;

struct Piloto 
{
    string Nome;
    string Equipe;
    int Pontuacao;
};

int totalCadastrados = 0;
list<Piloto> pilotos; // Lista que armazena todos os dados

void Pausar() 
{
    cout << "\nPressione ENTER para continuar..." << endl;
    cin.get();
}

void CadastrarPiloto() 
{
    if (totalCadastrados >= 10) {
        cout << "\nLimite máximo de 10 pilotos cadastrados atingido." << endl;
        Pausar();
        return;
    }

    cout << "\n------------------------------------" << endl;
    cout << "         CADASTRO DE PILOTO         " << endl;
    cout << "------------------------------------\n" << endl;

    Piloto novoPiloto;
    totalCadastrados++;

    cout << "> Informe o Nome do Piloto " << totalCadastrados << ": ";
    getline(cin, novoPiloto.Nome);
    cout << "> Informe a Equipe do Piloto " << totalCadastrados << ": ";
    getline(cin, novoPiloto.Equipe);
    cout << "> Informe a Pontuação do Piloto " << totalCadastrados << ": ";
    cin >> novoPiloto.Pontuacao;
    cin.ignore(); // Ignora o buffer do console

    pilotos.push_back(novoPiloto); // Adiciona o struct na lista principal
    cout << "\nPiloto cadastrado com sucesso! (" << totalCadastrados << "/10)" << endl;
    Pausar();
}

void ExibirRanking() 
{
    if (pilotos.empty()) {
        cout << "\nNenhum piloto cadastrado ainda." << endl;
        Pausar();
        return;
    }

    list<Piloto> ranking = pilotos; // Cria uma nova lista igual a original

    for (auto itI = ranking.begin(); itI != ranking.end(); itI++) { // Ordena a lista em ordem decrescente
        auto itJ = itI;
        itJ++;
        for (; itJ != ranking.end(); itJ++) {
            // Compara a pontuação atual com a próxima. Se a próxima for maior, inverte
            if (itI -> Pontuacao < itJ -> Pontuacao) {
                Piloto temp = *itI;
                *itI = *itJ;
                *itJ = temp;
            }
        }
    }

    cout << "\n------------------------------------" << endl;
    cout << "        RANKING DO CAMPEONATO       " << endl;
    cout << "------------------------------------\n" << endl;

    int posicao = 1;
    for (auto it = ranking.begin(); it != ranking.end(); it++) {
        // left e setw(15) criam colunas alinhadas com 15 espaços predefinidos
        cout << posicao << "º: " << left << setw(15) << it -> Nome << " | " << setw(15) << it -> Equipe << " | " << it -> Pontuacao << " pts" << endl;
        posicao++;
    }
    Pausar();
}

double CalcularPontuacaoMedia() 
{
    if (pilotos.empty()) { // Evita divisão por zero
        return 0;
    }

    double ptsTotal = 0;
    for (auto it = pilotos.begin(); it != pilotos.end(); it++) { // Percorre todos os elementos da lista
        ptsTotal += it -> Pontuacao; // Soma as pontuações individuais
    }

    return (ptsTotal / (double)pilotos.size());
}

void ExibirEstatisticasMedia() 
{
    if (pilotos.empty()) {
        cout << "\nNenhum piloto cadastrado ainda." << endl;
        Pausar();
        return;
    }

    double media = CalcularPontuacaoMedia();
    int acimaMedia = 0;

    for (auto it = pilotos.begin(); it != pilotos.end(); it++) { // Percorre a lista principal contando quem bateu a média
        if (it -> Pontuacao >= media) {
            acimaMedia++;
        }
    }

    cout << "\n------------------------------------" << endl;
    cout << "        ESTATÍSTICAS DA MÉDIA       " << endl;
    cout << "------------------------------------\n" << endl;

    cout << "Média de pontos do campeonato: " << fixed << setprecision(2) << media << " pts" << endl;
    cout << "Quantidade de pilotos na média ou acima: " << acimaMedia << endl;
    Pausar();
}

void ExibirMelhorEquipe() 
{
    if (pilotos.empty()) {
        cout << "\nNenhum piloto cadastrado ainda." << endl;
        Pausar();
        return;
    }

    list<string> nomeEquipes;
    list<int> pontosEquipes;

    for (auto it = pilotos.begin(); it != pilotos.end(); it++) {
        // Busca se a equipe atual já existe na lista nomeEquipes
        auto itNome = find(nomeEquipes.begin(), nomeEquipes.end(), it -> Equipe);
        if (itNome != nomeEquipes.end()) {  // A equipe existe
            // Descobre o índice calculando a distância entre o começo da lista e o iterador achado
            int distancia = distance(nomeEquipes.begin(), itNome);
            auto itPontos = pontosEquipes.begin();
            // Avança o iterador de pontos a exata mesma distância, alinhando as duas listas
            advance(itPontos, distancia);
            *itPontos += it -> Pontuacao; // Soma os pontos
        }
        else {
            nomeEquipes.push_back(it -> Equipe);
            pontosEquipes.push_back (it -> Pontuacao);
        }
    }

    int maiorPontuacao = -1;
    string melhorEquipe = "";

    auto itNome = nomeEquipes.begin();
    auto itPontos = pontosEquipes.begin();

    for (; itNome != nomeEquipes.end(); itNome++, itPontos++) { // Percorre as duas listas simultaneamente
        if (*itPontos > maiorPontuacao) {
            maiorPontuacao = *itPontos;
            melhorEquipe = *itNome;
        }
    }

    cout << "\n------------------------------------" << endl;
    cout << "MELHOR EQUIPE: " << melhorEquipe << " | " << maiorPontuacao << " pts" << endl;
    cout << "------------------------------------" << endl;
    Pausar();
}

void Menu() 
{
    int opcao = 0;
    while (opcao != 5) {
        system("cls"); // Limpa o console
        cout << "====================================" << endl;
        cout << "   SISTEMA DE CADASTRO DE PILOTOS   " << endl;
        cout << "====================================\n" << endl;
        cout << "Pilotos cadastrados: " << totalCadastrados << "/10\n" << endl;
        cout << "-------------------------------------------" << endl;
        cout << "1 - Cadastrar Piloto" << endl;
        cout << "2 - Exibir Ranking do Campeonato" << endl;
        cout << "3 - Exibir Estatísticas de Média" << endl;
        cout << "4 - Exibir Melhor Equipe" << endl;
        cout << "5 - Sair" << endl;
        cout << "-------------------------------------------" << endl;
        
        cout << "> Escolha uma opção: ";
        cin >> opcao;

        // Se o usuário digitar uma letra ao invés de um número, o cin entra em estado de erro
        if (cin.fail()) {
            cin.clear(); // Limpa o estado de erro
        }
        cin.ignore(10000, '\n'); // Descarta 10000 caracteres ou um ENTER

        switch (opcao) {
            case 1:
                CadastrarPiloto();
                break;
            case 2:
                ExibirRanking();
                break;
            case 3:
                ExibirEstatisticasMedia();
                break;
            case 4:
                ExibirMelhorEquipe();
                break;
            case 5:
                cout << "\nEncerrando programa." << endl;
                break;
            default:
                cout << "\nOpção inválida. Tente novamente." << endl;
                Pausar();
                break;
        }
    }
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    Menu();
}