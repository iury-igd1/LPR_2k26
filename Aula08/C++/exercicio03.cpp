/* 
Exercício 03:
    Defina uma struct chamada Livro com os seguintes campos: 
        Titulo, Autor, AnoPublicacao, NumeroPaginas e Preco.

    Crie um programa que permita ao usuário inserir dados de 3 livros e, em seguida, calcule e exiba o 
    preço total dos livros cadastrados e a média de páginas dos livros.
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>
#include <string>

using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    Livro listaLivros[3];
    double somaPaginas = 0;
    double somaPrecos = 0;

    system("cls");
    cout << "========================" << endl;
    cout << "   CADASTRO DE LIVROS   " << endl;
    cout << "========================\n" << endl;

    for (int i = 0; i < 3; i++) { // Lê os dados de cada um dos 3 livros, somando páginas e preços ao longo da leitura
        cout << "> Informe o título do Livro " << i+1 << ": ";
        getline(cin, listaLivros[i].Titulo);
        cout << "> Informe o nome do autor do Livro " << i+1 << ": ";
        getline(cin, listaLivros[i].Autor);
        cout << "> Informe o ano de publicação do Livro " << i+1 << ": ";
        cin >> listaLivros[i].AnoPublicacao;
        cout << "> Informe o número de páginas do Livro " << i+1 << ": ";
        cin >> listaLivros[i].NumeroPaginas;
        somaPaginas += listaLivros[i].NumeroPaginas;
        cout << "> Informe o preço do Livro " << i+1 << ": ";
        cin >> listaLivros[i].Preco;
        somaPrecos += listaLivros[i].Preco;

        cin.ignore();
        cout << endl;
    }

    cout << "Livros cadastrados:" << endl;
    cout << "[1] " << listaLivros[0].Titulo << endl;
    cout << "[2] " << listaLivros[1].Titulo << endl;
    cout << "[3] " << listaLivros[2].Titulo << endl;
    cout << endl;

    cout << fixed << setprecision(2);
    cout << "Preço total dos livros cadastrados = R$ " << somaPrecos << endl;
    cout << "Média de páginas dos livros = " << somaPaginas / 3 << endl;    
}
