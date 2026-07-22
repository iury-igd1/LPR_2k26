/* 
Exercício 08:
    Crie uma struct chamada Livro contendo:
        Título, Autor, Ano de publicação, Quantidade disponível

    Utilize um dicionário em que: Chave = Código do livro / Valor = Struct Livro
    Implemente as funções:
      - CadastrarLivro()
      - BuscarLivro()
      - EmprestarLivro()
      - ExibirRelatorio()

    O programa deverá:
      - Cadastrar 10 livros;
      - Permitir buscar um livro pelo código;
      - Realizar empréstimos, reduzindo a quantidade disponível;
      - Impedir empréstimos quando não houver exemplares.
      - Exibir um relatório contendo:
          > Total de livros cadastrados;
          > Livro mais antigo;
          > Livro com maior quantidade disponível.
      - Exibir quantos livros existem por autor.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>
#include <map>
#include <list>
#include <algorithm>
#include <cstdlib>

using namespace std;

// Definição da struct
struct Livro 
{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int Quantidade;
};

int totalCadastrados = 0;
map<string, Livro> biblioteca; 

void Pausar() 
{
    cout << "\nPressione ENTER para continuar..." << endl;
    cin.get();
}

void CadastrarLivro() 
{
    if (totalCadastrados >= 10) {
        cout << "\nLimite máximo de 10 livros cadastrados atingido." << endl;
        Pausar();
        return;
    }

    system("cls");
    cout << "-------------------------------------------" << endl;
    cout << "             CADASTRO DE LIVRO             " << endl;
    cout << "-------------------------------------------\n" << endl;

    string codigo;
    cout << "> Digite o código identificador do livro (Ex: 1A01): ";
    getline(cin >> ws, codigo);

    if (biblioteca.find(codigo) != biblioteca.end()) { // Verifica se a chave já existe no dicionário
        cout << "\nErro: Já existe um livro cadastrado com este código." << endl;
        Pausar();
        return;
    }

    Livro novoLivro;
    totalCadastrados++;

    cout << "> Informe o título do Livro " << totalCadastrados << ": ";
    getline(cin >> ws, novoLivro.Titulo);

    cout << "> Informe o autor do Livro " << totalCadastrados << ": ";
    getline(cin >> ws, novoLivro.Autor);

    cout << "> Informe o ano de publicação do Livro " << totalCadastrados << ": ";
    cin >> novoLivro.AnoPublicacao;

    cout << "> Informe a quantidade disponível do Livro " << totalCadastrados << ": ";
    cin >> novoLivro.Quantidade;
    
    cin.ignore(10000, '\n');

    biblioteca[codigo] = novoLivro;
    cout << "\nLivro cadastrado com sucesso! (" << totalCadastrados << "/10)" << endl;
    Pausar();
}

void BuscarLivro() 
{
    if (biblioteca.empty()) {
        cout << "\nNenhum livro foi cadastrado." << endl;
        Pausar();
        return;
    }

    system("cls");
    cout << "-------------------------------------------" << endl;
    cout << "                BUSCAR LIVRO               " << endl;
    cout << "-------------------------------------------\n" << endl;

    string codigo;
    cout << "> Digite o código do livro que deseja buscar: ";
    getline(cin >> ws, codigo);

    if (biblioteca.find(codigo) != biblioteca.end()) {
        Livro livro = biblioteca[codigo];
        cout << "\n[Livro Encontrado]" << endl;
        cout << "Título: " << livro.Titulo << endl;
        cout << "Autor: " << livro.Autor << endl;
        cout << "Ano de Publicação: " << livro.AnoPublicacao << endl;
        cout << "Quantidade em estoque: " << livro.Quantidade << endl;
    } 
    else {
        cout << "\nNão existe um livro cadastrado com esse código." << endl;
    }
    Pausar();
}

void EmprestarLivro() 
{
    if (biblioteca.empty()) {
        cout << "\nNenhum livro foi cadastrado." << endl;
        Pausar();
        return;
    }

    system("cls");
    cout << "-------------------------------------------" << endl;
    cout << "            EMPRÉSTIMO DE LIVRO            " << endl;
    cout << "-------------------------------------------\n" << endl;

    string codigo;
    cout << "> Digite o código do livro para realizar o empréstimo: ";
    getline(cin >> ws, codigo);

    if (biblioteca.find(codigo) != biblioteca.end()) {
        
        if (biblioteca[codigo].Quantidade > 0) {
            biblioteca[codigo].Quantidade--; 
            cout << "\nEmpréstimo realizado com sucesso! Exemplares restantes: " << biblioteca[codigo].Quantidade << endl;
        } 
        else {
            cout << "\nNão há exemplares disponíveis." << endl;
        }
    } 
    else {
        cout << "\nLivro não encontrado." << endl;
    }
    Pausar();
}

void ExibirRelatorio() 
{
    if (biblioteca.empty()) {
        cout << "\nNenhum livro cadastrado ainda." << endl;
        Pausar();
        return;
    }

    system("cls");
    cout << "-------------------------------------------" << endl;
    cout << "          RELATÓRIO DA BIBLIOTECA          " << endl;
    cout << "-------------------------------------------\n" << endl;

    cout << "Total de livros cadastrados: " << biblioteca.size() << "\n" << endl;

    int anoMaisAntigo = 999999;
    string tituloMaisAntigo = "";

    int maiorQuantidade = -1;
    string tituloMaiorQtd = "";

    list<string> listaAutores;
    list<int> qtdLivrosPorAutor;

    for (auto it = biblioteca.begin(); it != biblioteca.end(); it++) {
        Livro livro = it->second;

        if (livro.AnoPublicacao < anoMaisAntigo) {
            anoMaisAntigo = livro.AnoPublicacao;
            tituloMaisAntigo = livro.Titulo;
        }
        if (livro.Quantidade > maiorQuantidade) {
            maiorQuantidade = livro.Quantidade;
            tituloMaiorQtd = livro.Titulo;
        }

        auto itAutor = find(listaAutores.begin(), listaAutores.end(), livro.Autor);
        if (itAutor != listaAutores.end()) {
            int posicao = distance(listaAutores.begin(), itAutor);
            auto itQtd = qtdLivrosPorAutor.begin();
            advance(itQtd, posicao);
            (*itQtd)++;
        } 
        else {
            listaAutores.push_back(livro.Autor);
            qtdLivrosPorAutor.push_back(1);
        }
    }

    cout << "Livro mais antigo: " << tituloMaisAntigo << " (" << anoMaisAntigo << ")" << endl;
    cout << "Livro com maior estoque disponível: " << tituloMaiorQtd << " (" << maiorQuantidade << " exemplares)\n" << endl;

    cout << "-------------------------------------------" << endl;
    cout << "       QUANTIDADE DE LIVROS POR AUTOR      " << endl;
    cout << "-------------------------------------------" << endl;
    
    auto itA = listaAutores.begin();
    auto itQ = qtdLivrosPorAutor.begin();
    
    for (; itA != listaAutores.end(); itA++, itQ++) {
        cout << "Autor: " << left << setw(20) << *itA << " | Livros registados: " << *itQ << endl;
    }

    Pausar();
}

void Menu() 
{
    int opcao = 0;
    while (opcao != 5) {
        system("cls");
        cout << "===========================================" << endl;
        cout << "      SISTEMA DE GESTÃO DE BIBLIOTECA      " << endl;
        cout << "===========================================\n" << endl;
        cout << "Livros cadastrados: " << totalCadastrados << "/10\n" << endl;
        cout << "-------------------------------------------" << endl;
        cout << "1 - Cadastrar Livro" << endl;
        cout << "2 - Buscar Livro por Código" << endl;
        cout << "3 - Realizar Empréstimo" << endl;
        cout << "4 - Exibir Relatório Completo" << endl;
        cout << "5 - Sair" << endl;
        cout << "-------------------------------------------" << endl;

        cout << "> Escolha uma opção: ";
        cin >> opcao;

        if (cin.fail()) {
            cin.clear();
        }
        cin.ignore(10000, '\n');

        switch (opcao) {
            case 1:
                CadastrarLivro();
                break;
            case 2:
                BuscarLivro();
                break;
            case 3:
                EmprestarLivro();
                break;
            case 4:
                ExibirRelatorio();
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