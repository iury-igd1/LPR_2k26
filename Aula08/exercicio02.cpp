/* 
Exercício 02:
    Defina uma struct Produto que contenha os seguintes campos: 
        Nome, Codigo, Preco e Quantidade. 
    
    Crie um programa que permita ao usuário inserir dados de 3 produtos e, em seguida, exiba o valor total 
    em estoque (considerando o preço e a quantidade de cada produto).
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <string>

using namespace std;

struct Produto {
    string Nome;
    string Codigo;
    double Preco;
    int Quantidade;
};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    Produto listaProdutos[3];
    double total = 0;

    cout << "==========================" << endl;
    cout << "   CADASTRO DE PRODUTOS   " << endl;
    cout << "==========================\n" << endl;

    for (int i = 0; i < 3; i++) { // Lê os dados de cada um dos 3 produtos e já acumula o valor total em estoque
        cout << "> Informe o nome do Produto " << (i + 1) << ": ";
        getline(cin, listaProdutos[i].Nome);
        cout << "> Informe o código do Produto " << (i + 1) << ": ";
        getline(cin, listaProdutos[i].Codigo);
        cout << "> Informe o preço do Produto " << (i + 1) << ": ";
        cin >> listaProdutos[i].Preco;
        cout << "> Informe a quantidade do Produto " << (i + 1) << " no estoque: ";
        cin >> listaProdutos[i].Quantidade;
        cin.ignore();

        total += listaProdutos[i].Preco * listaProdutos[i].Quantidade;
        cout << endl;
    }

    cout << "Produtos cadastrados:" << endl;
    cout << "[1] " << listaProdutos[0].Nome << endl;
    cout << "[2] " << listaProdutos[1].Nome << endl;
    cout << "[3] " << listaProdutos[2].Nome << endl;
    cout << endl;

    cout << "Valor total em estoque = R$ " << fixed << setprecision(2) << total << endl;
}
