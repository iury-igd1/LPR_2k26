/* 
Exercício 03:
    Desenvolva um programa que simule um sistema de seleção de heróis da Marvel para uma equipe. 
    O programa deve ter as seguintes funcionalidades:

    a) Cadastro de Heróis:
    Crie uma função chamada cadastrarHeroi que permita ao usuário inserir o nome, o poder e a pontuação de 
    um herói. A função deve solicitar essas informações ao usuário e armazená-las em variáveis. Não é 
    necessário armazenar os heróis em uma lista ou vetor. O programa deve permitir o cadastro de até 5 heróis.

    b) Seleção de Equipe:
    Crie uma função chamada selecionarEquipe que permita ao usuário selecionar heróis para formar sua equipe. 
    A função deve exibir os heróis cadastrados e permitir que o usuário selecione quais heróis deseja incluir 
    em sua equipe. O usuário deve ser capaz de selecionar três heróis para sua equipe.

    c) Pontuação Total da Equipe:
    Crie uma função chamada calcularPontuacaoTotal que calcule a pontuação total da equipe com base nos 
    heróis selecionados. A pontuação total da equipe deve ser a soma das pontuações individuais de cada herói.

    d) Exibição da Equipe:
    Crie uma função chamada exibirEquipe que exiba os heróis selecionados para a equipe, seu poder e a 
    pontuação total da equipe.

    e) Menu:
    Crie uma função chamada menuPrincipal que exiba um menu com as opções disponíveis para o usuário 
    (cadastro de heróis, seleção de equipe, exibição da equipe e sair do programa). O usuário deve poder 
    escolher uma das opções do menu e o programa deve executar a funcionalidade correspondente.

    Requisitos Adicionais:
    - O programa deve continuar em execução até que o usuário escolha a opção de sair;
    - Utilize variáveis locais para armazenar as informações dos heróis e da equipe;
    - Não utilize classes, vetores ou listas.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>
#include <cstdlib>

using namespace std;

void pausar() {
    cout << "\nPressione ENTER para continuar...";
    cin.get();
}

// Solicita os dados de um novo herói (nome, poder e pontuação) e armazena nas variáveis da próxima posição livre
void cadastrarHeroi(string &nome1, string &nome2, string &nome3, string &nome4, string &nome5,
    string &poder1, string &poder2, string &poder3, string &poder4, string &poder5,
    int &pts1, int &pts2, int &pts3, int &pts4, int &pts5, int &totalHerois) {

    if (totalHerois >= 5) {
        cout << "\nLimite de heróis cadastrados atingido." << endl;
        pausar();
        return;
    }

    cout << "\n-------------------------------------------" << endl;
    cout << "             CADASTRO DE HERÓI             " << endl;
    cout << "-------------------------------------------\n" << endl;
    cout << "Vagas disponíveis: " << (5 - totalHerois) << "\n" << endl;

    string nome, poder;
    int pts;

    cout << "> Nome do herói: ";
    getline(cin, nome);

    cout << "> Poder do herói: ";
    getline(cin, poder);

    cout << "> Pontuação do herói: ";
    cin >> pts;
    cin.ignore();

    switch (totalHerois) {
        case 0:
            nome1 = nome; poder1 = poder; pts1 = pts;
            break;
        case 1:
            nome2 = nome; poder2 = poder; pts2 = pts;
            break;
        case 2:
            nome3 = nome; poder3 = poder; pts3 = pts;
            break;
        case 3:
            nome4 = nome; poder4 = poder; pts4 = pts;
            break;
        case 4:
            nome5 = nome; poder5 = poder; pts5 = pts;
            break;
    }
    totalHerois++;
    cout << "\nHerói cadastrado com sucesso! (" << totalHerois << "/5)" << endl;

    pausar();
}

// Exibe os heróis cadastrados e permite escolher 3 deles para formar a equipe
void selecionarEquipe(const string &nome1, const string &nome2, const string &nome3, const string &nome4, const string &nome5,
    const string &poder1, const string &poder2, const string &poder3, const string &poder4, const string &poder5,
    int pts1, int pts2, int pts3, int pts4, int pts5, int totalHerois,
    int &equipe1, int &equipe2, int &equipe3) {

    if (totalHerois < 3) {
        cout << "\nCadastre pelo menos 3 heróis antes de montar a equipe." << endl;
        pausar();
        return;
    }

    cout << "\n-------------------------------------------" << endl;
    cout << "              SELEÇÃO DE EQUIPE            " << endl;
    cout << "-------------------------------------------\n" << endl;
    cout << "Escolha 3 heróis para sua equipe.\n" << endl;

    cout << "-------------------------------------------" << endl;
    cout << "ID  HERÓI           PODER           PONTOS" << endl;
    cout << "-------------------------------------------" << endl;
    cout << "1   " << left << setw(15) << nome1 << " " << setw(15) << poder1 << " " << setw(6) << pts1 << endl;
    cout << "2   " << left << setw(15) << nome2 << " " << setw(15) << poder2 << " " << setw(6) << pts2 << endl;
    cout << "3   " << left << setw(15) << nome3 << " " << setw(15) << poder3 << " " << setw(6) << pts3 << endl;

    if (totalHerois > 3) {
        cout << "4   " << left << setw(15) << nome4 << " " << setw(15) << poder4 << " " << setw(6) << pts4 << endl;
    }
    if (totalHerois > 4) {
        cout << "5   " << left << setw(15) << nome5 << " " << setw(15) << poder5 << " " << setw(6) << pts5 << endl;
    }

    int temp1, temp2, temp3;

    cout << "\n> Escolha o primeiro herói da equipe: ";
    cin >> temp1;
    cin.ignore();
    if (temp1 > totalHerois || temp1 < 1) {
        cout << "\nHerói inválido." << endl;
        pausar();
        return;
    }

    cout << "> Escolha o segundo herói da equipe:  ";
    cin >> temp2;
    cin.ignore();
    if (temp2 > totalHerois || temp2 < 1) {
        cout << "\nHerói inválido." << endl;
        pausar();
        return;
    }

    cout << "> Escolha o terceiro herói da equipe: ";
    cin >> temp3;
    cin.ignore();
    if (temp3 > totalHerois || temp3 < 1) {
        cout << "\nHerói inválido." << endl;
        pausar();
        return;
    }

    if (temp1 == temp2 || temp1 == temp3 || temp2 == temp3) {
        cout << "\nVocê não pode escolher o mesmo herói mais de uma vez." << endl;
        return;
    }

    equipe1 = temp1;
    equipe2 = temp2;
    equipe3 = temp3;

    cout << "\nEquipe cadastrada com sucesso!" << endl;

    pausar();
}

// Retorna a pontuação do herói cujo número foi informado
int pontuacao(int heroi, int pts1, int pts2, int pts3, int pts4, int pts5) {
    switch (heroi) {
        case 1: return pts1;
        case 2: return pts2;
        case 3: return pts3;
        case 4: return pts4;
        case 5: return pts5;
        default: return 0;
    }
}

// Soma a pontuação dos 3 heróis da equipe selecionada
void calcularPontuacaoTotal(int equipe1, int equipe2, int equipe3,
    int pts1, int pts2, int pts3, int pts4, int pts5) {

    if (equipe1 == 0 || equipe2 == 0 || equipe3 == 0) {
        cout << "\nNenhuma equipe foi selecionada." << endl;
        pausar();
        return;
    }

    int total = 0;
    total += pontuacao(equipe1, pts1, pts2, pts3, pts4, pts5);
    total += pontuacao(equipe2, pts1, pts2, pts3, pts4, pts5);
    total += pontuacao(equipe3, pts1, pts2, pts3, pts4, pts5);

    cout << "\nPontuação total da equipe: " << total << " pts" << endl;

    pausar();
}

// Exibe os dados (nome, poder e pontuação) de um herói específico
void heroi(int heroi, const string &nome1, const string &nome2, const string &nome3, const string &nome4, const string &nome5,
    const string &poder1, const string &poder2, const string &poder3, const string &poder4, const string &poder5,
    int pts1, int pts2, int pts3, int pts4, int pts5) {

    switch (heroi) {
        case 1:
            cout << "[1] " << nome1 << endl;
            cout << "    Poder: " << poder1 << endl;
            cout << "    Pontuação: " << pts1 << " pts\n" << endl;
            break;
        case 2:
            cout << "[2] " << nome2 << endl;
            cout << "    Poder: " << poder2 << endl;
            cout << "    Pontuação: " << pts2 << " pts\n" << endl;
            break;
        case 3:
            cout << "[3] " << nome3 << endl;
            cout << "    Poder: " << poder3 << endl;
            cout << "    Pontuação: " << pts3 << " pts\n" << endl;
            break;
        case 4:
            cout << "[4] " << nome4 << endl;
            cout << "    Poder: " << poder4 << endl;
            cout << "    Pontuação: " << pts4 << " pts\n" << endl;
            break;
        case 5:
            cout << "[5] " << nome5 << endl;
            cout << "    Poder: " << poder5 << endl;
            cout << "    Pontuação: " << pts5 << " pts\n" << endl;
            break;
    }
}

// Exibe os heróis da equipe selecionada e a pontuação total
void exibirEquipe(int equipe1, int equipe2, int equipe3,
    const string &nome1, const string &nome2, const string &nome3, const string &nome4, const string &nome5,
    const string &poder1, const string &poder2, const string &poder3, const string &poder4, const string &poder5,
    int pts1, int pts2, int pts3, int pts4, int pts5) {

    if (equipe1 == 0 || equipe2 == 0 || equipe3 == 0) {
        cout << "\nEquipe não selecionada." << endl;
        pausar();
        return;
    }

    cout << "\n-------------------------------------------" << endl;
    cout << "            EQUIPE SELECIONADA            " << endl;
    cout << "-------------------------------------------\n" << endl;
    heroi(equipe1, nome1, nome2, nome3, nome4, nome5, poder1, poder2, poder3, poder4, poder5, pts1, pts2, pts3, pts4, pts5);
    heroi(equipe2, nome1, nome2, nome3, nome4, nome5, poder1, poder2, poder3, poder4, poder5, pts1, pts2, pts3, pts4, pts5);
    heroi(equipe3, nome1, nome2, nome3, nome4, nome5, poder1, poder2, poder3, poder4, poder5, pts1, pts2, pts3, pts4, pts5);
    cout << "-------------------------------------------" << endl;
    calcularPontuacaoTotal(equipe1, equipe2, equipe3, pts1, pts2, pts3, pts4, pts5);
}

// Exibe o menu principal e direciona para a função correspondente até o usuário escolher sair
void menuPrincipal(string &nome1, string &nome2, string &nome3, string &nome4, string &nome5,
    string &poder1, string &poder2, string &poder3, string &poder4, string &poder5,
    int &pts1, int &pts2, int &pts3, int &pts4, int &pts5,
    int &equipe1, int &equipe2, int &equipe3, int &totalHerois) {

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
                cadastrarHeroi(nome1, nome2, nome3, nome4, nome5,
                    poder1, poder2, poder3, poder4, poder5,
                    pts1, pts2, pts3, pts4, pts5, totalHerois);
                break;
            case 2:
                selecionarEquipe(nome1, nome2, nome3, nome4, nome5,
                    poder1, poder2, poder3, poder4, poder5,
                    pts1, pts2, pts3, pts4, pts5,
                    totalHerois, equipe1, equipe2, equipe3);
                break;
            case 3:
                calcularPontuacaoTotal(equipe1, equipe2, equipe3, pts1, pts2, pts3, pts4, pts5);
                break;
            case 4:
                exibirEquipe(equipe1, equipe2, equipe3,
                    nome1, nome2, nome3, nome4, nome5,
                    poder1, poder2, poder3, poder4, poder5,
                    pts1, pts2, pts3, pts4, pts5);
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

// Ponto de entrada do programa: inicializa as variáveis e chama o menu principal
int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    string nome1 = "N/A", nome2 = "N/A", nome3 = "N/A", nome4 = "N/A", nome5 = "N/A";
    string poder1 = "N/A", poder2 = "N/A", poder3 = "N/A", poder4 = "N/A", poder5 = "N/A";
    int pts1 = 0, pts2 = 0, pts3 = 0, pts4 = 0, pts5 = 0;
    int equipe1 = 0, equipe2 = 0, equipe3 = 0, totalHerois = 0;

    menuPrincipal(nome1, nome2, nome3, nome4, nome5,
        poder1, poder2, poder3, poder4, poder5,
        pts1, pts2, pts3, pts4, pts5,
        equipe1, equipe2, equipe3, totalHerois);
}
