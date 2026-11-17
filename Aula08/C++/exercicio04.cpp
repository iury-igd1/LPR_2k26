/* 
Exercício 04:
    Desenvolva um programa que simule um sistema de seleção de heróis da Marvel para uma equipe. 
    O programa deve ter as seguintes funcionalidades:

    a) Cadastro de Heróis:
    Crie uma função chamada cadastrarHeroi que permita ao usuário inserir o nome, o poder e a pontuação de um 
    herói. A função deve solicitar essas informações ao usuário e armazená-las em um struct. O programa deve 
    permitir o cadastro de até 5 heróis.

    b) Seleção de Equipe:
    Crie uma função chamada selecionarEquipe que permita ao usuário selecionar heróis para formar sua equipe. 
    A função deve exibir os heróis cadastrados e permitir que o usuário selecione quais heróis deseja incluir 
    em sua equipe. O usuário deve ser capaz de selecionar três heróis para sua equipe.

    c) Pontuação Total da Equipe:
    Crie uma função chamada calcularPontuacaoTotal que calcule a pontuação total da equipe com base nos heróis 
    selecionados. A pontuação total da equipe deve ser a soma das pontuações individuais de cada herói.

    d) Exibição da Equipe:
    Crie uma função chamada exibirEquipe que exiba os heróis selecionados para a equipe, seu poder e a pontuação 
    total da equipe.

    e) Menu:
    Crie uma função chamada menuPrincipal que exiba um menu com as opções disponíveis para o usuário (cadastro 
    de heróis, seleção de equipe, exibição da equipe e sair do programa). O usuário deve poder escolher uma das 
    opções do menu e o programa deve executar a funcionalidade correspondente.

    Requisitos Adicionais:
    - O programa deve continuar em execução até que o usuário escolha a opção de sair;
    - Utilize structs para armazenar as informações dos heróis e da equipe;
    - NÃO utilize classes ou listas.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>

using namespace std;

struct Heroi {
    string Nome;
    string Poder;
    int Pontuacao;
};

struct Equipe {
    int integrantes[3] = { 0, 0, 0 }; // Identificadores dos 3 heróis selecionados
};

Heroi herois[5];
int totalHerois = 0; // Controla quantas posições já estão preenchidas
Equipe equipe;

// Aguarda ENTER para que o usuário possa ler o resultado antes de voltar ao menu
void pausar() {
    cout << "\nPressione ENTER para continuar..." << endl;
    cin.get();
}

// Solicita nome, poder e pontuação de um novo herói e o adiciona ao vetor, se houver vaga
void cadastrarHeroi() {
    if (totalHerois >= 5) {
        cout << "\nLimite de heróis cadastrados atingido." << endl;
        pausar();
        return;
    }

    cout << "\n-------------------------------------------" << endl;
    cout << "             CADASTRO DE HERÓI             " << endl;
    cout << "-------------------------------------------\n" << endl;

    Heroi heroi;

    cout << "> Nome do herói: ";
    getline(cin, heroi.Nome);
    cout << "> Poder do herói: ";
    getline(cin, heroi.Poder);
    cout << "> Pontuação do herói: ";
    cin >> heroi.Pontuacao;
    cin.ignore();

    herois[totalHerois] = heroi;
    totalHerois++;

    cout << "\nHerói cadastrado com sucesso! (" << totalHerois << "/5)" << endl;
    pausar();
}

// Exibe os heróis cadastrados e permite escolher 3 deles para formar a equipe
void selecionarEquipe() {
    if (totalHerois < 3) {
        cout << "\nCadastre pelo menos 3 heróis antes de montar a equipe." << endl;
        pausar();
        return;
    }

    cout << "\n-------------------------------------------" << endl;
    cout << "              SELEÇÃO DE EQUIPE            " << endl;
    cout << "-------------------------------------------\n" << endl;
    cout << "ID  HERÓI           PODER           PONTOS" << endl;
    cout << "-------------------------------------------" << endl;

    for (int i = 0; i < totalHerois; i++) {
        cout << (i + 1) << "   " << left << setw(15) << herois[i].Nome << " " << setw(15) << herois[i].Poder << " " << setw(6) << herois[i].Pontuacao << endl;
    }

    Equipe novaEquipe; // Armazena as escolhas temporariamente, sem alterar a equipe já selecionada

    for (int i = 0; i < 3; i++) {
        cout << "\n> Escolha o herói " << (i + 1) << " da equipe: ";
        int escolha;
        cin >> escolha;
        cin.ignore();

        if (escolha < 1 || escolha > totalHerois) {
            cout << "\nHerói inválido." << endl;
            pausar();
            return;
        }

        bool repetido = false;

        // Compara a escolha atual com as escolhas para que o mesmo herói não entre duas vezes na equipe
        for (int j = 0; j < i; j++) {
            if (novaEquipe.integrantes[j] == escolha) {
                repetido = true;
                break;
            }
        }

        if (repetido) {
            cout << "\nVocê não pode escolher o mesmo herói mais de uma vez." << endl;
            pausar();
            return;
        }

        novaEquipe.integrantes[i] = escolha;
    }

    equipe = novaEquipe; // Confirma a nova equipe somente depois de validar seus três integrantes

    cout << "\nEquipe cadastrada com sucesso!" << endl;
    pausar();
}

// Soma a pontuação dos 3 heróis da equipe selecionada
int calcularPontuacaoTotal() {
    int total = 0;

    for (int i = 0; i < 3; i++) {
        int indice = equipe.integrantes[i] - 1; // Converte o identificador do herói para o índice correspondente no vetor
        total += herois[indice].Pontuacao;
    }

    return total;
}

// Exibe os heróis da equipe selecionada e a pontuação total
void exibirEquipe() {
    // O primeiro identificador permanece zero enquanto nenhuma equipe completa foi confirmada
    if (equipe.integrantes[0] == 0) {
        cout << "\nEquipe não selecionada." << endl;
        pausar();
        return;
    }

    cout << "\n-------------------------------------------" << endl;
    cout << "            EQUIPE SELECIONADA            " << endl;
    cout << "-------------------------------------------\n" << endl;

    for (int i = 0; i < 3; i++) {
        int id = equipe.integrantes[i];
        Heroi h = herois[id - 1];

        cout << "[" << id << "] " << h.Nome << endl;
        cout << "    Poder: " << h.Poder << endl;
        cout << "    Pontuação: " << h.Pontuacao << " pts\n" << endl;
    }

    cout << "-------------------------------------------" << endl;
    cout << "\nPontuação total da equipe: " << calcularPontuacaoTotal() << " pts" << endl;
    pausar();
}

// Exibe o menu principal e direciona para a função correspondente até o usuário escolher sair
void menuPrincipal() {
    int opcao = 0;

    while (opcao != 5) {
        system("cls");
        cout << "===========================================" << endl;
        cout << "   SISTEMA DE FORMAÇÃO DE EQUIPES MARVEL   " << endl;
        cout << "===========================================\n" << endl;
        cout << "Heróis cadastrados: " << totalHerois << "/5\n" << endl;
        cout << "-------------------------------------------" << endl;
        cout << "1 - Cadastrar Herói" << endl;
        cout << "2 - Selecionar Equipe" << endl;
        cout << "3 - Calcular Pontuação" << endl;
        cout << "4 - Exibir Equipe" << endl;
        cout << "5 - Sair" << endl;
        cout << "-------------------------------------------" << endl;
        cout << "> Escolha uma opção: ";
        cin >> opcao;
        cin.ignore();

        switch (opcao) {
            case 1:
                cadastrarHeroi();
                break;
            case 2:
                selecionarEquipe();
                break;
            case 3:
                if (equipe.integrantes[0] == 0) {
                    cout << "\nNenhuma equipe foi selecionada." << endl;
                } 
                else {
                    cout << "\nPontuação total da equipe: " << calcularPontuacaoTotal() << " pts" << endl;
                }
                pausar();
                break;
            case 4:
                exibirEquipe();
                break;
            case 5:
                cout << "\nEncerrando programa." << endl;
                break;
            default:
                cout << "\nOpção inválida. Tente novamente." << endl;
                pausar();
                break;
        }
    }
}

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");
    menuPrincipal();
}
